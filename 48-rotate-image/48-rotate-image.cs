public class Solution {
    public static void Swap (ref int item1,ref int item2){
        int temp=item1;
        item1=item2;
        item2=temp;
    }
    
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        for (int i = 0; i < n; i++)
            for (int j = i+1; j < n; j++)
            {
                Swap(ref matrix[i][j],ref matrix[j][i]);
                
            }
        for(int i =0 ;i<n;i++){
            Array.Reverse(matrix[i]);
        }

    }
}