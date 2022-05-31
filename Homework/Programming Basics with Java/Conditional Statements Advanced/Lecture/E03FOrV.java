import java.util.Scanner;

public class E03FOrV {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String food = scanner.nextLine();

        switch (food) {
            case "banana":
            case "kiwi":
            case "grapes":
            case "apple":
            case "cherry":
            case "lemon":
                System.out.println("fruit");
                break;
            case "cucumber":
            case "tomato":
            case "pepper":
            case "carrot":
                System.out.println("vegetable");
                break;
            default:
                System.out.println("unknown");
        }
    }
}
