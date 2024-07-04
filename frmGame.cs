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
        int wave = 1, startingIncome = 20, startingHP = 100, numebrOfDefences = 0, maxDefences = 10;
        int mouseX, mouseY;
        bool mouseClick;
        string mapNameWithExtension;
        string mapNameNoExtension;
        mapData properties;
        StreamReader readFile = new StreamReader($@"{GlobalVariables.rootResource}SpawnOrder.txt");
        GameProperties gameProperties = new GameProperties();
        List<defence> playerDefences = new List<defence>();
        List<enemy> enemyPlayers;

        #region functions
        #region Form Related
        public frmGame(string mapName)
        {
            InitializeComponent();
            mapNameWithExtension = mapName + ".png";
            mapNameNoExtension = mapName;

            switch (mapNameNoExtension)
            {
                case "Basic":
                    startingIncome = 20;
                    break;

                case "Water":
                    startingIncome = 80;
                    maxDefences = 18;
                    break;

                case "Lava":
                    startingIncome = 60;
                    maxDefences = 14;
                    break;
            }
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            Image map = new Bitmap($"{GlobalVariables.maps}{mapNameWithExtension}");
            this.BackgroundImage = map;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            playerDefences.Clear();
            MessageBox.Show($"Maximum number of troops: {maxDefences}\nTotal number of waves: 10\nBoss comes on wave 10!");
        }
        #endregion
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

            return data;
        }

        bool temp = false;

        private void frmGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseClick == true)
            {
                playerDefences[numebrOfDefences].SetLocation(this, e.X, e.Y);
                numebrOfDefences++;
                mouseClick = false;
            }
        }

        #region Shop
        #region Infantry
        private void dOWNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wave == 1) 
                if (gameProperties.money - 10 >= 0 && playerDefences.Count + 1 <= maxDefences)
                {
                    maxDefences++;
                    playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_1.png"), "down", this, 50));
                    mouseClick = true;
                    gameProperties.money -= 10;
                }
            else
                {
                    if (gameProperties.money - 10 >= 0 && playerDefences.Count + 1 <= maxDefences)
                    {
                        playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_1.png"), "down", this, 50));
                        mouseClick = true;
                        gameProperties.money -= 10;
                    }
                }
        }

        private void lEFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wave == 1)
                if (gameProperties.money - 10 >= 0 && playerDefences.Count + 1 <= maxDefences)
                {
                    maxDefences++;
                    playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_1.png"), "left", this, 50));
                    mouseClick = true;
                    gameProperties.money -= 10;
                }
            else
                {
                    if (gameProperties.money - 10 >= 0 && playerDefences.Count + 1 <= maxDefences)
                    {
                        playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_1.png"), "left", this, 50));
                        mouseClick = true;
                        gameProperties.money -= 10;
                    }
                }
        }

        private void rIGHTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wave == 1)
                if (gameProperties.money - 10 >= 0 && playerDefences.Count + 1 <= maxDefences)
                {
                    maxDefences++;
                    playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_1.png"), "right", this, 50));
                    mouseClick = true;
                    gameProperties.money -= 10;
                }
            else
                {
                    playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_1.png"), "right", this, 50));
                    mouseClick = true;
                    gameProperties.money -= 10;
                }
        }

        private void uPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wave == 1)
                if (gameProperties.money - 10 >= 0 && playerDefences.Count + 1 <= maxDefences)
                {
                    maxDefences++;
                    playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_1.png"), "up", this, 50));
                    mouseClick = true;
                    gameProperties.money -= 10;
                }
            else
                {
                    playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_1.png"), "up", this, 50));
                    mouseClick = true;
                    gameProperties.money -= 10;
                }
        }
        #endregion

        #region MachineGunner
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 50 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_2.png"), "up", this, 100));
                mouseClick = true;
                gameProperties.money -= 50;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 50 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_2.png"), "down", this, 100));
                mouseClick = true;
                gameProperties.money -= 50;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 50 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_2.png"), "left", this, 100));
                mouseClick = true;
                gameProperties.money -= 50;
            }
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 50 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_2.png"), "right", this, 100));
                mouseClick = true;
                gameProperties.money -= 50;
            }
        }
        #endregion

        #region Sniper

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 250 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_3.png"), "up", this, 150));
                mouseClick = true;
                gameProperties.money -= 250;
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 250 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_3.png"), "down", this, 150));
                mouseClick = true;
                gameProperties.money -= 250;
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 250 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_3.png"), "left", this, 150));
                mouseClick = true;
                gameProperties.money -= 250;
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 250 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_3.png"), "right", this, 150));
                mouseClick = true;
                gameProperties.money -= 250;
            }
        }

        #endregion

        #region Grenadier
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 500 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_4.png"), "up", this, 200));
                mouseClick = true;
                gameProperties.money -= 500;
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 500 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_4.png"), "down", this, 200));
                mouseClick = true;
                gameProperties.money -= 500;
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 500 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_4.png"), "left", this, 200));
                mouseClick = true;
                gameProperties.money -= 500;
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 500 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_4.png"), "right", this, 200));
                mouseClick = true;
                gameProperties.money -= 500;
            }
        }

        #endregion

        #region Mine
        private void uPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 1000 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_5.png"), "up", this, 500));
                mouseClick = true;
                gameProperties.money -= 1000;
            }
        }

        private void dOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 1000 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_5.png"), "down", this, 500));
                mouseClick = true;
                gameProperties.money -= 1000;
            }
        }

        private void infantryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lEFTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 1000 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_5.png"), "left", this, 500));
                mouseClick = true;
                gameProperties.money -= 1000;
            }
        }

        private void rIGHTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (gameProperties.money - 1000 >= 0 && playerDefences.Count + 1 <= maxDefences)
            {
                playerDefences.Add(new defence(new Bitmap($@"{GlobalVariables.sprites}Defence_5.png"), "right", this, 500));
                mouseClick = true;
                gameProperties.money -= 1000;
            }
        }
        #endregion
        #endregion

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            gameProperties.wave++;
            mnuMainBar.Items[6].Text = $"START-{(gameProperties.wave + 1).ToString()}";
            if ((gameProperties.wave + 1) == 11)
            {
                mnuMainBar.Items[6].Text = "START-10";
            }
        }

        private void frmGame_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        #region Game Loop
        private void tmrGameLoop_Tick(object sender, EventArgs e)
        {
            while (temp != true)
            {
                properties = LoadMapData(mapNameNoExtension);
                gameProperties.money = startingIncome;
                gameProperties.wave = 0;
                gameProperties.score = 0;
                gameProperties.HP = startingHP;
                mnuMainBar.Items[4].Text = gameProperties.score.ToString();
                mnuMainBar.Items[2].Text = gameProperties.HP.ToString();
                temp = true;
                wave = 1;
            }
            string line = "";
            int hp = 0, mvSpeed = 0, damage = 0;
            mnuMainBar.Items[5].Text = $"MONEY:    {gameProperties.money}";

            if (gameProperties.wave == wave)
            {
                while ((line = readFile.ReadLine()) != null)
                {
                    int index = 0;
                    enemyPlayers = new List<enemy>();
                    foreach (char enemyType in line)
                    {
                        Convert.ToInt32(enemyType);
                        switch(mapNameNoExtension)
                        {
                            case "Basic":
                                switch (enemyType)
                                {
                                    case '1':
                                        mvSpeed = 2;
                                        hp = 100;
                                        damage = 10;
                                        break;

                                    case '2':
                                        mvSpeed = 3;
                                        hp = 200;
                                        damage = 20;
                                        break;

                                    case '3':
                                        mvSpeed = 4;
                                        hp = 300;
                                        damage = 15;
                                        break;

                                    case '4':
                                        mvSpeed = 2;
                                        hp = 400;
                                        damage = 25;
                                        break;

                                    case '5':
                                        mvSpeed = 2;
                                        hp = 500;
                                        damage = 50;
                                        break;

                                    case '6':
                                        mvSpeed = 3;
                                        hp = 1500;
                                        damage = 100;
                                        break;
                                }
                                break;

                            case "Water":
                                switch (enemyType)
                                {
                                    case '1':
                                        mvSpeed = 2;
                                        hp = 200;
                                        damage = 10;
                                        break;

                                    case '2':
                                        mvSpeed = 3;
                                        hp = 300;
                                        damage = 20;
                                        break;

                                    case '3':
                                        mvSpeed = 4;
                                        hp = 400;
                                        damage = 15;
                                        break;

                                    case '4':
                                        mvSpeed = 2;
                                        hp = 500;
                                        damage = 25;
                                        break;

                                    case '5':
                                        mvSpeed = 2;
                                        hp = 600;
                                        damage = 50;
                                        break;

                                    case '6':
                                        mvSpeed = 3;
                                        hp = 2000;
                                        damage = 100;
                                        break;
                                }
                                break;

                            case "Lava":
                                switch (enemyType)
                                {
                                    case '1':
                                        mvSpeed = 2;
                                        hp = 150;
                                        damage = 10;
                                        break;

                                    case '2':
                                        mvSpeed = 3;
                                        hp = 250;
                                        damage = 20;
                                        break;

                                    case '3':
                                        mvSpeed = 4;
                                        hp = 350;
                                        damage = 15;
                                        break;

                                    case '4':
                                        mvSpeed = 2;
                                        hp = 450;
                                        damage = 25;
                                        break;

                                    case '5':
                                        mvSpeed = 2;
                                        hp = 550;
                                        damage = 50;
                                        break;

                                    case '6':
                                        mvSpeed = 3;
                                        hp = 1750;
                                        damage = 100;
                                        break;
                                }
                                break;
                        }
                        enemyPlayers.Add(new enemy(Image.FromFile($@"{GlobalVariables.sprites}Enemy_{enemyType}.png"), mapNameNoExtension, this, hp, mvSpeed, gameProperties));
                        enemyPlayers[index].Move(this, playerDefences, mnuMainBar, damage, lblEnemyHP);
                        index++;
                        Thread.Sleep(500);
                    }
                    line = "";
                    wave++;
                    break;
                }
            }
        }
        #endregion
        #endregion
    }

    #region Game Related Classes
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

    #region enemy class
    /// <summary>
    /// This class initialises an enemy after being creates, and its sole purpose is to acts as a template.
    /// </summary>
    class enemy
    {
        public int health = 100, numberOfChckpoints = 0, index = 0, speed = 3, score = 0;
        public mapData properties;
        public string mapNameNoExtension = "";
        public List<bool> checkpoints = new List<bool>();
        public PictureBox enemyObj = new PictureBox();
        public bool outOfSpawn = false;
        public GameProperties gameProperties = new GameProperties();
        bool dead = false;
        public List<bool> canShoot = new List<bool>();
        int defenceIndex = 0;
        public enemy(Image img, string map, Form game, int HP, int movementSpeed, GameProperties gP)
        {
            gameProperties = gP;
            health = HP;
            speed = movementSpeed;
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
            canShoot.Clear();
        }

        public void Move(Form game, List<defence> playerDefences, MenuStrip gameMenu, int damage, Label lblEnemyHP)
        {

            foreach (defence shooter in playerDefences)
            {
                canShoot.Add(true);
            }

            for (int i = 0; i < numberOfChckpoints; i++)
            {
                checkpoints.Add(false);
            }

            while (checkpoints[index] == false)
            {
                lblEnemyHP.Text = "Enemy HP: " + health.ToString();
                gameProperties.score++;
                gameMenu.Items[2].Text = gameProperties.HP.ToString();
                gameMenu.Items[4].Text = gameProperties.score.ToString();
                game.Refresh();
                
                foreach (defence defender in playerDefences)
                {
                    defender.defenceObj.Refresh();
                    canShoot[defenceIndex] = defender.ShootEnemy(this, index, properties, canShoot[defenceIndex]);
                    defenceIndex++;
                }
                defenceIndex = 0;

                if (health <= 0)
                {
                    game.Controls.Remove(enemyObj);
                    enemyObj.Hide();
                    game.Refresh();
                    dead = true;
                    gameMenu.Items[5].Text = $"MONEY:   {gameProperties.money}";
                    break;
                }
                /*
                if (gameProperties.HP <= 0)
                {

                }
                */
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
                            enemyObj.Left += speed;
                            enemyObj.Refresh();
                            if (enemyObj.Left >= properties.turningPoints[index].First().Key.Item1)
                            {
                                checkpoints[index] = true;
                                index++;
                            }
                            break;
                        case "left":
                            enemyObj.Left -= speed;
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

            checkpoints.Add(false);
            
            while (checkpoints[checkpoints.Count - 1] != true && dead != true)
            {
                switch (properties.turningPoints[index].First().Value.ToString())
                {
                    case "left":
                        enemyObj.Left--;
                        enemyObj.Refresh();
                        if (enemyObj.Left <= properties.playerBase.Keys.First())
                        {
                            index++;
                            checkpoints[index] = true;
                        }
                        break;
                    case "right":
                        enemyObj.Left++;
                        enemyObj.Refresh();
                        if (enemyObj.Left >= properties.playerBase.Keys.First())
                        {
                            index++;
                            checkpoints[index] = true;
                        }
                        break;
                    case "up":
                        enemyObj.Top--;
                        enemyObj.Refresh();
                        if (enemyObj.Top <= properties.playerBase.Values.First())
                        {
                            index++;
                            checkpoints[index] = true;
                        }
                        break;
                    case "down":
                        enemyObj.Top++;
                        enemyObj.Refresh();
                        if (enemyObj.Top >= properties.playerBase.Values.First())
                        {
                            index++;
                            checkpoints[index] = true;
                        }
                        break;
                }
            }
            if (checkpoints[checkpoints.Count - 1] == true && dead == false)
                gameProperties.HP -= damage;
            else if (checkpoints[checkpoints.Count - 1] == false && dead == true)
                if (gameProperties.wave >= 5)
                {
                    gameProperties.money += damage * (gameProperties.wave - 5);
                } else gameProperties.money += damage;

            if (gameProperties.HP <= 0)
            {
                frmEndScreen end = new frmEndScreen(gameProperties.score, "Lost!");
                game.Hide();
                end.ShowDialog();
                game.Close();
            } else if (gameProperties.wave == 10)
            {
                frmEndScreen end = new frmEndScreen(gameProperties.score, "Won!");
                game.Hide();
                end.ShowDialog();
                game.Close();
            }
            gameMenu.Items[5].Text = $"MONEY:   {gameProperties.money}";
            lblEnemyHP.Text = "Enemy HP:" + health;
            game.Controls.Remove(enemyObj);
            game.Refresh();
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
    #endregion

    #region defence class
    class defence
    {
        public PictureBox defenceObj = new PictureBox();
        string dir = "";
        int damage;

        public defence(Bitmap bmp, string direction, Form game, int dmg)
        {
            damage = dmg;
            dir = direction;
            defenceObj.Image = bmp;
            defenceObj.SizeMode = PictureBoxSizeMode.AutoSize;
            defenceObj.BackColor = Color.Transparent;
            defenceObj.BringToFront();

            switch (direction)
            {
                case "left":
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;

                case "right":
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;

                case "down":
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
            }

            game.Controls.Add(defenceObj);
        }

        public void SetLocation(Form game, int x, int y)
        {
            defenceObj.Location = new Point(x - (defenceObj.Width / 2), y - (defenceObj.Height / 2));
        }

        public bool ShootEnemy(enemy enemyPlayer, int index, mapData properties, bool shoot)
        {
            if (defenceObj.Bounds.IntersectsWith(enemyPlayer.enemyObj.Bounds) && shoot == true)
            {
                if (index != 0)
                    switch (properties.turningPoints[index - 1].First().Value.ToString())
                    {
                        case "left":
                            if (dir == "right")
                            {
                                enemyPlayer.health -= damage;
                            }
                            return false;

                        case "right":
                            if (dir == "left")
                            {
                                enemyPlayer.health -= damage;
                            }
                            return false;

                        case "up":
                            if (dir == "down")
                            {
                                enemyPlayer.health -= damage;
                            }
                            return false;

                        case "down":
                            if (dir == "up")
                            {
                                enemyPlayer.health -= damage;
                            }
                            return false;
                    }
                else if (index == 0 && dir == "up")
                {
                    enemyPlayer.health -= damage;
                    return false;
                }
            }
            else if (!defenceObj.Bounds.IntersectsWith(enemyPlayer.enemyObj.Bounds) && shoot == true)
                return true;

            return false;
        }
    }
    #endregion
    #endregion
}
