using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {

        IDataResult<List<Course>> GetByCategory(int id);

        IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IDataResult<List<Course>> GetAll();

        IDataResult<Course> GetById(int id);
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(Course course);
    }
}
