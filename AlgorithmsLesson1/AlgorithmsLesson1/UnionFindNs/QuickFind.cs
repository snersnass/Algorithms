using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLesson1.UnionFindNs
{
    class QuickFind : UnionFind
    {

        public QuickFind(int numberOfElements)
        {
            setUpMatrix(numberOfElements);
          }

        public void union(int p, int q)
        {
            int pId = matrix[p];
            int qId = matrix[q];

            for (int i = 0 ; i < noElements ; i++)
            {
                if (matrix[i] == pId)
                {
                    matrix[i] = qId;
                }
            }
        }

        public Boolean connected(int p, int q)
        {
            return (matrix[p] == matrix[q]);
        }
    }
}
