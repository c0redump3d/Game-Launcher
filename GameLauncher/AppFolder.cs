using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    class AppFolder
    {
        /*
         * 
         * The purpose of this class is to create a text file telling us that
         * this application has been opened before. This is here for the tutorial
         * form. So, on first start up of this application, it will show the tutorial
         * form, otherwise it won't.
         * 
         */

        private string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // appdata location

        public void createFile()// create file if neccessary, called on startup
        {
            if (File.Exists(appData + @"\GameLauncher\settings.txt")) // don't want to create a file that already exists
                return;

            if (!Directory.Exists(appData + @"\GameLauncher\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\GameLauncher\");

            if (!Directory.Exists(appData + @"\GameLauncher\SnakeGame\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\GameLauncher\SnakeGame\");

            if (!Directory.Exists(appData + @"\GameLauncher\PaintApp\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\GameLauncher\PaintApp\");

            if (!Directory.Exists(appData + @"\GameLauncher\TetrisGame\")) //same thing, dont want to create directory that already exists
                Directory.CreateDirectory(appData + @"\GameLauncher\TetrisGame\");

            var settingsTXT = File.Create(appData + @"\GameLauncher\settings.txt");

            settingsTXT.Close();
        }
    }
}
