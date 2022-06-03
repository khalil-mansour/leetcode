using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    internal class KWeakestRowsInMatrix
    {
        public int[] KWeakest(int[][] mat, int k)
        {

            return Enumerable.Range(0, mat.Length)
                .Select((x,i) => new KeyValuePair<int,int>(x, mat[i].Sum()))
                .OrderBy(x => x.Value)
                .Select(x => x.Key)
                .Take(k).ToArray();
        }
    }
}
