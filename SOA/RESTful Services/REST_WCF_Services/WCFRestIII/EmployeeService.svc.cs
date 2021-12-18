/*
 * Serviços REST5 com todas as operações CRUD sobre um ficheiro
 * lufer
 * */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace WCFRestIII
{    
    public class EmployeeService : IEmployeeService
    {
        public EmployeeDataContract GetEmployeeDetails(string EmpId)
        {
            EmployeeDataContract emp = new EmployeeDataContract();

            try
            {
                XDocument doc = XDocument.Load(@"c:\temp\EmployeeData.xml");                

                IEnumerable<XElement> employee =
                    (from result in doc.Descendants("DocumentElement").Descendants("Employees")
                     where result.Element("EmployeeID").Value == EmpId.ToString()
                     select result);

                emp.EmployeeID = employee.ElementAt(0).Element("EmployeeID").Value;
                emp.Name = employee.ElementAt(0).Element("Name").Value;
                emp.JoiningDate = employee.ElementAt(0).Element("JoiningDate").Value;
                emp.CompanyName = employee.ElementAt(0).Element("CompanyName").Value;
                emp.Address = employee.ElementAt(0).Element("Address").Value;
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
            return emp;
        }

        public bool AddNewEmployee(EmployeeDataContract employee)
        {
            try
            {
                XDocument doc = XDocument.Load(@"c:\temp\EmployeeData.xml");                

                doc.Element("DocumentElement").Add(
                        new XElement("Employees",
                        new XElement("EmployeeID", employee.EmployeeID),
                        new XElement("Name", employee.Name),
                        new XElement("JoiningDate", employee.JoiningDate),
                        new XElement("CompanyName", employee.CompanyName),
                        new XElement("Address", employee.Address)));

                doc.Save(@"c:\temp\EmployeeData.xml");
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
            return true;
        }

        public void UpdateEmployee(EmployeeDataContract employee)
        {
            try
            {
                XDocument doc = XDocument.Load("c:\\temp\\EmployeeData.xml");
                
                var target = doc
                     .Element("DocumentElement")
                     .Elements("Employees")
                     .Where(e => e.Element("EmployeeID").Value == employee.EmployeeID)
                     .Single();

                target.Element("Name").Value = employee.Name;
                target.Element("JoiningDate").Value = employee.JoiningDate;
                target.Element("CompanyName").Value = employee.CompanyName;
                target.Element("Address").Value = employee.Address;

                doc.Save("c:\\temp\\EmployeeData.xml");
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
        }

        public void DeleteEmployee(string EmpId)
        {
            try
            {
                XDocument doc = XDocument.Load("c:\\temp\\EmployeeData.xml");
                
                foreach (var result in doc.Descendants("DocumentElement").Descendants("Employees"))
                {
                    if (result.Element("EmployeeID").Value == EmpId.ToString())
                    {
                        result.Remove();
                        break;
                    }
                }
                doc.Save("c:\\temp\\EmployeeData.xml");
                
            }
            catch (Exception ex)
            {
                throw new FaultException<string>
                        (ex.Message);
            }
        }
    }
}
