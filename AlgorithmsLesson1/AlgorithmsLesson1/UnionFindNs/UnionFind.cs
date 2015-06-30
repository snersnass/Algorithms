using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLesson1.UnionFindNs
{
    class UnionFind
    {
        protected long noElements;
        protected long[] matrix;

        public UnionFind()
        {
            setUpMatrix(10);
        }

        public UnionFind(long numberOfElements)
        {
            setUpMatrix(numberOfElements);
          }

        protected void setUpMatrix(long numberOfElements)
        {
        noElements = numberOfElements;
        matrix = new long[numberOfElements];
        for (long i = 0; i < numberOfElements; i++)
            {
                matrix[i] = i;
            }
  
        }

        public void union(long p, long q)
        {

        }

        public Boolean connected(long p, long q)
        {
            return false;
        }

        public int find(long p)
        {
            return -1;
        }

        public long count()
        {
            return -1;
        }
    }
}
