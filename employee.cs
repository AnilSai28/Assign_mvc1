using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_employee_company
{
    class employee
    {
        private int employeeid;
        private string employeename;
        private string employeecity;
        public static int count = 1000;
        public employee(string employeename, string employeecity)
        {
            this.employeeid = ++employee.count;
            this.employeename = employeename;
            this.employeecity = employeecity;
        }
        public int pemployeeid
        {
            get { return this.employeeid; }
        }
        public string pemployeename { get { return this.employeename; } }

        public string pemployeecity
        {
            get { return this.employeecity; }
            set
            {
                this.employeecity = value;
            }
        }
        public void leaverequest(string reason)
        {
            Console.WriteLine("leave request : employeeid : " + this.employeeid + ",reason : " + reason);
        }



    }
}







































