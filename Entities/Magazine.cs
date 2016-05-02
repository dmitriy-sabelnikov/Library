using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Magazine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PublishHouse { get; set; }
        public string PublishMonth { get; set; }
        public string MagazineTheme { get; set; }
    }
}
