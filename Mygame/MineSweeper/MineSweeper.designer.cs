namespace Mygame
{
    partial class MineSweeper
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
            this.resetbutton = new System.Windows.Forms.Button();
            this.Mypanel = new System.Windows.Forms.Panel();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(363, 28);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(4);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(53, 50);
            this.resetbutton.TabIndex = 0;
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Mypanel
            // 
            this.Mypanel.Location = new System.Drawing.Point(100, 95);
            this.Mypanel.Name = "Mypanel";
            this.Mypanel.Size = new System.Drawing.Size(600, 600);
            this.Mypanel.TabIndex = 1;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(100, 28);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 25);
            this.tbX.TabIndex = 2;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(100, 59);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 25);
            this.tbY.TabIndex = 3;
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(34, 28);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(60, 15);
            this.lbX.TabIndex = 4;
            this.lbX.Text = "宽度为:";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(37, 59);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(52, 15);
            this.lbY.TabIndex = 5;
            this.lbY.Text = "高度为";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(225, 59);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(78, 25);
            this.btSubmit.TabIndex = 6;
            this.btSubmit.Text = "确认设置";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // MineSweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.Mypanel);
            this.Controls.Add(this.resetbutton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MineSweeper";
            this.Text = "扫雷";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MineSweeper_FormClosing);
            this.Load += new System.EventHandler(this.MineSweeper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Panel Mypanel;
        
    }
}

