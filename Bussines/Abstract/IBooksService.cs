using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IBooksService
    {
        IDataResult<List<Books>>  GetAll();
        IDataResult<Books>   GetById(int Id);
        IResult  Add(Books book);
        IResult Delete(Books book);
        IResult Update(Books book);
        IDataResult<List<BookDetailsDto>> GetAllDetails();

    } 
}
