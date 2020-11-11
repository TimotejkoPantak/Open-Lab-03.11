using System;
using System.Linq;

namespace Open_Lab_03._11
{ť
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            if (str.SequenceEqual(str.Reverse()))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
