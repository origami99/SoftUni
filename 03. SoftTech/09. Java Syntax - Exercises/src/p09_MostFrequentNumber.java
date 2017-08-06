import java.util.Arrays;
import java.util.Scanner;

public class p09_MostFrequentNumber {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        Integer[] nums = Arrays.stream(console.nextLine().split(" "))
                .map(Integer::parseInt)
                .toArray(Integer[]::new);

        
    }
}
