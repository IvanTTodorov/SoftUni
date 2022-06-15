package Exercise;

import java.util.Scanner;

public class TennisRanklist {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        int points = Integer.parseInt(scanner.nextLine());
        double result = 0;
        double win = 0;

        for (int i = 0; i < n; i++) {
            String text = scanner.nextLine();
            if (text.equals("W")) {
                result += 2000;
                win ++;
            }
            if (text.equals("F")) {
                result += 1200;
            }
            if (text.equals("SF")) {
                result += 720;

            }
        }
        double totalPoints = result + points;
        double averagePoints = Math.floor(result / n);




        System.out.printf("Final points: %.0f%n", totalPoints);
        System.out.printf("Average points: %.0f%n", averagePoints);
        System.out.printf("%.2f%%%n", (win / n) * 100);


    }
}
