import java.util.*;

public class p09_CompareCharArrays {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String str1 = console.nextLine().replace(" ", "");
        String str2 = console.nextLine().replace(" ", "");

        int minLen = Math.min(str1.length(), str2.length());

        for(int i = 0; i < minLen; i++) {
            if(str1.charAt(i) > str2.charAt(i))
            {
                System.out.println(String.join("", str2));
                System.out.println(String.join("", str1));
                return;
            }
            else if(str2.charAt(i) < str1.charAt(i))
            {
                System.out.println(String.join("", str1));
                System.out.println(String.join("", str2));
                return;
            }
        }

        if(str1.length() > str2.length()){
            System.out.println(String.join("", str2));
            System.out.println(String.join("", str1));
        }
        else{
            System.out.println(String.join("", str1));
            System.out.println(String.join("", str2));
        }
    }
}
