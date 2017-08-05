import java.util.*;

public class p07_SumsByTown {

    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int n = Integer.parseInt(console.nextLine());

        TreeMap<String, Double> towns = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] line = console.nextLine().split("\\s+\\|\\s+");
            String town = line[0];
            Double income = Double.parseDouble(line[1]);

            if (towns.containsKey(town)){
                towns.put(town, towns.get(town) + income);
            }
            else {
                towns.put(town, income);
            }
        }

        for (Map.Entry<String, Double> entry : towns.entrySet()) {
            System.out.println(entry.getKey() + " -> " + entry.getValue());
        }
    }
}
