using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IAuthorService
    {
        IDataResult<List<Author>> GetAll();
        IDataResult<Author> GetById(int Id);
        IResult Add(Author author);
        IResult Delete(Author author);
        IResult Update(Author author);

    }
}
