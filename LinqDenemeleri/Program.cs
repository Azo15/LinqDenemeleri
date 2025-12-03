using System;
using System.Collections.Generic;
using System.Linq;

// 1. Veri Yapısı (Student Sınıfı)
 
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    { 
        return $"Ad: {Name}, Yaş: {Age}";
    }
}
 
class Program
{
    static void Main(string[] args)
    {
        // 2. Başlangıç Veri Seti (Öğrenci Listesi)
        List<Student> students = new List<Student>
        {
            new Student { Name = "Ali", Age = 20 },
            new Student { Name = "Ayse", Age = 17 },
            new Student { Name = "Mehmet", Age = 22 },
            new Student { Name = "Fatma", Age = 19 },
            new Student { Name = "Burak", Age = 25 },
            new Student { Name = "Gizem", Age = 18 }
        };

        Console.WriteLine("--- Tüm Öğrenciler ---");
        students.ForEach(s => Console.WriteLine(s));
        Console.WriteLine("\n======================================================\n");


        // SENARYO: Yaşı 18 den Büyük Olanları Filtrele Ada Göre Sırala ve Listeye Çevir


        // 3. Yaklaşım: LINQ Sorgu Sözdizimi (Query Syntax - SQL Benzeri)
     
        Console.WriteLine("###  LINQ Sorgu Sözdizimi (Query Syntax)");
        Console.WriteLine("### (Bildirimsel ve SQL sorgularına benzer)\n");

        var resultQuerySyntax =
            from student in students        // 1. Kaynak (students listesinden)
            where student.Age > 18          // 2. Filtrele (18 yaşından büyükler)
            orderby student.Name ascending  // 3. Sırala (Ad'a göre A-Z)
            select student;                 // 4. Seç

        // Sonucu List<Student> olarak alıyoruz
        List<Student> filteredByQuery = resultQuerySyntax.ToList();


        // 4. Sonuçları Yazdırma
        Console.WriteLine("--- Sorgu Sözdizimi Sonuçları ---");
        foreach (var student in filteredByQuery)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\n======================================================\n");


        // 5. Yaklaşım: LINQ Metot Sözdizimi (Method Syntax - Lambda İfadeli)
        Console.WriteLine("###  LINQ Metot Sözdizimi (Method Syntax)");
        Console.WriteLine("### (Zincirleme Metotlar ve Lambda İfadeleri)\n");

        // Zincirleme metot çağrıları ile aynı işlemi yapıyoruz:
        List<Student> filteredByMethod = students
            .Where(s => s.Age > 18)     // Filtreleme için Lambda (s => s.Age > 18)
            .OrderBy(s => s.Name)       // Sıralama için Lambda (s => s.Name)
            .ToList();                  // Sonucu List<Student> olarak döndür

        Console.WriteLine("--- Metot Sözdizimi Sonuçları ---");
        filteredByMethod.ForEach(s => Console.WriteLine(s));
    }
}
