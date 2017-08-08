import java.util.Collections;
import java.util.Scanner;

public class p15_CensorEmailAddress {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String email = console.nextLine();
        String text = console.nextLine();

        String username = email.split("@")[0];
        String domain = email.split("@")[1];

        String stars = String.join("", Collections.nCopies(username.length(), "*"));
        text = text.replaceAll(email, stars + "@" + domain);

        System.out.println(text);
    }
}
