public class Solution {
    public int RemoveDuplicates(int[] arr) 
    {
        int len = 0;
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            len++;
            //int j = i + 1;
            j++;
            while (j < arr.Length && arr[i] == arr[j])
            {
                j++;
            }
            if(!(j < arr.Length))
            {
                break;
            }
            arr[i + 1] = arr[j];
        }
        return len;
    }
}