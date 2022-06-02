import java.util.Scanner;

public class SumOfSec {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

int first = Integer.parseInt (scanner.nextLine());
int second = Integer.parseInt (scanner.nextLine());
int third = Integer.parseInt (scanner.nextLine());

int SumSec = first + second + third;
int min = SumSec / 60;
int sec = SumSec % 60;
        System.out.printf("%d:%02d", min, sec);
        }




    }



