import java.util.Scanner;

public class p05_SymmetricNumbers {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int n = Integer.parseInt(console.nextLine());

        for (int i = 1; i <= n; i++) {
            if (isSymmetric(Integer.toString(i))){
                System.out.print(i + " ");
            }
        }
    }

    private static boolean isSymmetric(String str) {
        for (int j = 0; j < str.length() / 2; j++) {
            if (str.charAt(j) != str.charAt(str.length() - 1 - j)) {
                return false;
            }
        }

        return true;
    }
}
