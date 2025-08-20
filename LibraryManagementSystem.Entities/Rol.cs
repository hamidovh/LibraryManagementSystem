namespace LibraryManagementSystem.Entities
{
    public class Rol : IEntity
    {
        public int ID { get; set; } // Primary Key
        //public int RolID { get; set; } // Primary Key
        public string RolAdi { get; set; }
    }
}
