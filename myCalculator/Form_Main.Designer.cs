namespace myCalaulater
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_point = new System.Windows.Forms.Button();
            this.btn_sci = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_yk = new System.Windows.Forms.Button();
            this.btn_zk = new System.Windows.Forms.Button();
            this.btn_arcsin = new System.Windows.Forms.Button();
            this.btn_arccos = new System.Windows.Forms.Button();
            this.btn_arctan = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_ln = new System.Windows.Forms.Button();
            this.btn_lg = new System.Windows.Forms.Button();
            this.btn_round = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.AcceptsReturn = true;
            this.txtDisplay.BackColor = System.Drawing.SystemColors.Info;
            this.txtDisplay.Font = new System.Drawing.Font("华文新魏", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisplay.Location = new System.Drawing.Point(18, 32);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(445, 49);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clear.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Location = new System.Drawing.Point(18, 104);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(108, 76);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.LightGray;
            this.btn_div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_div.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_div.Location = new System.Drawing.Point(132, 104);
            this.btn_div.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(108, 76);
            this.btn_div.TabIndex = 2;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.Color.LightGray;
            this.btn_multi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_multi.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_multi.Location = new System.Drawing.Point(246, 104);
            this.btn_multi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(108, 76);
            this.btn_multi.TabIndex = 3;
            this.btn_multi.Text = "×";
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.BackColor = System.Drawing.Color.LightGray;
            this.btn_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backspace.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_backspace.Location = new System.Drawing.Point(357, 104);
            this.btn_backspace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(108, 76);
            this.btn_backspace.TabIndex = 4;
            this.btn_backspace.Text = "退格";
            this.btn_backspace.UseVisualStyleBackColor = false;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // btn_7
            // 
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_7.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_7.Location = new System.Drawing.Point(18, 184);
            this.btn_7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(108, 76);
            this.btn_7.TabIndex = 5;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_8.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_8.Location = new System.Drawing.Point(132, 184);
            this.btn_8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(108, 76);
            this.btn_8.TabIndex = 6;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_9.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_9.Location = new System.Drawing.Point(246, 184);
            this.btn_9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(108, 76);
            this.btn_9.TabIndex = 7;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.LightGray;
            this.btn_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sub.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sub.Location = new System.Drawing.Point(357, 184);
            this.btn_sub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(108, 76);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_equal.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_equal.Location = new System.Drawing.Point(357, 352);
            this.btn_equal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(108, 160);
            this.btn_equal.TabIndex = 16;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_3
            // 
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_3.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_3.Location = new System.Drawing.Point(246, 352);
            this.btn_3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(108, 76);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_2.Location = new System.Drawing.Point(132, 352);
            this.btn_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(108, 76);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_1.Location = new System.Drawing.Point(18, 352);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(108, 76);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.LightGray;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add.Location = new System.Drawing.Point(357, 268);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(108, 76);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_6
            // 
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_6.Location = new System.Drawing.Point(246, 268);
            this.btn_6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(108, 76);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_5.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_5.Location = new System.Drawing.Point(132, 268);
            this.btn_5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(108, 76);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_4.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_4.Location = new System.Drawing.Point(18, 268);
            this.btn_4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(108, 76);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_0
            // 
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_0.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_0.Location = new System.Drawing.Point(18, 432);
            this.btn_0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(219, 76);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.button17_Click);
            // 
            // btn_point
            // 
            this.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_point.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_point.Location = new System.Drawing.Point(246, 432);
            this.btn_point.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(108, 76);
            this.btn_point.TabIndex = 18;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // btn_sci
            // 
            this.btn_sci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sci.Font = new System.Drawing.Font("方正字迹-杨素彬楷 简繁", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sci.Location = new System.Drawing.Point(18, 528);
            this.btn_sci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sci.Name = "btn_sci";
            this.btn_sci.Size = new System.Drawing.Size(447, 76);
            this.btn_sci.TabIndex = 19;
            this.btn_sci.Text = "打开科学计算器功能";
            this.btn_sci.UseVisualStyleBackColor = true;
            this.btn_sci.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sqrt.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sqrt.Location = new System.Drawing.Point(732, 352);
            this.btn_sqrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(108, 76);
            this.btn_sqrt.TabIndex = 20;
            this.btn_sqrt.Text = "sqrt";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mod.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mod.Location = new System.Drawing.Point(507, 268);
            this.btn_mod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(108, 76);
            this.btn_mod.TabIndex = 21;
            this.btn_mod.Text = "mod";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(621, 104);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 76);
            this.button6.TabIndex = 26;
            this.button6.Text = "cos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(507, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 76);
            this.button1.TabIndex = 29;
            this.button1.Text = "sin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(732, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 76);
            this.button2.TabIndex = 30;
            this.button2.Text = "tan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_yk
            // 
            this.btn_yk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_yk.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_yk.Location = new System.Drawing.Point(621, 432);
            this.btn_yk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_yk.Name = "btn_yk";
            this.btn_yk.Size = new System.Drawing.Size(108, 76);
            this.btn_yk.TabIndex = 31;
            this.btn_yk.Text = ")";
            this.btn_yk.UseVisualStyleBackColor = true;
            this.btn_yk.Click += new System.EventHandler(this.btn_yk_Click);
            // 
            // btn_zk
            // 
            this.btn_zk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_zk.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_zk.Location = new System.Drawing.Point(507, 432);
            this.btn_zk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_zk.Name = "btn_zk";
            this.btn_zk.Size = new System.Drawing.Size(108, 76);
            this.btn_zk.TabIndex = 32;
            this.btn_zk.Text = "(";
            this.btn_zk.UseVisualStyleBackColor = true;
            this.btn_zk.Click += new System.EventHandler(this.btn_zk_Click);
            // 
            // btn_arcsin
            // 
            this.btn_arcsin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_arcsin.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_arcsin.Location = new System.Drawing.Point(507, 184);
            this.btn_arcsin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_arcsin.Name = "btn_arcsin";
            this.btn_arcsin.Size = new System.Drawing.Size(108, 76);
            this.btn_arcsin.TabIndex = 33;
            this.btn_arcsin.Text = "arcsin";
            this.btn_arcsin.UseVisualStyleBackColor = true;
            this.btn_arcsin.Click += new System.EventHandler(this.btn_arcsin_Click);
            // 
            // btn_arccos
            // 
            this.btn_arccos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_arccos.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_arccos.Location = new System.Drawing.Point(621, 184);
            this.btn_arccos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_arccos.Name = "btn_arccos";
            this.btn_arccos.Size = new System.Drawing.Size(108, 76);
            this.btn_arccos.TabIndex = 34;
            this.btn_arccos.Text = "arccos";
            this.btn_arccos.UseVisualStyleBackColor = true;
            this.btn_arccos.Click += new System.EventHandler(this.btn_arccos_Click);
            // 
            // btn_arctan
            // 
            this.btn_arctan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_arctan.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_arctan.Location = new System.Drawing.Point(732, 184);
            this.btn_arctan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_arctan.Name = "btn_arctan";
            this.btn_arctan.Size = new System.Drawing.Size(108, 76);
            this.btn_arctan.TabIndex = 35;
            this.btn_arctan.Text = "arctan";
            this.btn_arctan.UseVisualStyleBackColor = true;
            this.btn_arctan.Click += new System.EventHandler(this.btn_arctan_Click);
            // 
            // btn_max
            // 
            this.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_max.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_max.Location = new System.Drawing.Point(621, 268);
            this.btn_max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(108, 76);
            this.btn_max.TabIndex = 36;
            this.btn_max.Text = "max";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_min.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_min.Location = new System.Drawing.Point(732, 268);
            this.btn_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(108, 76);
            this.btn_min.TabIndex = 37;
            this.btn_min.Text = "min";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_ln
            // 
            this.btn_ln.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ln.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ln.Location = new System.Drawing.Point(507, 352);
            this.btn_ln.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ln.Name = "btn_ln";
            this.btn_ln.Size = new System.Drawing.Size(108, 76);
            this.btn_ln.TabIndex = 38;
            this.btn_ln.Text = "ln";
            this.btn_ln.UseVisualStyleBackColor = true;
            this.btn_ln.Click += new System.EventHandler(this.btn_ln_Click);
            // 
            // btn_lg
            // 
            this.btn_lg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_lg.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_lg.Location = new System.Drawing.Point(621, 352);
            this.btn_lg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lg.Name = "btn_lg";
            this.btn_lg.Size = new System.Drawing.Size(108, 76);
            this.btn_lg.TabIndex = 39;
            this.btn_lg.Text = "lg";
            this.btn_lg.UseVisualStyleBackColor = true;
            this.btn_lg.Click += new System.EventHandler(this.btn_lg_Click);
            // 
            // btn_round
            // 
            this.btn_round.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_round.Font = new System.Drawing.Font("方正榜书行简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_round.Location = new System.Drawing.Point(732, 432);
            this.btn_round.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_round.Name = "btn_round";
            this.btn_round.Size = new System.Drawing.Size(108, 76);
            this.btn_round.TabIndex = 40;
            this.btn_round.Text = "round";
            this.btn_round.UseVisualStyleBackColor = true;
            this.btn_round.Click += new System.EventHandler(this.btn_round_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(867, 628);
            this.Controls.Add(this.btn_round);
            this.Controls.Add(this.btn_lg);
            this.Controls.Add(this.btn_ln);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_arctan);
            this.Controls.Add(this.btn_arccos);
            this.Controls.Add(this.btn_arcsin);
            this.Controls.Add(this.btn_zk);
            this.Controls.Add(this.btn_yk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_sci);
            this.Controls.Add(this.btn_point);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txtDisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "常规计算器";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_point;
        private System.Windows.Forms.Button btn_sci;
        private System.Windows.Forms.Button btn_sqrt;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_yk;
        private System.Windows.Forms.Button btn_zk;
        private System.Windows.Forms.Button btn_arcsin;
        private System.Windows.Forms.Button btn_arccos;
        private System.Windows.Forms.Button btn_arctan;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_ln;
        private System.Windows.Forms.Button btn_lg;
        private System.Windows.Forms.Button btn_round;
    }
}

