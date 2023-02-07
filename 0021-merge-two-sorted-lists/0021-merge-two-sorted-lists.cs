/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode? mergedListNode = null;
        ListNode? firstNode = null;

        if (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                mergedListNode = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                mergedListNode = new ListNode(list2.val);
                list2 = list2.next;
            }
            firstNode = mergedListNode;
        }

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                mergedListNode!.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                mergedListNode!.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            mergedListNode = mergedListNode.next;
        };

        // now either list1 or list2 have values not both
        if (list1 != null && mergedListNode == null)
        {
            mergedListNode = new ListNode(list1.val);
            firstNode = mergedListNode;
            list1 = list1.next;
        }
        while (list1 != null)
        {
            mergedListNode!.next = new ListNode(list1.val);
            list1 = list1.next;
            mergedListNode = mergedListNode.next;
        }

        if (list2 != null && mergedListNode == null)
        {
            mergedListNode = new ListNode(list2.val);
            firstNode = mergedListNode;
            list2 = list2.next;
        }
        while (list2 != null)
        {
            mergedListNode!.next = new ListNode(list2.val);
            list2 = list2.next;
            mergedListNode = mergedListNode.next;
        }

        return firstNode == null ? null : firstNode;
    }
}