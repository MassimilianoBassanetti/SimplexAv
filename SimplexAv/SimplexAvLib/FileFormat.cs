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
        /// <summary>
        /// Hashtable dei formati audio supportati
        /// </summary>
        public Hashtable audioFormats;
        /// <summary>
        /// Hashtable dei formati video supportati
        /// </summary>
        public Hashtable videoFormats;
        /// <summary>
        /// Costruttore della classe
        /// </summary>
        public FileFormat()
        {
            // Inizializza e riempe la variabile dei formati audio con i tutti i formati audio supportati
            audioFormats = new Hashtable()
            {
                {"aa", new FileType( "aa","Audible AA format files",FileContent.Audio) }               

            };
        }
    }
}
