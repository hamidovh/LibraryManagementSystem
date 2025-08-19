using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Kitab
    {
        public int KitabID { get; set; } // Primary Key
        public string KitabAdi { get; set; }
        public string Muellif { get; set; }
        public bool StokdaVarmi { get; set; } // Indicates if the book is available
        public string Qeyd { get; set; } // Description of the book
        
    }
}
/*
public string SiraNo { get; set; } // Shelf number
public string RafNo { get; set; } // Rack number
public string Barkod { get; set; } // Barcode for the book
public string Cild { get; set; } // Binding type
public DateTime YayinTarixi { get; set; } // Publication date
public string ISBN { get; set; } // International Standard Book Number
public string Yayinevi { get; set; } // Publisher
public string Dil { get; set; } // Language of the book
public string Kategori { get; set; } // Category of the book
public int SayfaSayisi { get; set; } // Number of pages 
*/
