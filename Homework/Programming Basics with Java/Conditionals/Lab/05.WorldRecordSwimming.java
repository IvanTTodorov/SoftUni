import java.util.Scanner;

public class WorldRecordSwimming {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Double RecordInSec = Double.parseDouble(scanner.nextLine());
        Double DistanceInMetres = Double.parseDouble(scanner.nextLine());
        Double Seconds = Double.parseDouble(scanner.nextLine());

        double TotalSeconds = DistanceInMetres * Seconds;
        double resistance = Math.floor(DistanceInMetres / 15) * 12.5;
        TotalSeconds = TotalSeconds + resistance;


        if (RecordInSec <= TotalSeconds) {
            double diff = Math.abs(RecordInSec - TotalSeconds);
            System.out.printf("No, he failed! He was %.2f seconds slower.", diff);
        } else {
            System.out.printf("Yes, he succeeded! The new world record is %.2f seconds.", TotalSeconds);
        }

        }
    }
