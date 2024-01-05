namespace BlazorTest.Models
{
    public class Pizza
    {
        public Pizza(int id, string name) : this(id, name, string.Empty) { }

        public Pizza(int id, string name, string group)
        {
            Id = id;
            Name = name;
            Group = group;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
    }
}
