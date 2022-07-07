using P127_FrontToBack.Models.Base;

namespace P127_FrontToBack.Models
{
    public class Phone:BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public string Ram { get; set; }
        public short Count { get; set; }

    }
}
