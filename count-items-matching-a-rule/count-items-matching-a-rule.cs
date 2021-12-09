public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int counter = 0;
        string[] ruleskeys = { "type", "color", "name" };
        int indexRulerKey = -1;

        for (int i = 0; i < ruleskeys.Length; i++)
        {
            if (ruleskeys[i] == ruleKey)
            {
                indexRulerKey = i;
            }
        }
        
        for(int i = 0; i < items.Count; i++)
        {
            if(items[i][indexRulerKey] == ruleValue)
            {
                counter++;
            }
        }
        return counter;
    }
}