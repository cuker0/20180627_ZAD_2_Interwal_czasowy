using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180627_ZAD_2_Interwal_czasowy

/*
Napisz klasę reprezentującą interwał (odcinek) czasu, spełniającą poniższe wymagania:
1.	Dokładność - 1 sekunda Tu chyba wszystko jasne
2.	Można ustawić i pobrać całkowitą liczbę sekund, minut i godzin
Przykład: ustawiam całkowitą liczbę minut na 2,25 i zaraz po tym pobieram całowitą liczbę sekund, która powinna w tym wypadku wynosić 135 oraz godzin 0,0375. Czyli całkowita liczba min i godzin jest liczbą zmiennoprzecinkową. 135 sek == 2,25 min == 0,0375 h
3.	Można pobrać liczbę godzin, minut i sekund
W tym wypadku pobierane są poszczególe składkni rerezentujące czas. Jeśli ustawimy całkowitą liczbę sekund z punktu 2 na 4000 to mamy 1h 6min i 40sek. Tutaj wszytskie składniki są całkowitoliczbowe. 3 metody lub 3 właściwości.
4.	Można ustawić odcinek czasu podając liczbę godzin, minut i sekund
Metoda z 3 parametrami pozwalająca na ustawienie odcina czasu zgodnie z jej parametrami. Tutaj parametry również są całkowitoliczbowe jak w pkt. 3.
5.	Do obecnego interwału można dodać:
a.	sekundy
b.	minuty 
c.	godziny 
d.	odcinek czasu podany w godzinach, minutach i sekundach 4 metody a) dodaje sekundy do obecnego interwału (odcinka) czasu, b) dodaje minuty, c) dodaje godziny, d) jak w pkt 4 tylko nie ustawiamy a dodajemy. Wszystkie parametry tutaj są całkowitoliczbowe.
 */

