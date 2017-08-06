import java.util.Scanner;

public class p02_BooleanVariable {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String str = console.nextLine();

        System.out.println(str.equals("True") ? "Yes" : "No");
    }
}
