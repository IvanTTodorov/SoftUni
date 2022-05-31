import java.util.Scanner;

public class FishingBoat {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int budget = Integer.parseInt(scanner.nextLine());
        String season = scanner.nextLine();
        int numFisherMan = Integer.parseInt(scanner.nextLine());

        double rentPrice = 0;
        switch (season) {
            case "Spring":
                rentPrice = 3000;
                break;
            case "Summer":
            case "Autumn":
                rentPrice = 4200;
                break;
            case "Winter":
                rentPrice = 2600;
                break;
        }
        if (numFisherMan <= 6) {
            rentPrice = rentPrice * 0.90;
        } else if (numFisherMan >= 7 && numFisherMan <= 11) {
            rentPrice = rentPrice * 0.85;
        } else {
            rentPrice = rentPrice * 0.75;
        }

        if (!season.equals("Autumn")) {
            if (numFisherMan % 2 == 0) {
                rentPrice = rentPrice * 0.95;
            }
        }
        double diff = Math.abs(budget - rentPrice);
        if (budget >= rentPrice) {
            System.out.printf("Yes! You have %.2f leva left.", diff);
        } else {
            System.out.printf("Not enough money! You need %.2f leva.", diff);

        }
    }
}