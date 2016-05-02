using Entities;
using Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    public class Library
    {    
        private List<Book> _books = new List<Book>();
        private List<Newspaper> _newspapers = new List<Newspaper>();
        private List<Magazine> _magazines = new List<Magazine>();

        //search max id in _books
        private int GetNextIdBook()
        {
            int maxId = 0;
            foreach (Book book in _books) 
            {
                if (book.Id > maxId)
                {
                    maxId = book.Id;
                }
            }
            return ++maxId;
        }
        //search max id in _newspapers
        private int GetNextIdNewspaper()
        {
            int maxId = 0;
            foreach (Newspaper newspaper in _newspapers)
            {
                if (newspaper.Id > maxId)
                {
                    maxId = newspaper.Id;
                }
            }
            return ++maxId;
        }
        //search max id in _magazines
        private int GetNextIdMagazine()
        {
            int maxId = 0;
            foreach (Magazine magazine in _magazines)
            {
                if (magazine.Id > maxId)
                {
                    maxId = magazine.Id;
                }
            }
            return ++maxId;
        }

        public void AddBook(string code, string nameBook, string author)
        {
            int idBook = GetNextIdBook();
            Book book = new Book { Id = idBook, CodeBook = code, Name = nameBook, Author = author };
            _books.Add(book);
        }

        public void AddNewspaper (string nameNewspaper, string author, string publishHouse, DateTime releaseDate, decimal periodicity)
        {
            int idNewspaper = GetNextIdNewspaper();
            Newspaper newspaper = new Newspaper {
                Id = idNewspaper,
                Name = nameNewspaper,
                Author = author,
                PublishHouse = publishHouse,
                ReleaseDate = releaseDate,
                Periodicity = periodicity
            };
            _newspapers.Add(newspaper);
        }

        public void AddMagazine(string nameMagazine, string publishHouse, string publishMonth, string magazineTheme)
        {
            int idMagazine = GetNextIdMagazine();
            Magazine magazine = new Magazine
            {
                Id = idMagazine,
                Name = nameMagazine,
                PublishHouse = publishHouse,
                PublishMonth = publishMonth,
                MagazineTheme = magazineTheme
            };
            _magazines.Add(magazine);
        }

        public List<Book> GetAllBook()
        {
            return _books;
        }

        public List<Newspaper> GetAllNewspaper()
        {
            return _newspapers;
        }

        public List<Magazine> GetAllMagazine()
        {
            return _magazines;
        }

        public void UnionListBooks (List<Book> UnionListBook)
        {
            _books.AddRange(UnionListBook);
        }

        public void UnionListNewspapers(List<Newspaper> UnionListNewspapers)
        {
            _newspapers.AddRange(UnionListNewspapers);
        }

        public void UnionListMagazines(List<Magazine> UnionListMagazines)
        {
            _magazines.AddRange(UnionListMagazines);
        }
    }
}
