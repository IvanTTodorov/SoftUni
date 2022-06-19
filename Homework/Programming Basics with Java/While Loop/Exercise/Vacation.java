package Exercise;

import java.util.Scanner;

public class Vacation {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double needMoney = Double.parseDouble(scanner.nextLine());
        double money = Double.parseDouble(scanner.nextLine());
        double leftMoney = money;
        int days = 0;
        int totalDay = 0;
        boolean isFailed = false;


        while (leftMoney < needMoney) {

            if (days == 5) {
                isFailed = true;
                break;
            }
            String input = scanner.nextLine();
            double dailyMoney = Double.parseDouble(scanner.nextLine());
            totalDay++;
            if (input.equals("spend")) {
                leftMoney = leftMoney - dailyMoney;
                days++;
                if (leftMoney < 0) {
                    leftMoney = 0;

                }
            } else {
                leftMoney = leftMoney + dailyMoney;
                days = 0;
            }

        }
        if (isFailed) {
            System.out.println("You can't save the money.");
            System.out.println(days);
        } else {
            System.out.printf("You saved the money for %d days.%n", totalDay);
        }
    }
}
