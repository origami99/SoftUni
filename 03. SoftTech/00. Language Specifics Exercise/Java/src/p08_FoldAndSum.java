import java.util.*;

public class p08_FoldAndSum {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String[] arr = console.nextLine().split(" ");
        int[] array = Arrays.stream(arr).mapToInt(Integer::parseInt).toArray();
        int len = arr.length;

        int[] left = Arrays.copyOfRange(array, 0, len / 4);
        reverseArray(left);
        int[] middle = Arrays.copyOfRange(array, len / 4, len / 2 + len / 4);
        int[] right = Arrays.copyOfRange(array, len / 2 + len / 4, len);
        reverseArray(right);

        for(int i = 0; i < left.length; i++){
            middle[i] += left[i];
        }
        for(int i = 0; i < right.length; i++){
            middle[i + len / 4] += right[i];
        }

        for (int num : middle) {
            System.out.print(num + " ");
        }
    }

    private static void reverseArray(int[] arr) {
        for(int i = 0; i < arr.length / 2; i++) {
            int temp = arr[i];
            arr[i] = arr[arr.length - i - 1];
            arr[arr.length - i - 1] = temp;
        }
    }
}
