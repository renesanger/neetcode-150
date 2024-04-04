public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];
        Array.Fill(res, 0);
        var stack = new Stack<int>();

        for(int i = 0; i < temperatures.Length; i++){
            var t = temperatures[i];
            while (stack.Any() && temperatures[stack.Peek()] < t)
            {
                var prev = stack.Pop();
                res[prev] = i - prev;
            }
            stack.Push(i);
        }
        return res;
    }
}
