namespace Mygame
{
    partial class Calculation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculation));
            this.btLeaderboard = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbLeftNum = new System.Windows.Forms.Label();
            this.lbRightNum = new System.Windows.Forms.Label();
            this.lbAlgorithm = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btRight = new System.Windows.Forms.Button();
            this.btError = new System.Windows.Forms.Button();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.lbTimeLeft = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.PictureBox();
            this.btReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btGamebegin = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLeaderboard
            // 
            this.btLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLeaderboard.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btLeaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLeaderboard.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLeaderboard.ForeColor = System.Drawing.Color.Black;
            this.btLeaderboard.Location = new System.Drawing.Point(945, 259);
            this.btLeaderboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLeaderboard.Name = "btLeaderboard";
            this.btLeaderboard.Size = new System.Drawing.Size(143, 61);
            this.btLeaderboard.TabIndex = 1;
            this.btLeaderboard.Text = "排行榜";
            this.btLeaderboard.UseVisualStyleBackColor = false;
            this.btLeaderboard.Click += new System.EventHandler(this.btLeaderboard_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.BackColor = System.Drawing.Color.Salmon;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.Font = new System.Drawing.Font("方正舒体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExit.Location = new System.Drawing.Point(945, 496);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(144, 64);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "退出游戏";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbLeftNum
            // 
            this.lbLeftNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLeftNum.AutoSize = true;
            this.lbLeftNum.BackColor = System.Drawing.Color.Honeydew;
            this.lbLeftNum.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLeftNum.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbLeftNum.Location = new System.Drawing.Point(339, 260);
            this.lbLeftNum.Name = "lbLeftNum";
            this.lbLeftNum.Size = new System.Drawing.Size(0, 60);
            this.lbLeftNum.TabIndex = 3;
            this.lbLeftNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRightNum
            // 
            this.lbRightNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRightNum.AutoSize = true;
            this.lbRightNum.BackColor = System.Drawing.Color.LightCoral;
            this.lbRightNum.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRightNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbRightNum.Location = new System.Drawing.Point(791, 260);
            this.lbRightNum.Name = "lbRightNum";
            this.lbRightNum.Size = new System.Drawing.Size(0, 60);
            this.lbRightNum.TabIndex = 4;
            this.lbRightNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAlgorithm
            // 
            this.lbAlgorithm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAlgorithm.AutoSize = true;
            this.lbAlgorithm.BackColor = System.Drawing.Color.Tan;
            this.lbAlgorithm.Font = new System.Drawing.Font("华文琥珀", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAlgorithm.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbAlgorithm.Location = new System.Drawing.Point(565, 248);
            this.lbAlgorithm.Name = "lbAlgorithm";
            this.lbAlgorithm.Size = new System.Drawing.Size(0, 83);
            this.lbAlgorithm.TabIndex = 5;
            this.lbAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbResult.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbResult.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbResult.Location = new System.Drawing.Point(565, 370);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 60);
            this.lbResult.TabIndex = 6;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRight
            // 
            this.btRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btRight.BackColor = System.Drawing.Color.Transparent;
            this.btRight.BackgroundImage = global::Mygame.Properties.Resources.yes;
            this.btRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRight.Font = new System.Drawing.Font("华文隶书", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRight.ForeColor = System.Drawing.Color.Snow;
            this.btRight.Location = new System.Drawing.Point(263, 490);
            this.btRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(151, 76);
            this.btRight.TabIndex = 8;
            this.btRight.Text = "修正する";
            this.btRight.UseVisualStyleBackColor = false;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btError
            // 
            this.btError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btError.BackgroundImage = global::Mygame.Properties.Resources.no;
            this.btError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btError.Font = new System.Drawing.Font("华文隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btError.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btError.Location = new System.Drawing.Point(711, 489);
            this.btError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btError.Name = "btError";
            this.btError.Size = new System.Drawing.Size(160, 77);
            this.btError.TabIndex = 9;
            this.btError.Text = "エラー";
            this.btError.UseVisualStyleBackColor = true;
            this.btError.Click += new System.EventHandler(this.btError_Click);
            // 
            // GameTime
            // 
            this.GameTime.Interval = 1000;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick);
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTimeLeft.AutoSize = true;
            this.lbTimeLeft.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbTimeLeft.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLeft.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTimeLeft.Location = new System.Drawing.Point(724, 386);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(133, 28);
            this.lbTimeLeft.TabIndex = 11;
            this.lbTimeLeft.Text = "残り時間:";
            this.lbTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTime
            // 
            this.pbTime.BackColor = System.Drawing.Color.Transparent;
            this.pbTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTime.Location = new System.Drawing.Point(24, 292);
            this.pbTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(159, 232);
            this.pbTime.TabIndex = 12;
            this.pbTime.TabStop = false;
            // 
            // btReset
            // 
            this.btReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReset.BackColor = System.Drawing.Color.BurlyWood;
            this.btReset.Font = new System.Drawing.Font("方正舒体", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btReset.Location = new System.Drawing.Point(939, 376);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(156, 49);
            this.btReset.TabIndex = 13;
            this.btReset.Text = "重置排行榜";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btError, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btRight, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbResult, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btExit, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbRightNum, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbAlgorithm, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbLeftNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btGamebegin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btHelp, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTimeLeft, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btReset, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btLeaderboard, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.84906F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.15094F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 603);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("华文行楷", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(294, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 84);
            this.label1.TabIndex = 14;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btGamebegin
            // 
            this.btGamebegin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGamebegin.BackColor = System.Drawing.Color.Wheat;
            this.btGamebegin.Font = new System.Drawing.Font("方正舒体", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btGamebegin.ForeColor = System.Drawing.Color.Black;
            this.btGamebegin.Location = new System.Drawing.Point(254, 125);
            this.btGamebegin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGamebegin.Name = "btGamebegin";
            this.btGamebegin.Size = new System.Drawing.Size(170, 64);
            this.btGamebegin.TabIndex = 16;
            this.btGamebegin.Text = "开始游戏";
            this.btGamebegin.UseVisualStyleBackColor = false;
            this.btGamebegin.Click += new System.EventHandler(this.btGamebegin_Click);
            // 
            // btHelp
            // 
            this.btHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHelp.BackColor = System.Drawing.Color.Honeydew;
            this.btHelp.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btHelp.Location = new System.Drawing.Point(484, 129);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(161, 57);
            this.btHelp.TabIndex = 17;
            this.btHelp.Text = "游戏帮助";
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculation";
            this.Text = "加减大师";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculation_FormClosing);
            this.Load += new System.EventHandler(this.Calculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLeaderboard;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbLeftNum;
        private System.Windows.Forms.Label lbRightNum;
        private System.Windows.Forms.Label lbAlgorithm;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btError;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Label lbTimeLeft;
        private System.Windows.Forms.PictureBox pbTime;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGamebegin;
        private System.Windows.Forms.Button btHelp;
    }
}