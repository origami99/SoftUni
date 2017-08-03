import java.util.*;

public class p10_SumReversedNumbers {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String numsStr = console.nextLine();
        String[] numsArr = getReversed(numsStr).split(" ");

        int sum = 0;
        for(String num : numsArr) {
            sum += Integer.parseInt(num);
        }

        System.out.println(sum);
    }

    private static String getReversed(String num) {
        return new StringBuilder(num).reverse().toString();
    }
}
