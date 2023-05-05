using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Customer, int, Customer> CustomerData()
        {
            return new CustomerRepo();
        }

        public static IRepo<Book, int, Book> BookData()
        {
            return new BookRepo();
        }
    }
}
