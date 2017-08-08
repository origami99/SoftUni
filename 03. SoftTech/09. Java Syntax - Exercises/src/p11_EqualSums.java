import java.util.Arrays;
import java.util.Scanner;

public class p11_EqualSums {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int[] nums = Arrays.stream(console.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        if (nums.length == 1) {
            System.out.println(0);
            return;
        }

        int[] leftArr;
        int[] rightArr;
        for (int i = 0; i < nums.length; i++) {
            leftArr = Arrays.copyOfRange(nums, 0, i);
            rightArr = Arrays.copyOfRange(nums, i + 1, nums.length);

            int leftSum = Arrays.stream(leftArr).sum();
            int rightSum = Arrays.stream(rightArr).sum();

            if (leftSum == rightSum) {
                System.out.println(i);
                return;
            }
        }

        System.out.println("no");
    }
}
