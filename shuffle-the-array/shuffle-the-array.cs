public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] arr = new int[nums.Length];
        int[] arrX = new int[n];
        int[] arrY = new int[n];
        int countArrX = 0;
        int countArrY = 0;
        for(int i = 0; i < n; i++){
            arrX[i] = nums[i];
        }
        for(int i = n; i < nums.Length; i++){
            arrY[i-n] = nums[i];
        }
        for(int i = 0; i < nums.Length; i++){    
            if(i % 2 == 0){
                arr[i] = arrX[countArrX];
                countArrX++;
            }else{
                arr[i] = arrY[countArrY];
                countArrY++;
            }    
        }
        return arr;
    }
}