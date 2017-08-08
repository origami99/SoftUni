import java.util.Scanner;

public class p13_ReverseString {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String[] arr = console.nextLine().split("");

        for (int i = arr.length - 1; i >= 0; i--) {
            System.out.print(arr[i]);
        }
    }
}
