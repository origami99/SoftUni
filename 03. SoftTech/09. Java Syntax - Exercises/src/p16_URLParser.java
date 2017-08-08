import java.util.Scanner;

public class p16_URLParser {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String url = console.nextLine();

        String protocol = "";
        String server;
        String resource = "";

        String[] leftSplit = url.split("://");
        if (leftSplit.length == 2){
            protocol = leftSplit[0];
        }

        String[] rightSplit = leftSplit[leftSplit.length - 1].split("/" ,2);
        if (rightSplit.length == 2){
            resource = rightSplit[1];
        }

        server = rightSplit[0];

        System.out.printf("[protocol] = \"%s\"\n", protocol);
        System.out.printf("[server] = \"%s\"\n", server);
        System.out.printf("[resource] = \"%s\"\n", resource);
    }
}
