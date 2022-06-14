package Exercise;

import java.util.Scanner;

public class CleverLily {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int age = Integer.parseInt(scanner.nextLine());
        double priceLaundry = Double.parseDouble(scanner.nextLine());
        int priceToy = Integer.parseInt(scanner.nextLine());
        int toys = 0;
        int money = 0;
        double totalSum = 0;
        int allMoney = 0;
       double brotherCount = 0;
        for (int i = 1; i <= age; i++) {

            if (i % 2 == 0) {
                money += 10;
                allMoney = money + allMoney;
                brotherCount++;

            } else {
                toys++;

            }
        }
        totalSum = allMoney + (toys * priceToy) - brotherCount;


        double diff = Math.abs(totalSum - priceLaundry);

        if (totalSum >= priceLaundry) {
            System.out.printf("Yes! %.2f", diff);
        } else {
            System.out.printf("No! %.2f", diff);
        }


    }
}
