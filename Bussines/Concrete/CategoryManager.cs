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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal= categoryDal;
        }
        public IResult Add(Category categories)
        {
            _categoryDal.Add(categories);
            return new SuccessResult(Message.CategoryAdded);
        }

        public IResult Delete(Category categories)
        {
            _categoryDal.Delete(categories);
            return new SuccessResult(Message.CategoryDeleted);

        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Message.CategoriesListened);
        }

        public IDataResult<Category> GetById(int Id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c=>c.CategoryId==Id), Message.CategoryListed);
        }

        public IResult Update(Category categories)
        {
            _categoryDal.Update(categories);
            return new SuccessResult(Message.CategoriesUptated);
        }
    }
}
