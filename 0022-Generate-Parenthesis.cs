public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        StringBuilder s = new StringBuilder();

        void backtrack(int openN, int closeN) {
            if(s.Length == n*2){
                result.Add(s.ToString());
                return;
            }

            if(openN < n){
                s.Append('(');
                backtrack(openN+1,closeN);
                s.Remove(s.Length-1,1);
            }

            if(closeN < openN){
                s.Append(')');
                backtrack(openN, closeN+1);
                s.Remove(s.Length-1,1);
            }            
        }

        backtrack(0,0);
        return result;
    }
}
