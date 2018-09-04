namespace KSS.Models
{
    public class Location
    {
        public int LocationId { get; set; } //PK
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
    }
}
