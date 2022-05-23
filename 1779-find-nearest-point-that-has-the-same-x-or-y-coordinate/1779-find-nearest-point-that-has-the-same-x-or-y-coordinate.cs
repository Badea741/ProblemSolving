public class Solution {
    public static int ManhattanDistance(int x1 , int x2,int y1,int y2){
        return Math.Abs(x1-x2)+Math.Abs(y1-y2);
    }
    public int NearestValidPoint(int x, int y, int[][] points) {
        bool isValid = false;
        int min = int.MaxValue;
        int index = 0;
        for (int i = 0; i < points.Length; ++i)
        {
            if (points[i][0] == x || points[i][1] == y)
            {
                int distance = ManhattanDistance(x, points[i][0], y, points[i][1]);
                if (min > distance)
                {
                    min = distance;
                    index = i;
                }

                isValid = true;
            }
        }
        if (!isValid) return -1;
        return index;
    }
}