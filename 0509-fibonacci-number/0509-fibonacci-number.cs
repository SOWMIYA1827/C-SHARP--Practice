public class Solution {
    public int Fib(int n) {
        int f1 = 0 , f2 = 1 ;
        
        int sum = 0 ;

        if(n==0) return 0 ;
        if(n==1) return 1;
        else{
            for(int i=2 ; i<=n ; i++){
                sum = f1 + f2 ;
                f1 = f2 ;
                f2 = sum ;
            }
        }

        return sum ;
    }
}