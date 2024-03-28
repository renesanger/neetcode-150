public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        int left = 0;
        int right = numbers.Length - 1;
        while(left<right){
            int sum = numbers[left] + numbers[right];
             if(sum>target){
                right--;
             }
             else if(sum<target){
                left++;
             }
             else{
                 return new int[] {left + 1, right + 1};
             }
        }
        return new int[0];
    }
}
