using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LogicOfTheApp
{
    public class blanktextfile
    {
        public static void createfile()
        {
            string Path = @"D:\\Phase2\\C# day5 aug 24\\filehandling_demo\text.txt";
            File.Create(Path);

        }
    }
}
