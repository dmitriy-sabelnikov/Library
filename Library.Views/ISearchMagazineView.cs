using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Views
{
    public interface ISearchMagazineView
    {
        string NameMagazine { get; set; }
        string PublishHouse { get; set; }
        string PublishMonth { get; set; }
        string MagazineTheme { get; set; }
    }
}
