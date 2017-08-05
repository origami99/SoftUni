import java.util.Arrays;
import java.util.Scanner;

public class p03_3IntegersSum {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        Integer[] nums = Arrays.stream(console.nextLine().split("\\s+"))
                .map(Integer::parseInt)
                .toArray(Integer[]::new);

        Integer num1 = nums[0];
        Integer num2 = nums[1];
        Integer num3 = nums[2];

        if (num1 + num2 == num3){
            Integer minNum = Math.min(num1, num2);
            Integer maxNum = Math.max(num1, num2);

            System.out.printf("%d + %d = %d", minNum, maxNum, num3);
        }
        else if (num1 + num3 == num2){
            Integer minNum = Math.min(num1, num3);
            Integer maxNum = Math.max(num1, num3);

            System.out.printf("%d + %d = %d", minNum, maxNum, num2);
        }
        else if (num2 + num3 == num1){
            Integer minNum = Math.min(num2, num3);
            Integer maxNum = Math.max(num2, num3);

            System.out.printf("%d + %d = %d", minNum, maxNum, num1);
        }
        else {
            System.out.println("No");
        }
    }
}
