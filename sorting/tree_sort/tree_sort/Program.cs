﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree_sort {
    class Program {
        static void Main(string[] args) {

            int[] array = new int[] { 2, 14, 11, 16, 82, 4, 34, 51, 1, 4 };
            TreeSort sorter = new TreeSort();
            sorter.Sort(array);
            Console.WriteLine(string.Join(", ", array));
        }
    }
}