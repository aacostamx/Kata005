﻿using Kata005.Models;
using Kata005.Repositories;
using System;
using System.Collections.Generic;
using SimpleInjector;
using Kata005.Interfaces;

namespace Kata005
{
    public class Program
    {
        static readonly Container container;

        static Program()
        {
            container = new Container();

            container.Register<IPrincipal, Principals>();
            container.Register<IStudent, Students>();
            container.Register<ITeacher, Teachers>();

            container.Verify();
        }

        static void Main(string[] args)
        {
            var principalRepository = container.GetInstance<IPrincipal>();
            var studentRepository = container.GetInstance<IStudent>();
            var teacherRepository = container.GetInstance<ITeacher>();

            Guid guid = principalRepository.GetByExpression(c => c.Name == "Dr. Wilson").Id;
            var principal = principalRepository.GetByExpression(c => c.Id == guid);
            Console.WriteLine($"Id: {principal.Id} \nPrincipal : {principal.Name}");

            Teacher teacher = teacherRepository.GetByExpression(c => c.Id == 1);
            Console.WriteLine($"Teacher: {teacher.Name}");

            List<Student> studentsForTeacher = studentRepository.GetByTeacherId(teacher.Id);
            Console.WriteLine($"Students: ");
            foreach (Student student in studentsForTeacher)
            {
                Console.WriteLine($"{student.Name}");
            }
        }
    }
}
