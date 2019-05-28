using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mygame
{
    public partial class MineSweeper : Form
    {
        //是否首次运行
        public int isFirst = 1;
        int xMax = Mygame.Properties.Settings.Default.MineSweeperX;
        int yMax = Mygame.Properties.Settings.Default.MineSweeperY;
        //核心矩阵
        public Core core = new Core();
        public void RefreshMineSweeper()
        {
        int xMax = Mygame.Properties.Settings.Default.MineSweeperX;
        int yMax = Mygame.Properties.Settings.Default.MineSweeperY;
        //核心矩阵
        Core core = new Core();
        Button[,] b = new Button[Mygame.Properties.Settings.Default.MineSweeperX - 2, Mygame.Properties.Settings.Default.MineSweeperY - 2];
        //标签
        Label[,] l = new Label[Mygame.Properties.Settings.Default.MineSweeperX - 2, Mygame.Properties.Settings.Default.MineSweeperY - 2];
        init();
        core.resetM();
        }
        //用于装载按钮的主面板
        //按钮
        public Button[,] b = new Button[Mygame.Properties.Settings.Default.MineSweeperX - 2, Mygame.Properties.Settings.Default.MineSweeperY - 2];
        //标签
        public Label[,] l = new Label[Mygame.Properties.Settings.Default.MineSweeperX - 2, Mygame.Properties.Settings.Default.MineSweeperY - 2];

        public MineSweeper()
        {
            InitializeComponent();
        }

        private void MineSweeper_Load(object sender, EventArgs e)
        {
            try
            {
                this.Icon = Properties.Resources.WinMine;
                resetbutton.Image = Properties.Resources.happy;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            init();
            core.resetM();
        }

        //初始化
        private void init()
        {
            for (int i = 0; i < xMax - 2; i++)
            {
                for (int j = 0; j < yMax - 2; j++)
                {
                    //为 Button 添加坐标信息
                    int[] t = new int[2];
                    t[0] = i;
                    t[1] = j;
                    // Button 初始化
                    b[i, j] = new Button();
                    b[i, j].Size = new Size((int)(Mypanel.Width / (xMax - 2)), (int)(Mypanel.Height / (yMax - 2)));
                    b[i, j].Location = new Point(i * (int)(Mypanel.Width / (xMax - 2)), j * (int)(Mypanel.Height / (yMax - 2)));
                    b[i, j].Tag = t;
                    b[i, j].Visible = true;
                    // Label 初始化
                    l[i, j] = new Label();
                    l[i, j].Size = new Size((int)(Mypanel.Width / (xMax - 2)), (int)(Mypanel.Height / (yMax - 2)));
                    l[i, j].Location = new Point(i * (int)(Mypanel.Width / (xMax - 2)), j * (int)(Mypanel.Height / (yMax - 2)));
                    l[i, j].BorderStyle = BorderStyle.FixedSingle;
                    l[i, j].BackColor = Color.LightGray;
                    l[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    l[i, j].Visible = false;

                    //添加到主面板
                    Mypanel.Controls.Add(l[i, j]);
                    Mypanel.Controls.Add(b[i, j]);
                    //为 Button 添加事件
                    b[i, j].MouseDown += button_MouseDown;
                }
            }
        }

        // Button 的事件
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            resetbutton.Focus();
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (bt.Image == null)
                {
                    if(core.mines[((int[])bt.Tag)[0] + 1, ((int[])bt.Tag)[1] + 1] < 20)
                    {
                        core.mines[((int[])bt.Tag)[0] + 1, ((int[])bt.Tag)[1] + 1] += 20;
                    }
                    try
                    {
                        bt.Image = Properties.Resources.flag;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Application.Exit();
                    }
                }
                else
                {
                    if (core.mines[((int[])bt.Tag)[0] + 1, ((int[])bt.Tag)[1] + 1] >= 20)
                    {
                        core.mines[((int[])bt.Tag)[0] + 1, ((int[])bt.Tag)[1] + 1] -= 20;
                    }
                    bt.Image = null;
                }
            }
            else if(e.Button == System.Windows.Forms.MouseButtons.Left && bt.Image == null)
            {
                // 1为游戏继续，0为踩雷
                int check = core.rmM(((int[])bt.Tag)[0] + 1, ((int[])bt.Tag)[1] + 1);
                if (check == 1)
                {
                    isFirst = 0;
                    new graph().showM(b, l, core);
                }
                else if (isFirst == 1 && check == 0)
                {
                    //首次踩雷处理
                    do
                    {
                        core.resetM();
                    } while (core.rmM(((int[])bt.Tag)[0] + 1, ((int[])bt.Tag)[1] + 1) == 0);
                    isFirst = 0;
                    new graph().showM(b, l, core);
                }
                else if (isFirst == 0 && check == 0)
                {
                    new graph().lose(b, l, core);
                    return;
                }
            }
            int isWin = core.win_check();
            if(isWin == 0)
            {
                new graph().win(b, l, core);
                return;
            }
        }

        //重置按钮事件
        private void resetbutton_Click(object sender, EventArgs e)
        {
            isFirst = 1;
            for (int i = 0; i < xMax - 2; i++)
            {
                for (int j = 0; j < yMax - 2; j++)
                {
                    l[i, j].Visible = false;
                    b[i, j].Image = null;
                    b[i, j].Visible = true;
                }
            }
            core.resetM();
        }

        private void MineSweeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mygame.GameCentre.MainForm.Show();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            Mygame.Properties.Settings.Default.MineSweeperX = int.Parse(tbX.Text);
            Mygame.Properties.Settings.Default.MineSweeperY = int.Parse(tbY.Text);
            Mygame.Properties.Settings.Default.Save();
        }
    }




    public class Core
    {
        public int minesNum = Mygame.Properties.Settings.Default.minesNum;
        public int xMax = Mygame.Properties.Settings.Default.MineSweeperX;
        public int yMax = Mygame.Properties.Settings.Default.MineSweeperY;
        public int[,] mines = new int[Mygame.Properties.Settings.Default.MineSweeperX, Mygame.Properties.Settings.Default.MineSweeperY];

        //清空矩阵
        public void clearM()
        {
            for (int i = 0; i <= xMax - 1; i++)
            {
                for (int j = 0; j <= yMax - 1; j++)
                {
                    mines[i, j] = 0;
                }
            }
        }

        //布雷函数
        public void setM()
        {
            int counter = 0;
            int i, j;
            Random r = new Random(System.DateTime.Now.Millisecond);
            while (counter < minesNum)
            {
                i = r.Next(1, xMax - 1);
                j = r.Next(1, yMax - 1);
                if (mines[i, j] == 0)
                {
                    mines[i, j] = 9;
                    counter++;
                }
            }
            for (i = 1; i <= xMax - 2; i++)
            {
                for (j = 1; j <= yMax - 2; j++)
                {
                    if (mines[i, j] != 9)
                    {
                        int c = 0;
                        if (mines[i - 1, j - 1] == 9)
                            c++;
                        if (mines[i - 1, j] == 9)
                            c++;
                        if (mines[i - 1, j + 1] == 9)
                            c++;
                        if (mines[i, j - 1] == 9)
                            c++;
                        if (mines[i, j + 1] == 9)
                            c++;
                        if (mines[i + 1, j - 1] == 9)
                            c++;
                        if (mines[i + 1, j] == 9)
                            c++;
                        if (mines[i + 1, j + 1] == 9)
                            c++;
                        mines[i, j] = c;
                    }
                }
            }
        }

        //排雷函数
        public int rmM(int x, int y)
        {
            if (x <= 0 || y <= 0 || x >= xMax - 1 || y >= yMax - 1)
            {
                return -1;
            }
            else if (mines[x, y] == 9)
                return 0;
            else if (mines[x, y] >= 1 && mines[x, y] <= 8)
            {
                mines[x, y] += 10;
                return 1;
            }
            else if (mines[x, y] == 0)
            {
                mines[x, y] += 10;
                rmM(x - 1, y - 1);
                rmM(x - 1, y);
                rmM(x - 1, y + 1);
                rmM(x, y - 1);
                rmM(x, y + 1);
                rmM(x + 1, y - 1);
                rmM(x + 1, y);
                rmM(x + 1, y + 1);
                return 1;
            }
            else
            {
                return 2;
            }
        }

        //重置矩阵
        public void resetM()
        {
            clearM();
            setM();
        }

        //胜利判断
        public int win_check()
        {
            int c = 0;
            for (int i = 1; i < xMax - 1; i++)
            {
                for (int j = 1; j < yMax - 1; j++)
                {
                    if (mines[i, j] <= 9)
                        c++;
                    if (mines[i, j] >= 20 && mines[i, j] != 29)
                        c++;
                }
            }
            // 0为胜利
            return c;
        }
    }

    class graph
    {
        int xMax = Mygame.Properties.Settings.Default.MineSweeperX;
        int yMax = Mygame.Properties.Settings.Default.MineSweeperY;

        //在 Button 上打印矩阵信息(测试用)
        public void printM(Button[,] b, Core core)
        {
            for (int i = 0; i < xMax - 2; i++)
            {
                for (int j = 0; j < yMax - 2; j++)
                {
                    b[i, j].Text = core.mines[i + 1, j + 1].ToString();
                }
            }
        }

        //显示
        public void showM(Button[,] b, Label[,] l, Core core)
        {
            for (int i = 0; i < xMax - 2; i++)
            {
                for (int j = 0; j < yMax - 2; j++)
                {
                    l[i, j].Image = null;
                    if (core.mines[i + 1, j + 1] >= 0 && core.mines[i + 1, j + 1] <= 9)
                    {

                    }
                    else if (core.mines[i + 1, j + 1] == 10)
                    {
                        b[i, j].Visible = false;
                        l[i, j].Visible = true;
                        l[i, j].Text = "";
                    }
                    else if (core.mines[i + 1, j + 1] > 10 && core.mines[i + 1, j + 1] <= 18)
                    {
                        b[i, j].Visible = false;
                        l[i, j].Visible = true;
                        l[i, j].Text = (core.mines[i + 1, j + 1] - 10).ToString();
                    }
                    else if (core.mines[i + 1, j + 1] >= 20 && core.mines[i + 1, j + 1] <= 29)
                    {

                    }
                }
            }
        }

        //胜利
        public void win(Button[,] b, Label[,] l, Core core)
        {
            for (int i = 0; i < xMax - 2; i++)
            {
                for (int j = 0; j < yMax - 2; j++)
                {
                    b[i, j].Visible = false;
                    l[i, j].Visible = true;
                    if (core.mines[i + 1, j + 1] == 10)
                    {
                        l[i, j].Image = null;
                        l[i, j].Text = "";
                    }
                    else if (core.mines[i + 1, j + 1] > 10 && core.mines[i + 1, j + 1] <= 18)
                    {
                        l[i, j].Image = null;
                        l[i, j].Text = (core.mines[i + 1, j + 1] - 10).ToString();
                    }
                    else if (core.mines[i + 1, j + 1] == 29)
                    {
                        l[i, j].Text = "";
                        try
                        {
                            l[i, j].Image = Properties.Resources.correct;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Application.Exit();
                        }
                    }
                }
            }
        }

        //失败
        public void lose(Button[,] b, Label[,] l, Core core)
        {
            for (int i = 0; i < xMax - 2; i++)
            {
                for (int j = 0; j < yMax - 2; j++)
                {
                    b[i, j].Visible = false;
                    l[i, j].Visible = true;
                    if (core.mines[i + 1, j + 1] == 0 || core.mines[i + 1, j + 1] == 10)
                    {
                        l[i, j].Image = null;
                        l[i, j].Text = "";
                    }
                    else if (core.mines[i + 1, j + 1] > 0 && core.mines[i + 1, j + 1] <= 8)
                    {
                        l[i, j].Image = null;
                        l[i, j].Text = core.mines[i + 1, j + 1].ToString();
                    }
                    else if (core.mines[i + 1, j + 1] == 9)
                    {
                        l[i, j].Text = "";
                        try
                        {
                            l[i, j].Image = Properties.Resources.bomb;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Application.Exit();
                        }
                    }
                    else if (core.mines[i + 1, j + 1] > 10 && core.mines[i + 1, j + 1] <= 18)
                    {
                        l[i, j].Image = null;
                        l[i, j].Text = (core.mines[i + 1, j + 1] - 10).ToString();
                    }
                    else if (core.mines[i + 1, j + 1] == 29)
                    {
                        l[i, j].Text = "";
                        try
                        {
                            l[i, j].Image = Properties.Resources.correct;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Application.Exit();
                        }
                    }
                    else if (core.mines[i + 1, j + 1] >= 20 && core.mines[i + 1, j + 1] <= 28)
                    {
                        l[i, j].Text = "";
                        try
                        {
                            l[i, j].Image = Properties.Resources.cross;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Application.Exit();
                        }
                    }
                }
            }
        }
    }
}
