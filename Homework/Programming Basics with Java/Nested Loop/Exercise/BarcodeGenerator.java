package Exercise;

import java.util.Scanner;

public class BarcodeGenerator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int first = Integer.parseInt(scanner.nextLine());
        int second = Integer.parseInt(scanner.nextLine());

        int Startunits = first % 10;
        int Starttens = first / 10 % 10;
        int Starthundreds = first / 100 % 10;
        int Startthounsand = first / 1000 % 10;

        int Endunits = second % 10;
        int Endtens = second / 10 % 10;
        int Endhundreds = second / 100 % 10;
        int Endthounsand = second / 1000 % 10;

        for (int i = Startthounsand; i <= Endthounsand; i++) {
            for (int j = Starthundreds; j <= Endhundreds; j++) {
                for (int k = Starttens; k <= Endtens; k++) {
                    for (int l = Startunits; l <= Endunits; l++) {
                        boolean isOdd = (i % 2 != 0)
                                && (j % 2 != 0)
                                && (k % 2 != 0)
                                && (l % 2 != 0);
                        if (isOdd) {
                            System.out.printf("%d%d%d%d ", i, j, k, l);


                        }
                    }
                }
            }
        }
    }
    }
