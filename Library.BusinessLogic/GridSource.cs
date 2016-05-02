using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public static class GridSource
    {
        public static Library BookLibrary { get; set; }

        public static List <Book> ResultSearchBook { get; set; }

        public static List<Newspaper> ResultSearchNewspaper { get; set; }

        public static List<Magazine> ResultSearchMagazine { get; set; }
        
        public static void ClearGrid(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        public static void FillLibraryByBooks(DataGridView grid, List<Book> books)
        {
            int gridRow = grid.RowCount;
            foreach (Book book in books)
            {
                grid.Rows.Add();
                grid.Rows[gridRow].Cells["Id"].Value = book.Id;
                grid.Rows[gridRow].Cells["Author"].Value = book.Author;
                grid.Rows[gridRow].Cells["NameBook"].Value = book.Name;
                grid.Rows[gridRow].Cells["CodeBook"].Value = book.CodeBook;
                grid.Rows[gridRow].Cells["Type"].Value = PublicationType.book.ToString();
                gridRow++;
            }
        }

        public static void FillLibraryByNewspapers(DataGridView grid, List<Newspaper> newspapers)
        {
            int gridRow = grid.RowCount;
            foreach (Newspaper newspaper in newspapers)
            {
                grid.Rows.Add();
                grid.Rows[gridRow].Cells["Id"].Value = newspaper.Id;
                grid.Rows[gridRow].Cells["Author"].Value = newspaper.Author;
                grid.Rows[gridRow].Cells["NameBook"].Value = newspaper.Name;
                grid.Rows[gridRow].Cells["PublishHouse"].Value = newspaper.PublishHouse;
                grid.Rows[gridRow].Cells["ReleaseDate"].Value = newspaper.ReleaseDate;
                grid.Rows[gridRow].Cells["Periodicity"].Value = newspaper.Periodicity;
                grid.Rows[gridRow].Cells["Type"].Value = PublicationType.newspaper.ToString();
                gridRow++;
            }
        }

        public static void FillLibraryByMagazines(DataGridView grid, List<Magazine> magazines)
        {
            int gridRow = grid.RowCount;
            foreach (Magazine magazine in magazines)
            {
                grid.Rows.Add();
                grid.Rows[gridRow].Cells["Id"].Value = magazine.Id;
                grid.Rows[gridRow].Cells["NameBook"].Value = magazine.Name;
                grid.Rows[gridRow].Cells["PublishHouse"].Value = magazine.PublishHouse;
                grid.Rows[gridRow].Cells["PublishMonth"].Value = magazine.PublishMonth;
                grid.Rows[gridRow].Cells["MagazineTheme"].Value = magazine.MagazineTheme;
                grid.Rows[gridRow].Cells["Type"].Value = PublicationType.magazine.ToString();
                gridRow++;
            }
        }


    }
}
