public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0; i<nums.Length; i++){
            for(int c=i+1; c<nums.Length; c++){
                if(nums[c] == target -  nums[i]){
                    int[] indTwoAdd = {i,c};
                    return indTwoAdd;
                }
            }            
        }
        return null;
    }
}