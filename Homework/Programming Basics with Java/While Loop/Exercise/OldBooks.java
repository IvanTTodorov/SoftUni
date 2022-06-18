package Exercise;

import java.security.KeyStore;
import java.util.Scanner;

public class OldBooks {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String wantedBookName = scanner.nextLine();
        String input = scanner.nextLine();
        int count = 0;
        boolean isFound = false;


        while (!input.equals("No More Books")) {
            if (input.equals(wantedBookName)) {
                isFound = true;
                break; }

            count ++;
            input = scanner.nextLine(); }

        if (isFound) {
            System.out.printf("You checked %d books and found it.", count); }
        else {
            System.out.println("The book you search is not here!");
            System.out.printf("You checked %d books.", count);



    }
}


    }

