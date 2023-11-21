using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSharp_Opgaver
{
    internal class SubMenus
    {
        public static void Variables()
        {
            string name = "Variables";

            string[] options = {
                "\t1. Task 1 \t Desc: Grundlæggende variabler og udskrivning",
                "\t2. Task 2 \t Desc: Udvidelse af variabeludskrivning",
                "\t3. Task 3 \t Desc: Kompleks variabeludskrivning",
                "\t4. Task 4 \t Desc: Brug af decimaltal og samlet udskrivning",
                "\t5. Task 5 \t Desc: Brugerinput og sammensat tekst",
                "\t6. Task 6 \t Desc: Beregning af cirkelareal med brugerinput"
            };

            Action[] cases = {
                () => {
                    Console.WriteLine("1");
                    Console.ReadKey();
                }
            };

            Menu.build(name, options, cases);
        }

        public static void Strings()
        {
            string name = "Strings";

            string[] options = {
                "\t1. Task 1 \t Desc: Erklæring og Udskrivning af Variabletyper",
                "\t2. Task 2 \t Desc: Ændring af Variabelværdi",
                "\t3. Task 3 \t Desc: Erklæring og Udskrivning af String Variabel",
                "\t4. Task 4 \t Desc: Sætningsopbygning med Variable"
            };

            Action[] cases =
            {
                () => Console.WriteLine("1"),
            };

            Menu.build(name, options, cases);
        }

        public static void Menu3()
        {

        }
        
        public static void Menu4()
        {

        }

        public static void Menu5()
        {

        }

        public static void Menu6()
        {

        }

        public static void Menu7()
        {

        }
    }
}
