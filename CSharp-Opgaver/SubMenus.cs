using CSharp_Opgaver.tasks.Constructors;
using CSharp_Opgaver.tasks.Arithmetic_expressions;
using CSharp_Opgaver.tasks.Arrays;
using CSharp_Opgaver.tasks.Boolean_variables;
using CSharp_Opgaver.tasks.Extended_control_structures;
using CSharp_Opgaver.tasks.If_else_statements;
using CSharp_Opgaver.tasks.Loops;
using CSharp_Opgaver.tasks.Methods_and_instances;
using CSharp_Opgaver.tasks.Strings;
using CSharp_Opgaver.tasks.Switch_Case;
using CSharp_Opgaver.tasks.Variable_expressions;
using CSharp_Opgaver.tasks.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CSharp_Opgaver.tasks.Return_types_and_parameters;
using CSharp_Opgaver.tasks.Instance_variables;
using CSharp_Opgaver.tasks.Inheritance;

namespace CSharp_Opgaver
{
    internal class SubMenus
    {
        // Submenus
        public static void Variables()
        {
            // Create instance of Variables_Tasks
            Variables_Tasks variables_tasks = new Variables_Tasks();

            // Name of submenu
            string name = "Variables";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Grundlæggende variabler og udskrivning",
                "2. Task 2 \t Desc: Udvidelse af variabeludskrivning",
                "3. Task 3 \t Desc: Kompleks variabeludskrivning",
                "4. Task 4 \t Desc: Brug af decimaltal og samlet udskrivning",
                "5. Task 5 \t Desc: Brugerinput og sammensat tekst",
                "6. Task 6 \t Desc: Beregning af cirkelareal med brugerinput"
            };

