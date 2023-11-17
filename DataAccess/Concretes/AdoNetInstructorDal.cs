using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetInstructorDal
    {
        public void Add(Instructor instructor)
        {
            Console.WriteLine("instructor "+instructor.FirstName+" "+instructor.LastName+" Ado.Net kullanılarak veritabanına eklendi..");
        }
    }
}
