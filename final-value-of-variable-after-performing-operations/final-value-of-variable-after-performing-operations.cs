public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
        for(int i = 0; i < operations.Length; i++){
            if((operations[i] == "++X") | (operations[i] == "++x")){
                ++x;
            }else if((operations[i] == "X++") | (operations[i] == "x++")){
                x++;
            }else if((operations[i] == "--X") | (operations[i] == "--x")){
                --x;
            }else if((operations[i] == "X--") | (operations[i] == "x--")){
                x--;
            }
            
        }
        return x;
    }
}