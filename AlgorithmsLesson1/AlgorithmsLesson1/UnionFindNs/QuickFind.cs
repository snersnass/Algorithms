using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLesson1.UnionFindNs
{
    class QuickFind : UnionFind
    {

        public QuickFind(long numberOfElements)
        {
            Console.WriteLine("QuickFind");
            setUpMatrix(numberOfElements);
          }

        public void union(long p, long q)
        {
            long pId = matrix[p];
            long qId = matrix[q];

            for (long i = 0 ; i < noElements ; i++)
            {
                if (matrix[i] == pId)
                {
                    matrix[i] = qId;
                }
            }
        }

        new public Boolean connected(long p, long q)
        {
            return (matrix[p] == matrix[q]);
        }
    }
}
