using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_File.Servises
{
    class ChangeFile
    {
        public void Delete()
        {
            ReadFromFile File = new ReadFromFile();
            Console.WriteLine(File.FromFile());
            Console.WriteLine();
        }
    }
}
