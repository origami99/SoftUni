import java.util.Scanner;

public class p05_IntegerToHexAndBinary {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int num = Integer.parseInt(console.nextLine());

        String hex = Integer.toHexString(num).toUpperCase();
        String binary = Integer.toBinaryString(num);

        System.out.println(hex);
        System.out.println(binary);
    }
}
