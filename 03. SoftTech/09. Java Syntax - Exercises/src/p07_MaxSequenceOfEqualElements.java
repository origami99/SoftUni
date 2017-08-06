import java.util.Collections;
import java.util.Scanner;

public class p07_MaxSequenceOfEqualElements {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] nums = console.nextLine().split(" ");

        String currElem = "";
        String nextElem = "";
        int currLen = 1;
        int bestLen = 0;
        String bestNum = "";

        for (int i = 0; i < nums.length; i++) {
            currElem = nums[i];

            if (i != nums.length - 1){
                nextElem = nums[i + 1];

                if (currElem.equals(nextElem)){
                    currLen++;
                }
                else{
                    currLen = 1;
                }
            }

            if (currLen > bestLen){
                bestLen = currLen;
                bestNum = nums[i];
            }
        }

        System.out.println(String.join(" ", Collections.nCopies(bestLen, bestNum)));
    }
}
