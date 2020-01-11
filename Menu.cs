using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypov1
{
   public class Menu
    {

        enum Admin
        {
            dodaj_samochód = 1,
            usuń_samochód,
            lista_aut,
            dodaj_klienta,
            usuń_klienta,
            lista_pracowników,
            dodaj_wypożyczenie,
            anuluj_wypożyczenie,
            zmodyfikuj_wypozyczenie,
            dodaj_pracownika,
            usuń_pracownika,
            licencja_programu,
            statystyka,
            wyloguj
        };

        enum User
        {
            dodaj_klienta = 1,
            dodaj_samochód,
            lista_aut,
            dodaj_wypozyczenie,
            anuluj_wypozyczenie,
            zmodyfikuj_wypożyczenie,
            wyloguj
        };

        public void menuAdmina()
        {
            bool k = true;
            while (k)
            {
                Console.Clear();

                Console.WriteLine("Admin:");

                int i = 1;

                foreach (Admin admin in (Admin[])Enum.GetValues(typeof(Admin)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(admin.ToString().Replace('_', ' ')));
                }

                bool exit = true;

                Admin start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');


                bool AdminConfirmed = Enum.TryParse<Admin>(choosenOption, out start);

                if (!AdminConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }

                switch (start)
                {
                    case Admin.dodaj_samochód:
                        add_car dodaj = new add_car("", "", 0, 0, "", "", true);
                        dodaj.AddCarList();
                       

                        break;
                    case Admin.usuń_samochód:
                        break;
                    case Admin.lista_aut:
                        
                        break;
                    case Admin.dodaj_klienta:
                        break;
                    case Admin.usuń_klienta:
                        break;
                    case Admin.lista_pracowników:
                        break;
                    case Admin.dodaj_wypożyczenie:
                        break;
                    case Admin.anuluj_wypożyczenie:
                        break;
                    case Admin.zmodyfikuj_wypozyczenie:
                        break;
                    case Admin.dodaj_pracownika:
                        //addEmployee add = new addEmployee();
                        //add.Adiing();
                        break;
                    case Admin.usuń_pracownika:
                        //deleteEmployee delte = new deleteEmployee();
                        //delte.Delete();
                        break;
                    case Admin.licencja_programu:
                        break;
                    case Admin.statystyka:
                        break;
                    case Admin.wyloguj:

                        k = false;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void menuUsera()
        {
            bool k = true;
            while (k)
            {
                Console.Clear();

                Console.WriteLine("User:");

                int i = 1;

                foreach (User admin in (User[])Enum.GetValues(typeof(User)))
                {
                    Console.Write($"[{i++}]. ");
                    Console.WriteLine(String.Concat(admin.ToString().Replace('_', ' ')));
                }

                bool exit = true;

                User start;
                string choosenOption = Console.ReadLine().Replace(' ', '_');


                bool AdminConfirmed = Enum.TryParse<User>(choosenOption, out start);

                if (!AdminConfirmed)
                {
                    Console.WriteLine("Wybrałeś niepoprawną opcję");
                }

                switch (start)
                {
                    case User.dodaj_klienta:
                        break;
                    case User.dodaj_samochód:
                        break;
                    case User.lista_aut:
                        break;
                    case User.dodaj_wypozyczenie:
                        break;
                    case User.anuluj_wypozyczenie:
                        break;
                    case User.zmodyfikuj_wypożyczenie:
                        break;
                    case User.wyloguj:
                        k = false;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

            }
        }

    }
}
