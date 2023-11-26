using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexAvLib.Enum
{
    /// <summary>
    /// Enum per identificare il contenuto del file e per evitare
    /// una lunga lista di if{} e per creare un hashtable con tutte le informazioni del formato che verranno usate anche dal open/savefiledialog
    /// </summary>
    public enum FileContent
    {
        Audio, Video
    }
}
