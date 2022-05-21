public class Solution {
    public double Average(int[] salary) {
     double avg = 1;
        double sum = 0;
        int max = salary.Max();
        int min = salary.Min();
        double n = salary.Length;
        for (int i = 0; i < n; i++)
        {
            if (salary[i] == max || salary[i] == min) continue;
            sum += salary[i];
        }
        avg = sum / (n - 2);
        return avg;
    }
}