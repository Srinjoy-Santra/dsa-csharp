using System;
using System.Collections.Generic;

// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.sortedset-1?view=net-6.0

namespace dsa.practice
{
    public class Set
    {
        public void Run()
        {
            var mySet = new SortedSet<int>(new DescendingOrderExtension());
            // add something
            // note that we add 2 before we add 1
            mySet.Add(2);
            mySet.Add(1);
            // enumerate through the set
            foreach(var item in mySet)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class DescendingOrderExtension : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            return b.CompareTo(a);
        }
    }
}