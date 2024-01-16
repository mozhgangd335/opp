using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    class Program
    {

       static Ilibrary Manager = new BookLibrary();
        static void Main(string[] args)

        {
        
       

            while (true)
            {
                int menu = GetInt("1.add book or payanname\n2.showbooks\n3.show payanname\n4.delete book or payanname\n5.show details book or payanname");

                switch (menu)
                {
                    case 1:
                        {
                            var type = GetInt("enter your type:1.book  2.payanname");
                            var Name = GetString("enter name or title");
                            BookLibrary.Add(Name, type);

                            break;
                           
                        }
                    case 2:

                        {

                            foreach(var book in BookLibrary._books)
                            {
                                Console.WriteLine($"BooKName is:{book.BookName}");
                            }
                            break;
                        }

                    case 3:
                        {
                            foreach(var payanname in BookLibrary._payanname)
                            {
                                Console.WriteLine($"title of payanname is:{payanname.Titel}");
                            }
                            break;
                        }
                    case 4:
                        {

                            var type = GetInt("enter your type:1.book  2.payanname");
                            var Name = GetString("enter name or title");
                            BookLibrary.Delete(Name, type);


                            break;
                        }
                    case 5:
                        {

                            var type = GetInt("enter your type:1.book  2.payanname");
                            var Name = GetString("enter name or title");

                            BookLibrary.ShowDetails(Name, type);
                            break;
                        }
                }

                

            }



        }


      public static string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine();
            return value;
        }

      public static int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine());
            return value;
        }
    }
}
