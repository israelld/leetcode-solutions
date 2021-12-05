public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] smallerThanIt = new int[nums.Length];
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < nums.Length; j++){
                if(nums[j] != nums[i] & nums[j] < nums[i]){
                    count++;
                }                
            }
        smallerThanIt[i] = count;    
        count = 0;    
        }
        return smallerThanIt;
    }
}