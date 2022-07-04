public static class Extension{
    public static int ToInt(this char x)
    {
        return (int)Char.GetNumericValue(x);
    } 
}
public  class Solution {
    
    public  string AddBinary(string a, string b) {
        int i =a.Length-1,j=b.Length-1;
        StringBuilder result=new();
        int carry=0;
        while (i>=0||j>=0){
            int sum=carry;
            if(i>=0)sum+=a[i--] -'0';
            if(j>=0)sum+=b[j--]- '0';
            result.Append(sum%2);
            carry=sum/2; 
        }
        if(carry!=0)result.Append(carry);
        char[] resultAsCharArr=result.ToString().ToCharArray();
        Array.Reverse(resultAsCharArr);
        
        return new string(resultAsCharArr);
    }
}