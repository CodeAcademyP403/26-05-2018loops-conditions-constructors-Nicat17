using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSection
{
    public class Catagory
    {
        private string name;
        //private static bool log;
        //private static int arrCount;
        private static int _ID { get; set; }
        //private static string[] addName = new string[10];

        static Catagory()
        {
            _ID = 0;
           // log = true;
            //arrCount = 1;
           // addName[0] = "_";
        }

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                //int temp = 0;
                name = value;

                //for (int i = 0; i < arrCount; i++)
                //{
                //    if (addName[i] == value)
                //    {
                //        break;
                //    }
                //    else if (addName[i] == null)
                //    {
                //        continue;
                //    }
                //    else
                //    {
                //        if (temp == 0)
                //        {
                //            _ID++;
                //            addName[arrCount - 1] = name;
                //            temp++;
                //            name = value;
                //        }
                //        else
                //        {
                //            continue;
                //        }
                //    }
                //}
                //arrCount++;
            }
        }
    }
}
