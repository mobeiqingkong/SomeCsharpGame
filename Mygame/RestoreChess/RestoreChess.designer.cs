namespace Mygame
{
    partial class RestoreChess
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
            this.components = new System.ComponentModel.Container();
            this.btNewGame = new System.Windows.Forms.Button();
            this.lbTest = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.tlpRecord = new System.Windows.Forms.TableLayoutPanel();
            this.pbBomb = new System.Windows.Forms.PictureBox();
            this.pbTime = new System.Windows.Forms.PictureBox();
            this.btExitChess = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.lbGame = new System.Windows.Forms.Label();
            this.tlpGame = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            this.tlpGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNewGame
            // 
            this.btNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNewGame.Location = new System.Drawing.Point(9, 38);
            this.btNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.Size = new System.Drawing.Size(124, 32);
            this.btNewGame.TabIndex = 0;
            this.btNewGame.Text = "开始游戏";
            this.btNewGame.UseVisualStyleBackColor = true;
            this.btNewGame.Click += new System.EventHandler(this.btNewGame_Click);
            // 
            // lbTest
            // 
            this.lbTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTest.Location = new System.Drawing.Point(100, 0);
            this.lbTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTest.Name = "lbTest";
            this.lbTest.Size = new System.Drawing.Size(115, 48);
            this.lbTest.TabIndex = 1;
            this.lbTest.Text = "次数:0";
            this.lbTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTime.Location = new System.Drawing.Point(255, 0);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(100, 48);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "已用时:";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbSelect
            // 
            this.cbSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbSelect.Location = new System.Drawing.Point(151, 5);
            this.cbSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(171, 23);
            this.cbSelect.TabIndex = 4;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // tlpRecord
            // 
            this.tlpRecord.ColumnCount = 9;
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpRecord.Controls.Add(this.pbBomb, 1, 0);
            this.tlpRecord.Controls.Add(this.pbTime, 7, 0);
            this.tlpRecord.Controls.Add(this.lbTime, 5, 0);
            this.tlpRecord.Controls.Add(this.lbTest, 3, 0);
            this.tlpRecord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpRecord.Location = new System.Drawing.Point(0, 518);
            this.tlpRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpRecord.Name = "tlpRecord";
            this.tlpRecord.RowCount = 1;
            this.tlpRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRecord.Size = new System.Drawing.Size(474, 48);
            this.tlpRecord.TabIndex = 5;
            // 
            // pbBomb
            // 
            this.pbBomb.BackgroundImage = global::Mygame.Properties.Resources.RestoreChessBackground;
            this.pbBomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBomb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBomb.Location = new System.Drawing.Point(35, 2);
            this.pbBomb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBomb.Name = "pbBomb";
            this.pbBomb.Size = new System.Drawing.Size(42, 44);
            this.pbBomb.TabIndex = 0;
            this.pbBomb.TabStop = false;
            // 
            // pbTime
            // 
            this.pbTime.BackgroundImage = global::Mygame.Properties.Resources.time;
            this.pbTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbTime.Location = new System.Drawing.Point(393, 4);
            this.pbTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(42, 42);
            this.pbTime.TabIndex = 1;
            this.pbTime.TabStop = false;
            // 
            // btExitChess
            // 
            this.btExitChess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExitChess.Location = new System.Drawing.Point(339, 38);
            this.btExitChess.Margin = new System.Windows.Forms.Padding(4);
            this.btExitChess.Name = "btExitChess";
            this.btExitChess.Size = new System.Drawing.Size(127, 32);
            this.btExitChess.TabIndex = 6;
            this.btExitChess.Text = "退出游戏";
            this.btExitChess.UseVisualStyleBackColor = true;
            this.btExitChess.Click += new System.EventHandler(this.btExitChess_Click);
            // 
            // btHelp
            // 
            this.btHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHelp.Location = new System.Drawing.Point(152, 38);
            this.btHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(169, 32);
            this.btHelp.TabIndex = 7;
            this.btHelp.Text = "玩法介绍";
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // lbGame
            // 
            this.lbGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGame.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGame.Location = new System.Drawing.Point(9, 0);
            this.lbGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGame.Name = "lbGame";
            this.lbGame.Size = new System.Drawing.Size(124, 34);
            this.lbGame.TabIndex = 8;
            this.lbGame.Text = "游戏模式:";
            // 
            // tlpGame
            // 
            this.tlpGame.ColumnCount = 3;
            this.tlpGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpGame.Controls.Add(this.btNewGame, 0, 1);
            this.tlpGame.Controls.Add(this.cbSelect, 1, 0);
            this.tlpGame.Controls.Add(this.btExitChess, 2, 1);
            this.tlpGame.Controls.Add(this.btHelp, 1, 1);
            this.tlpGame.Controls.Add(this.lbGame, 0, 0);
            this.tlpGame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpGame.Location = new System.Drawing.Point(0, 444);
            this.tlpGame.Margin = new System.Windows.Forms.Padding(4);
            this.tlpGame.Name = "tlpGame";
            this.tlpGame.RowCount = 2;
            this.tlpGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.tlpGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            this.tlpGame.Size = new System.Drawing.Size(474, 74);
            this.tlpGame.TabIndex = 9;
            // 
            // RestoreChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Mygame.Properties.Resources.RestoreChessBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(474, 566);
            this.Controls.Add(this.tlpGame);
            this.Controls.Add(this.tlpRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RestoreChess";
            this.Text = "复原棋";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RestoreChess_FormClosing);
            this.Load += new System.EventHandler(this.RestoreChess_Load);
            this.tlpRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            this.tlpGame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNewGame;
        private System.Windows.Forms.Label lbTest;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.TableLayoutPanel tlpRecord;
        private System.Windows.Forms.PictureBox pbBomb;
        private System.Windows.Forms.PictureBox pbTime;
        private System.Windows.Forms.Button btExitChess;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.Label lbGame;
        private System.Windows.Forms.TableLayoutPanel tlpGame;
    }
}

