using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsWPF
{
    public class common
    {
        public common()
        {

        }

        public int Add_number(int first_number, int second_number)
        {
            return first_number + second_number;
        }

        public int Sub_number(int first_number, int second_number)
        {
            return first_number - second_number;
        }

        public int Mul_number(int first_number, int second_number)
        {
            return first_number * second_number;
        }


        public int Div_number(int first_number, int second_number)
        {
            return first_number / second_number;
        }

        public int Five_Marks_Name(string studentname, int mark1, int mark2, int mark3, int mark4, int mark5)
        {
            int total =  mark1 + mark2 + mark3 + mark4 + mark5;
            return total;
            
        }

        public int Five_Marks(int mark1, int mark2, int mark3, int mark4, int mark5)
        {
            int total = mark1 + mark2 + mark3 + mark4 + mark5;
            return total;
        }

    }
}
