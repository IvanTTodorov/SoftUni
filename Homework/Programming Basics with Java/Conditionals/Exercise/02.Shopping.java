package Exercise;

import java.util.Scanner;

public class Shopping {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double Budget = Double.parseDouble(scanner.nextLine());
        int Videocards = Integer.parseInt(scanner.nextLine());
        int Processor = Integer.parseInt(scanner.nextLine());
        int RAM = Integer.parseInt(scanner.nextLine());

        double PriceVideoCards = 250 * Videocards;
        double PriceProcessor = Processor * (PriceVideoCards * 0.35);
        double PriceRam = RAM * (PriceVideoCards * 0.1);
        double TotalSum = PriceProcessor + PriceRam + PriceVideoCards;

        if (Videocards > Processor) {
            TotalSum = TotalSum - (TotalSum * 0.15);
        }
        double Diff = Math.abs(Budget - TotalSum);
        if (Budget >= TotalSum) {
            System.out.printf("You have %.2f leva left!", Diff);
        } else {
            System.out.printf("Not enough money! You need %.2f leva more!", Diff);
        }

    }
}
