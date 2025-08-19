using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Entities
{
    public class Muellif
    {
        public int MuellifID { get; set; } // Primary Key
        public string MuellifAdi { get; set; } 
        public string MuellifSoyadi { get; set; } 
        public string MuellifAdSoyadi
        {
            get { return $"{MuellifAdi} {MuellifSoyadi}"; } // Full name of the author
        }
        public DateTime MuellifinDoghumTarixi { get; set; } 
    }
}
