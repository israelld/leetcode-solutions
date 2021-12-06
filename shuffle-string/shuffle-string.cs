public class Solution {
    public string RestoreString(string s, int[] indices) {
        
        int minimum = 0;
        char charMinimum;
        char[] newS = s.ToCharArray();

        for (int i = 0; i < indices.Length; i++)
        {
            for (int j = i; j < indices.Length; j++)
            {
                if (indices[i] > indices[j])
                {   
                    minimum = indices[j];
                    indices[j] = indices[i];
                    indices[i] = minimum;

                    charMinimum = newS[j];
                    newS[j] = newS[i];
                    newS[i] = charMinimum;
                }
            }  
        }
        string newStoString = new string(newS);
        return newStoString;
    }
}