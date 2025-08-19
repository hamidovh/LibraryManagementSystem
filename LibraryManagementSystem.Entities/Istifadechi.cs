using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Istifadechi
    {
        public int ID { get; set; } // Primary Key
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DoghumTarixi { get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        public string IstifadechiAdi { get; set; }
        public string Shifre { get; set; }
        public bool Aktivdirmi { get; set; }
        public DateTime QeydiyyatTarixi { get; set; } // istifadechinin elavə olunma tarixidir.
        public int RolID { get; set; }
        public virtual Rol Rol { get; set; } // Istifadechi class-i ile Rol class-i arasında elaqe
    }
}
