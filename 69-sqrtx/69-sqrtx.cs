public class Solution {
    public int MySqrt(int x) {
        int high =x; int low=0;
        while(high>=low){
            int middle=low+(high-low)/2;
            long t = (long)middle*middle;
            if(t==x)return middle;
            if(x<t){
                high=middle-1;
            }
            else low=middle+1;
        }
        return high;
    }
}