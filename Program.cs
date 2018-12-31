using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_employee_company
{
    class Program
    {
        static void Main(string[] args)
        {
            company brandsys = new company("brandsys,bgl","abc");
            Console.WriteLine(brandsys.pcompanyname + " " + brandsys.pcompanyname);
            bool flag = true;
            while (flag)

            {
                Console.WriteLine("1-add,2-find,3-remove,4-show,5-request leave,6-exit");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        {
                            Console.WriteLine("enter employee name : ");
                            string employeename = Console.ReadLine();
                            Console.WriteLine("enter employee city :");
                            string employeecity = Console.ReadLine();
                            employee obj = new employee(employeename, employeecity);
                            brandsys.addemployee(obj);
                            Console.WriteLine("your employee id : " + obj.pemployeeid);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("enter employee id : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            employee obj = brandsys.findemployee(id);
                            if (obj != null)
                            {
                                Console.WriteLine("employee details ");
                                Console.WriteLine(obj.pemployeeid + " " + obj.pemployeename + " " + obj.pemployeecity);
                            }
                            else
                            {
                                Console.WriteLine("employee not found");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("enter employeeid : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            bool status = brandsys.removeemployee(id);
                            if (status == true)
                            {
                                Console.WriteLine("employee removed");
                            }
                            else
                            {
                                Console.WriteLine("employee not found");
                            }
                            break;
                        }
                    case 4:
                        {
                            brandsys.showall();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("enter employee id : ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            employee obj = brandsys.findemployee(id);
                            if (obj != null)
                            {
                                Console.Write("enter the reason");
                                string reason = Console.ReadLine();
                                obj.leaverequest(reason);
                            }
                            else
                            {
                                Console.WriteLine("wrong employee id");
                            }

                            break;
                        }
                    case 6:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("you have entered a wrong option");
                            break;
                        }
                }
            }

        }
                }
}
