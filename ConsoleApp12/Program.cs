using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = new List<Student>()
            {

                new Student(){Id = 0, Name = "Algis", Age = 17 , AverageMark = 7, IsGettingTuition = false},
               new Student(){Id = 1, Name = "Kestas", Age = 27 , AverageMark = 8, IsGettingTuition = true},
               new Student(){Id = 2, Name = "Pranas", Age = 22 , AverageMark = 7, IsGettingTuition = true},
               new Student(){Id = 3, Name = "Anupras", Age = 18 , AverageMark = 6, IsGettingTuition = false},
               new Student(){Id = 4, Name = "Zigmas", Age = 19 , AverageMark = 9, IsGettingTuition = true},
               new Student(){Id = 5, Name = "Emilis", Age = 22 , AverageMark = 10, IsGettingTuition = false},
            };

            /*   var result = studentList.FindAll(student => student.Age > 20);
               result.ForEach(student => Console.WriteLine(student.Name));

               var result2 = studentList.FindAll(student => student.AverageMark > 8 && student.IsGettingTuition);
               result2.ForEach(student => Console.WriteLine(student.Name));

               var result3 = studentList.FindAll(student => student.AverageMark > 4 && student.Name.Length < 7);
               result3.ForEach(student => Console.WriteLine(student.Name));*/


            /*     IEnumerable<Student> result1 = studentList.Where(student => student.AverageMark > 8 && student.IsGettingTuition);
                 List<Student> result2 = studentList.Where(student => student.AverageMark > 8 && student.IsGettingTuition).ToList();


                 var names = result1.Where(student => student.AverageMark > 8 && student.IsGettingTuition).Select(student=>student.Name).ToList();

              names.ForEach(names => Console.WriteLine(names));
     */
            /*  List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

              List<int> result1 = numbers.Where(number => number % 2 == 1).ToList();

              List<int> result2 = numbers.Where(number => number % 5 == 0).ToList();
              result2.ForEach(number => Console.WriteLine(number));

              bool result3 = numbers.Contains(7);

              Console.WriteLine(result3);

              bool result4 = numbers.Any(number => number % 11== 0);
              Console.WriteLine(result4);*/

/*
            var result = studentList.OrderBy(student => student.AverageMark).Reverse().ToList();
            var result2 = studentList.OrderBy(student => student.Age).Reverse().ToList();

            var result3 = studentList.OrderBy(student => student.Age).ThenByDescending(student => student.AverageMark).ToList();
            result3.ForEach(student => Console.WriteLine(student.AverageMark));*/

            var groups = from student in studentList
                         where student.Age > 10
                         group student by (student.Age - 1) / 10;
            foreach (IGrouping<int, Student> grouping in groups)
            {
                Console.WriteLine("Students in group " + grouping.Key + "0" + "..." + (grouping.Key + 1) + "0");
                foreach (Student student in grouping)
                {
                    Console.WriteLine("\t" + student);
                }
            }



        }

    }
}
