using System;
using System.IO;

namespace GameLauncher
{
    class AppFolder
    {
        /*
         * 
         * create proper files/folders for launcher
         * 
         */

        private string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // appdata location

        public void createFile()// create file if neccessary, called on startup
        {

            if (!Directory.Exists(appData + @"\GameLauncher\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\GameLauncher\");

            if (!Directory.Exists(appData + @"\GameLauncher\SnakeGame\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\GameLauncher\SnakeGame\");

            if (!Directory.Exists(appData + @"\GameLauncher\PaintApp\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\GameLauncher\PaintApp\");

            if (!Directory.Exists(appData + @"\GameLauncher\TetrisGame\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\GameLauncher\TetrisGame\");


            if (File.Exists(appData + @"\GameLauncher\settings.txt")) // don't want to create a file that already exists
                return;

            var settingsTXT = File.Create(appData + @"\GameLauncher\settings.txt");

            settingsTXT.Close();
        }
    }
}
