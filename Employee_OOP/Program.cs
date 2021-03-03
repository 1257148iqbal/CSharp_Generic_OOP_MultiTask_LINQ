using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_OOP
{
    public enum DesignationEnum { GM=1, DGM, AGM, SM, Manager, Assistant}

    interface IRoles
    {
        List<string> RpInterfaceMethod();
    }

   abstract class Person    //It's possible to Inherite but not possible create Object 
    {
        int id;
        string name;

        public Person()
        {
            Console.Write("ID:  ");
            this.id = Int32.Parse(Console.ReadLine());
            Console.Write("Name:  ");
            this.name = Console.ReadLine();
        }

        public int GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }
    }

    sealed class Employee: Person, IRoles   //It's not possible to Inherite but not possible to create Object
    {
        private string _designation;
        private DateTime _birthDate;
        private DateTime _joinDate;
        public List<string> RpArray = new List<string>();

        public DateTime BirthDate
        {
            get
            {
                return _birthDate;
            }
            set
            {
                this._birthDate = value;
            }
        }
        public DateTime JoiningDate
        {
            get
            {
                return _joinDate;
            }
            set
            {
                this._joinDate = value;
            }
        }
        public string DesignationProperty
        {
            get
            {
                return _designation;
            }
            set
            {
                this._designation = value;
            }
        }


        public List<string> RpInterfaceMethod()
        {
            return RpArray;
        }

        public Employee()
        {
            Console.Write("Birth Date:  ");
            BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Joining Date:  "); 
            JoiningDate = Convert.ToDateTime(Console.ReadLine());
        }

        public DateTime GetBirthDate()
        {
            return this._birthDate;
        }
        public DateTime GetJoinDate()
        {
            return this._joinDate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========Input===========");

            Employee employee = new Employee();

            Console.WriteLine("You have the following designation: ");
            for (int i = 1; i <= Enum.GetValues(typeof(DesignationEnum)).Length; i++)
            {
                Console.Write(i + ". ");
                for (int j = i; j <= Enum.GetValues(typeof(DesignationEnum)).Length;)
                {
                    DesignationEnum des = (DesignationEnum)j;
                    Console.WriteLine(des);
                    break;
                }
            }

            Console.Write("Type any of the serial number of desingation mensioned above: ");
            int designation = Int32.Parse(Console.ReadLine());
            employee.DesignationProperty = Convert.ToString((DesignationEnum)designation);

            Console.WriteLine("Enter 'STOP' to stop role plays. ");
            Console.WriteLine("Role Play: ");
            bool isRoleContinue = true;
            int roleCounter = 0;
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
                    employee.RpInterfaceMethod().Add(userInput);
                    roleCounter++;
                }
            }
            while (isRoleContinue);

            Console.WriteLine("==========Output===========");
            Console.WriteLine($"ID: {employee.GetID()}");
            Console.WriteLine($"Name: {employee.GetName()}");
            Console.WriteLine($"Designation: {employee.DesignationProperty}");
            Console.WriteLine($"Birth Date: {employee.GetBirthDate().ToLongDateString()}");
            Console.WriteLine($"Join Date: {employee.GetJoinDate().ToLongDateString()}");
            Console.WriteLine($"Roles Play: {string.Join(", ", employee.RpArray)}");


        }
    }
}
