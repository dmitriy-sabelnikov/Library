using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Newspaper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string PublishHouse { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Periodicity { get; set; }    
    }
}
