using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBooksDal : EfEntityRepository<Books, LibraryContext>, IBooksDal
    {
        public List<BookDetailsDto> GetAllDetails()
        {
            using (LibraryContext context = new LibraryContext())
            {
                var result = from b in context.Books
                             join c in context.Categories
                             on b.CategoryId equals c.CategoryId
                             join a in context.Authors
                             on b.AuthorId equals a.Id
                             select new BookDetailsDto { Id = b.Id, BookName = b.BookName, AuthorName = a.AuthorName, About = b.About, CategoryName = c.CategoryName };
                return result.ToList();         
            }
        }
    }
}
