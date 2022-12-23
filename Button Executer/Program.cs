using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Executer
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        /// Welcome to the button executer application.
        /// This is a Window Forms application containing
        /// different types of buttons that can execute
        /// various tasks, including opening folders, links,
        /// and commands executed within the command line.
        /// 
        /// It reads the buttons in from an XML file and
        /// creates the appropriate buttons.
        /// The XML files must be stored in 
        /// %userprofile%\Documents\Button Executer.
        /// Download: https://drive.google.com/drive/folders/1MGS_LZBu9uVUugehw0zz3PrUBN7tUmKV?usp=sharing
        /// 
        /// Take a look at the ideas from the examples 
        /// and create / modify the buttons to your liking.
        /// The concepts should all be demonstrated within
        /// these examples provided.
        /// 
        /// Note: Some commands, such as logoff or msg may
        /// not work properly in this environment.
        /// 
        /// If you want to actually use this program, don't
        /// be shy and try to customize it to your liking.

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
