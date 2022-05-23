public class Solution {
    public double MyPow(double x, int n) {
        double actualValue=x;
        if(n==0)return 1;
        if(x==1)return 1;
        if(x==-1 && n%2==0)return 1;
        if(x==-1&& n %2==1)return -1;
        if(x<=9&&n<-999)return 0;
        if(n<0)
           for(int i =0 ; i<Math.Abs(n-1);++i){
            x/=actualValue;
        } 
        for(int i =0 ; i<n-1;++i){
            x*=actualValue;
        }
        return x;
    }
}