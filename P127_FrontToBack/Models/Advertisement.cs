using P127_FrontToBack.Models.Base;
using System;

namespace P127_FrontToBack.Models
{
    public class Advertisement:BaseEntity 
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
