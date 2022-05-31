package Lecture;

import com.sun.source.util.SourcePositions;

import java.util.Locale;
import java.util.Scanner;

public class TradeCommissions {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String nameTown = scanner.nextLine();
        Double s = Double.parseDouble(scanner.nextLine());

        if (nameTown.equals("Sofia")) {
            if (0 <= s && s <= 500) {
                double commision = s * 0.05;
                System.out.printf("%.2f", commision);
            } else if (500 < s && s <= 1000) {
                double commision = s * 0.07;
                System.out.printf("%.2f", commision);
            } else if (1000 < s && s <= 10000) {
                double commision = s * 0.08;
                System.out.printf("%.2f", commision);
            } else if (s > 10000) {
                double commision = s * 0.12;
                System.out.printf("%.2f", commision);
            } else
                System.out.println("error");


        } else if (nameTown.equals("Varna")) {
            if (0 <= s && s <= 500) {
                double commision = s * 0.045;
                System.out.printf("%.2f", commision);
            } else if (500 < s && s <= 1000) {
                double commision = s * 0.075;
                System.out.printf("%.2f", commision);
            } else if (1000 < s && s <= 10000) {
                double commision = s * 0.1;
                System.out.printf("%.2f", commision);
            } else if (s > 10000) {
                double commision = s * 0.13;
                System.out.printf("%.2f", commision);
            } else
                System.out.println("error");

        } else if (nameTown.equals("Plovdiv")) {
            if (0 <= s && s <= 500) {
                double commision = s * 0.055;
                System.out.printf("%.2f", commision);
            } else if (500 < s && s <= 1000) {
                double commision = s * 0.08;
                System.out.printf("%.2f", commision);
            } else if (1000 < s && s <= 10000) {
                double commision = s * 0.12;
                System.out.printf("%.2f", commision);
            } else if (s > 10000) {
                double commision = s * 0.145;
                System.out.printf("%.2f", commision);
            } else
                System.out.println("error");
            } else{
                System.out.println("error");
            }
        }
    }
