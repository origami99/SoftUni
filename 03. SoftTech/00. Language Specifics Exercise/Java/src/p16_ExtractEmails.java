import java.util.Scanner;
import java.util.regex.*;

public class p16_ExtractEmails {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String text = console.nextLine();

        Pattern pattern = Pattern.compile("(?<=^|\\s)[a-zA-Z0-9]+[\\.\\-_]?[a-zA-Z0-9]+@[a-zA-Z][a-zA-Z\\.\\-]+\\.[a-zA-Z]+");
        Matcher matcher = pattern.matcher(text);

        while (matcher.find()) {
            System.out.println(matcher.group(0));
        }
    }
}
