import java.util.Collections;
import java.util.Scanner;

public class p14_FitStringIn20Chars {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String str = console.nextLine();

        if (str.length() <= 20) {
            String stars = String.join("", Collections.nCopies(20 - str.length(), "*"));
            System.out.println(str + stars);
        } else {
            System.out.println(str.substring(0, 20));
        }
    }
}
