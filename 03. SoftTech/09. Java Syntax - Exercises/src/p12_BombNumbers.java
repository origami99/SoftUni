import java.util.*;
import java.util.stream.Collectors;

public class p12_BombNumbers {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        List<Integer> nums = Arrays.stream(console.nextLine().split(" "))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int[] input = Arrays.stream(console.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();
        int bombNum = input[0];
        int splashDamage = input[1];

        for (int i = 0; i < nums.size(); i++) {
            if (nums.get(i) == bombNum) {
                int left = Math.max(i - splashDamage, 0);
                int right = Math.min(i + 1 + splashDamage, nums.size());

                nums.subList(left, right).clear();

                i = 0;
            }
        }

        int sum = Arrays.stream
                (
                    Arrays.stream(nums.toArray())
                        .mapToInt(num -> Integer.parseInt(num.toString())).toArray()
                )
                .sum();

        System.out.println(sum);
    }
}
