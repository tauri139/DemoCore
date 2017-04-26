using DemoConsole.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new ActorDbContext())
            {
                db.Actors.AddRange(new Actor { Name = "Bruce Lee", Age = 75, AcademyWinner = false },
                    new Actor { Name = "Madonna", Age = 58, AcademyWinner = true });

                var count = db.SaveChanges();
                Console.WriteLine($"{count} records added");

                foreach (var Actor in db.Actors)
                {
                    Console.WriteLine($"Name - {Actor.Name},\t\t" + $"Age: {Actor.Age},\t\t" + $"Academy Winner: {Actor.AcademyWinner}");
                }
                Console.ReadLine();
            }
        }
    }
}
