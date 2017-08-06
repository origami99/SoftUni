import java.util.Arrays;
import java.util.Scanner;

public class p04_VowelOrDigit {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        Character input = console.next().charAt(0);

        Character[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        if (Arrays.asList(vowels).contains(input)){
            System.out.println("vowel");
        }
    }
}
