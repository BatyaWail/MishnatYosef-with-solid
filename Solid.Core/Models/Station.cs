namespace Solid.Core.Models
{
    public class Station
    {
        public string Adress { get; set; }
        public int Id { get; set; }
        public int CountFamily { get; set; }
        public DayOfWeek Day { get; set; }
        public Station(string adress, int id, int countFamily, DayOfWeek day)
        {
            Adress = adress;
            Id = id;
            CountFamily = countFamily;
            Day = day;
        }
    }
}
