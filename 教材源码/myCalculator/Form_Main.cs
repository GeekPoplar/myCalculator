using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalaulater
{
    public partial class Form_Main : Form
    {
        Stack st = new Stack();
        double num1, num2, tempresult, a;
        string Operator;
        public Form_Main()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num1 - num2;
                    st.Push(tempresult);

                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num1 * num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();
                }
                st.Push("-");
                txtDisplay.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num1 * num2;
                    st.Push(tempresult);

                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num1 * num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();
                }
                st.Push("×");
                txtDisplay.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num2 / num1;
                    st.Push(tempresult);

                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num1 * num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();
                }
                st.Push("÷");
                txtDisplay.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num1 / num2;
                    st.Push(tempresult);

                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num1 * num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();
                }
                txtDisplay.Text = tempresult.ToString();
                st.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            catch(Exception)
            {
                MessageBox.Show("已经为空了，无法再退格了！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            st.Clear();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDisplay.Text))
                txtDisplay.Text = "0.0";
            else if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                st.Push(txtDisplay.Text);
                if (st.Count >= 3)
                {
                    num1 = Convert.ToDouble(st.Pop());
                    Operator = Convert.ToString(st.Pop());
                    num2 = Convert.ToDouble(st.Pop());
                    tempresult = num1 + num2;
                    st.Push(tempresult);

                    if (Operator == "+")
                    {
                        tempresult = num1 + num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "-")
                    {
                        tempresult = num2 - num1;
                        st.Push(tempresult);
                    }
                    else if (Operator == "×")
                    {
                        tempresult = num1 * num2;
                        st.Push(tempresult);
                    }
                    else if (Operator == "÷")
                    {
                        tempresult = num2 / num1;
                        st.Push(tempresult);
                    }
                    txtDisplay.Text = tempresult.ToString();
                }
                st.Push("+");
                txtDisplay.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }
    }
}
