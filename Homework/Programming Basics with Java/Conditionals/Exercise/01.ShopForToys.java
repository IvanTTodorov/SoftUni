package Exercise;

import java.util.Scanner;

public class ShopForToys {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double PriceForTrip = Double.parseDouble(scanner.nextLine());
        int NumOfPuzzles = Integer.parseInt(scanner.nextLine());
        int NumOfDolls = Integer.parseInt(scanner.nextLine());
        int NumOfTeddyBears = Integer.parseInt(scanner.nextLine());
        int NumOfMinnions = Integer.parseInt(scanner.nextLine());
        int NumOfTrucks = Integer.parseInt(scanner.nextLine());

        double TotalSum = (NumOfDolls * 3.0)
                + (NumOfPuzzles * 2.6)
                + (NumOfTeddyBears * 4.1)
                + (NumOfMinnions * 8.2)
                + (NumOfTrucks * 2);
        int AllToys = NumOfDolls + NumOfMinnions + NumOfPuzzles + NumOfTrucks + NumOfTeddyBears;


        if (AllToys >= 50) {
            TotalSum = TotalSum * 0.75;
        }

       TotalSum = TotalSum * 0.90;
       double  diff = Math.abs(TotalSum - PriceForTrip);


        if (TotalSum >= PriceForTrip){
            System.out.printf("Yes! %.2f leva left", diff); }
        else {
            System.out.printf("Not enough money, %.2f leve needed.", diff);}


        }

    }

