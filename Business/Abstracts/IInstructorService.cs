using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        public DataResult<List<Instructor>> GetAll();

        public DataResult<Instructor> GetById(int id);
    }
}
