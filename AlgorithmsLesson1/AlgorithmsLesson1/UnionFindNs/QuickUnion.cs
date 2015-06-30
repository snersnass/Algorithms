using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLesson1.UnionFindNs
{
    class QuickUnion : UnionFind
    {
        public QuickUnion(long numberOfElements)
        {
            Console.WriteLine("QuickUnion");
            setUpMatrix(numberOfElements);
        }


        public void union(long p, long q)
        {
            long pId = root(p);
            long qId = root(q);

            matrix[pId] = qId;
        }


        new public Boolean connected(long p, long q)
        {
            return (root(p) == root(q));
        }



        private long root(long i)
        {
            while (i != matrix[i])
            {
                i = matrix[i];
            }
            return i;
        }
  
    }
}
