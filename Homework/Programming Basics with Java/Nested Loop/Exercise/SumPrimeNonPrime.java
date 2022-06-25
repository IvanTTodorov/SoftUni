package Exercise;

import java.util.Scanner;

public class SumPrimeNonPrime {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();
        int primeNum = 0;
        int nonprimeNum = 0;

        while (!input.equals("stop")) {
            int num = Integer.parseInt(input);
            if (num < 0) {
                System.out.println("Number is negative.");
                input = scanner.nextLine();
                continue;
            }
            int count = 0;
            for (int i = 1; i <= num; i++) {
                if (num % i == 0) {
                    count++;
                }
            }
            if (count == 2) {
                primeNum += num;
            } else {
                nonprimeNum += num;
            }

            input = scanner.nextLine();
        }
        System.out.printf("Sum of all prime numbers is: %d%n", primeNum);
        System.out.printf("Sum of all non prime numbers is: %d", nonprimeNum);
    }
}