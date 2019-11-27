/*实现思路，每输入一个字符便将当前显示框文本中的最后一个数值
压到数值栈中，也将符号压入符号栈中，同时在文本框上将符号显示出来*/
/*第二版：①在输入符号的过程中，将数值和符号都送进队列里边，在进行运算的时候才开始从队列中取数和符号，
将他们分别压入数值栈和符号栈中，压栈的过程即是在进行运算。
 */
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
        Stack<string> optr = new Stack<string>();
        Stack<double> opan = new Stack<double>();
        Queue st = new Queue();//用于存操作过程中的字符和数值
        string[] stt = new string[100];
        //在进行运算时用于向数栈和符号栈提供数据
        string temp;//用于存放最后一个被送入队列的符号
        bool Scical_on_Show;
        bool is_t_fu = false;

        public Form_Main()
        {
            InitializeComponent();
            temp = "#";
            Scical_on_Show = false;
            this.Width = 500;
            this.btn_sci.Width = 446;
            this.txtDisplay.Width = 446;
        }

        public int Isp(string op)
        {
            switch (op)
            {
                case "#":
                    return 0;
                case "(":
                    return 1;
                case "×":
                case "÷":
                case "mod":
                    return 5;
                case "+":
                case "-":
                case "max":
                case "min":
                    return 3;
                case "sin":
                case "cos":
                case "tan":
                case "sqrt":
                case "arcsin":
                case "arccos":
                case "arctan":
                case "ln":
                case "lg":
                case "round":
                    return 7;
                case ")":
                    return 8;
            }
            return 0;
        }
        public int Icp(string op)
        {
            switch (op)
            {
                case "#":
                    return 0;
                case "+":
                case "-":
                case "max":
                case "min":
                    return 2;
                case ")":
                    return 1;
                case "×":
                case "÷":
                case "mod":
                    return 4;
                case "sin":
                case "cos":
                case "tan":
                case "sqrt":
                case "arcsin":
                case "arccos":
                case "arctan":
                case "ln":
                case "lg":
                case "round":
                    return 6;
                case "(":
                    return 8;
            }
            return 0;
        }
        public double To_five(double a)
        {
            double b = a * 100000;
            return Convert.ToDouble(Math.Round(b)) / 100000;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";//一个原则，输入数字和小数点时不进行操作
            //当输入运算符时再进行操作
            
        }

        

        

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "1";
            else
                txtDisplay.Text += "1";
        }

        

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "2";
            else
                txtDisplay.Text += "2";

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "3";
            else
                txtDisplay.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "4";
            else
                txtDisplay.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "5";
            else
                txtDisplay.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "6";
            else
                txtDisplay.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "7";
            else
                txtDisplay.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "8";
            else
                txtDisplay.Text += "8";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            try
            {
                if (temp!="#" && txtDisplay.Text.LastIndexOf(temp) + temp.Length==txtDisplay.Text.Length)
                {
                    st.Enqueue("(");
                    st.Enqueue(0);
                    st.Enqueue("-");
                    temp = "-";
                    txtDisplay.Text += "(-";
                }
                else
                {
                    if (temp != ")")
                    {
                        if (temp != "#")
                        {
                            st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                        }
                        else
                        {
                            st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                        }
                    }
                    temp = "-";
                    st.Enqueue(temp);
                    txtDisplay.Text += temp;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("输入格式错误", "错误", MessageBoxButtons.OK);
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
                if(temp!=")")
                {
                    if (temp != "#")
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                    }
                    else
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                    }
                }
                temp = "×";
                st.Enqueue(temp);
                txtDisplay.Text += temp;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("输入格式错误", "错误", MessageBoxButtons.OK);
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
                if (temp!=")")
                {
                    if (temp != "#")
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                    }
                    else
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                    }
                }
                temp = "÷";
                st.Enqueue(temp);
                txtDisplay.Text += temp;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("输入格式错误", "错误", MessageBoxButtons.OK);
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
                if (temp!=")")
                {
                    if (temp != "#")
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                    }
                    else
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                    }
                }
                
                temp = "=";
                txtDisplay.Text += temp;
                optr.Push("#");
                st.Enqueue("#");
                string op="a";//用op来存当前从optr栈中弹出来的操作符
                string s = Convert.ToString(st.Dequeue());//从st队列中取值
                double num1, num2;
                while (op != "#" || s != "#")
                {
                    if (!isOp(s))
                    //如果取出来的是数值
                    {
                        opan.Push(Convert.ToDouble(s));
                        s = Convert.ToString(st.Dequeue());
                    }
                    else
                    //如果取出来的是符号
                    {
                        if (Isp(optr.Peek()) < Icp(s))
                        //栈顶符号优先级低
                        {
                            optr.Push(s);
                            s = Convert.ToString(st.Dequeue());
                        }
                        else if (Isp(optr.Peek()) > Icp(s))
                        //栈顶符号优先级高
                        {
                            op = optr.Pop();
                            //开始进行运算
                            if(op=="+")
                            {
                                num1 = opan.Pop();
                                num2 = opan.Pop();
                                opan.Push(num1 + num2);
                            }
                            else if(op=="-")
                            {
                                num1 = opan.Pop();
                                num2 = opan.Pop();
                                opan.Push(num2 - num1);
                            }
                            else if (op == "×")
                            {
                                num1 = opan.Pop();
                                num2 = opan.Pop();
                                opan.Push(num2 * num1);
                            }
                            else if (op == "÷")
                            {
                                num1 = opan.Pop();
                                num2 = opan.Pop();
                                opan.Push(num2 / num1);
                            }
                            else if (op == "sqrt")
                            {
                                num1 = opan.Pop();
                                opan.Push(To_five(Math.Sqrt(num1)));
                            }
                            else if (op == "sin")
                            {
                                num1 = opan.Pop();
                                opan.Push(To_five(Math.Sin(Math.PI/180*num1)));
                            }
                            else if (op == "cos")
                            {
                                num1 = opan.Pop();
                                opan.Push(To_five(Math.Cos(Math.PI / 180 * num1)));
                            }
                            else if (op == "tan")
                            {
                                num1 = opan.Pop();
                                opan.Push(To_five(Math.Tan(Math.PI / 180 * num1)));
                            }
                            else if (op=="mod")
                            {
                                num1 = opan.Pop();
                                num2 = opan.Pop();
                                opan.Push(Convert.ToInt32(num2)% Convert.ToInt32(num1)); 
                            }
                            else if (op == "arcsin")
                            {
                                num1 = opan.Pop();
                                opan.Push(Math.Asin(num1));
                            }
                            else if (op == "arccos")
                            {
                                num1 = opan.Pop();
                                opan.Push(Math.Acos(num1));
                            }
                            else if (op == "arctan")
                            {
                                num1 = opan.Pop();
                                opan.Push(Math.Atan(num1));
                            }
                            if (op == "max")
                            {
                                num1 = opan.Pop();
                                num2 = opan.Pop();
                                opan.Push(Math.Max(num1,num2));
                            }
                            if (op == "min")
                            {
                                num1 = opan.Pop();
                                num2 = opan.Pop();
                                opan.Push(Math.Min(num1, num2));
                            }
                            else if (op == "ln")
                            {
                                num1 = opan.Pop();
                                opan.Push(To_five(Math.Log(num1)));
                            }
                            else if (op == "lg")
                            {
                                num1 = opan.Pop();
                                opan.Push(To_five(Math.Log10(num1)));
                            }
                            else if (op == "round")
                            {
                                num1 = opan.Pop();
                                opan.Push(Math.Round(num1));
                            }
                        }
                        else
                        //栈顶符号和刚出队的符号优先级相同，即均为括号或均为#
                        {
                            op = optr.Pop();
                            if(st.Count!=0)
                                s = Convert.ToString(st.Dequeue());
                        }
                    }
                }
                txtDisplay.Text += Convert.ToString(opan.Pop());
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private bool isOp(object v)
        {
            switch(Convert.ToString(v))
            {
                case "#":
                case "(":
                case "×":
                case "÷":
                case "mod":
                case "+":
                case "-":
                case "sin":
                case "cos":
                case "tan":
                case "sqrt":
                case ")":
                case "arcsin":
                case "arccos":
                case "arctan":
                case "max":
                case "min":
                case "ln":
                case "lg":
                case "round":
                    return true;
                default:
                    return false;
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

        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            //暂时认定sqrt符号之前无直接接触的数字
            temp = "sqrt";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "sqrt";
            else
                txtDisplay.Text += "√";


        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "9";
            else
                txtDisplay.Text += "9";
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += ".";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (optr.Peek() != txtDisplay.Text.Substring(txtDisplay.Text.Length - optr.Peek().Length))
                //用于判断是否已经输入过this运算符，明显是有些不科学的
                {
                    if (optr.Peek() != "#")
                    //若显示框中不止一个数值
                    {
                        opan.Push(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(optr.Peek()) + optr.Peek().Length)));
                        //将点击this操作符前输入的数值压入栈中
                    }
                    else
                    //若显示框的文本中仅有一个数值
                    {
                        opan.Push(Convert.ToDouble(txtDisplay.Text));
                    }
                    optr.Push("+");
                    txtDisplay.Text += "+";
                }*/
                if (temp!=")")
                {
                    if (temp != "#")
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                    }
                    else
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                    }
                }
                temp = "+";
                st.Enqueue(temp);
                txtDisplay.Text += temp;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("输入格式错误", "错误", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Scical_on_Show)
            {
                this.Width = 883;
                this.btn_sci.Width = 821;
                this.txtDisplay.Width = 821;
                this.btn_sci.Text = "关闭科学计算器功能";
                Scical_on_Show = true;
                this.Text = "科学计算器";
            }
            else
            {
                this.Width = 500;
                this.btn_sci.Width = 446;
                this.txtDisplay.Width = 446;
                this.btn_sci.Text = "打开科学计算器功能";
                Scical_on_Show = false;
                this.Text = "常规计算器";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_zk_Click(object sender, EventArgs e)
        {
            //左括号

            temp = "(";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = temp;
            else
                txtDisplay.Text += temp;
        }

        private void btn_yk_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("=")||txtDisplay.Text.Contains("(-"))
            {
                if (temp != "#")
                {
                    st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                }
                else
                {
                    st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                }
                temp = ")";
                st.Enqueue(temp);
                txtDisplay.Text += temp;
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            try
            {
                if (temp != "#")
                {
                    st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                }
                else
                {
                    st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                }
                temp = "mod";
                st.Enqueue(temp);
                txtDisplay.Text += temp;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("输入格式错误", "错误", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //暂时认定sin符号之前无直接接触的数字
            temp = "sin";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "sin";
            else
                txtDisplay.Text += "sin";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //暂时认定cos符号之前无直接接触的数字
            temp = "cos";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "cos";
            else
                txtDisplay.Text += "cos";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //暂时认定tan符号之前无直接接触的数字
            temp = "tan";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "tan";
            else
                txtDisplay.Text += "tan";
        }

        private void btn_pi_Click(object sender, EventArgs e)
        {
            if (temp != "#" && txtDisplay.Text.LastIndexOf(temp) + temp.Length == txtDisplay.Text.Length)
            //如果最后一位是刚刚进队的符号
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_arcsin_Click(object sender, EventArgs e)
        {
            temp = "arcsin";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "arcsin";
            else
                txtDisplay.Text += "arcsin";
        }

        private void btn_arccos_Click(object sender, EventArgs e)
        {
            temp = "arccos";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "arccos";
            else
                txtDisplay.Text += "arccos";
        }

        private void btn_arctan_Click(object sender, EventArgs e)
        {
            temp = "arctan";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "arctan";
            else
                txtDisplay.Text += "arctan";
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            try
            {
                if (temp != ")")
                {
                    if (temp != "#")
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                    }
                    else
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                    }
                }
                temp = "max";
                st.Enqueue(temp);
                txtDisplay.Text += temp;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("输入格式错误", "错误", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            try
            {
                if (temp != ")")
                {
                    if (temp != "#")
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text.Substring(txtDisplay.Text.LastIndexOf(temp) + temp.Length)));
                    }
                    else
                    {
                        st.Enqueue(Convert.ToDouble(txtDisplay.Text));
                    }
                }
                temp = "min";
                st.Enqueue(temp);
                txtDisplay.Text += temp;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("输入格式错误", "错误", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("先输入数字才能进行此运算！", "错误", MessageBoxButtons.OK);
            }
        }

        private void btn_ln_Click(object sender, EventArgs e)
        {
            temp = "ln";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "ln";
            else
                txtDisplay.Text += "ln";
        }

        private void btn_lg_Click(object sender, EventArgs e)
        {
            temp = "lg";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "lg";
            else
                txtDisplay.Text += "lg";
        }

        private void btn_round_Click(object sender, EventArgs e)
        {
            temp = "round";
            st.Enqueue(temp);
            if (txtDisplay.Text.Contains("="))
                txtDisplay.Text = "round";
            else
                txtDisplay.Text += "round";
        }
    }
}
