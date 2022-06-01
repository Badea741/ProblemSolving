public class Solution {
    public string Interpret(string command) {
        StringBuilder ans=new();
        for(int i =0;i<command.Length;i++){
            if(command[i]=='G')ans.Append('G');
            else if(command[i]=='(' && command[i+1]==')')ans.Append('o');
            else if(command[i]=='('&&command[i+1]=='a')ans.Append("al");
        }
        return ans.ToString();
    }
}