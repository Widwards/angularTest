using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTestApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public int Pages { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
    }
    public class Catalog
    {
        public List<Book> Books { get; set; }

        public Catalog()
        {
            Books = new List<Book>();
            Books.Add(new Book
            {
                Id = 1,
                ISBN = "978-5-94074-617-1",
                Author = "Франческо Чезарини, Симон Томпсон",
                Language = "Русский",
                Name = "Программирование в Erlang",
                Pages = 488,
                Category = "Языки программирования (прочие)",
                Year = "2012"
            });
            Books.Add(new Book
            {
                Id = 2,
                ISBN = "978-5-496-00954-6",
                Author = "Брюс Эккель",
                Language = "Русский",
                Name = "Философия Java",
                Pages = 640,
                Category = "Java, J++. Языки программирования",
                Year = "2012"
            });
            Books.Add(new Book
            {
                Id = 3,
                ISBN = "978-5-8459-1869-7",
                Author = "Кей С. Хорстманн, Гари Корнелл",
                Language = "Русский",
                Name = "Java. Библиотека профессионала. Том 1. Основы",
                Pages = 864,
                Category = "Java, J++. Языки программирования",
                Year = "2014"
            });
            Books.Add(new Book
            {
                Id = 4,
                ISBN = "978-5-85582-317-2",
                Author = "Генри Бекет",
                Language = "Английский",
                Name = "Java SOAP",
                Pages = 456,
                Category = "Java, J++. Языки программирования",
                Year = "2012"
            });
            Books.Add(new Book
            {
                Id = 5,
                ISBN = "978-5-17-079458-4",
                Author = "Джордж Рэймонд Ричард Мартин",
                Language = "Русский",
                Name = "Рыцарь Семи Королевств",
                Pages = 384,
                Category = "Зарубежное фэнтези",
                Year = "2013"
            });
            Books.Add(new Book
            {
                Id = 6,
                ISBN = "5-352-00778-2",
                Author = "Алан Ф. Троуп",
                Language = "Русский",
                Name = "Люди крови",
                Pages = 384,
                Category = "Зарубежное фэнтези",
                Year = "2004"
            });
            Books.Add(new Book
            {
                Id = 7,
                ISBN = "978-5-389-07601-3",
                Author = "Морган Родес",
                Language = "Русский",
                Name = "Обреченные королевства",
                Pages = 0,
                Category = "Зарубежное фэнтези",
                Year = "2013"
            });

        }
    }


    public class BookSimple
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
    }
    public class CatalogSimple
    {
        public List<BookSimple> BooksSimple { get; set; }
        public CatalogSimple()
        {
            
            BooksSimple = new List<BookSimple>();
            BooksSimple.Add(new BookSimple
            {
                Id = 1,
                Author = "Франческо Чезарини, Симон Томпсон",
                Name = "Программирование в Erlang",
                Year = "2012"
            });
            BooksSimple.Add(new BookSimple
            {
                Id = 2,
                Author = "Брюс Эккель",
                Name = "Философия Java",
                Year = "2012"
            });
            BooksSimple.Add(new BookSimple
            {
                Id = 3,
                Author = "Кей С. Хорстманн, Гари Корнелл",
                Name = "Java. Библиотека профессионала. Том 1. Основы",
                Year = "2014"
            });
            BooksSimple.Add(new BookSimple
            {
                Id = 4,
                Author = "Генри Бекет",
                Name = "Java SOAP",
                Year = "2012"
            });
            BooksSimple.Add(new BookSimple
            {
                Id = 5,
                Author = "Джордж Рэймонд Ричард Мартин",
                Name = "Рыцарь Семи Королевств",
                Year = "2013"
            });
            BooksSimple.Add(new BookSimple
            {
                Id = 6,
                Author = "Алан Ф. Троуп",
                Name = "Люди крови",
                Year = "2004"
            });
            BooksSimple.Add(new BookSimple
            {
                Id = 7,
                Author = "Морган Родес",
                Name = "Обреченные королевства",
                Year = "2013"
            });
        }
    }
}