using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

//CategoryTest();
CourseManager courseManager = new CourseManager(new EfCourseDal());
var result = courseManager.GetCourseDetails();
if (result.Success == true)
{
    foreach (var item in courseManager.GetCourseDetails().Data)
    {
        Console.WriteLine(item.CourseName + " / " + item.CategoryName);
    }
}
else
{
    Console.WriteLine(result.Message);
}
static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.Name);
    }


    //var ds = categoryManager.GetById(1);
    //Console.WriteLine(ds.Name);


    //CourseManager courseManager = new CourseManager(new EfCourseDal());
    //foreach (var item in courseManager.GetByUnitPrice(0, 500))
    //{

    //    Console.WriteLine(item.Name);
    //}
}

