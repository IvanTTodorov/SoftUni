import java.util.Scanner;

public class FruitShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String fruit = scanner.nextLine();
        String dayOfWeek = scanner.nextLine();
        double quantity = Double.parseDouble(scanner.nextLine());




        if (dayOfWeek.equals("Monday") ||
                dayOfWeek.equals("Tuesday") ||
                dayOfWeek.equals("Wednesday") ||
                dayOfWeek.equals("Thursday") ||
                dayOfWeek.equals("Friday")) {
            if (fruit.equals("banana")) {
double banana = 2.50 * quantity;
                System.out.printf("%.2f", banana);
            } else if (fruit.equals("apple")) {
                double apple = 1.20 * quantity;
                System.out.printf("%.2f", apple);
            } else if (fruit.equals("grapefruit")) {
                double grapefruit = 1.45 * quantity;
                System.out.printf("%.2f", grapefruit);
            } else if (fruit.equals("orange")) {
                double orange = 0.85 * quantity;
                System.out.printf("%.2f",orange);
            } else if (fruit.equals("kiwi")) {
                double kiwi = 2.70 * quantity;
                System.out.printf("%.2f",kiwi);
            } else if (fruit.equals("pineapple")) {
                double pineapple = 5.50 * quantity;
                System.out.printf("%.2f",pineapple);
            } else if (fruit.equals("grapes")) {
                double grapes = 3.85 * quantity;
                System.out.printf("%.2f",grapes);
            } else {
                System.out.println("error");
            }

        } else if (dayOfWeek.equals("Saturday") ||
                dayOfWeek.equals("Sunday")) {
            if (fruit.equals("banana")) {
                double banana = 2.70 * quantity;
                System.out.printf("%.2f", banana);
            } else if (fruit.equals("apple")) {
                double apple = 1.25 * quantity;
                System.out.printf("%.2f", apple);
            } else if (fruit.equals("grapefruit")) {
                double grapefruit = 1.60 * quantity;
                System.out.printf("%.2f", grapefruit);
            } else if (fruit.equals("orange")) {
                double orange = 0.90 * quantity;
                System.out.printf("%.2f", orange);
            } else if (fruit.equals("kiwi")) {
                double kiwi = 3.00 * quantity;
                System.out.printf("%.2f", kiwi);
            } else if (fruit.equals("pineapple")) {
                double pineapple = 5.60 * quantity;
                System.out.printf("%.2f", pineapple);
            } else if (fruit.equals("grapes")) {
                double grapes = 4.20 * quantity;
                System.out.printf("%.2f", grapes);
            } else {
                System.out.println("error");
            }

        } else {
            System.out.println("error");


        }
    }
}


