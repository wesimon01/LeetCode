using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using LeetCodeProblems;

namespace LeetCodeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //RemoveDuplicates
            //var input = new int[] { 0,0,1,1,1,2,2,3,3,4 };
            //var result = RemoveDuplicates(input);
            
            // Single Number
            //var input = new int[] { 4,1,2,1,2,6,6,3,3,10,10 };
            //var result = SingleNumber2(input);

            //var head = new ListNode(1);
            //head.next = new ListNode(2);
            //head.next.next = new ListNode(4);
            //head.next.next.next = new ListNode(4);
            //head.next.next.next.next = new ListNode(4);

            //var result = Problems3.DeleteDuplicates(head);

            var input = new int [] { 9 };
            var result = Problems3.PlusOne(input);

            Console.WriteLine(result);
        }



     

    }
}
