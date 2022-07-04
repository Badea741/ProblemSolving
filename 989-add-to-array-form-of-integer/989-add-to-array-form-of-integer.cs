class Solution {
    public List<int> AddToArrayForm(int[] A, int K) {
        int N = A.Length;
        int cur = K;
        List<int> ans = new ();

        int i = N;
        while (--i >= 0 || cur > 0) {
            if (i >= 0)
                cur += A[i];
            ans.Add(cur % 10);
            cur /= 10;
        }

        ans.Reverse();
        return ans;
    }
}