import java.util.Arrays;
import java.util.Scanner;

public class p06_Largest3Numbers {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        Integer[] nums = Arrays.stream(console.nextLine().split("\\s+"))
                .map(Integer::parseInt)
                .toArray(Integer[]::new);

        Arrays.sort(nums);

        int bound = Math.min(nums.length, 3);
        for (int i = 0; i < bound; i++) {
            System.out.println(nums[nums.length - i - 1]);
        }
    }
}
