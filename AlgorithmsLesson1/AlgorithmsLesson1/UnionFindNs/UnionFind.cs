using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLesson1.UnionFindNs
{
    class UnionFind
    {
        protected int noElements;
        protected int[] matrix;

        public UnionFind()
        {
            setUpMatrix(10);
        }
        
        public UnionFind(int numberOfElements)
        {
            setUpMatrix(numberOfElements);
          }

        protected void setUpMatrix(int numberOfElements)
        {
        noElements = numberOfElements;
            matrix = new int[10];
            for (int i = 0 ; i < 10 ; i ++)
            {
                matrix[i] = i;
            }
  
        }

        public void union(int p, int q)
        {

        }

        public Boolean connected(int p, int q)
        {
            return false;
        }

        public int find(int p)
        {
            return -1;
        }

        public int count()
        {
            return -1;
        }
    }
}
