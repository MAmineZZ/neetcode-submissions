public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> unicNum = new HashSet<int>();
        foreach(int num in nums)
        {
            if(!unicNum.Add(num))
            {
                return true;
            }
        }
        
        return false;
                
    }
}