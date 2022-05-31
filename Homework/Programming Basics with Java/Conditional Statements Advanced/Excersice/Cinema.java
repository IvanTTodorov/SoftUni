package Excersice;

import java.util.Scanner;

public class Cinema {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String type = scanner.nextLine();
        int row = Integer.parseInt(scanner.nextLine());
        int column = Integer.parseInt(scanner.nextLine());

        double totalPrice = 0;

        if (type.equals("Premiere")) {
            totalPrice = 12 * row * column;
            System.out.printf("%.2f leva", totalPrice);
        } else if (type.equals("Normal")) {
            totalPrice = 7.5 * row * column;
            System.out.printf("%.2f leva", totalPrice);

        } else if (type.equals("Discount")) {
            totalPrice = 5 * row * column;
            System.out.printf("%.2f leva", totalPrice);
        }


    }
}
