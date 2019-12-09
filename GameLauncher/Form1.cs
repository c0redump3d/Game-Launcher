using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class Form1 : MaterialForm
    {
        private string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // appdata location
        private WebClient webc = new WebClient();
        string snakeGameVersion;
        string paintAppVersion;
        string tetrisGameVersion;
        bool tetrisOutOfDate = false;
        bool paintOutOfDate = false;
        bool snakeOutOfDate = false;
        //595, 510
        //825, 510

        int selectedTab = 0; // main menu

        public Form1()
        {
            InitializeComponent();
            AppFolder appSettings = new AppFolder();
            appSettings.createFile(); // creates file if necessary
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey900, 0, TextShade.WHITE);

            materialSkinManager.ROBOTO_REGULAR_11 = new Font("Roboto", 18);

            byte[] paintData = webc.DownloadData("https://raw.githubusercontent.com/StrugglingDoge/PaintApp/master/version"); // get latest release
            byte[] tetrisData = webc.DownloadData("https://raw.githubusercontent.com/StrugglingDoge/TetrisGame/master/version"); // get latest release
            byte[] snakeData = webc.DownloadData("https://raw.githubusercontent.com/StrugglingDoge/Snake-Game/master/release"); // get latest release

            paintAppVersion = Encoding.UTF8.GetString(paintData).Replace("\0", "").Remove(8);
            tetrisGameVersion = Encoding.UTF8.GetString(tetrisData).Replace("\0", "").Remove(8);
            snakeGameVersion = Encoding.UTF8.GetString(snakeData).Replace("\0", "").Remove(9);

            if (File.Exists(appData + @"\GameLauncher\TetrisGame\version.txt"))
            {
                StreamReader sr = new StreamReader(appData + @"\GameLauncher\TetrisGame\version.txt");
                string version = sr.ReadToEnd();
                if (version != tetrisGameVersion)
                {
                    tetrisOutOfDate = true;
                }
            }

            if (File.Exists(appData + @"\GameLauncher\PaintApp\version.txt"))
            {
                StreamReader sr = new StreamReader(appData + @"\GameLauncher\PaintApp\version.txt");
                string version = sr.ReadToEnd();
                if (version != paintAppVersion)
                {
                    paintOutOfDate = true;
                }
            }

            if (File.Exists(appData + @"\GameLauncher\SnakeGame\version.txt"))
            {
                StreamReader sr = new StreamReader(appData + @"\GameLauncher\SnakeGame\version.txt");
                string version = sr.ReadToEnd();
                if (version != snakeGameVersion)
                {
                    snakeOutOfDate = true;
                }
            }

            updateLog.BackColor = this.BackColor;
        }

        private void infoTetris_Click(object sender, System.EventArgs e)
        {
            selectedTab = 1; // tetris
            updateLog.Text = "Update Logs(" + tetrisGameVersion + "):\r\n" + Encoding.UTF8.GetString(webc.DownloadData("https://raw.githubusercontent.com/StrugglingDoge/TetrisGame/master/updatelogs")).Replace(@"\\n", "\r\n");

            if (File.Exists(appData + @"\GameLauncher\TetrisGame\TetrisGame.exe") && !tetrisOutOfDate)
            {
                if (downloadGameButton.Text != "Play")
                {
                    downloadGameButton.Text = "Play";
                    downloadGameButton.Left += 20;
                }
            }
            else
            {
                if (downloadGameButton.Text == "Play")
                    downloadGameButton.Left -= 20;
                if (tetrisOutOfDate)
                    downloadGameButton.Text = "Update";
                else
                    downloadGameButton.Text = "Download";
            }
            gameNameLabel.Text = "Tetris";
            inGamePicture.Image = Properties.Resources.tetrisGameplay;
            gameMenuPicture.Image = Properties.Resources.tetrisCapture;
            gameDescription.Text = "Tetris - just as you remember, but\nwith a few twists. With this game,\nyou can select any level to start on," +
                "\nand higher the level, the more\nchallenge.This game also\nsupports controllers!";

            tetrisPicture.Hide();
            paintAppPicture.Hide();
            snakeGamePicture.Hide();
            infoTetris.Hide();
            infoPaint.Hide();
            infoSnake.Hide();

            backButton.Show();
            gameNameLabel.Show();
            downloadGameButton.Show();
            inGamePicture.Show();
            gameDescription.Show();
            gameMenuPicture.Show();
            updateLog.Show();
            this.Width = 825;
        }

        private void backButton_Click(object sender, System.EventArgs e)
        {
            tetrisPicture.Show();
            paintAppPicture.Show();
            snakeGamePicture.Show();
            infoTetris.Show();
            infoPaint.Show();
            infoSnake.Show();

            backButton.Hide();
            gameNameLabel.Hide();
            downloadGameButton.Hide();
            inGamePicture.Hide();
            gameDescription.Hide();
            gameMenuPicture.Hide();
            updateLog.Hide();
            this.Width = 595;
        }

        private void downloadGameButton_Click(object sender, System.EventArgs e)
        {
            if (selectedTab == 1)
            {
                if (downloadGameButton.Text == "Download" || downloadGameButton.Text == "Update")
                {
                    using (WebClient wc = new WebClient())
                    {
                        downloadGameButton.Enabled = false;
                        wc.DownloadFile("https://github.com/StrugglingDoge/TetrisGame/releases/download/" + tetrisGameVersion + "/TetrisGame.exe", appData + @"\GameLauncher\TetrisGame\TetrisGame.exe");
                        wc.DownloadFile("https://github.com/StrugglingDoge/TetrisGame/releases/download/" + tetrisGameVersion + "/TetrisGame.exe.config", appData + @"\GameLauncher\TetrisGame\TetrisGame.exe.config");
                        if (!File.Exists(appData + @"\GameLauncher\TetrisGame\version.txt"))
                        {
                            var file = File.Create(appData + @"\GameLauncher\TetrisGame\version.txt");
                            file.Close();
                        }

                        StreamWriter sw = new StreamWriter(appData + @"\GameLauncher\TetrisGame\version.txt");
                        sw.Write("" + tetrisGameVersion);
                        sw.Close();
                        MessageBox.Show("Done.");
                        downloadGameButton.Text = "Play";
                        downloadGameButton.Left += 20;
                        tetrisOutOfDate = false;
                        downloadGameButton.Enabled = true;
                    }
                }
                else if (downloadGameButton.Text == "Play")
                {
                    Process[] pname = Process.GetProcessesByName("TetrisGame");
                    if (pname.Length == 0) // if game isnt already running
                        Process.Start(appData + @"\GameLauncher\TetrisGame\TetrisGame.exe");
                }
            }
            else if (selectedTab == 2)
            {

                if (downloadGameButton.Text == "Download" || downloadGameButton.Text == "Update")
                {
                    using (WebClient wc = new WebClient())
                    {
                        try
                        {
                            downloadGameButton.Enabled = false;
                            string paintAppLink = "https://github.com/StrugglingDoge/PaintApp/releases/download/" + paintAppVersion + "/PaintApp.exe";
                            wc.DownloadFile(paintAppLink, appData + @"\GameLauncher\PaintApp\PaintApp.exe");

                            if (!File.Exists(appData + @"\GameLauncher\PaintApp\version.txt"))
                            {
                                var file = File.Create(appData + @"\GameLauncher\PaintApp\version.txt");
                                file.Close();
                            }

                            StreamWriter sw = new StreamWriter(appData + @"\GameLauncher\PaintApp\version.txt");
                            sw.Write("" + paintAppVersion);
                            sw.Close();
                            MessageBox.Show("Done.");
                            downloadGameButton.Text = "Play";
                            downloadGameButton.Left += 20;
                            downloadGameButton.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed download, please try again later.\n Error: " + ex.Message);
                            downloadGameButton.Enabled = true;
                        }
                    }
                }
                else if (downloadGameButton.Text == "Play")
                {
                    Process[] pname = Process.GetProcessesByName("PaintApp");
                    if (pname.Length == 0) // if game isnt already running
                        Process.Start(appData + @"\GameLauncher\PaintApp\PaintApp.exe");
                }
            }
            else if (selectedTab == 3)
            {

                if (downloadGameButton.Text == "Download" || downloadGameButton.Text == "Update")
                {
                    using (WebClient wc = new WebClient())
                    {
                        try
                        {
                            downloadGameButton.Enabled = false;
                            string paintAppLink = "https://github.com/StrugglingDoge/Snake-Game/releases/download/" + snakeGameVersion + "/Snake." + snakeGameVersion + ".exe";
                            wc.DownloadFile(paintAppLink, appData + @"\GameLauncher\SnakeGame\SnakeGame.exe");
                            if (!File.Exists(appData + @"\GameLauncher\SnakeGame\version.txt"))
                            {
                                var file = File.Create(appData + @"\GameLauncher\SnakeGame\version.txt");
                                file.Close();
                            }

                            StreamWriter sw = new StreamWriter(appData + @"\GameLauncher\SnakeGame\version.txt");
                            sw.Write("" + snakeGameVersion);
                            sw.Close();
                            MessageBox.Show("Done.");
                            downloadGameButton.Text = "Play";
                            downloadGameButton.Left += 20;
                            downloadGameButton.Enabled = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed download, please try again later.\n Error: " + ex.Message);
                            downloadGameButton.Enabled = true;
                        }
                    }
                }
                else if (downloadGameButton.Text == "Play")
                {
                    Process[] pname = Process.GetProcessesByName("SnakeGame");
                    if (pname.Length == 0) // if game isnt already running
                        Process.Start(appData + @"\GameLauncher\SnakeGame\SnakeGame.exe");
                }
            }
        }

        private void infoPaint_Click(object sender, EventArgs e)
        {
            selectedTab = 2; // paint

            updateLog.Text = "Update Logs(" + paintAppVersion + "):\r\n" + Encoding.UTF8.GetString(webc.DownloadData("https://raw.githubusercontent.com/StrugglingDoge/PaintApp/master/updatelogs")).Replace(@"\\n", "\r\n");

            if (File.Exists(appData + @"\GameLauncher\PaintApp\PaintApp.exe") && !paintOutOfDate)
            {
                if (downloadGameButton.Text != "Play")
                {
                    downloadGameButton.Text = "Play";
                    downloadGameButton.Left += 20;
                }
            }
            else
            {
                if (downloadGameButton.Text == "Play")
                    downloadGameButton.Left -= 20;
                if (paintOutOfDate)
                    downloadGameButton.Text = "Update";
                else
                    downloadGameButton.Text = "Download";
            }

            gameNameLabel.Text = "Paint App";
            inGamePicture.Image = Properties.Resources.paintInGame;
            gameMenuPicture.Image = Properties.Resources.paintCapture;
            gameDescription.Text = "Paint App allows you to draw\nalmost anything you want. This app\nmakes it easy to draw pixel art\nwith lots of customiztion.";

            tetrisPicture.Hide();
            paintAppPicture.Hide();
            snakeGamePicture.Hide();
            infoTetris.Hide();
            infoPaint.Hide();
            infoSnake.Hide();

            backButton.Show();
            gameNameLabel.Show();
            downloadGameButton.Show();
            inGamePicture.Show();
            gameDescription.Show();
            gameMenuPicture.Show();
            updateLog.Show();
            this.Width = 825;
        }

        private void SnakeInfo_Click(object sender, EventArgs e)
        {
            selectedTab = 3; // snake

            updateLog.Text = "Update Logs(" + snakeGameVersion + "):\r\n" + Encoding.UTF8.GetString(webc.DownloadData("https://raw.githubusercontent.com/StrugglingDoge/Snake-Game/master/updatelogs")).Replace(@"\\n", "\r\n");

            if (File.Exists(appData + @"\GameLauncher\SnakeGame\SnakeGame.exe") && !snakeOutOfDate)
            {
                if (downloadGameButton.Text != "Play")
                {
                    downloadGameButton.Text = "Play";
                    downloadGameButton.Left += 20;
                }
            }
            else
            {
                if (downloadGameButton.Text == "Play")
                    downloadGameButton.Left -= 20;
                if (snakeOutOfDate)
                    downloadGameButton.Text = "Update";
                else
                    downloadGameButton.Text = "Download";
            }

            gameNameLabel.Text = "Snake Game";
            inGamePicture.Image = Properties.Resources.snakeInGame;
            gameMenuPicture.Image = Properties.Resources.snakeMenu;
            gameDescription.Text = "A reimagination of the classic\nsnake game! In this game, there\nare 3 diffent diffuculties that change\nyour speed of your snake. There\nare also lots of powerups that can\nspawn!";

            tetrisPicture.Hide();
            paintAppPicture.Hide();
            snakeGamePicture.Hide();
            infoTetris.Hide();
            infoPaint.Hide();
            infoSnake.Hide();

            backButton.Show();
            gameNameLabel.Show();
            downloadGameButton.Show();
            inGamePicture.Show();
            gameDescription.Show();
            gameMenuPicture.Show();
            updateLog.Show();
            this.Width = 825;
        }
    }
}
