using FirstSection_IntroductionToCSharp.DataAccess.Abstracts;
using FirstSection_IntroductionToCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSection_IntroductionToCSharp.Business;

public class CourseManager
{
    // Dependency injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        // Business rules
        return _courseDal.GetAll();
    }
}