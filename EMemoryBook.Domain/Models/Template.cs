namespace EMemoryBook.Domain.Models
{
    public class Template
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPremium { get; set; }


        public ICollection<Event> Events { get; set; }
    }
}
