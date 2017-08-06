import java.util.Scanner;

public class p03_ReverseCharacters {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String result = "";
        for (int i = 0; i < 3; i++) {
            String letter = console.nextLine();

            result = letter + result;
        }

        System.out.println(result);
    }
}
