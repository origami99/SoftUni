import java.util.*;

public class p18_Phonebook {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        TreeMap<String, String> phonebook = new TreeMap<>();
        while(true){
            String[] input = console.nextLine().split(" ");
            if(input[0].equals("END")){
                break;
            }

            if (input[0].equals("ListAll")){
                for (Map.Entry<String, String> entry : phonebook.entrySet()) {
                    System.out.println(entry.getKey() + " -> " + entry.getValue());
                }

                continue;
            }

            String action = input[0];
            String name = input[1];

            if(action.equals("A")){
                String phone = input[2];

                phonebook.put(name, phone);
            }
            else if (action.equals("S")){
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