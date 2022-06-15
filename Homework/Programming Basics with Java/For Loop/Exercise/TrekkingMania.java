package Exercise;

import java.util.Scanner;

public class TrekkingMania {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        int Musala = 0;
        int Monblan = 0;
        int Kalimandzaro = 0;
        int K2 = 0;
        int Everest = 0;



        for (int i = 0; i < n; i++) {
            int numParticipants = Integer.parseInt(scanner.nextLine());
            if (numParticipants <= 5) {
                Musala = Musala + numParticipants;
            } else if (numParticipants <= 12) {
                Monblan = Monblan + numParticipants;
            } else if (numParticipants <= 25) {
                Kalimandzaro = Kalimandzaro + numParticipants;
            } else if (numParticipants <= 40) {
                K2 = K2 + numParticipants;
            } else {
                Everest = Everest + numParticipants;
            }

        }
        int TotalClimbing =  Musala + Monblan + Kalimandzaro + K2 + Everest;

        System.out.printf("%.2f%%%n", Musala * 1.0 / TotalClimbing * 100);
        System.out.printf("%.2f%%%n", Monblan * 1.0 / TotalClimbing * 100);
        System.out.printf("%.2f%%%n", Kalimandzaro * 1.0 / TotalClimbing * 100);
        System.out.printf("%.2f%%%n", K2 * 1.0 / TotalClimbing * 100);
        System.out.printf("%.2f%%%n", Everest * 1.0 / TotalClimbing * 100);

    }
}

