class Solution {
public:
    bool isPalindrome(int x) {
        if (x < 0) return false;
        long unsigned int temp = x, d, palindromeOfX = 0;
        
        while (temp) {
            cout << temp;
            cout << endl;
            d = temp % 10;
            temp /= 10;
            palindromeOfX = palindromeOfX * 10 + d;
        }
        cout << palindromeOfX;
        return x == palindromeOfX;
    }
};