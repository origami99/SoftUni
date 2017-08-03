import java.util.Scanner;

public class p14_CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String text = console.nextLine().toLowerCase();
        String word = console.nextLine().toLowerCase();

        int counter = 0;
        int index = text.indexOf(word);

        while(index != -1){
            counter++;
            index = text.indexOf(word, index + 1);
        }

        System.out.println(counter);
    }
}
