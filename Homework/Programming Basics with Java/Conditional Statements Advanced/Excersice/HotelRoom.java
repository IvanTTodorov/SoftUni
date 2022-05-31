package Excersice;

import java.util.Scanner;

public class HotelRoom {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String month = scanner.nextLine();
        int numNights = Integer.parseInt(scanner.nextLine());

        double PriceStudio = 0;
        double PriceApartment = 0;

        switch (month) {
            case "May":
            case "October":

                PriceStudio = 50;
                PriceApartment = 65;
                if (numNights > 7 && numNights < 14) {
                    PriceStudio = (PriceStudio * 0.95) ;
                } else if (numNights > 14) {
                    PriceStudio = PriceStudio * 0.70;
                    PriceApartment = PriceApartment * 0.90;
                }
                break;
            case "June":
            case "September":
                PriceStudio = 75.20;
                PriceApartment = 68.70;
                if (numNights > 14) {
                    PriceStudio = PriceStudio * 0.80;
                    PriceApartment = PriceApartment * 0.90;
                }
                break;
            case "July":
            case "August":
                PriceStudio = 76;
                PriceApartment = 77;
                if (numNights > 14) {
                    PriceApartment = PriceApartment * 0.90;
                }
        }
        double totalPrice = PriceApartment * numNights;
        double totalPriceS = PriceStudio * numNights;
        System.out.printf("Apartment: %.2f lv. %n", totalPrice);
        System.out.printf("Studio: %.2f lv.", totalPriceS);
    }
}