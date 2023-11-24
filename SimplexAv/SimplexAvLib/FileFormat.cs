using SimplexAvLib.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexAvLib
{
    public class FileFormat
    {
        public Hashtable audioFormats;
        public Hashtable videoFormats;
        public FileFormat()
        {
            audioFormats = new Hashtable()
            {
                {"aa", new FileType( "aa","Audible AA format files",FileContent.Audio) }               

            };
        }
    }
}
