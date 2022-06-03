using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode
{
    class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var mag = magazine.ToList();
            char[] rans = ransomNote.ToCharArray();

            foreach (var item in rans)
            {
                if (!mag.Remove(item)) {
                    return false;
                }                      
            }
            return true;
        }
    }
}
