using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LINQ
{
    public class StudentDB
    {
        public static IEnumerable<Student> GetStudentFromDb()
        {
            return new[]
            {
                new Student() {StudentId = 1, StudentName = "John Nigel", Score = 83, City ="NYC", IsActive = true},
                new Student() {StudentId = 2, StudentName = "Alex Roma", Score = 81, City ="CA", IsActive = false},
                new Student() {StudentId = 3, StudentName = "Noha Shamil", Score = 88, City ="CA", IsActive = true},
                new Student() {StudentId = 4, StudentName = "James Palette", Score = 45, City ="NYC", IsActive = false},
                new Student() {StudentId = 5, StudentName = "Ron Jenova", Score = 85, City ="NYC", IsActive = true},
                new Student() {StudentId = 6, StudentName = "Bruce Lee", Score = 100, City ="CA", IsActive = false},
                new Student() {StudentId = 7, StudentName = "Dwayne Johnson", Score = 100, City ="CA", IsActive = true}



            }.AsEnumerable();
            
        }
    }
}