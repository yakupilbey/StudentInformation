using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList student1 = new StudentList();
            student1.name = "Yakup";
            student1.surname = "ILBEY";
            student1.age = 21;
            student1.schoolName = "Kocaeli University";


            StudentList student2 = new StudentList();
            student2.name = "Görken";
            student2.surname = "IZMIR";
            student2.age = 20;
            student2.schoolName = "Kocaeli University";


            StudentList student3 = new StudentList();
            student3.name = "Fatih";
            student3.surname = "KAPLAMA";
            student3.age = 24;
            student3.schoolName = "Bilkent University";


            StudentList student4 = new StudentList();
            student4.name = "AkiF";
            student4.surname = "ERGİN";
            student4.age = 21;
            student4.schoolName = "Fırat University";






            StudentList[] studentLists = new StudentList[] { student1, student2, student3, student4 };


            foreach (var student in studentLists)
            {
                Console.WriteLine("Adı Soyadı: " + student.name + " " + student.surname + "\nYaşı: " + student.age + "\nOkulu: " + student.schoolName + "\n---------------------------------\n");
            }
        }

    }
}


class StudentList
{
    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; }
    public string schoolName { get; set; }
}

