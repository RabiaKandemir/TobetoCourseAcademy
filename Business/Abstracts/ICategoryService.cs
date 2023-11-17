using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
      public DataResult<List<Category>> GetAll();

       public DataResult<Category> GetById(int id);

    }
}
