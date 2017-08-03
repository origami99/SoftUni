import java.util.Collections;
import java.util.Scanner;

public class p15_TextFilter {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] bannedWords = console.nextLine().split(", ");
        String text = console.nextLine();

        for (String bannedWord : bannedWords) {
            String stars = String.join("", Collections.nCopies(bannedWord.length(), "*"));
            text = text.replace(bannedWord, stars);
        }

        System.out.println(text);
    }
}
