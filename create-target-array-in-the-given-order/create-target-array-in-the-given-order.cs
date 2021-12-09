public class Solution {
    public int[] CreateTargetArray(int[] nums, int[] index) {
        
        int[] target = new int[index.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = target.Length-1; j >= index[i]; j--)
            {
                if(j == index[i])
                {
                    target[index[i]] = nums[i];
                }
                else
                {
                    target[j] = target[j-1];
                }
            }
        }
        return target;
    }
}