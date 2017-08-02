import java.util.Scanner;

public class p02_VariableInHexadecimalFormat {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String hex = console.nextLine().substring(2);
        int decimalNum = Integer.parseInt(hex, 16);
        System.out.println(decimalNum);
    }
}