using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_employee_company
{
    class company
    {
        private string companyname;
        private string companyaddress;
        private List<employee> employeelist = new List<employee>();
        public company(string companyname, string comapanyadderss)
        {
            this.companyname = companyname;
            this.companyaddress = companyaddress;
        }
        public string pcompanyname
        {
            get { return this.companyname; }
        }
        public string pcompanyaddress { get { return this.companyaddress; } }
        public void addemployee(employee obj)
        {
            employeelist.Add(obj);
            Console.WriteLine("employee added successfully...");
        }

        public bool removeemployee(int id)
        {
            foreach (employee e in this.employeelist)
            {
                if (e.pemployeeid == id)
                {
                    this.employeelist.Remove(e);
                    return true;
                }
            }
            return false;
        }
        public employee findemployee(int id)
        {
            foreach (employee e in this.employeelist)
            {
                if (e.pemployeeid == id)
                {
                    return e;
                }
            }
            return null;
        }
        public void showall()
        {
            foreach (employee e in this.employeelist)
            {


                Console.WriteLine(e.pemployeeid + " " + e.pemployeename);
            }
        }
    }
}           
