package Excersice;

import java.util.Scanner;

public class OnTimeForTheExam {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int hourExam = Integer.parseInt(scanner.nextLine());
        int minExam = Integer.parseInt(scanner.nextLine());
        int hourStudent = Integer.parseInt(scanner.nextLine());
        int minStudent = Integer.parseInt(scanner.nextLine());

        int examTime = (hourExam * 60) + minExam;
        int arrivalTime = (hourStudent * 60) + minStudent;
        int diff = Math.abs(examTime - arrivalTime);


        if (arrivalTime > examTime) {
            System.out.println("Late");
            if (diff >= 60) {
                int hour = diff / 60;
                int min = diff % 60;
                System.out.printf("%d:%02d hours after the start", hour, min);
            } else {

                System.out.printf("%d minutes after the start", diff);
            }

        } else if (examTime == arrivalTime || (diff > 0 && diff <= 30)) {
            System.out.println("On time");
            if (diff >= 1 && diff <= 30) {
                System.out.printf("%d minutes before the start", diff);
            }

        } else {
            System.out.println("Early");
            if (diff >= 60) {
                int hour = diff / 60;
                int min = diff % 60;
                System.out.printf("%d:%02d hours before the start", hour, min);
            } else {
                System.out.printf("%d minutes before the start", diff);
            }
        }
    }
}

