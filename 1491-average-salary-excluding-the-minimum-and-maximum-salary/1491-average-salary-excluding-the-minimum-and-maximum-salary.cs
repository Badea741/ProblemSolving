public class Solution {
    public double Average(int[] salary) {
     return salary.OrderBy(s => s)
                     .Skip(1)
                     .Take(salary.Length-2)
                     .Average();
    }
}