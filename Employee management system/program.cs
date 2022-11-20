using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal interface IPrintable
    {
        void PrintDetails();
    }
    public class Manager : IPrintable
    {
        private double _Petrol;
        private double _Food;
        private double _Others;
        private double sal;
        private double Gross;
        private double Netsal;

        public Manager(double Esalary)
        {
            sal = Esalary;
        }
        public void Foodie()
        {
            _Food = sal * 0.13;
        }
        public void Petrol()
        {
            _Petrol = sal * 0.08;
        }
        public void Others()
        {
            _Others = sal * 0.03;

        }
        public void GrossSalary()
        {
            Gross = sal + _Food + _Petrol + _Others;

        }
        public void CalculateSalary()
        {
            Pf = (Gross * 0.10);
            TDS = (Gross * 0.18);
            Netsal = Gross - (Pf + TDS);

        }
        private double Pf, TDS;

        public void PrintDetails()
        {
            Console.WriteLine("Emp Petrol Allowances:{0}", _Petrol);
            Console.WriteLine("Emp Food Allowances:{0}", _Food);
            Console.WriteLine("Emp Petrol Allowances:{0}", _Others);
            Console.WriteLine("Emp Gross Salary with Allowances:{0}", Gross);
            Console.WriteLine("Emp Net Salary:{0}", Netsal);
        }

    }
    public class MarketingExecutive : IPrintable
    {
        private double _sal;
        private double _KM;
        private double _TourAllowances;
        private double _TelephoneAllowances;
        private double _Netsal, _Pf, _TDS, _Gross;
        public MarketingExecutive(double Esal)
        {
            this._sal = Esal;
        }
        public void Grosssalary()
        {
            Console.Write("Enter the Total Kilometers Covered:");
            _KM = Convert.ToDouble(Console.ReadLine());
            _TourAllowances = 5 * _KM;
            _TelephoneAllowances = 1000;
            _Gross = _sal + _TourAllowances + _TelephoneAllowances;
        }

        public void CalculateSalary()
        {
            _Pf = (_Gross * 0.10);
            _TDS = (_Gross * 0.18);
            _Netsal = _Gross - (_Pf + _TDS);

        }
        public void PrintDetails()
        {
            Console.WriteLine("Emp Travel Allowances:{0}", _TourAllowances);
            Console.WriteLine("Emp Telephone Allowances:{0}", _TelephoneAllowances);
            Console.WriteLine("Emp Gross salary with  Allowances:{0}", _Gross);
            Console.WriteLine("Emp Net Salary :{0}", _Netsal);
        }

    }
    public class Employee
    {


        public static void Main()
        {
            Console.Write("Enter the salary of an Employee to find Food ,Petrol,Other Allowances :");
            Manager m = new Manager(Convert.ToDouble(Console.ReadLine()));

            m.Foodie();
            m.Petrol();
            m.Others();

            m.GrossSalary();
            m.CalculateSalary();
            m.PrintDetails();

            Console.Write("Enter the salary of an Employee to find Tele and Tour Allowances:");

            MarketingExecutive me = new MarketingExecutive(Convert.ToDouble(Console.ReadLine()));
            me.Grosssalary();
            me.CalculateSalary();
            me.PrintDetails();


        }

    }
}


