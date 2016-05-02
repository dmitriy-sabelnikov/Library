using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Views
{
    public interface ISearchBookView
    {
        string Code { get; set; }
        string Author { get; set; }
        string NameBook { get; set; }
    }
}
