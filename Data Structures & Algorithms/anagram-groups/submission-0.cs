public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> groups = new();

        foreach (string str in strs)
        {
            string sorted = new string(str.OrderBy(c => c).ToArray());

            if (!groups.ContainsKey(sorted))
            {
                groups[sorted] = new List<string>();
            }

            groups[sorted].Add(str);
        }

        return groups.Values.ToList();
    }
}