using System;
namespace leetcode
{
    internal class AddTwoNumbers
    {
        public class Solution
        {
            public class ListNode
            {
                public int val;
                public ListNode next;
                public ListNode(int val = 0, ListNode next = null)
                {
                    this.val = val;
                    this.next = next;
                }

                public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
                {
                    ListNode Calculation(ListNode l1, ListNode l2, ListNode result, bool wasOver)
                    {
                        if (l1 == null && l2 == null && wasOver == false)
                        {
                            return null;
                        }

                        int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + (wasOver ? 1 : 0);
                        result.val = sum % 10;
                        wasOver = sum >= 10;

                        if (l1?.next != null || l2?.next != null)
                        {
                            result.next = Calculation(l1?.next, l2?.next, new ListNode(), wasOver);
                        }
                        else
                        {
                            if (wasOver)
                            {
                                result.next = new ListNode(1);
                            }
                        }

                        return result;
                    }

                    return Calculation(l1, l2, new ListNode(), false);
                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Solution.ListNode l1 = new Solution.ListNode(2);
                l1.next = new Solution.ListNode(4);
                l1.next.next = new Solution.ListNode(3);

                Solution.ListNode l2 = new Solution.ListNode(5);
                l2.next = new Solution.ListNode(6);
                l2.next.next = new Solution.ListNode(4);

                Solution.ListNode result = new Solution.ListNode().AddTwoNumbers(l1, l2);

                while (result != null)
                {
                    Console.Write(result.val + " ");
                    result = result.next;
                }
            }
        }
    }
}