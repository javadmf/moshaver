namespace moshaver.Models
{
    public class Address
    {
     public int AddressId { get; set; }
     public int RegionId { get; set; }
     public string Highway { get; set; }
     public string Autobahn { get; set; }   
     public string MainSt { get; set; }   
     public string Street { get; set; }   
     public string Square { get; set; }   
     public string Alley { get; set; }   
     public string Deadend { get; set; }   
     public int Plaque { get; set; }   
     public int Postalcode { get; set; }
        public DateTime InsertDateTime { get; set; }
        public DateTime InsertDateTimePersian { get; set; }
        public DateTime UpDateTime { get; set; }
        public DateTime UptDateTimePersian { get; set; }

     public int InsertUserId { get; set; }
     public int InsertRoleId { get; set; }


        public ICollection<Users>? Users { get; set; }

    }
}
