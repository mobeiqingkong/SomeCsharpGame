namespace Mygame
{
    partial class Point24
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
            this.btGameBegin = new System.Windows.Forms.Button();
            this.btCalculate24 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbHint = new System.Windows.Forms.Label();
            this.tbCalculate = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btTest = new System.Windows.Forms.Button();
            this.btRefresh4Num = new System.Windows.Forms.Button();
            this.tlpPoint24 = new System.Windows.Forms.TableLayoutPanel();
            this.btHelp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbNum3 = new System.Windows.Forms.Label();
            this.lbNum4 = new System.Windows.Forms.Label();
            this.tbNum4 = new System.Windows.Forms.TextBox();
            this.tbNum3 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tlpPoint24.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGameBegin
            // 
            this.btGameBegin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGameBegin.BackColor = System.Drawing.Color.Teal;
            this.btGameBegin.Font = new System.Drawing.Font("隶书", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGameBegin.ForeColor = System.Drawing.Color.White;
            this.btGameBegin.Location = new System.Drawing.Point(30, 89);
            this.btGameBegin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btGameBegin.Name = "btGameBegin";
            this.btGameBegin.Size = new System.Drawing.Size(109, 43);
            this.btGameBegin.TabIndex = 0;
            this.btGameBegin.Text = "游戏开始";
            this.btGameBegin.UseVisualStyleBackColor = false;
            this.btGameBegin.Click += new System.EventHandler(this.btGameBegin_Click);
            // 
            // btCalculate24
            // 
            this.btCalculate24.BackColor = System.Drawing.Color.DarkCyan;
            this.btCalculate24.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCalculate24.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCalculate24.ForeColor = System.Drawing.Color.White;
            this.btCalculate24.Location = new System.Drawing.Point(806, 3);
            this.btCalculate24.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btCalculate24.Name = "btCalculate24";
            this.btCalculate24.Size = new System.Drawing.Size(130, 51);
            this.btCalculate24.TabIndex = 1;
            this.btCalculate24.Text = "计算24点";
            this.btCalculate24.UseVisualStyleBackColor = false;
            this.btCalculate24.Click += new System.EventHandler(this.btCalculate24_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.CadetBlue;
            this.btExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btExit.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExit.Location = new System.Drawing.Point(790, 197);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(146, 64);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "退出游戏";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbHint
            // 
            this.lbHint.AutoSize = true;
            this.lbHint.BackColor = System.Drawing.Color.Snow;
            this.lbHint.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHint.ForeColor = System.Drawing.Color.Black;
            this.lbHint.Location = new System.Drawing.Point(4, 57);
            this.lbHint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(342, 60);
            this.lbHint.TabIndex = 11;
            this.lbHint.Text = "请输入算式:\r\n注意,符号只能有+-*/()";
            // 
            // tbCalculate
            // 
            this.tbCalculate.BackColor = System.Drawing.Color.White;
            this.tbCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCalculate.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCalculate.Location = new System.Drawing.Point(4, 123);
            this.tbCalculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCalculate.Multiline = true;
            this.tbCalculate.Name = "tbCalculate";
            this.tbCalculate.Size = new System.Drawing.Size(462, 68);
            this.tbCalculate.TabIndex = 12;
            this.tbCalculate.TextChanged += new System.EventHandler(this.tbCalculate_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbResult.Location = new System.Drawing.Point(474, 123);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(462, 68);
            this.tbResult.TabIndex = 14;
            // 
            // lbResult
            // 
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbResult.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbResult.Location = new System.Drawing.Point(474, 57);
            this.lbResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(159, 63);
            this.lbResult.TabIndex = 15;
            this.lbResult.Text = "计算结果:";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btTest
            // 
            this.btTest.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.btTest.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTest.Location = new System.Drawing.Point(4, 199);
            this.btTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(104, 60);
            this.btTest.TabIndex = 16;
            this.btTest.Text = "计算";
            this.btTest.UseVisualStyleBackColor = false;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btRefresh4Num
            // 
            this.btRefresh4Num.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRefresh4Num.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btRefresh4Num.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRefresh4Num.ForeColor = System.Drawing.Color.White;
            this.btRefresh4Num.Location = new System.Drawing.Point(157, 88);
            this.btRefresh4Num.Name = "btRefresh4Num";
            this.btRefresh4Num.Size = new System.Drawing.Size(116, 44);
            this.btRefresh4Num.TabIndex = 17;
            this.btRefresh4Num.Text = "刷新数值";
            this.btRefresh4Num.UseVisualStyleBackColor = false;
            this.btRefresh4Num.Click += new System.EventHandler(this.btRefresh4Num_Click);
            // 
            // tlpPoint24
            // 
            this.tlpPoint24.BackColor = System.Drawing.Color.Transparent;
            this.tlpPoint24.ColumnCount = 10;
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.441614F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.16348F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.43737F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.90658F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.386412F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.112526F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04578F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04578F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04578F));
            this.tlpPoint24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.04578F));
            this.tlpPoint24.Controls.Add(this.tbNum1, 6, 2);
            this.tlpPoint24.Controls.Add(this.tbNum2, 7, 2);
            this.tlpPoint24.Controls.Add(this.tbNum3, 8, 2);
            this.tlpPoint24.Controls.Add(this.tbNum4, 9, 2);
            this.tlpPoint24.Controls.Add(this.btGameBegin, 1, 1);
            this.tlpPoint24.Controls.Add(this.btRefresh4Num, 2, 1);
            this.tlpPoint24.Controls.Add(this.btHelp, 3, 1);
            this.tlpPoint24.Controls.Add(this.lbNum4, 4, 2);
            this.tlpPoint24.Controls.Add(this.lbNum3, 3, 2);
            this.tlpPoint24.Controls.Add(this.lbNum2, 2, 2);
            this.tlpPoint24.Controls.Add(this.lbNum1, 1, 2);
            this.tlpPoint24.Location = new System.Drawing.Point(12, 12);
            this.tlpPoint24.Name = "tlpPoint24";
            this.tlpPoint24.RowCount = 4;
            this.tlpPoint24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPoint24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpPoint24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tlpPoint24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPoint24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPoint24.Size = new System.Drawing.Size(942, 250);
            this.tlpPoint24.TabIndex = 18;
            // 
            // btHelp
            // 
            this.btHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHelp.BackColor = System.Drawing.Color.PowderBlue;
            this.btHelp.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btHelp.ForeColor = System.Drawing.Color.DimGray;
            this.btHelp.Location = new System.Drawing.Point(290, 89);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(117, 43);
            this.btHelp.TabIndex = 18;
            this.btHelp.Text = "游戏玩法";
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btExit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btTest, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btCalculate24, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbHint, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbResult, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbCalculate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbResult, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 287);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.9697F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.40909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.37879F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(940, 264);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // lbNum1
            // 
            this.lbNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNum1.AutoSize = true;
            this.lbNum1.BackColor = System.Drawing.Color.Cyan;
            this.lbNum1.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNum1.Location = new System.Drawing.Point(63, 165);
            this.lbNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(44, 48);
            this.lbNum1.TabIndex = 7;
            this.lbNum1.Text = "0";
            // 
            // lbNum2
            // 
            this.lbNum2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNum2.AutoSize = true;
            this.lbNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbNum2.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNum2.Location = new System.Drawing.Point(193, 165);
            this.lbNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(44, 48);
            this.lbNum2.TabIndex = 10;
            this.lbNum2.Text = "0";
            // 
            // lbNum3
            // 
            this.lbNum3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNum3.AutoSize = true;
            this.lbNum3.BackColor = System.Drawing.Color.LightCyan;
            this.lbNum3.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNum3.Location = new System.Drawing.Point(326, 165);
            this.lbNum3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNum3.Name = "lbNum3";
            this.lbNum3.Size = new System.Drawing.Size(44, 48);
            this.lbNum3.TabIndex = 9;
            this.lbNum3.Text = "0";
            // 
            // lbNum4
            // 
            this.lbNum4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNum4.AutoSize = true;
            this.lbNum4.BackColor = System.Drawing.Color.PowderBlue;
            this.lbNum4.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNum4.Location = new System.Drawing.Point(431, 165);
            this.lbNum4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNum4.Name = "lbNum4";
            this.lbNum4.Size = new System.Drawing.Size(44, 48);
            this.lbNum4.TabIndex = 8;
            this.lbNum4.Text = "0";
            // 
            // tbNum4
            // 
            this.tbNum4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNum4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNum4.Location = new System.Drawing.Point(864, 163);
            this.tbNum4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNum4.Multiline = true;
            this.tbNum4.Name = "tbNum4";
            this.tbNum4.Size = new System.Drawing.Size(55, 52);
            this.tbNum4.TabIndex = 6;
            this.tbNum4.TextChanged += new System.EventHandler(this.tbNum4_TextChanged);
            // 
            // tbNum3
            // 
            this.tbNum3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNum3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNum3.Location = new System.Drawing.Point(767, 163);
            this.tbNum3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNum3.Multiline = true;
            this.tbNum3.Name = "tbNum3";
            this.tbNum3.Size = new System.Drawing.Size(55, 52);
            this.tbNum3.TabIndex = 5;
            this.tbNum3.TextChanged += new System.EventHandler(this.tbNum3_TextChanged);
            // 
            // tbNum2
            // 
            this.tbNum2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNum2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNum2.Location = new System.Drawing.Point(673, 163);
            this.tbNum2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNum2.Multiline = true;
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(55, 52);
            this.tbNum2.TabIndex = 4;
            this.tbNum2.TextChanged += new System.EventHandler(this.tbNum2_TextChanged);
            // 
            // tbNum1
            // 
            this.tbNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNum1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNum1.Location = new System.Drawing.Point(579, 163);
            this.tbNum1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNum1.Multiline = true;
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(55, 52);
            this.tbNum1.TabIndex = 3;
            this.tbNum1.TextChanged += new System.EventHandler(this.tbNum1_TextChanged);
            // 
            // Point24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Mygame.Properties.Resources.Point24MaxBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 710);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tlpPoint24);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Point24";
            this.Text = "24点";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Point24_FormClosing);
            this.tlpPoint24.ResumeLayout(false);
            this.tlpPoint24.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGameBegin;
        private System.Windows.Forms.Button btCalculate24;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbHint;
        private System.Windows.Forms.TextBox tbCalculate;
        public System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.Button btRefresh4Num;
        private System.Windows.Forms.TableLayoutPanel tlpPoint24;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbNum3;
        private System.Windows.Forms.TextBox tbNum4;
        private System.Windows.Forms.Label lbNum4;
        private System.Windows.Forms.Label lbNum3;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbNum1;
    }
}