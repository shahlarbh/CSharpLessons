using P329ConsoleAppPractise.Models;
using P329ConsoleAppPractise.Services;

namespace P329ConsoleAppPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StudentManager
            //StudentManager studentManager = new StudentManager();

            //string command = "";

            //do
            //{
            //    Console.Write("Enter the command:");
            //    command = Console.ReadLine();

            //    if (command.ToLower().Equals("add student"))
            //    {
            //        var student1 = new Student
            //        {
            //            Id = 1,
            //            Firstname = "Sahlar",
            //            Lastname = "Haciyev",
            //            Age = 25,
            //            Course = 4,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            }
            //        };

            //        var student2 = new Student
            //        {
            //            Id = 2,
            //            Firstname = "Elvin",
            //            Lastname = "Cebrayilov",
            //            Age = 24,
            //            Course = 4,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            }
            //        };

            //        studentManager.Add(student1);
            //        studentManager.Add(student2);
            //    }

            //    else if (command.ToLower().Equals("print students"))
            //    {
            //        studentManager.Print();
            //    }

            //    else if (command.ToLower().Equals("delete student"))
            //    {
            //        Console.Write("Enter the ID:");
            //        var id = int.Parse(Console.ReadLine());

            //        studentManager.Delete(id);
            //    }

            //    else if (command.ToLower().Equals("update student"))
            //    {
            //        Console.Write("Enter the ID:");
            //        var id = int.Parse(Console.ReadLine());

            //        var existStudent = studentManager.Get(id);
            //        if (existStudent == null)
            //            continue;
            //        Console.WriteLine(existStudent);

            //        var student2 = new Student
            //        {
            //            Id = 2,
            //            Firstname = "Elvin",
            //            Lastname = "Cebrayilov",
            //            Age = 27,
            //            Course = 4,
            //            EntryDate = DateTime.Now,
            //            Group = new Group
            //            {
            //                Id = 1,
            //                Name = "P329",
            //            }
            //        };

            //        studentManager.Update(2,student2);
            //    }
            //} while (command.ToLower() != "quit");
            #endregion

            TeacherManager teacherManager = new TeacherManager();

            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                if (command.ToLower().Equals("add teacher"))
                {
                    var teacher1 = new Teacher
                    {
                        Id = 1,
                        Firstname = "Rafet",
                        Lastname = "Rzayev",
                        Age = 26,
                        Profession = "Software developer",
                    };

                    var teacher2 = new Teacher
                    {
                        Id = 2,
                        Firstname = "Adil",
                        Lastname = "Heybatov",
                        Age = 25,
                        Profession = "Software developer",
                    };

                    teacherManager.Add(teacher1);
                    teacherManager.Add(teacher2);
                }

                else if (command.ToLower().Equals("print teachers"))
                {
                    teacherManager.Print();
                }

                else if (command.ToLower().Equals("delete teachers"))
                {
                    Console.Write("Enter the ID:");
                    var id = int.Parse(Console.ReadLine());

                    teacherManager.Delete(id);
                }

                else if (command.ToLower().Equals("update teachers"))
                {
                    Console.Write("Enter the ID:");
                    var id = int.Parse(Console.ReadLine());

                    var existTeacher = teacherManager.Get(id);
                    if (existTeacher == null)
                        continue;
                    Console.WriteLine(existTeacher);

                    var teacher2 = new Teacher
                    {
                        Id = 2,
                        Firstname = "Adil",
                        Lastname = "Heybatov",
                        Age = 27,
                        Profession = "Software developer",
                      
                    };

                    teacherManager.Update(2, teacher2);
                }
            } while (command.ToLower() != "quit");
        }
    }
}