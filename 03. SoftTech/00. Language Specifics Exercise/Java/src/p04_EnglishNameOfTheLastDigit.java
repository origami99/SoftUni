import java.util.Scanner;

public class p04_EnglishNameOfTheLastDigit {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String num = console.nextLine();

        String digitName = getLastDigitName(num);
        System.out.println(digitName);
    }

    private static String getLastDigitName(String num) {
        String[] names = "zero one two three four five six seven eight nine".split(" ");
        String lastDigit = num.substring(num.length() - 1);

        return names[Integer.parseInt(lastDigit)];
    }
}
