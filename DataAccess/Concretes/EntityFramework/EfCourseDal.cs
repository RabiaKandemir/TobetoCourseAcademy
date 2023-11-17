using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (TobetoCourseContext context = new TobetoCourseContext())
            {

                var result = from c in context.Courses
                             join ca in context.Categories
                             on c.CategoryId equals ca.Id
                             select new CourseDetailDto
                             {
                                 CourseId = c.Id,
                                 CourseName = c.Name,
                                 CategoryName = ca.Name,
                                 Price = c.Price
                             };
                return result.ToList();
            }
        }
    }
}
