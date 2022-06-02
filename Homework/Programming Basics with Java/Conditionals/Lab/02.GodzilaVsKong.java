import java.util.Scanner;

public class GodzilaVsKong {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double BudgetMovie = Double.parseDouble(scanner.nextLine());
        int NumberExtra = Integer.parseInt(scanner.nextLine());
        double PriceForClothes = Double.parseDouble(scanner.nextLine());

        double decor = BudgetMovie * 0.1;
        double MoneyForClothes = PriceForClothes * NumberExtra;


        if (NumberExtra > 150) {
            MoneyForClothes = MoneyForClothes * 0.9;
        }
        double TotalSum = MoneyForClothes + decor;
        double diff = Math.abs(TotalSum - BudgetMovie);


        if (TotalSum <= BudgetMovie) {
            System.out.println("Action!");
            System.out.printf("Wingard starts filming with %.2f leva left.", diff);

        } else {
            System.out.println("Not enough money!");

            System.out.printf("Wingard needs %.2f leva more.", diff);
        }


    }
}