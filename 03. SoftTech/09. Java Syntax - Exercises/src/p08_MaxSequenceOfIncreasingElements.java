import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class p08_MaxSequenceOfIncreasingElements {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        Integer[] nums = Arrays.stream(console.nextLine().split(" "))
                .map(Integer::parseInt)
                .toArray(Integer[]::new);

        ArrayList<Integer> currSeq = new ArrayList<>(Arrays.asList(nums[0]));
        ArrayList<Integer> bestSeq = new ArrayList<>();

        for (int i = 1; i < nums.length; i++) {
            Integer currNum = nums[i];
            Integer prevNum = nums[i - 1];

            if (currNum > prevNum) {
                currSeq.add(currNum);
            } else {
                currSeq.clear();
                currSeq.add(currNum);
            }

            if (currSeq.size() > bestSeq.size()) {
                bestSeq = new ArrayList<>(currSeq);
            }
        }

        for (Integer num : bestSeq) {
            System.out.print(num + " ");
        }
    }
}
