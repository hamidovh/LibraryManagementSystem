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
        public int MuellifID { get; set; }
        public virtual Muellif Muellif { get; set; } // Kitab class-i ile Muellif class-i arasında elaqe
        public int KateqoriyaID { get; set; }
        //public virtual Kateqoriya Kateqoriya { get; set; } // Kitab class-i ile Kateqoriya class-i arasında elaqe
        public decimal IcareQiymeti { get; set; } 
        public bool StokdaVarmi { get; set; } 
        public string Qeyd { get; set; } 
        
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
