using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
  public class BookLibrary: Ilibrary
    {
       private  List<Book> _books = new List<Book>();
       private  List<Payanname> _payanname = new List<Payanname>();
     
        public void Add(string name,int type )
        {
            if (type == 1)
            {
                Book book = new Book(name);
                _books.Add(book);
            }
            if (type == 2)
            {
                Payanname payanname = new Payanname(name);
                _payanname.Add(payanname);
            }
        }

        public void Delete(string name,int type )
        {
            if (type == 1)
            {
                var namefordel = _books.Find(_ => _.BookName == name);
                if (namefordel == null)
                {
                    throw new Exception("this book is not found");
                }else
                { _books.Remove(namefordel); }
            }
            if (type == 2)
            {
                var payan = _payanname.Find(_ => _.Titel == name);
                if (payan == null)
                {
                    throw new Exception("this name of payanname is not found");
                }
                else
                {
                    _payanname.Remove(payan);
                }
            }
        }

        public void ShowDetails(int type)
        {
            if (type == 1)
            {
               foreach(var book in _books)
                {
                    Console.WriteLine($"book name is:{book.BookName}");
                }
            }
            if (type == 2)
            {
                foreach(var payanname in _payanname)
                {
                    Console.WriteLine($"title of payanname is:{payanname.Titel}");
                }
            }
            List<Book> GetBook()
            {
                return _books;
            }

            List<Payanname> GetPayanname()
            {
                return _payanname;

            }

        }
    }

}
