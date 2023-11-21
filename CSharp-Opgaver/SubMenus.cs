using CSharp_Opgaver.tasks.Arithmetic_expressions;
using CSharp_Opgaver.tasks.Arrays;
using CSharp_Opgaver.tasks.Boolean_variables;
using CSharp_Opgaver.tasks.If_else_statements;
using CSharp_Opgaver.tasks.Loops;
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
        public static void Variables()
        {
            Variables_Tasks variables_tasks = new Variables_Tasks();

            string name = "Variables";

            string[] options = {
                "1. Task 1 \t Desc: Grundlæggende variabler og udskrivning",
                "2. Task 2 \t Desc: Udvidelse af variabeludskrivning",
                "3. Task 3 \t Desc: Kompleks variabeludskrivning",
                "4. Task 4 \t Desc: Brug af decimaltal og samlet udskrivning",
                "5. Task 5 \t Desc: Brugerinput og sammensat tekst",
                "6. Task 6 \t Desc: Beregning af cirkelareal med brugerinput"
            };

            Action[] cases = {
                () => variables_tasks.Task1(),
                () => variables_tasks.Task2(),
                () => variables_tasks.Task3(),
                () => variables_tasks.Task4(),
                () => variables_tasks.Task5(),
                () => variables_tasks.Task6()
            };

            Menu.buildSub(name, options, cases);
        }

        public static void Strings()
        {
            Strings_Tasks strings_tasks = new Strings_Tasks();

            string name = "Strings";

            string[] options = {
                "1. Task 1 \t Desc: Erklæring og Udskrivning af Variabletyper",
                "2. Task 2 \t Desc: Ændring af Variabelværdi",
                "3. Task 3 \t Desc: Erklæring og Udskrivning af String Variabel",
                "4. Task 4 \t Desc: Sætningsopbygning med Variable"
            };

            Action[] cases =
            {
                () => strings_tasks.Task1(),
                () => strings_tasks.Task2(),
                () => strings_tasks.Task3(),
                () => strings_tasks.Task4()
            };

            Menu.buildSub(name, options, cases);
        }

        public static void Arithmetic_expressions()
        {
            Arithmetic_expressions_Tasks arithmetic_expressions_tasks = new Arithmetic_expressions_Tasks();

            string name = "Arithmetic Expressions";

            string[] options = {
                "1. Task 1 \t Desc: Matematiske Udtryk og Programmering",
            };

            Action[] cases = {
                () => arithmetic_expressions_tasks.Task1()
            };

            Menu.buildSub(name, options, cases);
        }
        
        public static void Variable_expressions()
        {
            Variable_expressions_Tasks variable_expressions_tasks = new Variable_expressions_Tasks();

            string name = "Variable Expressions";

            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            Action[] cases = {
                () => variable_expressions_tasks.Task1(),
                () => variable_expressions_tasks.Task2()
            };

            Menu.buildSub(name, options, cases);
        }

        public static void Boolean_variables()
        {
            Boolean_variables_Tasks boolean_variables_tasks = new Boolean_variables_Tasks();

            string name = "Boolean Variables";

            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            Action[] cases = {
                () => boolean_variables_tasks.Task1(),
            };

            Menu.buildSub(name, options, cases);
        }

        public static void if_else_statements()
        {
            If_else_statements_Tasks if_else_ttatements_tasks = new If_else_statements_Tasks();

            string name = "if-else Statements";

            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            Action[] cases = {
                () => if_else_ttatements_tasks.Task1(),
                () => if_else_ttatements_tasks.Task2(),
                () => if_else_ttatements_tasks.Task3(),
                () => if_else_ttatements_tasks.Task4(),
                () => if_else_ttatements_tasks.Task5(),
                () => if_else_ttatements_tasks.Task6()
            };

            Menu.buildSub(name, options, cases);
        }

        public static void Switch_Case()
        {
            Switch_Case_Tasks switch_case_tasks = new Switch_Case_Tasks();

            string name = "Switch Case";

            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            Action[] cases = {
                () => switch_case_tasks.Task1(),
                () => switch_case_tasks.Task2(),
            };

            Menu.buildSub(name, options, cases);
        }

        public static void Loops()
        {
            Loops_Tasks loops_tasks = new Loops_Tasks();

            string name = "Loops";

            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

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

            Menu.buildSub(name, options, cases);
        }

        public static void Advanced_control_structures()
        {

        }

        public static void Methods_and_instances()
        {

        }

        public static void Return_types_and_parameters()
        {

        }

        public static void Instance_variables()
        {

        }

        public static void Inheritance()
        {

        }

        public static void Constructors()
        {

        }

        public static void Arrays()
        {
            Arrays_Tasks arrays_tasks = new Arrays_Tasks();

            string name = "Arrays";

            string[] options = {
                "1. Task 1 \t Desc: Enkel Operation med Int Variabler",
                "2. Task 2 \t Desc: Kompleks Operation med Tal og Variabelnavne",
            };

            Action[] cases = {
                () => arrays_tasks.Task1(),
            };

            Menu.buildSub(name, options, cases);
        }

        public static void Traversing_arrays()
        {

        }
    }
}
