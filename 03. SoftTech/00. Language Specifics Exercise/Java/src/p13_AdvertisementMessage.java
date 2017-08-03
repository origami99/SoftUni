import java.util.*;

public class p13_AdvertisementMessage {
    public static void main(String[] args) {
        String[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
        String[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        String[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        String[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        Scanner console = new Scanner(System.in);
        Integer n = Integer.parseInt(console.nextLine());

        Random rnd = new Random();

        for(int i = 0; i < n; i++){
            String phr = phrases[rnd.nextInt(phrases.length)];
            String evn = events[rnd.nextInt(events.length)];
            String auth = authors[rnd.nextInt(authors.length)];
            String city = cities[rnd.nextInt(cities.length)];

            System.out.println(phr + " " + evn + " " + auth + " - " + city);
        }
    }
}
