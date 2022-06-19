package MoreExercise;

import java.util.Scanner;

public class AverageNumber1 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt (scanner.nextLine());

        double totalsum = 0;

        for (int i = 0; i < n; i++ ) {
            int num = Integer.parseInt(scanner.nextLine());
            totalsum += num;
        } double average = totalsum / n;
        System.out.printf("%.2f", average);


                }
    }

