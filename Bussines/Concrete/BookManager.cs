using Bussines.Abstract;
using Bussines.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class BookManager : IBooksService
    {
        IBooksDal _BooksDal;
        public BookManager(IBooksDal booksDal)
        {
            _BooksDal = booksDal;
        }

        public IResult Add(Books book)
        {

            _BooksDal.Add(book);
            return new SuccessResult(Message.BookAdded);
        }

        public IResult Delete(Books book)
        {
            _BooksDal.Delete(book);
            return new SuccessResult(Message.BookDeleted);
        }

        public IDataResult<List<Books>>  GetAll()
        {

            return new SuccessDataResult<List<Books>>(_BooksDal.GetAll(),Message.BooksListed);
        }

        public IDataResult<List<BookDetailsDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<BookDetailsDto>>(_BooksDal.GetAllDetails(),Message.BooksDetailsListed);
        }

        public IDataResult<Books> GetById(int Id)
        {
            return new SuccessDataResult<Books>(_BooksDal.Get(b => b.Id == Id),Message.GivenBookListed);
        }

        public IDataResult<List<Books>> GetBySum(decimal min, decimal max)
        {
           return new SuccessDataResult<List<Books>>(_BooksDal.GetAll(b=>b.Sum>=min&&b.Sum<=max),Message.GivenBookListed);
        }

        public IResult Update(Books book)
        {
            _BooksDal.Update(book);
            return new SuccessResult("Kitap Güncellendi");
        }
    }
}
