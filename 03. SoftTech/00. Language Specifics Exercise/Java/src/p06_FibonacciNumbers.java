import java.util.Scanner;

public class p06_FibonacciNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int n = Integer.parseInt(console.nextLine());

        System.out.println(fibonacci(n));
    }

    private static int fibonacci(int n) {
        int a = 0;
        int b = 1;
        Integer temp = null;

        for(int i = 0; i < n; i++){
            temp = a;
            a = b;
            b = temp + a;
        }

        return b;
    }
}
