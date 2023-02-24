using Bussines.Abstract;
using Bussines.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorDal _AuthorDal;
        public AuthorManager(IAuthorDal AuthorDal)
        {
            _AuthorDal = AuthorDal;
        }
        public IResult Add(Author author)
        {
            _AuthorDal.Add(author);
            return new SuccessResult(Message.AuthorAdded);
        }

        public IResult Delete(Author Author)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Author>> GetAll()
        {
            return new SuccessDataResult<List<Author>>(_AuthorDal.GetAll(), Message.AuthorListened);
        }

        public IDataResult<Author> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Author Author)
        {
            throw new NotImplementedException();
        }
    }
}
