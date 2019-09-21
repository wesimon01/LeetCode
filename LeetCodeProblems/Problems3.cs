using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    public static class Problems3
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode pre = dummy;

            while (l1 != null && l2 != null) {
                if (l1.val <= l2.val) {
                    pre.next = l1;
                    l1 = l1.next;
                } 
                else {
                    pre.next = l2;
                    l2 = l2.next;
                }
                pre = pre.next;
            }
            
            if (l1 != null) pre.next = l1;
            if (l2 != null) pre.next = l2;
        
            return dummy.next;
        }
        
        public static ListNode DeleteDuplicates(ListNode head)
        {          
            if (head == null)
                return head;
            
            ListNode prevNode = head;
            ListNode currentNode = head.next;

            while (currentNode != null)
            {               
                if (prevNode.val == currentNode.val) {
                    prevNode.next = currentNode.next;
                    currentNode = currentNode.next;
                }
                else {
                    prevNode = prevNode.next;
                    currentNode = currentNode.next;
                }
            }
            return head;
        }
        public static int[] PlusOne(int[] digits)
        { 
            for (int i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                    if (digits[i - 1] != 9)
                    {
                        digits[i - 1]++;
                        break;
                    }
                    else
                        continue;
                }
                else
                {
                    digits[i]++;
                    break;
                }
            }
            return digits;
        }
    }

    public class ListNode 
    {
          public int val;
          public ListNode next;
          public ListNode(int x) { val = x; }
    }
}
