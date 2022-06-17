package Exercise;

import java.util.Scanner;

public class Coins {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double change = Double.parseDouble(scanner.nextLine());
        double coins = change * 100;
        int countCoins = 0;

        while (coins > 0) {
            coins = Math.round(coins);
            if (coins >= 200) {
                coins = coins - 200;
                countCoins++;
            } else if (coins >= 100) {
                coins = coins - 100;
                countCoins++;
            } else if (coins >= 50) {
                coins = coins - 50;
                countCoins++;
            } else if (coins >= 20) {
                coins = coins - 20;
                countCoins++;
            } else if (coins >= 10) {
                coins = coins - 10;
                countCoins++;
            } else if (coins >= 5) {
                coins = coins - 5;
                countCoins++;
            } else if (coins >= 2) {
                coins = coins - 2;
                countCoins++;
            } else if (coins >= 1) {
                coins = coins - 1;
                countCoins++;
            }  else {
                break; }


        }
        System.out.println(countCoins);
    }
}