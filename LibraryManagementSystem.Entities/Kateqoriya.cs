namespace LibraryManagementSystem.Entities
{
    public class Kateqoriya : IEntity 
    {
        public int ID { get; set; } // Primary Key
        //public int KateqoriyaID { get; set; } // Primary Key
        public string KateqoriyaAdi { get; set; } 
        public string KateqoriyaTesviri { get; set; } 
    }
}
