﻿using FirstSection_IntroductionToCSharp.DataAccess.Abstracts;
using FirstSection_IntroductionToCSharp.Entities;

namespace FirstSection_IntroductionToCSharp.DataAccess.Concretes;

public class EfCourseDal : ICourseDal
{
    List<Course> courses;

    public EfCourseDal()
    {
        Course course1 = new Course();
        course1.Id = 1;
        course1.Name = "JAVASCRIPT";
        course1.Description = "ES.Next vs...";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 1;
        course2.Name = "JAVA";
        course2.Description = "Java 17 vs...";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 1;
        course3.Name = "PYTHON";
        course3.Description = "Python 3.12... vs...";
        course3.Price = 20;

        courses = new List<Course>() { course1, course2, course3 };
    }

    public List<Course> GetAll()
    {
        // Burada database işlemleri yapılır.
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}