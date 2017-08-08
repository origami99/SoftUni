import java.util.Scanner;

public class p17_ChangeToUppercase {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String text = console.nextLine();

        while (text.contains("<upcase>")){
            int startIndex = text.indexOf("<upcase>");
            int endIndex = text.indexOf("</upcase>") + 9;

            String tagStatement = text.substring(startIndex, endIndex);
            String upperText = text.substring(startIndex + 8, endIndex - 9).toUpperCase();

            text = text.replace(tagStatement, upperText);
        }

        System.out.println(text);
    }
}
