using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
        class Person
        {
            public string Name;
            public int Age;

            // Method to display person's basic information
            public void DisplayInfo()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Age: " + Age);
            }
        }

        // Derived class Student (inherits from Person)
        class Student : Person
        {
            public string SchoolName;
            public int Grade;

            // Method to display student-specific information
            public void DisplayStudentInfo()
            {
                Console.WriteLine("School: " + SchoolName);
                Console.WriteLine("Grade: " + Grade);
            }
        }

        // Further derived class HighSchoolStudent (inherits from Student)
        class HighSchoolStudent : Student
        {
            public string HighSchoolName;
            public string FavoriteSubject;

            // Method to display high school student-specific information
            public void DisplayHighSchoolStudentInfo()
            {
                Console.WriteLine("High School: " + HighSchoolName);
                Console.WriteLine("Favorite Subject: " + FavoriteSubject);
            }
        }

    // The Inheritance class which contains the Run method
    class MultilevelInheritence
    {
            // The Run method where the logic for multilevel inheritance is executed
            public void Run()
            {
                // Create an object of the HighSchoolStudent class
                HighSchoolStudent student = new HighSchoolStudent();
                student.Name = "John Doe";
                student.Age = 16;
                student.SchoolName = "Riverdale High";
                student.Grade = 10;
                student.HighSchoolName = "Riverdale High School";
                student.FavoriteSubject = "Mathematics";

                // Calling methods from different levels of the inheritance hierarchy
                student.DisplayInfo();  // Inherited from Person
                student.DisplayStudentInfo();  // Inherited from Student
                student.DisplayHighSchoolStudentInfo();  // Specific to HighSchoolStudent
            }
        }
    }
