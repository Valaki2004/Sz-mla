using Számla.Models;
using Számla.Data;
using System;
namespace Program
{
    static public class Program
    {
        static void Kiir(IEnumerable<object> adatok)
        {
            foreach (var item in adatok)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {
            context db = new context();   
            var sorok = File.ReadAllLines(@"C:\Users\Diak\Desktop\cucc\szamla.txt").Skip(1);
            foreach (var sor in sorok)
                db.Class1.Add(new Class1(sor));

            db.SaveChanges();
            Kiir(db.Class1);
        }
    }
}
