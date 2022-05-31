package Excersice;

import java.util.Scanner;

public class OperationsBetweenNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int N1 = Integer.parseInt(scanner.nextLine());
        int N2 = Integer.parseInt(scanner.nextLine());
        char operator = scanner.nextLine().charAt(0);

        double result = 0;
        String oddOrEven = "";
        boolean isZero = false;

        if (operator == '+') {
            result = N1 + N2;
            if (result % 2 == 0) {
                oddOrEven = "even";
            } else {
                oddOrEven = "odd";
            }


        } else if (operator == '-') {
            result = N1 - N2;

            if (result % 2 == 0) {
                oddOrEven = "even";
            } else {
                oddOrEven = "odd";
            }


        } else if (operator == '*') {
            result = N1 * N2;
            if (result % 2 == 0) {
                oddOrEven = "even";
            } else {
                oddOrEven = "odd";
            }


        } else if (operator == '/') {
            if (N2 == 0) {
                isZero = true;

            } else {
                result = N1 * 1.0 / N2;

            }


        } else if (operator == '%') {
            if (N2 == 0) {
                isZero = true;

            } else {
                result = N1 % N2;

            }
        }
        if (operator == '+' ||
                operator == '-' ||
                operator == '*') {
            System.out.printf("%d %c %d = %.0f - %s", N1, operator,N2, result, oddOrEven);
        } else if (!isZero && operator == '/') {
            System.out.printf("%d / %d = %.2f", N1, N2, result);
        } else if (!isZero && operator == '%') {
            System.out.printf("%d %% %d = %.0f", N1, N2, result);
        } else if (isZero && operator == '/' || operator == '%') {
            System.out.printf("Cannot divide %d by zero", N1);


        }
    }

}
