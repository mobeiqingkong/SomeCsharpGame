namespace Mygame
{
    partial class GameCentre
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCentre));
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.lbTime = new System.Windows.Forms.Label();
            this.btQuit = new System.Windows.Forms.Button();
            this.btCalculation = new System.Windows.Forms.Button();
            this.lbCalculation = new System.Windows.Forms.Label();
            this.btAbout = new System.Windows.Forms.Button();
            this.btPoint24 = new System.Windows.Forms.Button();
            this.lbPoint24 = new System.Windows.Forms.Label();
            this.btRestoreChess = new System.Windows.Forms.Button();
            this.lbRestoreChess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.White;
            this.lbTime.Enabled = false;
            this.lbTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTime.Location = new System.Drawing.Point(734, 30);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(212, 26);
            this.lbTime.TabIndex = 3;
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.White;
            this.btQuit.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuit.Location = new System.Drawing.Point(886, 441);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(141, 39);
            this.btQuit.TabIndex = 4;
            this.btQuit.Text = "退出";
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btCalculation
            // 
            this.btCalculation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCalculation.BackgroundImage")));
            this.btCalculation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCalculation.Location = new System.Drawing.Point(674, 342);
            this.btCalculation.Name = "btCalculation";
            this.btCalculation.Size = new System.Drawing.Size(132, 124);
            this.btCalculation.TabIndex = 5;
            this.btCalculation.UseVisualStyleBackColor = true;
            this.btCalculation.Click += new System.EventHandler(this.btCalculation_Click);
            // 
            // lbCalculation
            // 
            this.lbCalculation.AutoSize = true;
            this.lbCalculation.BackColor = System.Drawing.Color.Transparent;
            this.lbCalculation.Font = new System.Drawing.Font("幼圆", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCalculation.ForeColor = System.Drawing.Color.White;
            this.lbCalculation.Location = new System.Drawing.Point(683, 354);
            this.lbCalculation.Name = "lbCalculation";
            this.lbCalculation.Size = new System.Drawing.Size(97, 14);
            this.lbCalculation.TabIndex = 6;
            this.lbCalculation.Text = "加減算マスタ";
            this.lbCalculation.Click += new System.EventHandler(this.lbCalculation_Click);
            // 
            // btAbout
            // 
            this.btAbout.BackColor = System.Drawing.Color.White;
            this.btAbout.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAbout.Location = new System.Drawing.Point(886, 354);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(141, 39);
            this.btAbout.TabIndex = 7;
            this.btAbout.Text = "关于";
            this.btAbout.UseVisualStyleBackColor = false;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // btPoint24
            // 
            this.btPoint24.BackgroundImage = global::Mygame.Properties.Resources.Point24Background;
            this.btPoint24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPoint24.Location = new System.Drawing.Point(181, 338);
            this.btPoint24.Name = "btPoint24";
            this.btPoint24.Size = new System.Drawing.Size(125, 128);
            this.btPoint24.TabIndex = 8;
            this.btPoint24.UseVisualStyleBackColor = true;
            this.btPoint24.Click += new System.EventHandler(this.btPoint24_Click);
            // 
            // lbPoint24
            // 
            this.lbPoint24.BackColor = System.Drawing.Color.Transparent;
            this.lbPoint24.Font = new System.Drawing.Font("方正舒体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPoint24.ForeColor = System.Drawing.Color.White;
            this.lbPoint24.Location = new System.Drawing.Point(213, 354);
            this.lbPoint24.Name = "lbPoint24";
            this.lbPoint24.Size = new System.Drawing.Size(68, 27);
            this.lbPoint24.TabIndex = 9;
            this.lbPoint24.Text = "24点";
            this.lbPoint24.Click += new System.EventHandler(this.lbPoint24_Click);
            // 
            // btRestoreChess
            // 
            this.btRestoreChess.BackgroundImage = global::Mygame.Properties.Resources.RestoreChessBackground;
            this.btRestoreChess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRestoreChess.Location = new System.Drawing.Point(674, 155);
            this.btRestoreChess.Name = "btRestoreChess";
            this.btRestoreChess.Size = new System.Drawing.Size(132, 138);
            this.btRestoreChess.TabIndex = 12;
            this.btRestoreChess.UseVisualStyleBackColor = true;
            this.btRestoreChess.Click += new System.EventHandler(this.lbRestoreChess_Click);
            // 
            // lbRestoreChess
            // 
            this.lbRestoreChess.BackColor = System.Drawing.Color.Transparent;
            this.lbRestoreChess.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRestoreChess.ForeColor = System.Drawing.Color.White;
            this.lbRestoreChess.Location = new System.Drawing.Point(692, 167);
            this.lbRestoreChess.Name = "lbRestoreChess";
            this.lbRestoreChess.Size = new System.Drawing.Size(97, 25);
            this.lbRestoreChess.TabIndex = 13;
            this.lbRestoreChess.Text = "复原棋";
            this.lbRestoreChess.Click += new System.EventHandler(this.lbRestoreChess_Click);
            // 
            // GameCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::Mygame.Properties.Resources.IndexBackgrond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 570);
            this.Controls.Add(this.lbPoint24);
            this.Controls.Add(this.lbRestoreChess);
            this.Controls.Add(this.btRestoreChess);
            this.Controls.Add(this.btPoint24);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.lbCalculation);
            this.Controls.Add(this.btCalculation);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.lbTime);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameCentre";
            this.Text = "游戏中心";
            this.Load += new System.EventHandler(this.GameCentre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btCalculation;
        private System.Windows.Forms.Label lbCalculation;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btPoint24;
        private System.Windows.Forms.Label lbPoint24;
        private System.Windows.Forms.Button btRestoreChess;
        private System.Windows.Forms.Label lbRestoreChess;
    }
}

