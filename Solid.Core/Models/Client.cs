namespace Solid.Core.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pone { get; set; }
        public string Adress { get; set; }
        public Client(int id, string name, string pone, string adress)
        {
            Id = id;
            Name = name;
            Pone = pone;
            Adress = adress;
        }
    }
}
