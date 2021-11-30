public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int richestCustomer = 0;
        int wealth = 0;
        for(int i = 0; i < accounts.Length; i++){
            for(int j = 0; j < accounts[i].Length; j++){
                wealth +=  accounts[i][j];
            }
            if(richestCustomer < wealth){
                richestCustomer = wealth;
            }
            wealth = 0;
        }
        return richestCustomer;
    }
}