public class Solution {
    private static uint[] Memoized =  new uint[38];
    public int Tribonacci(int n) {
        if (n < 0) return 0;
        if (Memoized[n] != 0) return (int)Memoized[n]; 
        if (n == 0) return 0; 
        if (n == 1) {
            Memoized[1] = 1;    
            return 1;
        }
        if (n == 2) {
            Memoized[2] = 1;    
            return 1;
        }
        int a = Tribonacci(n - 1) + Tribonacci(n - 2) + Tribonacci(n - 3);
        Memoized[n] = (uint)a;
        return a;
    }
}