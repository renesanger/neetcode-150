public class Solution {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length-1;
        int area = 0, res = 0;

        while(left < right){
            area = (right - left) * Math.Min(height[left], height[right]);
            res = Math.Max(area, res);

            if(height[left] > height[right]){
                right--;
            }
            else if(height[left] < height[right]){
                left++;
            }
            else{
                left++;
            }
        }

        return res;
    }
}
