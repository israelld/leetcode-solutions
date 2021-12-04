public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {        
        
        int minNum;
        int count = 0;      
        
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] == target){
                count++;
            }
        }
        for (int i = 0; i < nums.Length; i++){
            for (int j = i; j < nums.Length; j++){
                if (nums[j] < nums[i]){
                    minNum = nums[j];
                    nums[j] = nums[i];
                    nums[i] = minNum;
                }
            }
        }
        int[] targetInNums = new int[count];
        count = 0;

        for (int i = 0; i < nums.Length; i++){
            if (nums[i] == target){
                targetInNums[count] = i;
                count++;
            }
        }
        return targetInNums;
    }
}