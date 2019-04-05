namespace Demention_converter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m133 = new System.Windows.Forms.RadioButton();
            this.m177 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.d133 = new System.Windows.Forms.RadioButton();
            this.dd177 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.R_2_0 = new System.Windows.Forms.Label();
            this.rt_1_0 = new System.Windows.Forms.Label();
            this.W1 = new System.Windows.Forms.Label();
            this.H1 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.Label();
            this.W2 = new System.Windows.Forms.Label();
            this.H2 = new System.Windows.Forms.Label();
            this.D2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 288);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Diagonal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m133);
            this.groupBox2.Controls.Add(this.m177);
            this.groupBox2.Location = new System.Drawing.Point(318, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Media Aspec ratio";
            // 
            // m133
            // 
            this.m133.AutoSize = true;
            this.m133.Location = new System.Drawing.Point(26, 42);
            this.m133.Name = "m133";
            this.m133.Size = new System.Drawing.Size(40, 17);
            this.m133.TabIndex = 5;
            this.m133.Text = "4:3";
            this.m133.UseVisualStyleBackColor = true;
            this.m133.CheckedChanged += new System.EventHandler(this.Rbtn_Checkchange);
            // 
            // m177
            // 
            this.m177.AutoSize = true;
            this.m177.Location = new System.Drawing.Point(26, 19);
            this.m177.Name = "m177";
            this.m177.Size = new System.Drawing.Size(46, 17);
            this.m177.TabIndex = 4;
            this.m177.Text = "16:9";
            this.m177.UseVisualStyleBackColor = true;
            this.m177.CheckedChanged += new System.EventHandler(this.Rbtn_Checkchange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.d133);
            this.groupBox1.Controls.Add(this.dd177);
            this.groupBox1.Location = new System.Drawing.Point(191, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Screen aspect ratio";
            // 
            // d133
            // 
            this.d133.AutoSize = true;
            this.d133.Location = new System.Drawing.Point(15, 42);
            this.d133.Name = "d133";
            this.d133.Size = new System.Drawing.Size(40, 17);
            this.d133.TabIndex = 3;
            this.d133.Text = "4:3";
            this.d133.UseVisualStyleBackColor = true;
            this.d133.CheckedChanged += new System.EventHandler(this.Rbtn_Checkchange);
            // 
            // dd177
            // 
            this.dd177.AutoSize = true;
            this.dd177.Location = new System.Drawing.Point(15, 19);
            this.dd177.Name = "dd177";
            this.dd177.Size = new System.Drawing.Size(46, 17);
            this.dd177.TabIndex = 2;
            this.dd177.Text = "16:9";
            this.dd177.UseVisualStyleBackColor = true;
            this.dd177.CheckedChanged += new System.EventHandler(this.Rbtn_Checkchange);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duiagonal";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(249, 156);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(158, 28);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "&Convert";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 4;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.Controls.Add(this.R_2_0, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.rt_1_0, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.W1, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.H1, 2, 1);
            this.TableLayoutPanel1.Controls.Add(this.D1, 3, 1);
            this.TableLayoutPanel1.Controls.Add(this.W2, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.H2, 2, 2);
            this.TableLayoutPanel1.Controls.Add(this.D2, 3, 2);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 295);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 4;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(678, 109);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // R_2_0
            // 
            this.R_2_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.R_2_0.AutoSize = true;
            this.R_2_0.Location = new System.Drawing.Point(3, 61);
            this.R_2_0.Name = "R_2_0";
            this.R_2_0.Size = new System.Drawing.Size(163, 13);
            this.R_2_0.TabIndex = 2;
            this.R_2_0.Text = "4/3";
            this.R_2_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rt_1_0
            // 
            this.rt_1_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rt_1_0.AutoSize = true;
            this.rt_1_0.Location = new System.Drawing.Point(3, 34);
            this.rt_1_0.Name = "rt_1_0";
            this.rt_1_0.Size = new System.Drawing.Size(163, 13);
            this.rt_1_0.TabIndex = 0;
            this.rt_1_0.Text = "16/9";
            this.rt_1_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // W1
            // 
            this.W1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.W1.AutoSize = true;
            this.W1.Location = new System.Drawing.Point(172, 34);
            this.W1.Name = "W1";
            this.W1.Size = new System.Drawing.Size(163, 13);
            this.W1.TabIndex = 3;
            this.W1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // H1
            // 
            this.H1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.H1.AutoSize = true;
            this.H1.Location = new System.Drawing.Point(341, 34);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(163, 13);
            this.H1.TabIndex = 4;
            this.H1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // D1
            // 
            this.D1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.D1.AutoSize = true;
            this.D1.Location = new System.Drawing.Point(510, 34);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(165, 13);
            this.D1.TabIndex = 5;
            this.D1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // W2
            // 
            this.W2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.W2.AutoSize = true;
            this.W2.Location = new System.Drawing.Point(172, 61);
            this.W2.Name = "W2";
            this.W2.Size = new System.Drawing.Size(163, 13);
            this.W2.TabIndex = 6;
            this.W2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // H2
            // 
            this.H2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.H2.AutoSize = true;
            this.H2.Location = new System.Drawing.Point(341, 61);
            this.H2.Name = "H2";
            this.H2.Size = new System.Drawing.Size(163, 13);
            this.H2.TabIndex = 7;
            this.H2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // D2
            // 
            this.D2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.D2.AutoSize = true;
            this.D2.Location = new System.Drawing.Point(510, 61);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(165, 13);
            this.D2.TabIndex = 8;
            this.D2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 679);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Label rt_1_0;
        private System.Windows.Forms.Label R_2_0;
        private System.Windows.Forms.Label W1;
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Label D1;
        private System.Windows.Forms.Label W2;
        private System.Windows.Forms.Label H2;
        private System.Windows.Forms.Label D2;
        private System.Windows.Forms.RadioButton dd177;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton d133;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton m133;
        private System.Windows.Forms.RadioButton m177;
        }
}

