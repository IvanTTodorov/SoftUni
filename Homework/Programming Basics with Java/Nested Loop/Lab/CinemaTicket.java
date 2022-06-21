package Lecture;

import java.util.Scanner;

public class CinemaTicket {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();
        int totalTickets = 0;
        double percenthall = 0;
        int studentTicket = 0;
        int kidTicket = 0;
        int standardTicket = 0;

        while (!text.equals("Finish")) {
            double freeTickets = Double.parseDouble(scanner.nextLine());
            String typeTickets = scanner.nextLine();
            int count1Movie = 0;

            while (!typeTickets.equals("End")) {
                count1Movie++;
                switch (typeTickets) {
                    case "student":
                        studentTicket++;
                        break;
                    case "standard":
                        standardTicket++;
                        break;
                    case "kid":
                        kidTicket++;
                        break;
                }
                if (count1Movie == freeTickets) {
                    break;
                }
                typeTickets = scanner.nextLine();
            }
            totalTickets += count1Movie;

            percenthall = count1Movie / freeTickets * 100;
            System.out.printf("%s - %.2f%% full.%n", text, percenthall);
            text = scanner.nextLine();
        }

        System.out.printf("Total tickets: %d%n", totalTickets);
        System.out.printf("%.2f%% student tickets.%n", studentTicket * 1.0 / totalTickets * 100);
        System.out.printf("%.2f%% standard tickets.%n", standardTicket * 1.0 / totalTickets * 100);
        System.out.printf("%.2f%% kids tickets.%n", kidTicket * 1.0 / totalTickets * 100);


    }
}
