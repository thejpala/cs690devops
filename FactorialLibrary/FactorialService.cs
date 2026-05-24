namespace FactorialLibrary;

public class FactorialService{
    public static int Factorial(int n) {
        if (n < 0){
            throw new ArgumentOutOfRangeException(nameof(n), "Factorial is undefined for negative numbers.");
        }else if(n < 2){
             return 1;
        }
        return n * Factorial(n-1);

  }
}
