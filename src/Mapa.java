import javax.imageio.ImageIO;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.Scanner;

public class Mapa {
    public ArrayList<BlokiMapy> mapaBlokow;

    Mapa() throws FileNotFoundException {
        mapaBlokow = new ArrayList<>();
        wczytajMape();
    }

    public void wczytajMape() throws FileNotFoundException {
        File plikMapy = new File("C:\\Users\\zaq13\\IdeaProjects\\Kurs Kotlin\\Game\\src\\Mapa nr1");
        Scanner skanner = new Scanner(plikMapy);
        int liczbaBlokow = skanner.nextInt();
        String sciezkaDoTla;
        String [] sciezkaDoBloku;
        ArrayList<BlokZiemi> bloki = new ArrayList<>();
        ArrayList<Drzewa> drzewa = new ArrayList<>();
        skanner.nextLine();
        while (liczbaBlokow != 0) {
            sciezkaDoTla = skanner.nextLine();
            int liczbaBlokowZiemi = skanner.nextInt();
            skanner.nextLine();
            while (liczbaBlokowZiemi != 0) {
                sciezkaDoBloku = skanner.nextLine().split("/");
                bloki.add(new BlokZiemi(Integer.parseInt(sciezkaDoBloku[0]),
                        Integer.parseInt(sciezkaDoBloku[1]),
                        Integer.parseInt(sciezkaDoBloku[2]),
                        Integer.parseInt(sciezkaDoBloku[3]),
                        sciezkaDoBloku[4] + ".png"));
                liczbaBlokowZiemi--;
            }
            int liczbaDrzew = skanner.nextInt();
            skanner.nextLine();
            while (liczbaDrzew != 0) {
                sciezkaDoBloku = skanner.nextLine().split("/");
                System.out.println(sciezkaDoBloku[0]);
                drzewa.add(new Drzewa(Integer.parseInt(sciezkaDoBloku[0]),
                        Integer.parseInt(sciezkaDoBloku[1]),
                        Integer.parseInt(sciezkaDoBloku[2]),
                        Integer.parseInt(sciezkaDoBloku[3]),
                        sciezkaDoBloku[4] + ".png"));
                liczbaDrzew--;
            }
            BlokiMapy blok = new BlokiMapy(bloki, drzewa);
            bloki.clear();
            drzewa.clear();
            int liczbaPostaci = skanner.nextInt();
            skanner.nextLine();
            while (liczbaPostaci != 0) {
                String temp = skanner.nextLine();
                String [] postac = temp.split("/");

                int X = Integer.parseInt(postac[1]);
                int Y = Integer.parseInt(postac[2]);
                int szerokoscP = Integer.parseInt(postac[3]);
                int wysokoscP = Integer.parseInt(postac[4]);
                switch (postac[0]) {
                    case "MainChamp": {
                        blok.postacie.add(new MainChamp(X,Y,szerokoscP,wysokoscP));
                        break;
                    }
                    case "Goblin": {
                        blok.postacie.add(new Goblin(X,Y, szerokoscP, wysokoscP));
                        break;
                    }
                    case "Boss": {
                        blok.postacie.add(new Boss(X,Y, szerokoscP, wysokoscP));
                        break;
                    }
                }
                liczbaPostaci--;
            }
            liczbaBlokow--;
            try {
                blok.tlo = ImageIO.read(new File(sciezkaDoTla + ".png"));
            } catch (Exception e) {
                System.out.println("Bloki mapy layout: " + e);
            }
            mapaBlokow.add(blok);
        }
    }
}
