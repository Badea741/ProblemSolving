class Solution {
public:
    int squareOfSum(int n)  {
        int sum{0}, digit;
        while   (n) {
            digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
    bool isHappy(int n) {
        int fast , slow;
        fast = slow = n;
        do  {
            slow = squareOfSum(slow);
            fast = squareOfSum(fast);
            fast = squareOfSum(fast);
            if(fast == 1) return 1;
        } while (fast != slow);
        return 0;
    }
};