{
    class Program
    {
        static void Main(string[] args)
        {
            TimeInterval time1 = new TimeInterval();

            MAIN_FUNCTION: // Label w przypadku wpisania blednego numeru funkcji

            Console.WriteLine("Interwał czasowy. Wybierz interesujące zadanie \n\r" +
                " [1] - Konwertek czasu z minut na sekundy i godziny \n\r" +
                " [2] - Z podanego czasu w sekundach podaje czas z podzialem h,m,s \n\r" +
                " [3] - Ustanowienie odcinka czasu podajac liczbe godzin, minut sekund \n\r" +
                " [4] - Dodanie do wczesniejszego interwalu czasowego godzin,minut lub sekund \n\r" +
                " [9] - Wyjście");

            Console.Write("Wybór: ");
            string wybor = Console.ReadLine();

         {
                switch (int.Parse(wybor))
                {
                    
                    case 1: //Konwertek czasu z minut na sekundy i godziny
                        Console.Write("Wybor 1 \n\r Podaj liczbę minut: ");
                        string lmin = Console.ReadLine();  // podajemy czas w minutach -> zamienia na sek i hour zmiennoprzecinkowo
                        Console.WriteLine("Liczba sekund {0}, liczba minut {1}, liczba godzin {2}.\n\n\rNaciśnij dowolny klawisz", time1.PT1_MIN2SEC(double.Parse(lmin)), lmin, time1.PT1_MIN2HOUR(double.Parse(lmin)));
                        Console.ReadKey();
                        Console.Clear();

                        goto MAIN_FUNCTION;

                    case 2: //Z podanego czasu w sekundach podaje czas z podzialem h,m,s

                        
                        Console.Write("Wybor 2 \n\n\r Podaj całkowitą liczbę odcinka: ");
                        string lsek = Console.ReadLine();
                        time1.PT2_SEC2HOURMINSEC(int.Parse(lsek)); // dzieli podany czas (interwal) na hour,min,sec
                        Console.WriteLine("Ustawiony czas to h:{0} m:{1} s:{2}.\n\n\rNaciśnij dowolny klawisz", time1.PT2_SEC2HOUR(), time1.PT2_SEC2MIN(),time1.PT2_SEC2SEC());
                        Console.ReadKey();
                        Console.Clear();

                        goto MAIN_FUNCTION;

                    case 3: //po podaniu sek,min,godz ustanawia odcinek 
                        
                        Console.Write("Wybor 3 \n\n\rPodaj sekundy: ");
                        string lsek1 = Console.ReadLine();
                        Console.Write("Podaj minuty: ");
                        string lmin1 = Console.ReadLine();
                        Console.Write("Podaj godziny: ");
                        string lhour1 = Console.ReadLine();
                       
                        Console.WriteLine("Dla podanego czasu odcinek ma wartość: {0}.\n\n\rNaciśnij dowolny klawisz", time1.PT3_TIME2SEC(int.Parse(lsek1), int.Parse(lmin1), int.Parse(lhour1)));
                        Console.ReadKey();
                        Console.Clear();
                        goto MAIN_FUNCTION;
                       
                    case 4: //do istniejacego interwalu mozna dodac sek,min,godz
                        goto SUBMENU;
                       
                       

                    case 9:
                        Console.WriteLine("\n\rGood bye!");
                    break;

                    default: //W przypadku blednego wybrania ponowne sprawdzenie warunku
                        Console.Write("Nieznany numer zadania. Spróbuj jeszcze raz");
                        Console.ReadKey();
                        Console.Clear();
                        goto MAIN_FUNCTION;
                }
                SUBMENU:

                Console.WriteLine("Do obecnego interwału, który wynosi {0} dodaj \n\r" +
                           " [1] - sekundy \n\r" +
                           " [2] - minuty \n\r" +
                           " [3] - godziny \n\r" +
                           " [4] - godziny, minuty, sekundy", time1.TotalTime);

                string addchoose = Console.ReadLine();
                switch (int.Parse(addchoose))
                {
                    case 1:
                        
                        Console.Write("Podaj czas w sekundach: ");
                        time1.PT4_ADDSEC(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Interwał po zmianie wynosi: {0}", time1.TotalTime);
                        Console.ReadKey();
                        Console.Clear();
                        goto MAIN_FUNCTION;
                    case 2:
                        Console.Write("Podaj czas w minutach: ");
                        time1.PT4_ADDMIN(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Interwał po zmianie wynosi: {0}", time1.TotalTime);
                        Console.ReadKey();
                        Console.Clear();
                        goto MAIN_FUNCTION;
                    case 3:
                        Console.Write("Podaj czas w godzinach: ");
                        time1.PT4_ADDHOUR(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Interwał po zmianie wynosi: {0}", time1.TotalTime);
                        Console.ReadKey();
                        Console.Clear();
                        goto MAIN_FUNCTION;
                    case 4:
                        
                        Console.Write("Wybor 3 \n\n\rPodaj sekundy: ");
                        string lsek2 = Console.ReadLine();
                        Console.Write("Podaj minuty: ");
                        string lmin2 = Console.ReadLine();
                        Console.Write("Podaj godziny: ");
                        string lhour2 = Console.ReadLine();
                        time1.PT4_ADDTIME(int.Parse(lsek2), int.Parse(lmin2), int.Parse(lhour2));
                        Console.WriteLine("Interwał po zmianie wynosi: {0}", time1.TotalTime);
                        Console.ReadKey();
                        Console.Clear();
                        goto MAIN_FUNCTION;
                }
      
        }
    }

    public class TimeInterval

    {
        public int TotalTime;
        private double min2sec;
        private double min2hour;
        private int hour;
        private int min;
        private int sec;
        private int hour_reszta;
        
        public double PT1_MIN2SEC(double PT1_MIN)
        {
            min2sec = PT1_MIN * 60;
            return min2sec;
        }
        
        public double PT1_MIN2HOUR(double PT1_MIN)
        {
            min2hour = PT1_MIN / 3600;
            return min2hour;
        }   
            
        public void PT2_SEC2HOURMINSEC(int PT2_SEC)
        {
            hour_reszta = (PT2_SEC % 3600);
            hour = (PT2_SEC - hour_reszta) / 3600;
            min = (hour_reszta - sec) / 60;
            sec = hour_reszta % 60;
        }
            public int PT2_SEC2SEC ()
            {
                return sec;
            }

            public int PT2_SEC2MIN ()
            {
                return min;
            }

            public int PT2_SEC2HOUR ()
            {
                return hour;
            }

        public int PT3_TIME2SEC (int PT3_SEC, int PT3_MIN, int PT3_HOUR)

        {
             TotalTime= PT3_SEC + PT3_MIN * 60 + PT3_HOUR * 3600;
                return TotalTime;
      
        }
            

        public int PT4_ADDSEC (int PT4_SEC)
        {
          return  PT3_TIME2SEC(TotalTime + PT4_SEC,0,0);
                   
        }

        public int PT4_ADDMIN (int PT4_MIN)
        {
          return  PT3_TIME2SEC(TotalTime, PT4_MIN, 0);
        }

        public int PT4_ADDHOUR (int PT4_HOUR)
        {
           return PT3_TIME2SEC(TotalTime, 0, PT4_HOUR);
        }
        public int PT4_ADDTIME (int PT4_SEC,int PT4_MIN,int PT4_HOUR)
        {
           return PT3_TIME2SEC(TotalTime+PT4_SEC, PT4_MIN, PT4_HOUR);
        }
       


        }
     }
        
        
    }

