public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        var decompressedList = new List<int>();

        for (int i = 0; i < nums.Length; i+=2)
        {
            for(int j = 0; j < nums[i]; j++)
            {       
                decompressedList.Add(nums[i + 1]);
            }
    
        }

        return decompressedList.ToArray();
    }
}