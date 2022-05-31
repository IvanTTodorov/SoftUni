package Excersice;

import java.util.Scanner;

public class SkiTrip {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int daysToStay = Integer.parseInt(scanner.nextLine());
        String roomType = scanner.nextLine();
        String score = scanner.nextLine();

        double price = 0;
        double priceDiscount = 0;

        if ("room for one person".equals(roomType)) {
            price = 18.00 * (daysToStay - 1);
            priceDiscount = price;
        } else if ("apartment".equals(roomType)){
            price = 25.0 *(daysToStay-1);
            if (daysToStay < 10) {
                priceDiscount = price * 0.7;
            } else if (daysToStay <= 15) {
                priceDiscount = price * 0.65;
            } else {
                priceDiscount = price * 0.5;
            }
        } else if ("president apartment".equals(roomType)) {
            price = 35.00*(daysToStay-1);
            if (daysToStay < 10) {
                priceDiscount = price * 0.90;
            } else if (daysToStay <= 15) {
                priceDiscount = price * 0.85;
            } else {
                priceDiscount = price * 0.80;
            }
        }  double totalPrice = 0.00;
        if ("positive".equals(score)){
            totalPrice = priceDiscount + (priceDiscount * 0.25);

        } else if ("negative".equals(score)){
            totalPrice = priceDiscount * 0.9;

        } System.out.printf("%.2f", totalPrice);
    }
}