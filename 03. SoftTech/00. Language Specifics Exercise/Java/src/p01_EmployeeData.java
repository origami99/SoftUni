import java.util.Scanner;

public class p01_EmployeeData {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String firstName = console.nextLine();
        String lastName = console.nextLine();
        int age = Integer.parseInt(console.nextLine());
        char gender = console.nextLine().charAt(0);
        String iD = console.nextLine();
        String uniqueEmployeeNum = console.nextLine();

        System.out.printf("First name: %s\n", firstName);
        System.out.printf("Last name: %s\n", lastName);
        System.out.printf("Age: %d\n", age);
        System.out.printf("Gender: %s\n", gender);
        System.out.printf("Personal ID: %s\n", iD);
        System.out.printf("Unique Employee number: %s\n", uniqueEmployeeNum);
    }
}
