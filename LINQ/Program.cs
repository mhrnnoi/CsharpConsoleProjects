using System;
using System.Linq;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentDB.GetStudentFromDb();

            var activeHighScoreNYCStudents = students.Where(a => a.IsActive == true && a.Score > 80 && a.City == "NYC");

            var highScoreOrCAStudents = students.Where(a => a.Score > 80 || a.City == "CA")
                                                        .Select(a => a.StudentName);

            var nameStartWithBStudentsInMinimalForm = students.Where(a => a.StudentName.StartsWith("B"))
                                                            .Select(a => new MinimalStudent() { StudentName = a.StudentName, Score = a.Score });

            var inActiveStudentSortedByScoreDescending = students.Where(a => a.IsActive == false)
                                                                .OrderByDescending(a => a.Score);

            var meanOfAllScores = students.Select(a => a.Score).Average();

            var meanOfActiveCAStudentsWithROrDNamesScores = students.Where(a => a.IsActive == true && a.City == "CA" && (a.StudentName.ToLower().Contains('r') || a.StudentName.ToLower().Contains('d')))
                                                                    .Select(a => a.Score)
                                                                    .Average();

            foreach (var item in activeHighScoreNYCStudents)
            {
                Console.WriteLine(item.StudentName);
            }

            Console.WriteLine();

            foreach (var item in highScoreOrCAStudents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in nameStartWithBStudentsInMinimalForm)
            {
                Console.WriteLine(item.StudentName);
            }

            Console.WriteLine();

            foreach (var item in inActiveStudentSortedByScoreDescending)
            {
                Console.WriteLine(item.Score);
            }

            Console.WriteLine();

            Console.WriteLine("mean of all scores " + meanOfAllScores);

            Console.WriteLine();

            Console.WriteLine("mean of Active CA Students With R Or D Names Scores " + meanOfActiveCAStudentsWithROrDNamesScores);





        }
    }
}
