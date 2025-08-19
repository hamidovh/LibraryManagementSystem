using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Kateqoriya
    {
        public int KateqoriyaID { get; set; } // Primary Key
        public string KateqoriyaAdi { get; set; } // Name of the category
        public string KateqoriyaTesviri { get; set; } // Description of the category
    }
}
