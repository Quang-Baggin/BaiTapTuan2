using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            studentList.Add(new Student(1, "An", 15));
            studentList.Add(new Student(2, "Binh", 17));
            studentList.Add(new Student(3, "Anh", 18));
            studentList.Add(new Student(4, "Cuong", 14));
            studentList.Add(new Student(5, "Dung", 20));

            // a. In danh sach toan bo hoc sinh
            Console.WriteLine("=== a. Danh sach hoc sinh ===");

            foreach (Student student in studentList)
            {
                student.Show();
            }

            // b. Hoc sinh co tuoi tu 15 den 18
            Console.WriteLine("\n=== b. Hoc sinh tu 15 den 18 tuoi ===");

            var studentsAge = studentList.Where(
                s => s.Age >= 15 && s.Age <= 18);

            foreach (Student student in studentsAge)
            {
                student.Show();
            }

            // c. Hoc sinh co ten bat dau bang chu A
            Console.WriteLine("\n=== c. Hoc sinh co ten bat dau bang A ===");

            var studentsNameA = studentList.Where(
                s => s.Name.StartsWith("A",
                StringComparison.OrdinalIgnoreCase));

            foreach (Student student in studentsNameA)
            {
                student.Show();
            }

            // d. Tinh tong tuoi tat ca hoc sinh
            Console.WriteLine("\n=== d. Tong tuoi hoc sinh ===");

            int totalAge = studentList.Sum(s => s.Age);

            Console.WriteLine("Tong tuoi: " + totalAge);

            // e. Tim hoc sinh co tuoi lon nhat
            Console.WriteLine("\n=== e. Hoc sinh co tuoi lon nhat ===");

            int maxAge = studentList.Max(s => s.Age);

            var oldestStudents = studentList.Where(
                s => s.Age == maxAge);

            foreach (Student student in oldestStudents)
            {
                student.Show();
            }

            // f. Sap xep hoc sinh theo tuoi tang dan
            Console.WriteLine("\n=== f. Sap xep theo tuoi tang dan ===");

            var sortedStudents = studentList.OrderBy(
                s => s.Age);

            foreach (Student student in sortedStudents)
            {
                student.Show();
            }

            Console.ReadLine();
        }
    }
}

