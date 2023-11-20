using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public IResult Add(Course course)
        {
            if (course.Name.Length < 2)
            {
                return new ErrorResult(Messages.CourseNameInvalid);
            }
            _courseDal.Add(course);
            return new Result(true, Messages.CourseAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
                return new SuccessResult(Messages.CourseDeleted);
        }

        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 3)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CourseListed);
        }

        public IDataResult<List<Course>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<List<Course>> GetByCategory(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Course> GetById(int id)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(p => p.Price >= min && p.Price <= max));
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            if (DateTime.Now.Hour == 2)
            {
                return new ErrorDataResult<List<CourseDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdated);
        }
    }
}
