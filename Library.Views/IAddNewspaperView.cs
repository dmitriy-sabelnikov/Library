using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Views
{
    public interface IAddNewspaperView
    {
        string NameNewspaper {get; set;}
        string Author {get; set;}
        string PublishHouse {get; set;}
        DateTime ReleaseDate {get; set;}
        decimal Periodicity {get; set;}
    }
}
