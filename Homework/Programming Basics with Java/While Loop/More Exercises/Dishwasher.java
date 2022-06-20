package MoreExercise;

import java.util.Scanner;

public class Dishwasher {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int numBottles = Integer.parseInt(scanner.nextLine());
        String input = scanner.nextLine();
        int countLoading = 0;
        double quantityDishSoap = numBottles * 750;
        int dishes = 0;
        int poots = 0;

        while (!input.equals("End")) {
            int num = Integer.parseInt(input);
            countLoading++;
            if (countLoading % 3 == 0) {
                quantityDishSoap = quantityDishSoap - (num * 15);
                poots += num;
            } else {
                quantityDishSoap = quantityDishSoap - (num * 5);
                dishes += num;
            }
            if (quantityDishSoap < 0) {
                break;
            }
            input = scanner.nextLine();

        }


        if (quantityDishSoap >= 0) {
            System.out.println("Detergent was enough!");
            System.out.printf("%d dishes and %d pots were washed.%n", dishes, poots);
            System.out.printf("Leftover detergent %.0f ml.", quantityDishSoap);
        } else {
            System.out.printf("Not enough detergent, %.0f ml. more necessary!", Math.abs(quantityDishSoap));

        }
    }
}