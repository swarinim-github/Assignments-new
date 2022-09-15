using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class EmployeeDetails
    {
        private int empNo;
        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }
        private string empName;
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private double hRA;
        public double HRA
        {
            get { return hRA; }
            set { hRA = value; }
        }
        private double tA;
        public double TA
        {
            get { return tA; }
            set { tA = value; }
        }
        private double dA;
        public double DA
        {
            get { return dA; }
            set { dA = value; }
        }
        private double pF;
        public double PF
        {
            get { return pF; }
            set { pF = value; }
        }
        private double tDS;
        public double TDS
        {
            get { return tDS; }
            set { tDS = value; }
        }
        private double netSalary;
        public double NetSalary
        {
            get { return netSalary; }
            set { netSalary = value; }
        }
        private double grossSalary;
        public double GrossSalary
        {
            get { return grossSalary; }
            set { grossSalary = value; }
        }

    }
    public class EmployeeManagement : EmployeeDetails
    {

        static void Main(string[] args)
        {
            EmployeeDetails employee = new EmployeeDetails();
            Display(employee);
            CalculateSalary(employee);
            Console.ReadLine();
        }

 

        static void Display(EmployeeDetails employee)
        {
            Console.Write("Employee Number :");
            employee.EmpNo = int.Parse(Console.ReadLine());

            Console.Write("Employee Name :");
            employee.EmpName = Console.ReadLine();
            Console.Write("Enter Your Salary");
            employee.Salary = int.Parse(Console.ReadLine());
            

            if (employee.Salary >= 20000)
            {
                employee.HRA = (employee.Salary * 30) / 100;
                employee.TA = (employee.Salary * 25) / 100;
                employee.DA = (employee.Salary * 35) / 100;
            }
            else if (employee.Salary < 20000 && employee.Salary > 15000)
            {
                employee.HRA = (employee.Salary * 25) / 100;
                employee.TA = (employee.Salary * 20) / 100;
                employee.DA = (employee.Salary * 30) / 100;
            }
            else if (employee.Salary < 15000 && employee.Salary > 10000)
            {
                employee.HRA = (employee.Salary * 20) / 100;
                employee.TA = (employee.Salary * 15) / 100;
                employee.DA = (employee.Salary * 25) / 100;
            }
            else if (employee.Salary < 10000 && employee.Salary > 5000)
            {
                employee.HRA = (employee.Salary * 15) / 100;
                employee.TA = (employee.Salary * 10) / 100;
                employee.DA = (employee.Salary * 20) / 100;
            }
            else
            {
                employee.HRA = (employee.Salary * 10) / 100;
                employee.TA = (employee.Salary * 5) / 100;
                employee.DA = (employee.Salary * 15) / 100;

            }

            employee.GrossSalary = employee.Salary + employee.HRA + employee.TA + employee.DA;

            Console.WriteLine("Gross Salary = " + employee.GrossSalary);


        }
            static void CalculateSalary(EmployeeDetails employee)
        {


            employee.PF = (employee.GrossSalary * 10) / 100;
            employee.TDS = (employee.GrossSalary * 18) / 100;
            employee.NetSalary = employee.GrossSalary - (employee.PF + employee.TDS);
            Console.WriteLine("Net Salary = " + employee.NetSalary);

        }

    }
}
