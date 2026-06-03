public class Solution {
    public int CountDigits(int num) {
        int x = num , count = 0 ;

        while(num > 0){
           int i = num%10;
           if(x%i == 0){
              count ++;
           }
            num = num / 10 ;
        }

        return count;
    }
}