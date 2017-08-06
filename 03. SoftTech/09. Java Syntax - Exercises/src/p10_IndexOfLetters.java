import java.util.Scanner;

public class p10_IndexOfLetters {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        char[] word = console.nextLine().toCharArray();

        for (char letter : word) {
            System.out.println(letter + " -> " + (letter - 'a'));
        }
    }
}
