using System;

namespace LibraryManagementSystem.Entities
{
    public class Icare : IEntity
    {
        public int ID { get; set; } // Primary Key
        //public int IcareID { get; set; } // Primary Key
        public decimal IcareQiymeti { get; set; } 
        public DateTime IcareTarixi { get; set; } // Verilme tarixi
        public DateTime SonTarix { get; set; } // Qaytarilmali oldughu tarix
        public DateTime QaytarilmaTarixi { get; set; } // Qaytarildighi tarix (qaytarilanadek Nullable olmalidir)
        public bool Qaytarilibmi { get; set; } // Icarenin qaytarilib-qaytarilmadighini gosterir (true - qaytarilib, false - qaytarilmayib)
        public string Statusu { get; set; } // Icarenin veziyyetini, aktiv olub-olmadighini ("Icarededir" ("Aktiv"), "Gecikir", "Qaytarilib")
        public int IstifadechiID { get; set; } // Foreign Key to Istifadechi
        public virtual Istifadechi Istifadechi { get; set; } // Icare class-i ile Istifadechi class-i arasında elaqe
        public int KitabID { get; set; } // Foreign Key to Kitab
        public virtual Kitab Kitab { get; set; } // Icare class-i ile Kitab class-i arasında elaqe
    }
}
