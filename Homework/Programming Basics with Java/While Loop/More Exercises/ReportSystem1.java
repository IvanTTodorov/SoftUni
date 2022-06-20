package MoreExercise;

import java.util.Scanner;

public class ReportSystem1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double neededMoney = Integer.parseInt(scanner.nextLine());
        String input = scanner.nextLine();
        double totalSum = 0;
        int count = 0;
        int countCash = 0;
        int countCard = 0;
        double moneyCash = 0;
        double moneyCard = 0;

        while (!input.equals("End")) {
            double sumProducts = Double.parseDouble(input);
            count++;
            if (count % 2 != 0) {
                if (sumProducts > 100) {
                    System.out.println("Error in transaction!");
                } else {
                    System.out.println("Product sold!");
                    totalSum += sumProducts;
                    moneyCash += sumProducts;
                    countCash++;
                }

            } else {
                if (sumProducts < 10) {
                    System.out.println("Error in transaction!");
                } else {
                    System.out.println("Product sold!");
                    totalSum += sumProducts;
                    moneyCard += sumProducts;
                    countCard++;

                }
            }
            if (totalSum >= neededMoney) {
                break;
            }
            input = scanner.nextLine();
        }
        double avCS = moneyCash / countCash;
        double avCC = moneyCard / countCard;
        if (totalSum >= neededMoney) {
            System.out.printf("Average CS: %.2f%n", avCS);
            System.out.printf("Average CC: %.2f", avCC);
        } else {
            System.out.println("Failed to collect required money for charity.");
        }
    }
}

