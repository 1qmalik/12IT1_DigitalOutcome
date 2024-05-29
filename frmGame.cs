using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace FinalStand
{
    public partial class frmGame : Form
    {
        string mapNameWithExtension;
        string mapNameNoExtension;
        mapData properties;
        StreamReader readFile = new StreamReader($@"{GlobalVariables.rootResource}SpawnOrder.txt");
        GameProperties gameProperties = new GameProperties();

        public frmGame(string mapName, string difficultyLevel)
        {
            InitializeComponent();
            mapNameWithExtension = mapName + ".png";
            mapNameNoExtension = mapName;
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            Image map = new Bitmap($"{GlobalVariables.maps}{mapNameWithExtension}");
            this.BackgroundImage = map;
        }

        private mapData LoadMapData(string mapName)
        {
            //Create an instance of the mapData class and name it data
            mapData data = new mapData();
            //Create an instance of the XmlDocument class and name it xmlMapData
            XmlDocument xmlMapData = new XmlDocument();
            //Load the XML file that contains all the map properties
            xmlMapData.Load($@"{GlobalVariables.maps}mapData\mapData.xml");
            //This selects a node/header called turning points which contains the x,y coords of where the AI will turn at
            XmlNode turningPointNode = xmlMapData.SelectSingleNode($"//{mapNameNoExtension}/TurningPoints");
            //Setting my mapData variables with the XML file data through the XmlDocument Class
            string enemyX = xmlMapData.SelectSingleNode($"//{mapNameNoExtension}/EnemySpawn/x").InnerText;
            string enemyY = xmlMapData.SelectSingleNode($"//{mapNameNoExtension}/EnemySpawn/y").InnerText;
            string baseX = xmlMapData.SelectSingleNode($"//{mapNameNoExtension}/PlayerBase/x").InnerText;
            string baseY = xmlMapData.SelectSingleNode($"//{mapNameNoExtension}/PlayerBase/y").InnerText;
            data.enemySpawn.Add(Convert.ToInt16(enemyX) - 13, Convert.ToInt16(enemyY));
            data.playerBase.Add(Convert.ToInt16(baseX), Convert.ToInt16(baseY));
            int index = 0;
            foreach (XmlNode node in turningPointNode)
            {
                Dictionary<int, int> temp = new Dictionary<int, int>();
                temp.Add(Convert.ToInt16(node.SelectSingleNode("x").InnerText) - 13, Convert.ToInt16(node.SelectSingleNode("x").InnerText));
                data.turningPoints.Add(new Dictionary<Dictionary<int, int>, string>());
                data.turningPoints[index].Add(temp, node.SelectSingleNode("direction").InnerText);
                temp.Clear();
                index++;
            }

            return data;
        }

        bool temp = false;
        private void tmrGameLoop_Tick(object sender, EventArgs e)
        {
            while (temp != true)
            {
                properties = LoadMapData(mapNameNoExtension);
                temp = true;
            }

            gameProperties.score++;
            gameProperties.wave++;
            string line;

            while ((line = readFile.ReadLine()) != null)
            {
                foreach (char enemyType in line)
                {
                    PictureBox enemy = new PictureBox();
                    enemy.Left = properties.enemySpawn.First().Key;
                    enemy.Top = properties.enemySpawn.First().Value;
                    enemy.SizeMode = PictureBoxSizeMode.AutoSize;
                    enemy.BackColor = Color.Transparent;

                    switch (enemyType)
                    {
                        case 'B':
                            //Basic enemy spawns
                            enemy.Image = Image.FromFile($@"{GlobalVariables.sprites}BasicEnemyAttacker.png");
                            enemy.BringToFront();
                            break;
                    }
                    Controls.Add(enemy);
                }
                line = "";
            }
        }
    }

    /// <summary>
    /// This custom class made by me will hold global variable that I want to be used everywhere
    /// </summary>
    public class GlobalVariables
    {
        public static string maps = @"resources\maps\";
        public static string sprites = @"resources\sprites\";
        public static string rootResource = @"resources\";
    }

    class GameProperties
    {
        public int wave = 0;
        public int score = 0;
        public int money = 0;
    }

    /// <summary>
    /// This class contains predefined variable that will hold the properties of a map
    /// </summary>
    class mapData
    {
        public Dictionary<int, int> enemySpawn = new Dictionary<int, int>();
        public Dictionary<int, int> playerBase = new Dictionary<int, int>();
        public List<Dictionary<Dictionary<int, int>, string>> turningPoints = new List<Dictionary<Dictionary<int, int>, string>>();
    }
}
