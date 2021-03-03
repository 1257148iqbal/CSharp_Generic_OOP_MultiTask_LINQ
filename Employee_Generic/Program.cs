using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Generic
{
    enum Designation { GM = 1, DGM, AGM, SM, Manager, Assistant }
    interface IRolePlays<T>
    {
        List<T> RpInterfaceMethod();
    }

    abstract class Person<T>
    {
        public T ID { get; set; }
        public T Name { get; set; }
    }

    sealed class Employee<T>: Person<T>, IRolePlays<T>
    {

        public T Designation { get; set; }
        public T DateOfBirth { get; set; }
        public T JoinDate { get; set; }
        public List<T> RpArray = new List<T>();
        public List<T> RpInterfaceMethod()
        {
            return RpArray;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> id = new Employee<int>();
            Console.Write("ID       : ");
            id.ID = Convert.ToInt32(Console.ReadLine());

            Employee<string> Na = new Employee<string>();
            Console.Write("Name       : ");
            Na.Name= Convert.ToString(Console.ReadLine());

            Employee<Designation> de = new Employee<Designation>();
            Console.WriteLine();

            Console.WriteLine("\t 1 . " + Designation.GM);
            Console.WriteLine("\t 2 . " + Designation.DGM);
            Console.WriteLine("\t 3 . " + Designation.AGM);
            Console.WriteLine("\t 4 . " + Designation.SM);
            Console.WriteLine("\t 5 . " + Designation.Manager);
            Console.WriteLine("\t 6 . " + Designation.Assistant);
            Console.WriteLine("Please Input for Designation 1/2/3/4/5/6");
            Console.WriteLine("Designation  : ");
            de.Designation = (Designation)Convert.ToInt32(Console.ReadLine());

            Employee<DateTime> DB = new Employee<DateTime>();
            Console.Write("Date Of Birth : ");
            DB.DateOfBirth = Convert.ToDateTime(Console.ReadLine());

            Employee<DateTime> JD = new Employee<DateTime>();
            Console.Write("Join Date  : ");
            JD.JoinDate = Convert.ToDateTime(Console.ReadLine());

            Employee<string> RP = new Employee<string>();
            Console.WriteLine("Enter 'STOP' To stop role plays:");
            Console.WriteLine("Role Play     : ");
            bool isRoleContinue = true;
            int rolecounter = 0;
            do
            {
                string userInput = " ";
                userInput = Console.ReadLine();
                if (userInput.ToUpper() == "STOP")
                {
                    isRoleContinue = false;
                }
                else
                {
                    RP.RpInterfaceMethod().Add(userInput);
                    rolecounter++;
                }
            }
            while (isRoleContinue);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("At a Glance Employee Information :-");
            Console.WriteLine();
            Console.WriteLine("Employee ID    =>  " + id.ID);
            Console.WriteLine("Empolyee Name  =>  " + Na.Name);
            Console.WriteLine("Designation    =>  " + de.Designation);
            Console.WriteLine("Date of Birth  =>  " + DB.DateOfBirth.ToLongDateString());
            Console.WriteLine("Joining Date   =>  " + JD.JoinDate.ToLongDateString());
            Console.WriteLine("Role Play      =>  " + String.Join(",", RP.RpArray));

        }
    }
}
