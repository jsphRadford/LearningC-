using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class fileStuff
    {
        private static void NewMethod()
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);

            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...", true);
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                //
            }
        }
    }
}
