﻿namespace MergeTwoSortedLists;

public class Solution
{
    public ListNode MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var merged = new ListNode();
        var current = merged;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            
            current = current.next;
        }
        
        current.next = list1 ?? list2;

        return merged.next;
    }
}