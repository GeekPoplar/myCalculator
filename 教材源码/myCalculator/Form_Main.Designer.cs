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
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.AcceptsReturn = true;
            this.txtDisplay.Font = new System.Drawing.Font("宋体", 12F);
            this.txtDisplay.Location = new System.Drawing.Point(12, 27);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(318, 26);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Location = new System.Drawing.Point(12, 70);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 34);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_div
            // 
            this.btn_div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_div.Location = new System.Drawing.Point(93, 70);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(75, 34);
            this.btn_div.TabIndex = 2;
            this.btn_div.Text = "÷";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_multi.Location = new System.Drawing.Point(174, 70);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(75, 34);
            this.btn_multi.TabIndex = 3;
            this.btn_multi.Text = "×";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backspace.Location = new System.Drawing.Point(255, 70);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(75, 34);
            this.btn_backspace.TabIndex = 4;
            this.btn_backspace.Text = "退格";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // btn_7
            // 
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_7.Location = new System.Drawing.Point(12, 110);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 33);
            this.btn_7.TabIndex = 5;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_8.Location = new System.Drawing.Point(93, 110);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 33);
            this.btn_8.TabIndex = 6;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_9.Location = new System.Drawing.Point(174, 110);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 33);
            this.btn_9.TabIndex = 7;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sub.Location = new System.Drawing.Point(255, 110);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(75, 33);
            this.btn_sub.TabIndex = 8;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_equal.Location = new System.Drawing.Point(255, 189);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(75, 72);
            this.btn_equal.TabIndex = 16;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_3
            // 
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_3.Location = new System.Drawing.Point(174, 189);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 33);
            this.btn_3.TabIndex = 15;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_2.Location = new System.Drawing.Point(93, 189);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 33);
            this.btn_2.TabIndex = 14;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Location = new System.Drawing.Point(12, 189);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 33);
            this.btn_1.TabIndex = 13;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(255, 149);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 34);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_6
            // 
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_6.Location = new System.Drawing.Point(174, 149);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 34);
            this.btn_6.TabIndex = 11;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_5.Location = new System.Drawing.Point(93, 149);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 34);
            this.btn_5.TabIndex = 10;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_4.Location = new System.Drawing.Point(12, 149);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 34);
            this.btn_4.TabIndex = 9;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_0
            // 
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_0.Location = new System.Drawing.Point(12, 228);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(156, 33);
            this.btn_0.TabIndex = 17;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.button17_Click);
            // 
            // btn_point
            // 
            this.btn_point.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_point.Location = new System.Drawing.Point(174, 228);
            this.btn_point.Name = "btn_point";
            this.btn_point.Size = new System.Drawing.Size(75, 33);
            this.btn_point.TabIndex = 18;
            this.btn_point.Text = ".";
            this.btn_point.UseVisualStyleBackColor = true;
            this.btn_point.Click += new System.EventHandler(this.btn_point_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(352, 283);
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
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myCalculator";
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
    }
}

