using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace leetcode
{
    internal class RichestCustomerWealth
    {
        public int Richest(int[][] accounts)
        {
            return Enumerable.Range(0, accounts.Length)
                .Select(x => accounts[x].Sum())
                .Max();
        }
    }
}
