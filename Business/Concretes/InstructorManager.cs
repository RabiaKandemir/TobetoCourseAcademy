using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructordal;
        public InstructorManager(IInstructorDal instructordal)
        {
            _instructordal= instructordal;
        }

        public IResult Add(Instructor instructor)
        {
            _instructordal.Add(instructor);
            return new SuccessResult(Messages.InstructorAdded);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructordal.Delete(instructor);
            return new SuccessResult(Messages.InstructorDeleted);
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructordal.GetAll(), Messages.CourseListed);
        }

        public IDataResult<Instructor> GetById(int id)
        {
            return new SuccessDataResult<Instructor>(_instructordal.Get(p => p.Id == id));
        }

        public IResult Update(Instructor instructor)
        {
            _instructordal.Update(instructor);
            return new SuccessResult(Messages.InstructorUpdated);
        }
    }
}
