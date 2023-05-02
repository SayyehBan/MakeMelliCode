using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeMelliCode
{
    class MakeCode
    {
        public string codeMake()
        {
            string result="0";
            try
            {
                Random rnd = new Random();
                int num1 = rnd.Next(0, 9);
                int num2 = rnd.Next(0, 9);
                int num3 = rnd.Next(0, 9);
                int num4 = rnd.Next(0, 9);
                int num5 = rnd.Next(0, 9);
                int num6 = rnd.Next(0, 9);
                int num7 = rnd.Next(0, 9);
                int num8 = rnd.Next(0, 9);
                int num9 = rnd.Next(0, 9);
                result = num1.ToString() + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9;
               
            }
            catch (Exception)
            {

                MessageBox.Show("");
            }
            return result;
        }
        public int SumCode()
        {
            string number = codeMake();
            var code = number.ToArray();
            int sum = 0;
            int postitionNUMBER = 10;
            int res = 0;
            while (postitionNUMBER >= 2)
            {
                for (int i = 0; i <= 8; i++)
                {
                    int num = Convert.ToInt32(code[i].ToString()) * postitionNUMBER;
                    sum = num + sum;
                    postitionNUMBER--;
                }
            }
            bool check = false;
            while (check == false)
            {
                int controlNumber = (11 - (sum % 11));
                if ((sum % 11) == controlNumber || (11 - (sum % 11)) == controlNumber)
                {
                    for (int i = 0; i <= 8; i++)
                    {
                        int melliCode = Convert.ToInt32(code[i].ToString());
                        res = melliCode + res;
                        return res;
                    }
                    check = true;
                    int result = res + controlNumber;
                    return result;
                }
                else
                {
                    MessageBox.Show("کدملی صحیحی ساخته نشد");
                }
            }
            return res;
        }


    }
}
