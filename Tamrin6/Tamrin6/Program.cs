using System;
using System.Collections.Generic;
using System.IO;

namespace UniversityApp
{
    
    class Student
    {
        public string StudentNumber { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        
        static Dictionary<string, Student> students = new Dictionary<string, Student>();

      
        static string filePath = @"C:\UNI.txt";

        static void Main(string[] args)
        {
            LoadFromFile();

            while (true)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Enter Student information ");
                Console.WriteLine("2. Display student information ");
                Console.WriteLine("3.Removing a Student ");
                Console.WriteLine("4. Exit ");
                Console.Write("Choose one : ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ShowStudents();
                        break;
                    case "3":
                        RemoveStudent();
                        break;
                    case "4":
                        SaveToFile();
                        return;
                    default:
                        Console.WriteLine("Erorrrrrrrrrrrrr!");
                        break;
                }
            }
        }

       
        static void AddStudent()
        {
            Console.Write("Student number : ");
            string number = Console.ReadLine();

            Console.Write("Student name : ");
            string name = Console.ReadLine();

            if (!students.ContainsKey(number))
            {
                students[number] = new Student
                {
                    StudentNumber = number,
                    Name = name
                };
                Console.WriteLine("Student added.");
            }
            else
            {
                Console.WriteLine("Student is already registered.");
            }
        }


        static void ShowStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No Student registered.");
                return;
            }

            foreach (var student in students.Values)
            {
                Console.WriteLine($"Number : {student.StudentNumber} | Name : {student.Name}");
            }
        }

       
        static void RemoveStudent()
        {
            Console.Write("Student number to delete : ");
            string number = Console.ReadLine();

            if (students.Remove(number))
            {
                Console.WriteLine("student was removed .");
            }
            else
            {
                Console.WriteLine("No student with this number was found .");
            }
        }

        
        static void SaveToFile()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var student in students.Values)
                {
                    writer.WriteLine($"{student.StudentNumber},{student.Name}");
                }
            }
        }

        
        static void LoadFromFile()
        {
            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    students[parts[0]] = new Student
                    {
                        StudentNumber = parts[0],
                        Name = parts[1]
                    };
                }
            }
        }
    }
} 