import java.util.Arrays;
import java.util.Scanner;

public class p06_CompareCharArrays {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String str1 = console.nextLine().replace(" ", "");
        String str2 = console.nextLine().replace(" ", "");

        String[] words = {str1, str2};

        Arrays.sort(words);

        System.out.println(String.join("\n", words));
    }
}
