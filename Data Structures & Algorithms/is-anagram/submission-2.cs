public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        string sortedS;
        string sortedT;

        sortedS= new string(s.OrderBy(c=>c).ToArray());
        sortedT= new string(t.OrderBy(c=>c).ToArray());

            return sortedS.SequenceEqual(sortedT);
    }
}