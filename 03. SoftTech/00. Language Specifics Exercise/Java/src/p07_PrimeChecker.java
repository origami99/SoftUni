import java.util.Scanner;

public class p07_PrimeChecker {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        long num = Long.parseLong(console.nextLine());

        System.out.println(isPrime(num) ? "True" : "False");
    }

    private static boolean isPrime(long num) {
        if(num >=0 && num <= 2){
            switch ((int) num) {
                case 0:
                    return false;
                case 1:
                    return false;
                case 2:
                    return true;
            }
        }

        for(int i = 2; i <= Math.sqrt(num); i++){
            if(num % i == 0){
                return false;
            }
        }

        return true;
    }
}
