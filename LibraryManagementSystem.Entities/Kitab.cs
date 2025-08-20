namespace LibraryManagementSystem.Entities
{
    public class Kitab : IEntity // IEntity interface-i ile Kitab class-i arasinda elaqe
    {
        public int ID { get; set; } // IEntity interface-indeki ID property-si. Primary Key.
        //public int KitabID { get; set; } // Primary Key
        public string KitabAdi { get; set; }
        public int MuellifID { get; set; } // Foreign Key to Muellif
        public virtual Muellif Muellif { get; set; } // Kitab class-i ile Muellif class-i arasında elaqe
        public int KateqoriyaID { get; set; } // Foreign Key to Kateqoriya
        public virtual Kateqoriya Kateqoriya { get; set; } // Kitab class-i ile Kateqoriya class-i arasında elaqe
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
