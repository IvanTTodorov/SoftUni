package MoreExercises;

import java.util.Scanner;

public class HappyCatParking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numDays = Integer.parseInt(scanner.nextLine());
        int numHours = Integer.parseInt(scanner.nextLine());
        double price = 0;
        int count = 0;

        for (int i = 1; i <= numDays; i++) {
            double priceForADay = 0;
            count++;

            for (int j = 1; j <= numHours; j++) {
                if (i % 2 == 0 && j % 2 != 0) {
                    priceForADay = priceForADay + 2.50;
                    price = price + 2.50;
                } else if (i % 2 != 0 && j % 2 == 0) {
                    priceForADay = priceForADay + 1.25;
                    price = price + 1.25;
                } else {
                    priceForADay = priceForADay + 1;
                    price = price + 1;
                }


            }
            System.out.printf("Day: %d - %.2f leva%n", i, priceForADay);
        }
        System.out.printf("Total: %.2f leva%n", price);
    }
}
