public class Solution {
    public int DiagonalSum(int[][] mat) {
        int sum=0;
        for(int i =0;i<mat.Length;i++){
            for(int j =0;j<mat.Length;j++){
                if(i==j){
                    sum+=mat[i][j];
                }
                if((i+j)==(mat.Length-1))sum+=mat[i][j];
                
                if(i==j&&i==(mat.Length/2)&&mat.Length%2!=0)sum-=mat[i][j];
            }
        }
        
        return sum;
    }
}