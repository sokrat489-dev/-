using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Эфендиев
{
    internal class Program
    {
        public class student
        {
            public string FIO;
            public int Ocenka1;
            public int Ocenka2;
            public void Show()
            {
                Console.WriteLine($"Студент: {FIO}");
                Console.WriteLine($"Оценка1: {Ocenka1}");
                Console.WriteLine($"Оценка2: {Ocenka2}");
            }
            
        class Program
        {
            static void Main(string[] args)
            {
                student student = new student();
                student.FIO = "Эфендиев";
                student.Ocenka1 = 3;
                student.Ocenka2 = 5;
                Console.WriteLine("--- Данные студента ---");
                student.Show();
                float average = student.SredOcenka();
                Console.WriteLine($"\nСредняя оценка:{average}");
                Console.ReadLine();
            }
        }public float SredOcenka()
            {
                return (Ocenka1 + Ocenka2) / 2.0f;
            }
        }
    }
}