            // Array of actions to be called
            Action[] cases = {
                () => variables_tasks.Task1(),
                () => variables_tasks.Task2(),
                () => variables_tasks.Task3(),
                () => variables_tasks.Task4(),
                () => variables_tasks.Task5(),
                () => variables_tasks.Task6()
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Strings()
        {
            // Create instance of Strings_Tasks
            Strings_Tasks strings_tasks = new Strings_Tasks();

            // Name of submenu
            string name = "Strings";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Erklæring og Udskrivning af Variabletyper",
                "2. Task 2 \t Desc: Ændring af Variabelværdi",
                "3. Task 3 \t Desc: Erklæring og Udskrivning af String Variabel",
                "4. Task 4 \t Desc: Sætningsopbygning med Variable"
            };

            // Array of actions to be called
            Action[] cases =
            {
                () => strings_tasks.Task1(),
                () => strings_tasks.Task2(),
                () => strings_tasks.Task3(),
                () => strings_tasks.Task4()
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Arithmetic_expressions()
        {
            // Create instance of Arithmetic_expressions_Tasks
            Arithmetic_expressions_Tasks arithmetic_expressions_tasks = new Arithmetic_expressions_Tasks();

            // Name of submenu
            string name = "Arithmetic Expressions";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Matematiske Udtryk og Programmering",
            };

            // Array of actions to be called
            Action[] cases = {
                () => arithmetic_expressions_tasks.Task1()
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }
        
        public static void Variable_expressions()
        {
            // Create instance of Variable_expressions_Tasks
            Variable_expressions_Tasks variable_expressions_tasks = new Variable_expressions_Tasks();

            // Name of submenu
            string name = "Variable Expressions";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            // Array of actions to be called
            Action[] cases = {
                () => variable_expressions_tasks.Task1(),
                () => variable_expressions_tasks.Task2()
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Boolean_variables()
        {
            // Create instance of Boolean_variables_Tasks
            Boolean_variables_Tasks boolean_variables_tasks = new Boolean_variables_Tasks();

            // Name of submenu
            string name = "Boolean Variables";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Erklær to int variabler og tildel dem en værdi. Erklær en boolean variabel",
            };

            // Array of actions to be called
            Action[] cases = {
                () => boolean_variables_tasks.Task1(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void if_else_statements()
        {
            // Create instance of if_else_statements_Tasks
            If_else_statements_Tasks if_else_ttatements_tasks = new If_else_statements_Tasks();

            // Name of submenu
            string name = "if-else Statements";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Erklær tal1 og tal2 som int og tildel dem værdierne 42 og 64. Udskriv passende besked baseret på summen",
                "2. Task 2 \t Desc: Bed brugeren om alder. Udskriv 'Du er for gammel.' hvis alderen er over 57; ellers 'Du er ikke for gammel",
                "3. Task 3 \t Desc: Spørg om alder og udskriv passende besked",
                "4. Task 4 \t Desc: Bed om navn, brugernavn og password. Udskriv passende besked",
                "5. Task 5 \t Desc: Spørg først om brugernavn. Udskriv passende besked baseret på svar",
                "6. Task 6 \t Desc: Spørg brugeren om daglig kørselsafstand til og fra arbejde. Udskriv passende fradrag baseret på kørselsafstand",
                "7. Task 7 \t Desc: Spørg om farve og alder. Baggrundsfarve sættes og Clear. Hvis over 18, cocktailbar; ellers sodavandsbar",
            };

            // Array of actions to be called
            Action[] cases = {
                () => if_else_ttatements_tasks.Task1(),
                () => if_else_ttatements_tasks.Task2(),
                () => if_else_ttatements_tasks.Task3(),
                () => if_else_ttatements_tasks.Task4(),
                () => if_else_ttatements_tasks.Task5(),
                () => if_else_ttatements_tasks.Task6(),
                () => if_else_ttatements_tasks.Task7()
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Switch_Case()
        {
            // Create instance of Switch_Case_Tasks
            Switch_Case_Tasks switch_case_tasks = new Switch_Case_Tasks();

            // Name of submenu
            string name = "Switch Case";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Bed brugeren om et tal mellem 1 og 6",
                "2. Task 2 \t Desc: Lav en drinkmenu",
            };

            // Array of actions to be called
            Action[] cases = {
                () => switch_case_tasks.Task1(),
                () => switch_case_tasks.Task2(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Loops()
        {
            // Create instance of Loops_Tasks
            Loops_Tasks loops_tasks = new Loops_Tasks();

            // Name of submenu
            string name = "Loops";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Lav et program til at udskrive tal fra 1 til 10",
                "2. Task 2 \t Desc: Gør opgave 1 om, så den tæller fra 100 til 1 ved hjælp af både et while-loop og et for-loop",
                "3. Task 3 \t Desc: Lav et for-loop der udskriver den lille 5-tabel",
                "4. Task 4 \t Desc: Lav et while-loop og et for-loop, der udskriver talrækkefølgen: 20-0",
                "5. Task 5 \t Desc: Lav et for-loop til at udskrive 7-tabellen",
                "6. Task 6 \t Desc: Udvid opgave 5, så brugeren selv indtaster hvilken tabel der skal udskrives",
                "7. Task 7 \t Desc: Lav et program til at tegne en ramme på skærmen",
                "8. Task 8 \t Desc: Udvid opgave 1, så den skriver dit navn i midten af rammen",
                "9. Task 9 \t Desc: Udvid opgave 2, så brugeren selv indtaster rammestørrelse og navnet",
            };

            // Array of actions to be called
            Action[] cases = {
                () => loops_tasks.Task1(),
                () => loops_tasks.Task2(),
                () => loops_tasks.Task3(),
                () => loops_tasks.Task4(),
                () => loops_tasks.Task5(),
                () => loops_tasks.Task6(),
                () => loops_tasks.Task7(),
                () => loops_tasks.Task8(),
                () => loops_tasks.Task9()
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Extended_control_structures()
        {
            // Create instance of Extended_control_structures_Tasks
            Extended_control_structures_Tasks extended_control_structures_tasks = new Extended_control_structures_Tasks();

            // Name of submenu
            string name = "Extended control structures";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Lav et for-loop der udskriver 3-tabellen",
                "2. Task 2 \t Desc: Lav et while-loop til at udskrive 4-tabellen med en if-sætning, der springer over tallet 16",
                "3. Task 3 \t Desc: Lav et program til at udregne befordringsfradrag",
                "4. Task 4 \t Desc: Lav et program til at bestemme skattens art baseret på indkomst",
                "5. Task 5 \t Desc: Lav et program til at beregne renten på en rentekonto i banken",
            };

            // Array of actions to be called
            Action[] cases = {
                () => extended_control_structures_tasks.Task1(),
                () => extended_control_structures_tasks.Task2(),
                () => extended_control_structures_tasks.Task3(),
                () => extended_control_structures_tasks.Task4(),
                () => extended_control_structures_tasks.Task5()
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Methods_and_instances()
        {
            // Create instance of Methods_and_instances_Tasks
            Methods_and_instances_Tasks methods_and_instances_tasks = new Methods_and_instances_Tasks();

            // Name of submenu
            string name = "Methods and instances";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Opret Bøger projekt, klasse Bog med PrintInfo metode",
                "2. Task 2 \t Desc: Opret en ny metode kaldet HarRåd i Bog klassen",
            };

            // Array of actions to be called
            Action[] cases = {
                () => methods_and_instances_tasks.Task1(),
                () => methods_and_instances_tasks.Task2(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Return_types_and_parameters()
        {
            // Create instance of Return_types_and_parameters
            Return_types_and_parameters return_types_and_parameters = new Return_types_and_parameters();

            // Name of submenu
            string name = "Return types and parameters";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Lav en klasse Bil med start- og slukmetoder",
                "2. Task 2 \t Desc: Tilføj FillGas metode til Bil og test fra Program",
                "3. Task 3 \t Desc: Tilføj bool-parameter til FillGas metoden",
                "4. Task 4 \t Desc: Opret RemainingGas metoden i Bil klassen",
            };

            // Array of actions to be called
            Action[] cases = {
                () => return_types_and_parameters.Task1(),
                () => return_types_and_parameters.Task2(),
                () => return_types_and_parameters.Task3(),
                () => return_types_and_parameters.Task4(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Instance_variables()
        {
            // Create instance of Instance_variables
            Instance_variables instance_variables_tasks = new Instance_variables();

            // Name of submenu
            string name = "Instance Variables";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Udvid Bog klassen med pris og titel variabler",
            };

            // Array of actions to be called
            Action[] cases = {
                () => instance_variables_tasks.Task1(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Inheritance()
        {
            // Create instance of Inheritance
            Inheritance inheritance_tasks = new Inheritance();

            // Name of submenu
            string name = "Inheritance";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Opret en Furniture klasse og dens subklasser Chair og Computer",
            };

            // Array of actions to be called
            Action[] cases = {
                () => inheritance_tasks.Task1(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Constructors()
        {
            // Create instance of Constructors_Tasks
            Constructors_Tasks constructors_tasks = new Constructors_Tasks();

            // Name of submenu
            string name = "Constructors";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Implementer konstruktører i Bog klassen",
            };

            // Array of actions to be called
            Action[] cases = {
                () => constructors_tasks.Task1(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Arrays()
        {
            // Create instance of Arrays_Tasks
            Arrays_Tasks arrays_tasks = new Arrays_Tasks();

            // Name of submenu
            string name = "Arrays";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Arbejde med Arrays",
            };

            // Array of actions to be called
            Action[] cases = {
                () => arrays_tasks.Task1(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Traversing_arrays()
        {
            // Create instance of Arrays_Tasks
            Arrays_Tasks arrays_tasks = new Arrays_Tasks();

            // Name of submenu
            string name = "Arrays";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Arbejde med et String og Numerisk Array og For-løkke",
            };

            // Array of actions to be called
            Action[] cases = {
                () => arrays_tasks.Task2(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }
    }
}
