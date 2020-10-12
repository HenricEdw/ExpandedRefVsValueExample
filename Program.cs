using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsRefTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Henric", Department.HR);
            //för värdetyper kan saker bli null
            //Jag vill hämta längden på namnet men har ännu inte gett namn ett värde
            //Finns olika sätt att kontrollera mot null
            
            //emp.Name = "Henric";

            EmployeeStruct empStruct = new EmployeeStruct();
            empStruct.Name = "Bertil";
            emp.Avdelning = Department.HR;
            Employee newEmp = emp;

            EmployeeStruct newEmpStruct = empStruct;

            ChangeEmp(newEmp);

            ChangeEmpStruct(newEmpStruct);

            Console.Read();
        }

        private static void ChangeEmpStruct(EmployeeStruct empStr)
        {
            empStr.Name = "Torild";
        }

        private static void ChangeEmp(Employee empInstance)
        {
            empInstance.Name = "Berit";
        }
    }
}
