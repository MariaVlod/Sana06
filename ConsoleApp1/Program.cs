using System;
using ClassLibrary1;

class Program
{
    static void Main()
    {
        Person[] people = new Person[]
        {
            new Applicant {Name = "Іван", SurName = "Петров", DateOfBirth = new DateTime(2000, 5, 15), ZNOGrade = 180, DocGrade = 95, ZNZ = "Школа №1" },
            new Student {Name = "Марія", SurName = "Іванова", DateOfBirth = new DateTime(1998, 8, 25), Course = 2, Group = "Гр.123", Faculty = "Інформатика", ZNZ = "Університет" },
            new Professor { Name = "Олександр", SurName = "Сидоров", DateOfBirth = new DateTime(1975, 3, 10), Position = "Доцент", Cathedra = "Комп'ютерні науки", VNZ = "Університет" },
            new User {Name = "Наталія", SurName = "Ковальчук", DateOfBirth = new DateTime(1985, 12, 8), NumberofReaderTicket = 12345, EDate = DateTime.Now.AddDays(-30), ContributionSize = 25.50M }
        };

        foreach (var person in people)
        {
            Console.WriteLine(person.ShowInfo());
        }
    }
}



