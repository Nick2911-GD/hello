using System;
namespace Lab_7
{
   public class Soccer : ISoccer
    {
        
        public Soccer(int totalgoal)
        {
            totalgoals = totalgoal ;
        }
       

        public static void Main(string[] args)
        {
            Soccer sc = new Soccer(3);
            Console.WriteLine(sc.totalgoals);
        }
    }
}
