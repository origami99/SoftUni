import java.util.Scanner;

public class p05_NumbersInReversedOrder {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String num = console.nextLine();
        String reversed = getReversed(num);
        System.out.println(reversed);
    }

    private static String getReversed(String num) {
        return new StringBuilder(num).reverse().toString();
    }
}
