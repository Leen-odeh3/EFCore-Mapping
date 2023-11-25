using EFCore.Context;
using EFCore.Entites;
using System.Numerics;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using UniContext obj = new UniContext();

            Student s1 = new Student() 
            {Fname= "Mohamed",Lastname= " Amir",
                Email="Mohamed @gmail.com",Address= "Cairo",
                Age=22, Phone="010144528955" };


            Student s2 = new Student()
            {
                Fname = "Mariam Selem",
                Lastname = "Selem",
                Email = "MS@gmail.com",
                Address = "Alex",
                Age = 25,
                Phone = "010144528955"
            };

            Student s3 = new Student()
            {
                Fname = "Tarek",
                Lastname = " Amir",
                Email = "TM@gmail.com",
                Address = "Luxor",
                Age = 23,
                Phone="015144528955"
            };

            Instructor c1 = new Instructor()
            {
                Name = "Ahmed Helmy",
                Email = "AH@gmail.com",
                Address = "Luxor",
                
            };
            Instructor c2 = new Instructor()
            {
                Name = "Ibrahim Fayek",
                Email = "EF@gmail.com",
                Address = "Cairo",

            };

            //obj.Students.Add(s1);
            //obj.Students.Add(s2);
            // obj.Students.Add(s3);

            //  obj.Instructors.Add(c1);
            // obj.Instructors.Add(c2);

            // obj.SaveChanges();

            //Retrieve all students living in ‘Cairo.’
            var x = obj.Students.Where(e => e.Address == "cairo").Select(e=>e.Fname);

            foreach(var c in x)
            {
                Console.WriteLine(c);
                
            }

            //Delete The Instructor who has ID => 2

            var InstructorId2 = obj.Instructors.Where(e => e.Id == 2).Select(e => e.Name).FirstOrDefault();

            Console.WriteLine(InstructorId2);


            //Modify the Address number of instructor who has ID ‘1’
            var InstructorId3 = obj.Instructors.Where(e => e.Id == 3).Select(e => e.Address).FirstOrDefault();
            InstructorId3 = "Palestine";
            Console.WriteLine(InstructorId3);

        }
    }
}