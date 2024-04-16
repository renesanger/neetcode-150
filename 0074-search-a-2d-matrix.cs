public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int ROWS = matrix.Length;
        int COLS = matrix[0].Length;

        int top = 0;
        int bot = ROWS - 1;
        int row = 0;

        while(top <= bot){
            row = (top + bot) / 2;
            if(target < matrix[row][0]){
                bot = row - 1;
            }
            else if(target > matrix[row][COLS - 1]){
                top = row + 1;
            }
            else{
                break;
            }
        }

        if(top > bot)
            return false;

        row = (top + bot) / 2;
        int l = 0; int r = COLS - 1;
        while(l <= r){
            int mid = (l+r)/2;
            if(target > matrix[row][mid]){
                l = mid + 1;
            }
            else if(target < matrix[row][mid]){
                r = mid - 1;
            }
            else{
                return true;
            }
        }

        return false;
    }
}
