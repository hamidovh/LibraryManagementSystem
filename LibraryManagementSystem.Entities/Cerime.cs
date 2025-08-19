using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Cerime
    {
        public int CerimeID { get; set; } // Primary Key
        public decimal Mebleg { get; set; } 
        public bool Odenilibmi { get; set; } 
        public DateTime CerimeTarix { get; set; } // Cerimenin yazildığı tarix
        public DateTime OdenmeTarixi { get; set; } // Cerimenin öənildiyi tarix (ödənilənədək null ola bilər)
        public string Sebeb { get; set; } // Cərimənin səbəbi, məsələn "Gecikmə" və ya "İtirilmiş kitab"
        public int IstifadechiID { get; set; } // Foreign Key to Istifadechi
        public virtual Istifadechi Istifadechi { get; set; } // Cerime class-i ile Istifadechi class-i arasında elaqe
        public int IcareID { get; set; } // Foreign Key to Icare
        public virtual Icare Icare { get; set; } // Cerime class-i ile Icare class-i arasında elaqe
    }
}
