package Exercise;

import java.util.Scanner;

public class TicketsForCinema {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        double totalTickets = 0;
        double standard = 0;
        double kids = 0;
        double student = 0;

        while (!input.equals("Finish")) {

            int freePlaces = Integer.parseInt(scanner.nextLine());
            String typeTickets = scanner.nextLine();

            double ticketPerMovie = 0;

            while (!typeTickets.equals("End")) {
                ticketPerMovie++;
                totalTickets ++;
                switch (typeTickets) {
                    case "standard":
                        standard++;
                        break;
                    case "kid":
                        kids++;
                        break;
                    case "student":
                        student++;
                        break;
                }
                if (ticketPerMovie == freePlaces) {
                    break; }
                typeTickets = scanner.nextLine();
            }


            System.out.printf("%s - %.2f%% full.%n", input, ticketPerMovie / freePlaces * 100);
            input = scanner.nextLine();
        }
        System.out.printf("Total tickets: %.0f%n", totalTickets);
        System.out.printf("%.2f%% student tickets.%n", student  /totalTickets * 100 );
        System.out.printf("%.2f%% standard tickets.%n", standard  /totalTickets * 100);
        System.out.printf("%.2f%% kids tickets.%n", kids  /totalTickets * 100);
    }
}
