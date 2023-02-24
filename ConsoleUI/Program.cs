// See https://aka.ms/new-console-template for more information
using Bussines.Concrete;
using DataAccess.Concrete.EntityFramework;

BookManager booksManager = new BookManager(new EfBooksDal());
var result = booksManager.GetAll();
if(result.Success)
foreach (var item in result.Data)
{
        Console.WriteLine(result.Message +"\n"+ item.BookName );
    }
