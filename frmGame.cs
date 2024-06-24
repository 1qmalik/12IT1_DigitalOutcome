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
using System.Threading;

namespace FinalStand
{
    public partial class frmGame : Form
    {
        int wave = 1, startingIncome = 20, startingHP = 100, numebrOfDefences = 1;
        int mouseX, mouseY;
        bool mouseClick;
        string mapNameWithExtension;
        string mapNameNoExtension;
        mapData properties;
        StreamReader readFile = new StreamReader($@"{GlobalVariables.rootResource}SpawnOrder.txt");
        GameProperties gameProperties = new GameProperties();
        List<defence> playerDefences;

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
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
                data.turningPoints.Add(new Dictionary<(int, int), string>());
                data.turningPoints[index].Add((Convert.ToInt16(node.SelectSingleNode("x").InnerText) - 13, 500 - Convert.ToInt16(node.SelectSingleNode("x").InnerText)), node.SelectSingleNode("direction").InnerText);
                index++;
            }

            return data;
        }

        bool temp = false;

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void frmGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseClick == true)
            {
                playerDefences[numebrOfDefences - 1].SetLocation(this, e.X, e.Y);
                mouseClick = false;
            }
        }

        private void dOWNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerDefences = new List<defence>();
            playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}BasicSoldierDefence.png"), "down", this));
            mouseClick = true;
        }

        private void lEFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerDefences = new List<defence>();
            playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}BasicSoldierDefence.png"), "left", this));
            mouseClick = true;
        }

        private void rIGHTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerDefences = new List<defence>();
            playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}BasicSoldierDefence.png"), "right", this));
            mouseClick = true;
        }

        private void frmGame_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void uPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerDefences = new List<defence>();
            playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}BasicSoldierDefence.png"), "up", this));
            mouseClick = true;
        }

        async Task startWave(string line)
        {
            await Task.Run(() =>
            {
                while ((line = readFile.ReadLine()) != null && gameProperties.wave == wave)
                {
                    int index = 0;
                    List<enemy> enemyPlayers = new List<enemy>();
                    foreach (char enemyType in line)
                    {
                        switch (enemyType)
                        {
                            case '1':
                                //Basic enemy spawns
                                enemyPlayers.Add(new enemy(Image.FromFile($@"{GlobalVariables.sprites}BasicEnemyAttacker.png"), mapNameNoExtension, this));
                                enemyPlayers[index].Move(this);
                                index++;
                                break;
                        }
                        System.Threading.Thread.Sleep(1000);
                    }
                    line = "";
                }
            });
        } 

        private void tmrGameLoop_Tick(object sender, EventArgs e)
        {
            while (temp != true)
            {
                properties = LoadMapData(mapNameNoExtension);
                gameProperties.money = startingIncome;
                mnuMainBar.Items[5].Text = $"MONEY:    {gameProperties.money}";
                mnuMainBar.Items[4].Text = gameProperties.score.ToString();
                mnuMainBar.Items[2].Text = gameProperties.HP.ToString();
                temp = true;
            }
            string line = "";

            startWave(line);
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

    /// <summary>
    /// this class holds 3 variables that are needed for the game to be a game
    /// </summary>
    class GameProperties
    {
        public int wave = 0;
        public int score = 0;
        public int money = 0;
        public int HP = 0;
    }

    /// <summary>
    /// This class contains predefined variable that will hold the properties of a map
    /// </summary>
    class mapData
    {
        public Dictionary<int, int> enemySpawn = new Dictionary<int, int>();
        public Dictionary<int, int> playerBase = new Dictionary<int, int>();
        public List<Dictionary<(int, int), string>> turningPoints = new List<Dictionary<(int, int), string>>();
    }

    /// <summary>
    /// This class initialises an enemy after being creates, and its sole purpose is to acts as a template.
    /// </summary>
    class enemy
    {
        public int health = 100;
        public int moveSpeed = 1;
        public int numberOfChckpoints = 0;
        public int index = 0;
        public mapData properties;
        public string mapNameNoExtension = "";
        public List<bool> checkpoints = new List<bool>();
        public PictureBox enemyObj = new PictureBox();
        public bool outOfSpawn = false;
        public int speed = 3;

        public enemy(Image img, string map, Form game)
        {
            mapNameNoExtension = map;
            properties = LoadMapData(map);
            enemyObj.Left = properties.enemySpawn.First().Key;
            enemyObj.Top = properties.enemySpawn.First().Value;
            enemyObj.Image = img;
            enemyObj.SizeMode = PictureBoxSizeMode.AutoSize;
            enemyObj.BackColor = Color.Transparent;
            //enemyObj.BringToFront();
            game.Controls.Add(enemyObj);
            //enemyObj.Show();
        }

        public void Move(Form game)
        {

            for (int i = 0; i < numberOfChckpoints; i++)
            {
                checkpoints.Add(false);
            };

            while (checkpoints[index] == false)
            {
                Thread.Sleep(1);
                if (outOfSpawn == false)
                {
                    enemyObj.Top += speed;
                    enemyObj.Refresh();
                    if (enemyObj.Bottom >= properties.turningPoints[index].First().Key.Item2)
                    {
                        outOfSpawn = true;
                        checkpoints[index] = true;
                        index++;
                    }
                }
                else
                {
                    switch (properties.turningPoints[index - 1].First().Value.ToString())
                    {
                        case "right":
                            enemyObj.Left -= speed;
                            enemyObj.Refresh();
                            if (enemyObj.Left >= properties.turningPoints[index].First().Key.Item1)
                            {
                                checkpoints[index] = true;
                                index++;
                            }
                            break;
                        case "left":
                            enemyObj.Left += speed;
                            enemyObj.Refresh();
                            if (enemyObj.Left <= properties.turningPoints[index].First().Key.Item1)
                            {
                                checkpoints[index] = true;
                                index++;
                            }
                            break;
                        case "up":
                            enemyObj.Top -= speed;
                            enemyObj.Refresh();
                            if (enemyObj.Top <= properties.turningPoints[index].First().Key.Item2)
                            {
                                checkpoints[index] = true;
                                index++;
                            }
                            break;
                        case "down":
                            enemyObj.Top += speed;
                            enemyObj.Refresh();
                            if (enemyObj.Top >= properties.turningPoints[index].First().Key.Item2)
                            {
                                checkpoints[index] = true;
                                index++;
                            }
                            break;
                    }
                }

                if (index == checkpoints.Count())
                    index--;
            }
            
            while (enemyObj.Top != properties.playerBase.Values.First() || enemyObj.Left != properties.playerBase.Keys.First())
            {
                switch (properties.turningPoints[index].First().Value.ToString())
                {
                    case "left":
                        enemyObj.Left--;
                        enemyObj.Refresh();
                        if (enemyObj.Left == properties.playerBase.Keys.First())
                        {
                            checkpoints[index] = true;
                        }
                        break;
                    case "right":
                        enemyObj.Left++;
                        enemyObj.Refresh();
                        if (enemyObj.Left == properties.playerBase.Keys.First())
                        {
                            checkpoints[index] = true;
                        }
                        break;
                    case "up":
                        enemyObj.Top--;
                        enemyObj.Refresh();
                        if (enemyObj.Top == properties.playerBase.Keys.First())
                        {
                            checkpoints[index] = true;
                        }
                        break;
                    case "down":
                        enemyObj.Top++;
                        enemyObj.Refresh();
                        if (enemyObj.Top == properties.playerBase.Values.First())
                        {
                            checkpoints[index] = true;
                        }
                        break;
                }
            }
            game.Controls.Remove(enemyObj);
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
                data.turningPoints.Add(new Dictionary<(int, int), string>());
                data.turningPoints[index].Add((Convert.ToInt16(node.SelectSingleNode("x").InnerText) - 13, Convert.ToInt16(node.SelectSingleNode("y").InnerText) + 13), node.SelectSingleNode("direction").InnerText);
                index++;
            }

            numberOfChckpoints = index;
            return data;
        }
    }

    class defence
    {
        PictureBox defenceObj = new PictureBox();

        public defence(Bitmap bmp, string direction, Form game)
        {
            defenceObj.Image = bmp;
            defenceObj.SizeMode = PictureBoxSizeMode.AutoSize;
            defenceObj.BackColor = Color.Transparent;
            defenceObj.BringToFront();

            switch (direction)
            {
                case "left":
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipY);
                    break;

                case "right":
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;

                case "down":
                    bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
            }

            game.Controls.Add(defenceObj);
            //
        }

        public void SetLocation(Form game, int x, int y)
        {
            defenceObj.Location = new Point(x - (defenceObj.Width / 2), y - (defenceObj.Height / 2));
        }
    }
}
