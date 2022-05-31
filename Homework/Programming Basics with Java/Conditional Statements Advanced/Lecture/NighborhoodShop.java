import java.util.Scanner;

public class NighborhoodShop {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String Product = scanner.nextLine();
        String Town = scanner.nextLine();
        double Quantity = Double.parseDouble(scanner.nextLine());

        double PriceOneProduct = 0;

        if (Town.equals("Sofia")) {
            if (Product.equals("coffee")) {
                PriceOneProduct = 0.5;
            } else if (Product.equals("water")) {
                PriceOneProduct = 0.8;
            } else if (Product.equals("beer")) {
                PriceOneProduct = 1.2;
            } else if (Product.equals("sweets")) {
                PriceOneProduct = 1.45;
            } else if (Product.equals("peanuts")) {
                PriceOneProduct = 1.60;
            }
        } else if (Town.equals("Plovdiv")) {
            if (Product.equals("coffee")) {
                PriceOneProduct = 0.4;
            } else if (Product.equals("water")) {
                PriceOneProduct = 0.7;
            } else if (Product.equals("beer")) {
                PriceOneProduct = 1.15;
            } else if (Product.equals("sweets")) {
                PriceOneProduct = 1.30;
            } else if (Product.equals("peanuts")) {
                PriceOneProduct = 1.50;
            }

        } else if (Town.equals("Varna")) {
            if (Product.equals("coffee")) {
                PriceOneProduct = 0.45;
            } else if (Product.equals("water")) {
                PriceOneProduct = 0.70;
            } else if (Product.equals("beer")) {
                PriceOneProduct = 1.10;
            } else if (Product.equals("sweets")) {
                PriceOneProduct = 1.35;
            } else if (Product.equals("peanuts")) {
                PriceOneProduct = 1.55;
            }
        }
    double TotalPrice = PriceOneProduct * Quantity;
        System.out.println(TotalPrice);




          }
}
