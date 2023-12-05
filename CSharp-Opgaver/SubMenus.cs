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
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
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
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            // Array of actions to be called
            Action[] cases = {
                () => if_else_ttatements_tasks.Task1(),
                () => if_else_ttatements_tasks.Task2(),
                () => if_else_ttatements_tasks.Task3(),
                () => if_else_ttatements_tasks.Task4(),
                () => if_else_ttatements_tasks.Task5(),
                () => if_else_ttatements_tasks.Task6()
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
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
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
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
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
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
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
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
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
            // Name of submenu
            string name = "Return types and parameters";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            // Array of actions to be called
            Action[] cases = {
                () => {},
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Instance_variables()
        {
            // Name of submenu
            string name = "Instance Variables";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            // Array of actions to be called
            Action[] cases = {
                () => {},
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }

        public static void Inheritance()
        {
            // Name of submenu
            string name = "Inheritance";

            // Options to be displayed
            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            // Array of actions to be calledddd
            Action[] cases = {
                () => {},
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
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
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
                () => arrays_tasks.Task1(),
            };

            // Build submenu
            Menu.buildSub(name, options, cases);
        }
    }
}
