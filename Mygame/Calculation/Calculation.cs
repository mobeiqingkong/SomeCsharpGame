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
    public partial class Calculation : Form
    {
        public static Calculation ca = null;
        //创建一个名为ca的窗口对象
        public Calculation()
        {
            InitializeComponent();
            //初始化Calculation
            ca = this;
            //将this指针指向ca
            this.DoubleBuffered = true;
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
        private Random RandomNum = new Random();
        //定义一个RandomNum用来生成随机数
        private float Algorithm;
        //
        private int TimeLeft,Score,LeftNum, RightNum, RealResult, RandomResult;
        //定义剩余时间,已获得的分数,一个左边的数,一个右边的数,真值,随机结果
        private void Calculation_Load(object sender, EventArgs e)
        {
        }

        private void btExit_Click(object sender, EventArgs e)
            //如果点击了退出游戏
        {
            GameCentre.MainForm.Show();
            //显示游戏主界面
            ca.Close();
            //退出加减大师界面
        }
        private void btLeaderboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("最高分为:"+Properties.Settings.Default.Calculation_MaxScore.ToString(),"排行榜" );//显示保存的最高分
            //MaxScore记录在Properties.Settings里,可直接调用
        }
        private void CalculationGameOver()
            //游戏结束
        {
            GameTime.Enabled = false;
            //将时间暂停
            if (Score > Properties.Settings.Default.Calculation_MaxScore)
                //如果获得的分数大于记录的分数
            { 
                Properties.Settings.Default.Calculation_MaxScore = Score;
                //刷新最高分
                Properties.Settings.Default.Save();
                //保存用户的更改
            }
            DialogResult dr = MessageBox.Show("你的分数为:"+Score.ToString(),"游戏结束",  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK) 
            {//如果用户点击确认,就执行GameStop方案,停止游戏,回到一开始的状态
                GameStop();
            }
            else
            {//如果用户点击的不是确认,就重新开始一局游戏,此时将分数归0,时间重置并开始游戏
                Score=0;
                //分数归零
               TimeLeft = 3;
                //时间重置为3
                GameTime.Enabled = true;
                //时间继续走动
                RefreshCalculation();
                //执行刷新
            }
        }        
        private void GameStop() 
        {//回到刚进入的状态
            lbLeftNum.Text = "";
            lbAlgorithm.Text = "";
            lbRightNum.Text = "";
            lbResult.Text = "";
            lbTimeLeft.Text = "残り時間:";
            //五个label都清空
            GameTime.Enabled = false;
            //时间暂停
            TimeLeft = 3;
            //时间重置
        }
        private void RefreshCalculation() 
            //刷新游戏算式
        {
            TimeLeft = 3;
            //重置时间为3
            lbTimeLeft.Text = "残り時間:"+TimeLeft.ToString();
            //显示重置的时间3
            LeftNum =RandomNum.Next(1, 20);//(生成1-20之间的随机数，不包括20)
            RightNum = RandomNum.Next(1, 20);//(生成1-20之间的随机数，不包括20)
            Algorithm = RandomNum.Next(0, 1);//(生成0-1之间的随机数，不包括20)
            if (Algorithm >= 0.5)
            {
                //如果Algorithm >= 0.5,则进行加法运算
                lbLeftNum.Text = LeftNum.ToString();
                lbRightNum.Text = RightNum.ToString();
                //将LeftNum与RightNum显示在label里
                lbAlgorithm.Text = "+";
                //lbAlgorithm显示加法
                RealResult = LeftNum + RightNum;//RealResult是正确计算的结果
                RandomResult = int.Parse(RandomNum.Next(RealResult - 1, RealResult + 1).ToString());
                //随机生成错误结果,与正确结果差1以内
                lbResult.Text = RandomResult.ToString();
                //随机生成的结果显示在lbResult内
            }
            else
            {
                //如果Algorithm < 0.5,则进行减法运算
                RealResult = LeftNum - RightNum;
                //RealResult是正确计算的结果
                lbLeftNum.Text = LeftNum.ToString();
                lbRightNum.Text = RightNum.ToString();
                //将LeftNum与RightNum显示在label里
                lbAlgorithm.Text = "-";
                //lbAlgorithm显示减法
                RealResult = LeftNum - RightNum;//这是正确计算的结果
                RandomResult = int.Parse(RandomNum.Next(RealResult - 1, RealResult + 1).ToString());
                //随机生成错误结果,与正确结果差1以内
                lbResult.Text = RandomResult.ToString();
                //随机生成的结果显示在lbResult内
            }
        }
        private void btNewGame_Click(object sender, EventArgs e)
            //点击新游戏
        {
            
            GameTime.Enabled = true; //开始计时
            GameTime.Interval = 1000; //设置实践执行周期为1000毫秒
            Score = 0;//分数归零
            RefreshCalculation();//刷新算式
            lbTimeLeft.Text = "残り時間:"+TimeLeft.ToString();
        }
        private void btRight_Click(object sender, EventArgs e)
            //点击打勾按钮
        {
            if (lbLeftNum.Text == "")
            {
                MessageBox.Show("请先开始游戏","提示");
                
                //如果没有数据就点击游戏结果判断的按钮就会弹窗
            }
            else
            {
                if (Algorithm >= 0.5)
                {
                    if (LeftNum + RightNum == RandomResult)
                        //如果加法判断正确
                    {
                        Score++;//对加法判断正确(结果相等)分数加1
                        RefreshCalculation();//刷新算式
                    }
                    else
                    {
                        CalculationGameOver();//判断错误,游戏结束
                    }
                }
                else
                {
                    if (LeftNum - RightNum == RandomResult)
                    //如果减法判断正确
                    {
                        Score++;//对减法判断正确(结果相等)分数加1
                        RefreshCalculation();//刷新算式
                    }
                    else
                    {
                        CalculationGameOver();//判断错误,游戏结束
                    }
                }
            }
        }

        private void btError_Click(object sender, EventArgs e)
            //点击打叉按钮
        {

            if (lbLeftNum.Text == "")
            {
                MessageBox.Show("请先开始游戏", "提示");//如果没有数据就点击游戏结果判断的按钮就会弹窗
            }
            else
            {
                if (Algorithm >= 0.5)
                {
                    if (LeftNum + RightNum != RandomResult)
                    {
                        Score++;//对加法判断正确(结果不相等)分数加1
                        RefreshCalculation();//刷新算式
                    }
                    else
                    {
                        CalculationGameOver();//判断错误,游戏结束
                    }
                }
                else
                {
                    if (LeftNum - RightNum != RandomResult)
                    {
                        Score++;//对减法判断正确(结果不相等)分数加1
                        RefreshCalculation();//刷新算式
                    }
                    else
                    {
                        CalculationGameOver();//判断错误,游戏结束
                    }
                }
            }
        }
        private void GameTime_Tick(object sender, EventArgs e)
        {

            --TimeLeft;//每秒TimeLeft减一
            lbTimeLeft.Text ="残り時間:"+ TimeLeft.ToString();//显示剩余时间
            
            if (TimeLeft < 0)//如果剩余时间小于0,即回答超时
            {
                GameTime.Enabled = false;//时间暂停计算
                CalculationGameOver();//游戏结束
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Calculation_MaxScore=0;//重置最高分为0
            Properties.Settings.Default.Save();//保存用户的更改
        }

        private void Calculation_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameCentre.MainForm.Show();//窗口关闭时,显示主界面
        }

        private void lbGameBegin_Click(object sender, EventArgs e)
        {
            GameTime.Enabled = true; //开始计时
            GameTime.Interval = 1000; //设置实践执行周期为1000毫秒
            Score = 0;//分数归零
            RefreshCalculation();//刷新算式
            lbTimeLeft.Text = TimeLeft.ToString();
        }

        private void btGamebegin_Click(object sender, EventArgs e)
        {
            GameTime.Enabled = true; //开始计时
            GameTime.Interval = 1000; //设置实践执行周期为1000毫秒
            Score = 0;//分数归零
            RefreshCalculation();//刷新算式
            lbTimeLeft.Text = "残り時間:"+TimeLeft.ToString();
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击开始游戏,会在下方随机生成两个数字以及它们的计算结果,玩家必须在规定的时间内做出判断,如果超时或者判断错误,游戏结束","游戏帮助");
        }

    }
}
