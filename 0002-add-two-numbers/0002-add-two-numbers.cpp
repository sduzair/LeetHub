/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     unsigned long int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(unsigned long int x) : val(x), next(nullptr) {}
 *     ListNode(unsigned long int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        ListNode *sumLL;
        ListNode **temp = &sumLL;
        int sum, carry = 0;
        while (l1 && l2) {
            sum = (l1 -> val + l2 -> val + carry) % 10;
            ListNode *node = new ListNode(sum);
            *temp = node;
            // cout << (*temp) -> val;
            temp = &(node -> next);
            carry = (l1 -> val + l2 -> val + carry) / 10;
            
            l1 = l1 -> next;
            l2 = l2 -> next;
        }
        if (!l1 && !l2) {
            if (carry > 0) {
                *temp = new ListNode(carry);
            }
        }
        if (l1) {
            *temp = l1;
            int sum = (l1 -> val + carry);
            l1 -> val = sum % 10;
            // cout << (*temp) -> val;
            int newCarry = sum / 10;
            // cout << newCarry;
            // cout << endl;
            while (newCarry > 0) {
                if (!(l1 -> next)) {
                    l1 -> next = new ListNode();
                }
                l1 = l1 -> next;
                sum = l1 -> val + newCarry;
                l1 -> val = sum % 10;
                // cout << l1 -> val;
                newCarry = sum / 10;
            }
        }
        if (l2) {
            *temp = l2;
            int sum = (l2 -> val + carry);
            l2 -> val = sum % 10;
            // cout << (*temp) -> val;
            int newCarry = sum / 10;
            // cout << newCarry;
            // cout << endl;
            while (newCarry > 0) {
                if (!(l2 -> next)) {
                    l2 -> next = new ListNode();
                }
                l2 = l2 -> next;
                sum = l2 -> val + newCarry;
                l2 -> val = sum % 10;
                // cout << l2 -> val;
                newCarry = sum / 10;
            }
        }
        return sumLL;
    }
    // ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
    //     // 1 reverse the linked lists
    //     // 2 convert them to numbers
    //     // 3 add the numbers
    //     // 4 convert the sum unsigned long into a ll and reverse the ll
    //     l1 = reverseLL(l1);
    //     l2 = reverseLL(l2);
    //     unsigned long int num1 = getNumFromLL(l1);
    //     unsigned long int num2 = getNumFromLL(l2);
    //     cout << num1;
    //     cout << endl;
    //     cout << num2;
    //     cout << endl;
    //     unsigned long int sum = num1 + num2;
    //     cout << sum;
    //     // cout << getNumFromLL(converNumToLL(sum));
    //     return converNumToLL(sum);
    // }
    ListNode* converNumToLL(unsigned long int num) {
        ListNode *headNode;
        unsigned long int d;
        ListNode **prevNode = &headNode;
        do {
            d = num % 10;
            num /= 10;
            ListNode *lNode = new ListNode(d);
            *prevNode = lNode;
            prevNode = &(lNode -> next);
        } while (num != 0);
        return headNode;
    }
    unsigned long int getNumFromLL (ListNode *l1) {
        unsigned long int num1 = 0;
        while(l1) {
            num1 = num1 + l1 -> val;
            num1 = num1 * 10;
            l1 = l1 -> next;
        }
        num1 = num1 / 10;
        return num1;
    }
    ListNode* reverseLL (ListNode* ll) {
        ListNode *temp, *prevLL;
        prevLL = NULL;
        while (ll) {
            temp = ll -> next;
            ll -> next = prevLL;
            prevLL = ll;
            ll = temp;
        }
        return prevLL;
    }
};