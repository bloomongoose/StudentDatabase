using System;
using System.Collections.Generic;

namespace StudentDatabaseLab
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string homeTown { get; set; }
        public string favoriteFood { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about?");
            Console.WriteLine("Enter a number 1 through 14:");
            int input = int.Parse(Console.ReadLine());
            

            List<Student> dataBase = new List<Student>();
            Student a = new Student();
            a.ID = 1;
            a.Name = "Justin";
            a.homeTown = "Wyoming, MI";
            a.favoriteFood = "Baja Blast";
            dataBase.Add(a);
            Student b = new Student();
            b.ID = 2;
            b.Name = "Matt";
            b.homeTown = "Flint, MI";
            b.favoriteFood = "Hot Wings";
            dataBase.Add(b);
            Student c = new Student();
            c.ID = 3;
            c.Name = "Logan";
            c.homeTown = "Plymouth, MI";
            c.favoriteFood = "Funyuns";
            dataBase.Add(c);
            Student d = new Student();
            d.ID = 4;
            d.Name = "Raston";
            d.homeTown = "Zeeland, MI";
            d.favoriteFood = "Vanilla Instant Pudding";
            dataBase.Add(d);
            Student e = new Student();
            e.ID = 5;
            e.Name = "Yousif";
            e.homeTown = "Oak Park, MI";
            e.favoriteFood = "Deep Dish Pizza";
            dataBase.Add(e);
            Student f = new Student();
            f.ID = 6;
            f.Name = "Yash";
            f.homeTown = "Detroit, MI";
            f.favoriteFood = "Hot Cheeto Puffs";
            dataBase.Add(f);
            Student g = new Student();
            g.ID = 7;
            g.Name = "Chris";
            g.homeTown = "Novi, MI";
            g.favoriteFood = "Tacos";
            dataBase.Add(g);
            //foreach (var obj in dataBase)
            //{
            //    Console.WriteLine(obj.ID);
            //    Console.WriteLine(obj.Name);
            //    Console.WriteLine(obj.homeTown);
            //    Console.WriteLine(obj.favoriteFood); 
            //}
            foreach (var obj in dataBase)
            {
                if (input == obj.ID)
                {
                    Console.WriteLine($"Student {obj.ID} is {obj.Name}. What would you like to know about {obj.Name}?");
                    Console.WriteLine("Enter hometown or favorite food");
                    string answer = Console.ReadLine();
                    if( answer == "hometown")
                    {
                        Console.WriteLine($"{obj.Name} is from {obj.homeTown}.");
                    }
                    else if (answer == "favorite food")
                    {
                        Console.WriteLine($"{obj.Name}'s favorite food is {obj.favoriteFood}.");
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist. Please try again");
                    }
                }
                //else
                //{
                //    Console.WriteLine("That student does not exist. Please try again.");
                //}
            }
            

            

        }
        
            
                
        
    }
}
