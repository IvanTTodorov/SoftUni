import java.util.Scanner;

public class InvalidNumber {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int num = Integer.parseInt(scanner.nextLine());
        boolean IsValid = (100 <= num) && (200 >= num) || (num == 0);

        if (!IsValid) {
            System.out.println("invalid");
        } else if (IsValid) {
            System.out.println("Valid");
        }
    }
}