public class Solution {
    public int[] RunningSum(int[] nums) {
        int acumulation = 0;
        int[] runningSum = new int[nums.Length];
        for(int i = 0; i< nums.Length; i++){
            runningSum[i] = nums[i] + acumulation;
            acumulation = runningSum[i];
        }
        return runningSum;
    }
}