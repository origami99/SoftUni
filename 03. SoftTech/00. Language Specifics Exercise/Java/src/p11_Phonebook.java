import java.util.*;

public class p11_Phonebook {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        LinkedHashMap<String, String> phonebook = new LinkedHashMap<>();
        while(true){
            String[] input = console.nextLine().split(" ");
            if(input[0].equals("END")){
                break;
            }

            String action = input[0];
            String name = input[1];

            if(action.equals("A")){
                String phone = input[2];

                phonebook.put(name, phone);
            }
            else{
                if(phonebook.containsKey(name)){
                    System.out.println(name + " -> " + phonebook.get(name));
                }
                else{
                    System.out.println("Contact " + name + " does not exist.");
                }
            }
        }
    }
}
