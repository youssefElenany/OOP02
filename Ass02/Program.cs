using System;

namespace Ass02
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            //Person[] persons = new Person[3];
            //persons[0] = new Person { Name = "John", Age = 25 };
            //persons[1] = new Person { Name = "Mary", Age = 30 };
            //persons[2] = new Person { Name = "Alex", Age = 20 };

            //foreach (var person in persons)
            //{
            //    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            //} 
            #endregion

            #region Q2
            //Console.Write("Enter X1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter X2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter Y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point p1 = new Point { X = x1, Y = y1 };
            //Point p2 = new Point { X = x2, Y = y2 };

            //double distance = Point.Distance(p1, p2);
            //Console.WriteLine($"Distance between points: {distance}");

            #endregion

            #region Q3
            //    Member[] persons = new Member[3];
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write($"Enter name for Member {i + 1}: ");
            //        persons[i].Name = Console.ReadLine();
            //        Console.Write($"Enter age for Member {i + 1}: ");
            //        persons[i].Age = Convert.ToInt32(Console.ReadLine());
            //    }

            //    Member oldest = persons[0];
            //    foreach (var Member in persons)
            //    {
            //        if (Member.Age > oldest.Age)
            //            oldest = Member;
            //    }

            //    Console.WriteLine($"Oldest Member: {oldest.Name}, Age: {oldest.Age}");
            //}

            #region Q4
            Rectangle rect = new Rectangle();
            rect.Width = 5.5;
            rect.Height = 4.2;
            rect.DisplayInfo(); 
            #endregion

        }

        #endregion


    }

}






          

       






    


