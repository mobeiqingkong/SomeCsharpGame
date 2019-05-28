using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mygame
{
    public partial class GameCentre : Form
    {
        public static GameCentre MainForm = null;
        public GameCentre()
        {
            InitializeComponent();
            this.ControlBox = false;
            MainForm = this; //设置当前窗口对象为MainForm,便于之后展开
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }
        private void GameCentre_Load(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
            MainTimer.Enabled = true;
            MainTimer.Interval = 100;
        }
        private void btCalculation_Click(object sender, EventArgs e)
        {
            Mygame.Calculation C = new Mygame.Calculation();
            C.Show();
            this.Hide();
        }
        private void lbCalculation_Click(object sender, EventArgs e)
        {
            Mygame.Calculation C = new Mygame.Calculation();
            C.Show();
            this.Hide();
        }
        private void btPoint24_Click(object sender, EventArgs e)
        {
            Point24 P = new Point24();
            P.Show();
            this.Hide();
        }
        private void lbPoint24_Click(object sender, EventArgs e)
        {
            Point24 P = new Point24();
            P.Show();
            this.Hide();
        }
        private void btRestoreChess_Click(object sender, EventArgs e)
        {
            RestoreChess M = new RestoreChess();
            M.Show();
            this.Hide();//将本窗口隐藏
        }
        private void lbRestoreChess_Click(object sender, EventArgs e)
        {
            RestoreChess M = new RestoreChess();
            M.Show();
            this.Hide();//将本窗口隐藏
        }
        private void btAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者: \n邱龙志\n顾宇晴\n\n版本:1.0.1", "关于");
        }
        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
