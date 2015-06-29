using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLesson1.UnionFindNs;

namespace AlgorithmsLesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = getIntFromConsole("How many points does your set have?");
     
      if (n > 0)
      {
          int p1 = getIntFromConsole("Enter point p");
          int p2 = getIntFromConsole("Enter point q");
          //UnionFind uf = new UnionFind(n);
          QuickFind findAlgo = new QuickFind(n);
          while (p1 >= 0 && p2 >= 0)
          {

              if (!findAlgo.connected(p1, p2))
              {
                  //    Up to here
                  Console.WriteLine("Connecting {0} to {1}", p1, p2);

                  findAlgo.union(p1, p2);
              }
              else
              {
                  Console.WriteLine("{0} and {1} already connected", p1, p2);
              }
              p1 = getIntFromConsole("Enter point p");
              p2 = getIntFromConsole("Enter point q");
          }
         
          

      }
      else
            {
                //user gave an illegal input. Handle it here.
                Console.WriteLine("We can only have a whole number of points - fail!");
            }
            Console.WriteLine("...");
 
        }

       static int getIntFromConsole(String prompt)
        {
            int n = 0;
            Console.WriteLine(prompt);
            if (int.TryParse(Console.ReadLine(), out n))
            {

            }
            else
            {
                n = -1;
            }
            return n;
        }

    }
}
