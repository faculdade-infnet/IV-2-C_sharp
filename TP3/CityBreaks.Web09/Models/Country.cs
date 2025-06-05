namespace CityBreaks.Web.Models
{
    public class Country
    {
        public int Id { get; set; }        
        public string CountryCode { get; set; } = null;
        public string CountryName { get; set; } = null;
        public List<City> Cities{ get; set; } = new ();
    }
}
