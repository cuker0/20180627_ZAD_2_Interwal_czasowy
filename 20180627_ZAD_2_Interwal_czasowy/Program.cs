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

            //    Console.Write("Podaj liczbe minut: ");
            //    string strMinAppTime = Console.ReadLine();
            //    double doubleMinAppTime = double.Parse(strMinAppTime);
            //    time1.pt1_MinTotalTime = doubleMinAppTime;
            time1.PT1_MIN2SEC(2.25);
            time1.PT1_MIN2HOUR(2.25);
            time1.PT2_SEC2HOUR(8000);
            time1.PT2_SEC2MIN(8000);
            time1.PT3_TIME2SEC(100, 666, 2);
            Console.ReadKey();
        }
    }

    public class TimeInterval
    {
        public double PT1_MIN2SEC (double PT1_MIN)
        {
            double pt1_min2sec = PT1_MIN * 60;
            return pt1_min2sec;
        }
        public double PT1_MIN2HOUR (double PT1_MIN)
        {
            double pt1_min2hour = PT1_MIN / 3600;
            return pt1_min2hour;
        }

        public int PT2_SEC2HOUR (int PT2_SEC)
        {
            int hour_reszta = (PT2_SEC % 3600);
            int hour = (PT2_SEC - hour_reszta) / 3600;
            return hour;
        }
        public int PT2_SEC2MIN(int PT2_SEC)
        {
            int min_reszta_hour = (PT2_SEC % 3600);
            int min_reszta_min = (PT2_SEC - min_reszta_hour) / 3600;
            int min = (min_reszta_hour - min_reszta_min) / 60;
            return min;
        }
        public int PT3_TIME2SEC (int PT3_SEC, int PT3_MIN, int PT3_HOUR)
        {
            int totaltime = PT3_SEC + PT3_MIN * 60 + PT3_HOUR * 3600;
                return totaltime;
        }
    }
        
        
    }

