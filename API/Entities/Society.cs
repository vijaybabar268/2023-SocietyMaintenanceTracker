namespace API.Entities
{
    public class Society
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Society(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}