import java.util.Scanner;

public class p01_VariableInHexFormat {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String hex = console.nextLine();
        int decimalNum = Integer.parseInt(hex, 16);
        System.out.println(decimalNum);
    }
}
