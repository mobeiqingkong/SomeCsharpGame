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
    public partial class RestoreChess : Form
    {
        int N = 0; //行列数
        int M; //由combox选择的行列数
        public int swapCounter = 0;//计算总步数
        public int gametime = 0;//计算时间花费
        Button[,] buttons = new Button[10, 10];//定义一个按钮数值
        public RestoreChess()
        {
            InitializeComponent();
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            M = int.Parse(cbSelect.Text);//每次进行选择时,将选择的值赋给M
        }

        private void btNewGame_Click(object sender, EventArgs e)
                //点击开始游戏的时候
        {
            if (cbSelect.Text!="")
                //如果有选择游戏模式
            {
                ClearButtonsArray();//清除上一局的按钮
                N = M;//新的行列数
                InitializeButtonsArray();//构建新一局的按钮
                swapCounter = 0;//步数清零
                lbTest.Text = "次数:" + swapCounter.ToString();//lbTest显示步数
                gametime = 0;//时间清零
                lbTime.Text = "已用时:0";//tbTime显示时间
                StarGame();//开始游戏
            }
            else {
                MessageBox.Show("请选择游戏模式", "提示");
                //没有选择游戏模式的话则提示"请选择游戏模式"
            }
        }

        private void RestoreChess_Load(object sender, EventArgs e)
        {
        }
        private void ClearButtonsArray()
            //清除按钮
        {
            for (int r = 0; r < N; r++)
                for (int c = 0; c < N; c++)
                {
                    this.Controls.Remove(buttons[r, c]);
                    //清空按钮,this.Controls指的是该窗口的控件,这条语句是移除所有buttons[r, c]
                }
        }
        private void InitializeButtonsArray()
        //初始化按钮布局
        {
            int x0 = 10, y0 = 10, w = 45, d = 50;
            //x0,y0用来控制按钮间的间距,w控制一个按钮的宽度与高度,d是控制两个按钮间的距离
            for (int r = 0; r < N; r++)
                for (int c = 0; c < N; c++)
                    //总共N*N个按钮
                {
                    int num = r * N + c;
                    //num从0开始计数,第r行c列的num值为(r-1)*N+(c-1)
                    Button btn = new Button();
                    //声明一个Button类型的btn
                    btn.Text = (num + 1).ToString();
                    //这个button显示的文本为num+1
                    btn.Top = y0 + r * d;
                    //这个button距离上边 y0 + r * d
                    btn.Left = x0 + c * d;
                    //这个button距离左边 x0 + c * d

                    btn.Width = w;
                    //设置该button的宽度为w
                    btn.Height = w;
                    //设置该button的高度为w

                    btn.Visible = true;
                    //button可视化
                    //btn.Enabled = false;

                    btn.Tag = num; 
                    //按钮序号,按钮位置不变,Tag不变,就Text交换
                    btn.Click += new EventHandler(Btn_Click);
                    //委托注册button点击事件
                    buttons[r, c] = btn; //新按钮放入按钮阵列
                    this.Controls.Add(btn); //加载到界面
                }
            buttons[N - 1, N - 1].Visible = false; //留一个空位
        }

        void StarGame()
            //打乱按钮布局
        {
            int r = N - 1, c = N - 1;
            //默认buttons[N - 1, N - 1]为空,所以r,c设置为N-1
            for (int i = 0; i < N*N*N; i++)
                //电脑模拟人走棋,执行100次
            {
                Swap(buttons[r, c], FindNeighbor(buttons[r, c]));
                //不断交换buttons[r, c]与它相邻按钮
                r = r3;
                c = c3;
                //将原来buttons[r, c]的相邻按钮的r与c赋值回r,用来继续走棋
            }
            timer1.Enabled = true;
            //开启计时器
        }

        void Swap(Button b1, Button b2)
            //交换两个按钮的Text以及可视化状态
        {
            string tmpText = b1.Text;
            b1.Text = b2.Text;
            b2.Text = tmpText;
            //交换两个按钮的Text
            bool tmpVisible = b1.Visible;
            b1.Visible = b2.Visible;
            b2.Visible = tmpVisible;
            //交换两个按钮的可视化状态
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button current = sender as Button; 
            //当前点中按钮
            Button blank = FindeHiddenButton(); 
            //空白按钮
            if (IsNeighbor(current, blank))
                //如果点击的按钮与空白按钮相邻
            {
                Swap(current, blank);
                //执行swap操作
                swapCounter += 1;
                //步数加一
                lbTest.Text = "次数:" + swapCounter.ToString();
                //显示到lbTest上
                blank.Focus();
                //锁定到刚才点击交换的按钮
            }
            if (Victory())
            {
                timer1.Enabled = false;
                //时间停止
                MessageBox.Show("胜利！\n\t用时"+lbTime.Text+"\n\t点击"+swapCounter+"次","游戏结束！");
                //游戏成功的提示
                swapCounter = 0;//步数清零
                lbTest.Text = "次数:" + swapCounter.ToString();//lbTest显示步数
                gametime = 0;//时间清零
                lbTime.Text = "已用时:0";//tbTime显示时间
            }
        }

        Button FindeHiddenButton()
            //寻找空白的按钮
        {
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    if (!buttons[r, c].Visible)
                    {
                        return buttons[r, c];
                        //如果该按钮为不可视(空白),则返回该button
                    }
                }
            }
            return null;
            //没找到不可视(空白)button,返回null
        }
        int r3, c3,OldTag;//声明在外面,因为StarGame()要用到值,OldTag用来记录先前一步的T按钮的Tag
        private Button FindNeighbor(Button b1)
        //为了保证游戏一定有解,采用模拟走棋法,每次都与相邻的按钮交换,FindNeighbor用来寻找可交换的相邻按钮
        {
            int t1 = (int)b1.Tag;

            //记录传入的button的Tag的值
            int[] b2 = new int[4];
            //b2是b1可能的邻居按钮
            int[] b3 = new int[4];
            //b3是b1真实的邻居按钮
            b2[0] = t1 - N;
            //如果邻居按钮在上面,tag就是t1-N
            b2[1] = t1 + N;
            //如果邻居按钮在下面,tag就是t1+N
            b2[2] = t1 - 1;
            //如果邻居按钮在左边,tag就是t1-1
            b2[3] = t1 + 1;
            //如果邻居按钮在右边,tag就是t1+1
            int m = 0;
            //m用来记录b3有效长度
            for (int i = 0; i < b2.Length; i++)//循环查询b2的有效值
            {/*
                if (i == 0 && b2[i] >= 0)
                {
                        b3[m] = b2[i];
                        m++;
                }
                else if (i==1 && b2[i] < N * N)
                {
                    b3[m] = b2[i];
                    m++;
                }
                else if (i == 2 && (b2[2] + 1) % N != 0)
                {
                        b3[m] = b2[i];
                        m++;
                }
                else if (i == 3&& b2[3] % N != 0)
                {
                        b3[m] = b2[i];
                        m++;
                }*/

                switch (i)
                {
                    case 0:
                        if (b2[i] >= 0&&b2[i]!=OldTag)
                            //如果上一排的Tag>=0,即存在向上的邻居按钮,不为OldTag是为了防止走棋反复
                        {
                            b3[m] = b2[i];
                            m++;
                        }
                        break;
                    case 1:
                        if (b2[i] < N * N && b2[i] != OldTag)
                        //如果下一排的Tag<N*N且不为之前的按钮,即存在向下的邻居按钮,不为OldTag是为了防止走棋反复
                        {
                            b3[m] = b2[i];
                            m++;
                        }
                        break;
                    case 2:
                        //if ((int)(b2[i] / N) == (int)((b2[i] + 1) / N))
                        if ((b2[i] + 1) % N != 0 && b2[i] != OldTag)
                            //0 1 2
                            //3 4 5
                            //6 7 8
                        //如果Button按钮的Tag-1不是N的倍数且不为之前的按钮,即存在向左的邻居按钮,见上图,不为OldTag是为了防止走棋反复
                        {
                            b3[m] = b2[i];
                           // MessageBox.Show(b3[m].ToString());
                            m++;
                        }
                        break;
                    case 3:
                        //if ((int)((b2[i] / N)) == (int)((b2[i]-1) / N))
                        if (b2[i] % N != 0 && b2[i] != OldTag)
                        //如果Button按钮的Tag+1不是N的倍数且不为之前的按钮,即存在向右的邻居按钮,见上图,不为OldTag是为了防止走棋反复
                        {
                            b3[m] = b2[i];
                           // MessageBox.Show(b3[m].ToString());
                            m++;
                        }
                        break;
                }
            }
                /*
                    //tag值在0-N*N内有效,以3*3为例,Tag排列如图(注意Tag不是Text)
                    //0 1 2
                    //3 4 5
                    //6 7 8
                    //0 1
                    //2 3
                    //Tag是不变的,Text一直在交换,简单说就是显示的在变化,按钮布局没有交换
                    //将b2里有效值传入b3
                    //每传入一个有效值,m加一
                }*/
                Random Random = new Random();
                int Rand = Random.Next(0, m);
                //定义一个随机数在[0,m)之间的整数
                //如果m为3,那么Rand就有可能是0,1,2,就有可能取b3[0],b3[1],b3[2]三个有效值
                        for (int k = 0; k < 4; k++)
                        {
                            if (Rand == k)
                            {
                                r3 = b3[k] / N;
                                c3 = b3[k] % N;
                                OldTag = t1;
                                return buttons[r3, c3];
                            }
                        }
                return null;
            }
            
        bool IsNeighbor(Button b1, Button b2)
            //判断两个按钮是否相邻
        {
            int t1 = (int)b1.Tag;
            //第一个按钮的tag属性赋值给t1
            int t2 = (int)b2.Tag;
            //第二个按钮的tag属性赋值给t2
            int r1 = t1 / N, c1 = t1 % N;
            //由t1反推r1与c1
            int r2 = t2 / N, c2 = t2 % N;
            //由t2反推r2与c2
            //因为tag的计算公式为r * N + c,又c<N,所以tag/N取整就是r,tag/N取余就
            if (System.Math.Abs(r1 - r2) + System.Math.Abs(c1-c2)==1)
            //如果距离为1
            {
                return true;
                //判断相邻,返回true
            }
            return false;
            //否则判断不相邻,返回false
        }

        bool Victory()
            //判断是否游戏结束
        {
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                   // if (buttons[r, c].Text != (r * N + c + 1).ToString())
                    if (int.Parse(buttons[r, c].Text) != int.Parse(buttons[r,c].Tag.ToString())+1)
                        //Text值比Tag值多1,通过遍历所有按钮的Text值与Tag值的情况判断游戏是否结束
                    {
                        return false;
                        //如果从buttons[0, 0]到buttons[N-1, N-1],存在某个button的Text不为它应该具有的号码,返回false
                    }
                }
            }
            return true;
            //如果从buttons[0, 0]到buttons[N-1, N-1]已经全部排序,则返回true
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gametime += 1;
            //每秒gametime加1
            lbTime.Text = "已用时:"+gametime.ToString();
            // lbTime显示已用时间
        }

        private void btExitChess_Click(object sender, EventArgs e)
            //点击退出游戏
        {
            Mygame.GameCentre.MainForm.Show();
            //显示主游戏界面
            this.Close();
            //关闭该界面
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("首先选择游戏模式，如果选择的游戏模式为n，则第一行为1到n，\n第二行为n+1到2n，以此类推，第n行为n（n-1）+1到n*n-1，\n比如说，选择的游戏模式是3，则会有3*3的九宫格，玩家通过交换，\n最终使得第一行的数字为123，第二行为456，第三行为78", "玩法介绍");
            //游戏玩法提示
        }

        private void RestoreChess_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mygame.GameCentre.MainForm.Show();
            //关闭窗口时打开游戏主界面
        }
    }
}
