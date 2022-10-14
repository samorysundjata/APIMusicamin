namespace APIMusicamin.Models
{
    public class Artista
    {
        private string name;

        public Guid Id { get; set; }
        public string Name { get => name; set => name = value; }

    }
}
