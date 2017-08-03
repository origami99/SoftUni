import java.util.Scanner;
import java.util.regex.*;

public class p17_ExtractSentencesByKeyword {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String word = console.nextLine();
        String text = console.nextLine();

        String[] sentences = text.split("[?!.]");
        String pattern = "[^A-Za-z]" + word + "[^A-Za-z]";

        Pattern r = Pattern.compile(pattern);

        for (String s : sentences) {
            Matcher m = r.matcher(s);

            if (m.find()) {
                System.out.println(s);
            }
        }
    }
}
