using System;

namespace LibraryManagementSystem.Entities
{
    public class Istifadechi : IEntity
    {
        public int ID { get; set; } // Primary Key
        //public int IstifadechiID { get; set; } // Primary Key
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DoghumTarixi { get; set; }
        public string Cins { get; set; } // K/Q
        public string FinKod { get; set; } 
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        public string IstifadechiAdi { get; set; }
        public string Shifre { get; set; }
        public bool Aktivdirmi { get; set; }
        public DateTime QeydiyyatTarixi { get; set; } // istifadechinin elavə olunma tarixidir.
        public int RolID { get; set; } // Foreign Key to Rol
        public virtual Rol Rol { get; set; } // Istifadechi class-i ile Rol class-i arasında elaqe
    }
}
