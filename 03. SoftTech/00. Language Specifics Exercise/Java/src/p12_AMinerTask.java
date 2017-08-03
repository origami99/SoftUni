import java.util.*;

public class p12_AMinerTask {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        LinkedHashMap<String, Integer> resourses = new LinkedHashMap<>();

        while (true) {
            String res = console.nextLine();
            if (res.equals("stop")) {
                break;
            }
            Integer quant = Integer.parseInt(console.nextLine());

            if (resourses.containsKey(res)) {
                resourses.put(res, quant + resourses.get(res));
            } else {
                resourses.put(res, quant);
            }
        }

        for (String ress : resourses.keySet()){
            System.out.println(ress + " -> " + resourses.get(ress));
        }
    }
}
