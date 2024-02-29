using mystudents;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var studenten = new SortedDictionary<int, Student>
        {
            { 2179336, new Student(2179336, "Marouane", "email@gmail.com", 19) },
            { 9187643, new Student(9187643, "Mohamed", "email@gmail.com", 19) },
            { 3193838, new Student(3193838, "Fadili", "email@gmail.com", 22) },
            { 4327434, new Student(4327434, "Zarzour", "email@gmail.com", 48) },
            { 5387977, new Student(5387977, "Cristiano", "email@gmail.com", 39) },
            { 6927977, new Student(6927977, "Pessi", "email@gmail.com", 36) },
            { 3827382, new Student(3827382, "Penaldo", "email@gmail.com", 80) },
            { 7469222, new Student(7469222, "Gurpreet", "email@gmail.com", 19) },
            { 3476666, new Student(3476666, "Frionel", "email@gmail.com", 90) },
            { 1010838, new Student(1010838, "Khabib", "email@gmail.com", 35) }
        };

        Console.Write("Voer de ID in ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            if (studenten.TryGetValue(id, out Student studentzoeken))
            {
                Console.WriteLine($"Name: {studentzoeken?.Naam}");
                Console.WriteLine($"Email: {studentzoeken?.Email}");
                Console.WriteLine($"leeftijd: {studentzoeken?.Leeftijd}");
            }
            else
            {
                Console.WriteLine("niet gevonden");
            }
        }
        Console.WriteLine("Lijst met studentennummers en namen:");
        foreach (var (studentId, student) in studenten)
        {
            Console.WriteLine($"Studentnummer: {studentId}, Naam: {student.Naam}");
        }



        var oudsteStudent = studenten.Values.OrderBy(student => student.Leeftijd).LastOrDefault();
        if (oudsteStudent != null)
        {
            Console.WriteLine($"Naam: {oudsteStudent.Naam}");
            Console.WriteLine($"ID: {oudsteStudent.Id}");
            Console.WriteLine($"Leeftijd: {oudsteStudent.Leeftijd}");
        }
        else
        {
            Console.WriteLine("student niet gevonden");
        }


        var gesorteerdeStudenten = studenten.Values.OrderBy(student => student.Leeftijd);

        Console.WriteLine("\nLijst van studenten gesorteerd op leeftijd:");
        foreach (var student in gesorteerdeStudenten)
        {
            Console.WriteLine($"Naam: {student.Naam}, Leeftijd: {student.Leeftijd}");
        }
    }
}


