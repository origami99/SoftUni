import java.util.*;

public class p09_MostFrequentNumber {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] nums = console.nextLine().split(" ");

        LinkedHashMap<String, Integer> count = new LinkedHashMap<>();
        for (String num : nums) {
            if (!count.containsKey(num)){
                count.put(num, 1);
            }

            count.put(num, count.get(num) + 1);
        }

        String mostOccurNum = null;
        Integer maxVal = 0;
        for (Map.Entry<String, Integer> item : count.entrySet()) {
            if (item.getValue() > maxVal){
                maxVal = item.getValue();
                mostOccurNum = item.getKey();
            }
        }

        System.out.println(mostOccurNum);
    }
}
