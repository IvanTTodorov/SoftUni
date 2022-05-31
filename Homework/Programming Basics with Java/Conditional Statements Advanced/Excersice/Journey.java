package Excersice;

import java.util.Scanner;

public class Journey {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double budget = Double.parseDouble(scanner.nextLine());
        String season = scanner.nextLine();
        String vacation = "";
        String place = "";
        double price = 0;
        if (budget <= 100) {
            vacation = "Bulgaria";

            if (season.equals("summer")) {
                price = budget * 0.3;
                place = "Camp";
            } else if (season.equals("winter")) {
                price = budget * 0.7;
                place = "Hotel";
            }
        } else if (budget <= 1000) {
            vacation = "Balkans";

            if (season.equals("summer")) {
                price = budget * 0.4;
                place = "Camp";
            } else if (season.equals("winter")) {
                price = budget * 0.8;
                place = "Hotel";
            }
        } else {
            vacation = "Europe";
            price = budget * 0.9;
            place = "Hotel";
        }
        System.out.printf("Somewhere in %s%n", vacation);
        System.out.printf("%s - %.2f", place, price);

        }
    }
