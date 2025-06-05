namespace CityBreaks.Web.Models
{
    public class City
    {
        public int Id { get; set; }        
        public string Name{ get; set; } = null;
        // Foreign key to Country
        public int CountryId { get; set; }
        public Country Country { get; set; } = null;

        public List<Property> Properties { get; set; } = new ();
    }
}
