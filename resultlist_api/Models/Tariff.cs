namespace resultlist_api.Models
{
    public class Tariff
    {
        public string Name { get; set; }
        public int Download { get; set; }
        public int Upload { get; set; }
        public string[] Benefits { get; set; }
        public double Price { set; get; }
    }
}
