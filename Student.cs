using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapBuoi2
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
        }
        public void Input()
        {
            Console.Write("Nhap ma hoc sinh: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten hoc sinh: ");
            Name = Console.ReadLine();

            Console.Write("Nhap tuoi hoc sinh: ");
            Age = int.Parse(Console.ReadLine());
        }

        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void Show()
        {
            Console.WriteLine("Ma HS: {0} | Ho ten: {1} | Tuoi: {2}",
                Id, Name, Age);
        }
    }
}
