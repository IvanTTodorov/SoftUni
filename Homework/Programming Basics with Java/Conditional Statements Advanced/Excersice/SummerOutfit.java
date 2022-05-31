package Excersice;

import java.util.Scanner;

public class SummerOutfit {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int c = Integer.parseInt(scanner.nextLine());
        String timeOfDay = scanner.nextLine();

        String outfit = "";
        String shoes = "";

        if (timeOfDay.equals("Morning")) {
            if (10 <= c && c <= 18) {
                outfit = "Sweatshirt";
                shoes = "Sneakers";

            } else if (18 < c && c <= 24) {
                outfit = "Shirt";
                shoes = "Moccasins";

            } else if (c >= 25) {
                outfit = "T-Shirt";
                shoes = "Sandals";

            }

        } else if (timeOfDay.equals("Afternoon")) {
            if (10 <= c && c <= 18) {
                outfit = "Shirt";
                shoes = "Moccasins";
            } else if (18 < c && c <= 24) {
                outfit = "T-Shirt";
                shoes = "Sandals";
            } else if (c >= 25) {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }

        } else if (timeOfDay.equals("Evening"))
            if (10 <= c && c <= 18) {
                outfit = "Shirt";
                shoes = "Moccasins";
            } else if (18 < c && c <= 24) {
                outfit = "Shirt";
                shoes = "Moccasins";
            } else if (c >= 25) {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
        System.out.printf ("It's %d degrees, get your %s and %s.", c, outfit, shoes);


    }
    }




