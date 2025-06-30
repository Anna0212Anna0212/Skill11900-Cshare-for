using System;
using System.IO;
using System.Windows.Forms;

namespace 第一站1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool Palindrome(string input)
        {
            int inp_size = input.Length;
            int mid = inp_size % 2 == 0 ? (inp_size - 1) / 2 : (inp_size - 1) / 2 + 1;
            for (int i = 0; i < mid; i++)
            {
                if (input[inp_size - 1 - i] != input[i])
                {
                    return false;
                }
            }
            return true;
        }

        bool Prime(string input)
        {
            int in_inpu = int.Parse(input);
            int input_size = input.Length - 1;
            for (int i = 2; i < input_size; i++)
            {
                if (in_inpu % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //*******************************
            //* 11900-1060301 Program Start *
            //*******************************
            string input1 = File.ReadAllText("1060301.SM");
            if (Palindrome(input1))
            {
                label2.Text = $"第一題結果：{input1} is a palindrome.";
            }
            else
            {
                label2.Text = $"第一題結果：{input1} is not a palindrome.";
            }
            //*******************************
            //* 11900-1060302 Program Start *
            //*******************************
            int max = int.Parse(File.ReadAllText("1060302.SM"));
            label3.Text = "第二題結果：\n";
            for (int i = 1; i <= max; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    label3.Text += j;
                }
                label3.Text += "\n";
            }
            //*******************************
            //* 11900-1060303 Program Start *
            //*******************************
            string input3 = File.ReadAllText("1060303.SM");
            if (Prime(input3))
            {
                label4.Text = $"第三題結果：{input3} is a prime number.";
            }
            else
            {
                label4.Text = $"第三題結果：{input3} is not a prime number.";
            }
            //*******************************
            //* 11900-1060304 Program Start *
            //*******************************
            string[] input4 = File.ReadAllLines("1060304.SM");
            double[] answ = new double[3];
            for (int i = 0; i < 3; i++)
            {
                string[] strings = input4[i].Split(',');
                answ[i] = int.Parse(strings[1]) / ((int.Parse(strings[0]) / 100.0) * (int.Parse(strings[0]) / 100.0));
            }
            Array.Sort(answ);
            if (answ[0] >= 20 && answ[0] <= 25)
            {
                label5.Text = $"第四題結果：最小BMI值={answ[0].ToString("F0")}，正常";
            }
            else
            {
                label5.Text = $"第四題結果：最小BMI值={answ[0].ToString("F0")}，不正常";
            }
            //*******************************
            //* 11900-1060305 Program Start *
            //*******************************
            string[] input5 = File.ReadAllLines("1060305.SM");
            label6.Text = "第五題結果：\n";
            for (int i = 0; i < 2; i++)
            {
                string[] a = input5[i].Split(',');
                string[] b = input5[i + 2].Split(',');
                label6.Text += $"[{int.Parse(a[0]) + int.Parse(b[0])}         {int.Parse(a[1]) + int.Parse(b[1])}]\n";
            }
        }
    }
}
