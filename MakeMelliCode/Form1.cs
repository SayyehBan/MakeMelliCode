using System;
using System.Linq;
using System.Windows.Forms;

namespace MakeMelliCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string number123 = "0123456789";
            Random rnd = new Random();
            object code1 = rnd.Next(1, 9);
            object code2 = rnd.Next(1, 9);
            object code3 = rnd.Next(1, 9);
            object code4 = rnd.Next(1, 9);
            object code5 = rnd.Next(1, 9);
            object code6 = rnd.Next(1, 9);
            object code7 = rnd.Next(1, 9);
            object code8 = rnd.Next(1, 9);
            object code9 = rnd.Next(1, 9);
            string numbers1 = number123.Substring(Convert.ToInt32(code1), 1);
            string numbers2 = number123.Substring(Convert.ToInt32(code2), 1);
            string numbers3 = number123.Substring(Convert.ToInt32(code3), 1);
            string numbers4 = number123.Substring(Convert.ToInt32(code4), 1);
            string numbers5 = number123.Substring(Convert.ToInt32(code5), 1);
            string numbers6 = number123.Substring(Convert.ToInt32(code6), 1);
            string numbers7 = number123.Substring(Convert.ToInt32(code7), 1);
            string numbers8 = number123.Substring(Convert.ToInt32(code8), 1);
            string numbers9 = number123.Substring(Convert.ToInt32(code9), 1);
            string sumnumber = numbers1 + numbers2 + numbers3 + numbers4 + numbers5 + numbers6 + numbers7 + numbers8 + numbers9;
            var code = sumnumber.ToArray();
            if (code.Length == 9)
            {
                int numberPosition = 10;
                int sum = 0;
                while (numberPosition >= 2)
                {
                    for (int i = 0; i <= 8; i++)
                    {
                        int number = Convert.ToInt32(code[i].ToString()) * numberPosition;
                        sum = sum + number;
                        numberPosition--;
                    }
                }
                int numberControl = (11 - (sum % 11));
                string ss = sumnumber + Convert.ToString(numberControl);
                if (ss.Length == 10)
                {
                    textBox1.Text = ss;
                    return;
                }
            }

        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                textBox1.SelectAll();
                textBox1.Copy();
                MessageBox.Show("کپی شد!");
            }
            else
            {
                MessageBox.Show("لطفاً ابتدا کدملی را تولید کنید");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number123 = "0123456789";
            byte[] bytes = Guid.NewGuid().ToByteArray();
            int seed = BitConverter.ToInt32(bytes, 0);
            Random rnd = new Random(seed);

            string sumnumber = string.Empty;
            for (int i = 0; i < 9; i++)
            {
                int randomNumber = rnd.Next(1, 9);
                sumnumber += number123[randomNumber];
            }

            int numberPosition = 10;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int number = Convert.ToInt32(sumnumber[i].ToString()) * numberPosition;
                sum += number;
                numberPosition--;
            }

            int numberControl = (11 - (sum % 11)) % 10;
            string ss = sumnumber + Convert.ToString(numberControl);

            textBox1.Text = ss;
        }

    }
}
