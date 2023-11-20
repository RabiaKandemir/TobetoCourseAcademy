using Business.Abstracts;
using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseInstructorManager : ICourseInstructorService
    {
        public IResult Add(Course course)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Course>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Course> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
