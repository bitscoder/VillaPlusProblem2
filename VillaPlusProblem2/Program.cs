// See https://aka.ms/new-console-template for more information

using VillaPlusProblem2.Models;

List<Students> students = new List<Students>();
students.Add(new Students() { Name = "Ruturaj", SubjectName = "Maths", Marks = 90 });
students.Add(new Students() { Name = "Villa", SubjectName = "History", Marks = 100 });
students.Add(new Students() { Name = "Ruturaj", SubjectName = "c++", Marks = 900 });
students.Add(new Students() { Name = "Chintawar", SubjectName = "java", Marks = 70 });
students.Add(new Students() { Name = "Ruturaj", SubjectName = "go", Marks = 920 });
students.Add(new Students() { Name = "Chintawar", SubjectName = "Angular", Marks = 190 });
students.Add(new Students() { Name = "Villa", SubjectName = "Sql", Marks = 230 });
students.Add(new Students() { Name = "Plus", SubjectName = "java", Marks = 70 });
students.Add(new Students() { Name = "Ruturaj", SubjectName = "go", Marks = 920 });
students.Add(new Students() { Name = "Plus", SubjectName = "Angular", Marks = 190 });
students.Add(new Students() { Name = "Villa", SubjectName = "Sql", Marks = 230 });


var results = from p in students
              group p.Marks by p.Name into g
              orderby g.Sum() descending
              select new { Name = g.Key, Marks = g.Sum() };
foreach(var result in results)
{
    Console.WriteLine("Student : {0} recived marks: {1}",result.Name, result.Marks);
}