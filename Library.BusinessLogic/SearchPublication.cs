using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class SearchPublication
    {
        public static List<Book> FindBook(List<Book> sourceBooks, string codeBook, string name, string author)
        {
            List<Book> resultFindNBook = new List<Book>();
            foreach (Book book in sourceBooks)
            {
                if ((book.CodeBook == codeBook || codeBook == String.Empty) &&
                    (book.Name == name || name == String.Empty) &&
                    (book.Author == author || author == String.Empty))
                {
                    resultFindNBook.Add(book);
                }
            }
            return resultFindNBook;
          
        }

        public static List<Newspaper> FindNewspaper(List<Newspaper> sourceNewspaper,string name, string author,string publishHouse, DateTime releaseDate, decimal periodicity)
        {
            List<Newspaper> resultFindNewspaper = new List<Newspaper>();
            foreach (Newspaper newspaper in sourceNewspaper)
            {
                if ((newspaper.Name == name || name == String.Empty) &&
                    (newspaper.Author == author || author == String.Empty) &&
                    (newspaper.PublishHouse == publishHouse || publishHouse == String.Empty) &&
                    (newspaper.ReleaseDate == releaseDate || releaseDate == DateTime.MinValue) &&
                    (newspaper.Periodicity == periodicity || periodicity == 0))
                {
                    resultFindNewspaper.Add (newspaper);
                }
            }
            return resultFindNewspaper;
        }

        public static List<Magazine> FindMagazine(List<Magazine> sourceMagazine, string name, string publishHouse, string publishMonth, string magazineTheme)
        {
            List<Magazine> resultFindMagazine = new List<Magazine>();
            foreach (Magazine magazine in sourceMagazine)
            {
                if ((magazine.Name == name || name == String.Empty) &&
                    (magazine.PublishHouse == publishHouse || publishHouse == String.Empty) &&
                    (magazine.PublishMonth == publishMonth || publishMonth == String.Empty) &&
                    (magazine.MagazineTheme == magazineTheme || magazineTheme == String.Empty))
                {
                    resultFindMagazine.Add(magazine);
                }
            }
            return resultFindMagazine;
        }
    }
}
