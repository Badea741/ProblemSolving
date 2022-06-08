

public class Solution
{
    public int Reverse(int x)
    {
        int newInt = 0;

        while (x != 0)
        {
            int pop = (x % 10);
            x = x / 10;
            int compareResult=newInt;
           
         newInt = newInt * 10 + pop;
            if((((newInt)-pop)/10)!=compareResult)return 0;
            
        }

        return newInt;

    }

}
