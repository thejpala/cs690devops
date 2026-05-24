namespace FactorialLibrary;

public class FactorialService{
    public static int Factorial(int n) {
        if (n < 0){
            throw new InvalidOperationException("Negative numbers don't have proper factorial");
        }else if(n < 2){
             return 1;
        }
        return n * Factorial(n-1);

  }
}
