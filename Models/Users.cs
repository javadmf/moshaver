using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace moshaver.Models
{
    public class Users
    {
        [Key]

            public int UserId   { get; set; }
            
            public int GenderId   { get; set; }
            public int GuId   { get; set; }
            public int AddressId   { get; set; }
            public string Username { get; set; }
        [Required(ErrorMessage ="نام را وارد نمایید")]    
        public string LastName { get; set; }
            public string FirstName { get; set; }
            public string Password { get; set; }
            public string HashedPassword { get; set; }
            public string IsActive { get; set; }
            public string VerificationCode { get; set; }
            public string RegisteredUser { get; set; }
            public string Lat { get; set; }
            public string Lon { get; set; }
            public string UserLocation { get; set; }
            public string UserDevices { get; set; }
            public string UserBrowsers { get; set; }
            public int UserTransactionId { get; set; }
            public DateTime SessionStartTime { get; set; }
            public DateTime SessionEndTime { get; set; }
            public DateTime LoginDate { get; set; }
            public DateTime InsertDateTime { get; set; }
            public DateTime InsertDateTimePersian { get; set; }
            public DateTime UpDateTime { get; set; }
        public DateTime UptDateTimePersian { get; set; }
    public Address Address { get; set; }
       
        }

}
