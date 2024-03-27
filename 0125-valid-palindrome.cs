/* Best Solution - Solution 1 Sliding Window */
public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while(left<right){
            if(!char.IsLetterOrDigit(s[left])){
                left++;
            }
            else if(!char.IsLetterOrDigit(s[right])){
                right--;
            }
            else{
                if(char.ToLower(s[left])!=char.ToLower(s[right])){
                    return false;
                }
                left++;
                right--;
            }
        }
        return true;
    }
}

/* Solution 2 - Filter, Clone, Reverse */
public class Solution {
    public bool IsPalindrome(string s) {
        string str = s.ToLower();
        string clean_str = "";
        for(int i=0;i<str.Length;i++){
            if((str[i]>='a' && str[i]<='z') || (str[i]>='0' && str[i]<='9')){
                clean_str += str[i];
            }
        }
        
        char[] c = clean_str.ToCharArray();
        Array.Reverse(c);
        string result_str = new string(c);
        /* //alternative to reversing a string
        string result_str = "";
        for(int i=clean_str.Length-1; i>=0; i--){
            result_str += clean_str[i];    
        }
        */
        return result_str == clean_str;
    }
}
