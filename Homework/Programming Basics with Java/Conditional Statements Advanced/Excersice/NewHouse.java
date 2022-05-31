package Excersice;

import java.util.Scanner;

public class NewHouse {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String typeFlowers = scanner.nextLine();
        int numFlower = Integer.parseInt(scanner.nextLine());
        int budget = Integer.parseInt(scanner.nextLine());

        double price = 0;


        switch (typeFlowers) {
            case "Roses":
                price = 5 * numFlower;
                if (numFlower > 80) {
                    price = price * 0.9;
                }
                break;
            case "Dahlias":
                price = 3.80 * numFlower;
                if (numFlower > 90) {
                    price = price * 0.85;
                }
                break;
            case "Tulips":
                price = 2.8 * numFlower;
                if (numFlower > 80) {
                    price = price * 0.85;
                }
                break;
            case "Narcissus":
                price = 3 * numFlower;
                if (numFlower < 120) {
                    price = price * 1.15;
                }
                break;
            case "Gladiolus":
                price = 2.5 * numFlower;
                if (numFlower < 80) {
                    price = price * 1.20;
                    break;
                }
        }
        double diff = Math.abs(price - budget);

        if (budget >= price) {
            System.out.printf("Hey, you have a great garden with %d %s and %.2f leva left.", numFlower, typeFlowers, diff);
        } else {
            System.out.printf("Not enough money, you need %.2f leva more.", diff);
        }
    }
}