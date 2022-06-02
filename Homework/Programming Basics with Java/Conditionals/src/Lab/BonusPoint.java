import java.util.Scanner;

public class BonusPoint {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int InitPoints = Integer.parseInt(scanner.nextLine());
        double Bonuspoint1 = 0;


        if (InitPoints <= 100) {
            Bonuspoint1 = 5;
        } else if (InitPoints <= 1000) {
            Bonuspoint1 = InitPoints * 0.2;
        } else {
            Bonuspoint1 = InitPoints * 0.1;
        }


        if (InitPoints % 2 == 0) {
            Bonuspoint1 = Bonuspoint1 + 1;
        }

        if (InitPoints % 10 == 5) {
            Bonuspoint1 = Bonuspoint1 + 2;
        }

        System.out.println(Bonuspoint1);
        System.out.println(InitPoints + Bonuspoint1);
    }
}