namespace moshaver.Models
{
    public class Items
    {
        public int ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Floors { get; set; }
        public string UnitsNum { get; set; }
        public float ItemLength { get; set; }
        public float StreetWidth { get; set; }

        //prob tab 
        public int MyProperty { get; set; }

        //ctor tab
        public Items()
        {

        }   
    }
}
