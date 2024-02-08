public class Solution {
    public bool IsAnagram(string s, string t) {
        int i = 0;
        List<char> list = s.ToList(); 
        int s_l = s.Length;
        int t_l = t.Length;

        if(s_l != t_l)
        {
            return false;
        }

        while(i < s_l || i < t_l)
        {
            list.Remove(t[i]);
            i++;            
        }
        return list.Count() == 0 ? true : false;
    }
}
