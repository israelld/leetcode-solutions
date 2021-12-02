public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] result = new bool[candies.Length];
        int greatest = candies[0];
        for(int i = 1; i < candies.Length; i++){
            if(greatest < candies[i]){
                greatest = candies[i];
            }
        }
        for(int i = 0; i < candies.Length; i++){
            if(candies[i] + extraCandies >=  greatest){
                result[i] = true;
            }else{
                result[i] = false;
            }
        }
        return result;
    }
}