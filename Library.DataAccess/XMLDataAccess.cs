using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.DataAccess
{
    public static class XMLDataAccess
    {
        public static void SaveToXmlBooks (string path, List <Book> books)
        {
            XDocument xDoc = new XDocument();
            XElement xBooks = new XElement("Books");
            foreach (Book book in books)
            {
                XElement xBook = new XElement("Book");
                XAttribute xBookId = new XAttribute("Id", book.Id);
                XElement xBookName = new XElement ("Name", book.Name);
                XElement xBookAuthor = new XElement ("Author", book.Author);
                XElement xBookCodeBook = new XElement ("CodeBook", book.CodeBook);
                xBook.Add(xBookId);
                xBook.Add(xBookName);
                xBook.Add(xBookAuthor);
                xBook.Add(xBookCodeBook);
                xBooks.Add(xBook);
            }
            xDoc.Add(xBooks);
            xDoc.Save(path);
        }

        public static List<Book> LoadFromXmlBooks (string path)
        {
            List<Book> books = new List<Book>();
            if (!File.Exists (path))
            {
                return books;
            }
            XDocument xDoc = XDocument.Load(path);
            if (xDoc.Element("Books") == null)
            {
                return books;
            }
            foreach (XElement bookElement in xDoc.Element("Books").Elements("Book"))
            {
                XAttribute xBookId = bookElement.Attribute("Id");
                XElement xBookName = bookElement.Element("Name");
                XElement xBookAuthor = bookElement.Element("Author");
                XElement xBookCodeBook = bookElement.Element("CodeBook");
                if (xBookId != null)
                {
                    Book book = new Book {
                        Id = Int32.Parse(xBookId.Value),
                        Name = xBookName.Value,
                        Author = xBookAuthor.Value,
                        CodeBook = xBookCodeBook.Value
                    };
                    books.Add(book);
                }
            }
            return books;
        }

        public static void SaveToXmlNewspaper(string path, List<Newspaper> newspapers)
        {
            XDocument xDoc = new XDocument();
            XElement xNewspapers = new XElement("Newspapers");
            foreach (Newspaper newspaper in newspapers)
            {
                XElement xNewspaper = new XElement("Newspaper");
                XAttribute xNewspaperId = new XAttribute("Id", newspaper.Id);
                XElement xNewspaperName = new XElement("Name", newspaper.Name);
                XElement xNewspaperAuthor = new XElement("Author", newspaper.Author);
                XElement xNewspaperPublishHouse = new XElement("PublishHouse", newspaper.PublishHouse);
                XElement xNewspaperReleaseDate = new XElement("ReleaseDate", newspaper.ReleaseDate);
                XElement xNewspaperPeriodicity = new XElement("Periodicity", newspaper.Periodicity);

                xNewspaper.Add(xNewspaperId);
                xNewspaper.Add(xNewspaperName);
                xNewspaper.Add(xNewspaperAuthor);
                xNewspaper.Add(xNewspaperPublishHouse);
                xNewspaper.Add(xNewspaperReleaseDate);
                xNewspaper.Add(xNewspaperPeriodicity);
                xNewspapers.Add(xNewspaper);
            }
            xDoc.Add(xNewspapers);
            xDoc.Save(path);
        }

        public static List<Newspaper> LoadFromXmlNewspapers(string path)
        {
            List<Newspaper> newspapers = new List<Newspaper>();
            if (!File.Exists(path))
            {
                return newspapers;
            }
            XDocument xDoc = XDocument.Load(path);
            if (xDoc.Element("Newspapers") == null)
            {
                return newspapers;
            }
            foreach (XElement newspaperElement in xDoc.Element("Newspapers").Elements("Newspaper"))
            {
                XAttribute xNewspaperId = newspaperElement.Attribute("Id");
                XElement xNewspaperName = newspaperElement.Element("Name");
                XElement xNewspaperAuthor = newspaperElement.Element("Author");
                XElement xNewspaperPublishHouse = newspaperElement.Element("PublishHouse");
                XElement xNewspaperReleaseDate = newspaperElement.Element("ReleaseDate");
                XElement xNewspaperPeriodicity = newspaperElement.Element("Periodicity");
                if (xNewspaperId != null)
                {
                    Newspaper newspaper = new Newspaper
                    {
                        Id = Int32.Parse(xNewspaperId.Value),
                        Name = xNewspaperName.Value,
                        Author = xNewspaperAuthor.Value,
                        PublishHouse = xNewspaperPublishHouse.Value,
                        ReleaseDate = DateTime.Parse(xNewspaperReleaseDate.Value),
                        Periodicity = Decimal.Parse(xNewspaperPeriodicity.Value)
                    };
                    newspapers.Add(newspaper);
                }
            }
            return newspapers;
        }

        public static void SaveToXmlMagazines(string path, List<Magazine> magazines)
        {
            XDocument xDoc = new XDocument();
            XElement xMagazines = new XElement("Magazines");
            foreach (Magazine magazine in magazines)
            {
                XElement xMagazine = new XElement("Magazine");
                XAttribute xMagazineId = new XAttribute("Id", magazine.Id);
                XElement xMagazineName = new XElement("Name", magazine.Name);
                XElement xMagazinePublishHouse = new XElement("PublishHouse", magazine.PublishHouse);
                XElement xMagazinePublishMonth = new XElement("PublishMonth", magazine.PublishMonth);
                XElement xMagazineMagazineTheme = new XElement("MagazineTheme", magazine.MagazineTheme);

                xMagazine.Add(xMagazineId);
                xMagazine.Add(xMagazineName);
                xMagazine.Add(xMagazinePublishHouse);
                xMagazine.Add(xMagazinePublishMonth);
                xMagazine.Add(xMagazineMagazineTheme);
                xMagazines.Add(xMagazine);
            }
            xDoc.Add(xMagazines);
            xDoc.Save(path);
        }

        public static List<Magazine> LoadFromXmlMagazines(string path)
        {
            List<Magazine> magazines = new List<Magazine>();
            if (!File.Exists(path))
            {
                return magazines;
            }
            XDocument xDoc = XDocument.Load(path);
            if (xDoc.Element("Magazines") == null)
            {
                return magazines;
            }
            foreach (XElement magazineElement in xDoc.Element("Magazines").Elements("Magazine"))
            {
                XAttribute xMagazineId = magazineElement.Attribute("Id");
                XElement xMagazineName = magazineElement.Element("Name");
                XElement xMagazinePublishHouse = magazineElement.Element("PublishHouse");
                XElement xMagazinePublishMonth = magazineElement.Element("PublishMonth");
                XElement xMagazinePublishTheme = magazineElement.Element("MagazineTheme");
                if (xMagazineId != null)
                {
                    Magazine magazine = new Magazine
                    {
                        Id = Int32.Parse(xMagazineId.Value),
                        Name = xMagazineName.Value,
                        PublishHouse = xMagazinePublishHouse.Value,
                        PublishMonth = xMagazinePublishMonth.Value,
                        MagazineTheme = xMagazinePublishTheme.Value
                    };
                    magazines.Add(magazine);
                }
            }
            return magazines;
        }

    }
}
