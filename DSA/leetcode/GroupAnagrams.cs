namespace DSA.leetcode;

// https://leetcode.com/problems/group-anagrams/

public class GroupAnagrams
{
    public IList<IList<string>> Solution(string[] strs) {
            Dictionary<string,List<string>> group = new();
            foreach(string str in strs)
            {
                char[] arr = new char[26];
                foreach(char c in str)
                {
                    arr[c - 'a']++;
                }
            
                string key = new String(arr);
                if(group.TryGetValue(key, out List<string> value))
                {
                    value.Add(str);
                    group[key] = value;
                }
                else
                {
                    group.Add(key, new List<string>(){str});
                }
            }
        
            IList<IList<string>> groups = new List<IList<string>>(){};
            foreach(var value in group.Values)
            {
                groups.Add(value.ToList());
            }
            return groups;
    }
}