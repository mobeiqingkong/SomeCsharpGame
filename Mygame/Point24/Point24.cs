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
    public partial class Point24 : Form
    {
        public Point24()
        {
            InitializeComponent();
        }
        private Random RandomNum = new Random();//用来生成随机数
        private int[] num =new int[4];//声明一个长度为4的数组

        private void btGameBegin_Click(object sender, EventArgs e)
            //点击游戏开始的事件
        {
            float[] cards = new float[4];
            //声明一个float数组用来存放四个数值
            for (int i = 1; i <= 4; ++i)
            //给每个label的Text循环赋值
            {
                Label label = (Label)this.tlpPoint24.Controls["lbNum" + i.ToString()];
                //label每次指定为lbNum i
                RandomNum.Next(1, 10);
                //随机生成1-9之间的数
                num[i - 1] = int.Parse(RandomNum.Next(1, 10).ToString());
                //强制类型转换float为int
                label.Text = num[i - 1].ToString();
                //显示数值
                cards[i - 1] = int.Parse(label.Text);
                //赋值到cards数组
            }
            if (cal(cards) != 1)
            {
                btRefresh4Num_Click(this, e);
                //如果计算不了24点,重新生成4个数
            }
        }

        private void tbCalculate_TextChanged(object sender, EventArgs e)
        {
            tbCalculate.Text = System.Text.RegularExpressions.Regex.Replace(tbCalculate.Text,@"[^1-9\+\-\*\/\\\(\)]","");
            //正则表达式替换,只允许计算的方框内有0-9*/+-(),非允许字符全部替换为空
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Mygame.GameCentre.MainForm.Show();
            this.Close();
        }
        public static float[] cal(float a, float b)
            //两个数之间的穷举运算
        {
            float[] result;
            if (a == 0 || b == 0)
            {
                if (a == 0 && b == 0)
                //计算的两个数都为0,只有一种结果就是0
                {
                    result = new float[1];
                    result[0] = 0;
                }
                else
                    //计算的两个数有一个为0,则有3种结果
                {
                    if (a == 0)
                    {
                        result = new float[3];
                        result[0] = b;
                        result[1] = 0 - b;
                        result[0] = 0;
                    }
                    else
                    {
                        result = new float[3];
                        result[0] = a;
                        result[1] = 0 - a;
                        result[0] = 0;
                    }
                }
            }
            else
                //如果都不为0,则最多有6个不同的值
            {
                result = new float[6];
                result[0] = a + b;
                result[1] = a - b;
                result[2] = a * b;
                result[3] = a / b;
                result[4] = b - a;
                result[5] = b / a;
            }
            return result;
        }
       
        public static string[] Cal = new string[3];//四个数一共经过3道计算,通过string数组记录下来
        public static bool OneThree=false;//判断式子是否是一个数与另外三位数计算的值再次计算得到24,称之为1&3型
        public static int cal(float[] cards)
        {
            int result = 0;
            if (cards.Length == 2)//如果数组只剩下两个数
            {
                float[] array = cal(cards[0], cards[1]);//进行穷举运算,将6个值重组为数组array

                for (int i = 0; i < array.Length; i++)
                {
                    if (  array[i] ==24)
                    //array[i]位于23.99999与24.00001之间,足够判断是否是24
                    {
                        if (OneThree == true)
                            //判断是否是1&3型,Cal[1]已经是三个数运算的算式,算式结果位于cards[1]
                        {
                            switch (i)
                            {
                                case 0:
                                    Cal[cards.Length - 2] = cards[0] + "+" + Cal[1];
                                    break;
                                case 1:
                                    Cal[cards.Length - 2] = cards[0] + "-" + Cal[1];
                                    break;
                                case 2:
                                    Cal[cards.Length - 2] = cards[0] + "*" + Cal[1];
                                    break;
                                case 3:
                                    Cal[cards.Length - 2] = "(" + cards[0] + "/" + Cal[1] + ")";
                                    break;
                                case 4:
                                    Cal[cards.Length - 2] = Cal[1] + "-" + cards[0];
                                    break;
                                case 5:
                                    Cal[cards.Length - 2] = "(" + Cal[1] + "/" + cards[0] + ")";
                                    break;
                            }
                        }
                        else
                            //如果是2&2型,则处理之前记录的两次算式,即Cal[1]和Cal[2]
                        {
                            switch (i)
                            {
                                case 0:
                                    Cal[cards.Length - 2] = Cal[2] + "+" + Cal[1] ;
                                    break;
                                case 1:
                                    Cal[cards.Length - 2] = Cal[2] + "-" + Cal[1] ;
                                    break;
                                case 2:
                                    Cal[cards.Length - 2] = Cal[2] + "*" + Cal[1] ;
                                    break;
                                case 3:
                                    Cal[cards.Length - 2] = "("+ Cal[2] + "/" + Cal[1] + ")";
                                    break;
                                case 4:
                                    Cal[cards.Length - 2] = Cal[1] + "-" + Cal[2] ;
                                    break;
                                case 5:
                                    Cal[cards.Length - 2] =  "("+Cal[1] + "/" + Cal[2] + ")";
                                    break;
                            }
                        }
                        result = 1;
                        OneThree = false;
                        break;
                    }
                }
                
            }
                
            else//如果数组剩余多于两个数
            {
                for (int i = 0; i < cards.Length - 1; i++)
                {
                    for (int j = i + 1; j < cards.Length; j++)
                    {
                        float[] array = cal(cards[i], cards[j]);
                        //穷举两个数之间的计算结果,构建结果数组array
                        float[] newdata = new float[cards.Length - 1];
                        //由未计算的数值与结果数组构建新数组newdata
                        int index = 0;
                        for (int k = 0; k < cards.Length; k++)
                        {
                            if (k != i && k != j)
                            //cards[i]和cards[j]都已经使用过,跳过
                            {
                                newdata[index] = cards[k];
                                //如果cards[k]未使用,放入新数组newdata里
                                index++;
                            }
                        }
                        for (int k = 0; k < array.Length; k++)
                        {
                            if (cards.Length == 3 && j - i > 1||cards.Length == 3&&i==1)
                            {
                                OneThree = true;
                                //判断为1&3型
                                switch (k)
                                {
                                    case 0:
                                        Cal[cards.Length - 2] = "(" + cards[i].ToString() + "+" + Cal[2] + ")";
                                        break;
                                    case 1:
                                        Cal[cards.Length - 2] = "(" + cards[i].ToString() + "-" + Cal[2].ToString() + ")";
                                        break;
                                    case 2:
                                        Cal[cards.Length - 2] = cards[i].ToString() + "*" + Cal[2];
                                        break;
                                    case 3:
                                        Cal[cards.Length - 2] = "("+cards[i].ToString() + "/" + Cal[2] + ")";
                                        break;
                                    case 4:
                                        Cal[cards.Length - 2] = "(" + Cal[2] + "-" + cards[i].ToString() + ")";
                                        break;
                                    case 5:
                                        Cal[cards.Length - 2] = "(" + Cal[2] + "/" + cards[i].ToString()+")";
                                        break;
                                }
                            }
                            else
                            {
                                OneThree = false;
                                switch (k)
                                {
                                    case 0:
                                        Cal[cards.Length - 2] = "(" + cards[i].ToString() + "+" + cards[j].ToString() + ")";
                                        break;
                                    case 1:
                                        Cal[cards.Length - 2] = "(" + cards[i].ToString() + "-" + cards[j].ToString() + ")";
                                        break;
                                    case 2:
                                        Cal[cards.Length - 2] = cards[i].ToString() + "*" + cards[j].ToString();
                                        break;
                                    case 3:
                                        Cal[cards.Length - 2] = "(" + cards[i].ToString() + "/" + cards[j].ToString() + ")";
                                        break;
                                    case 4:
                                        Cal[cards.Length - 2] = "(" + cards[j].ToString() + "-" + cards[i].ToString() + ")";
                                        break;
                                    case 5:
                                        Cal[cards.Length - 2] = "(" + cards[j].ToString() + "/" + cards[i].ToString() + ")";
                                        break;
                                }
                            }
                            newdata[newdata.Length - 1] = array[k];
                            //将结果数组挨个放入新数组newdata末位
                            result = cal(newdata);
                            //递归计算新数组
                            if (result == 1)
                            {
                                break;
                            }
                        }
                        if (result == 1)
                        {
                            break;
                        }
                    }
                    if (result == 1)
                    {
                        break;
                    }
                }
            }
            return result;
        }
        private void btCalculate24_Click(object sender, EventArgs e)
        {
            float[] cards = new float[4];
            cards[0] = int.Parse(tbNum1.Text);
            cards[1] = int.Parse(tbNum2.Text);
            cards[2] = int.Parse(tbNum3.Text);
            cards[3] = int.Parse(tbNum4.Text);
            if (cal(cards) == 1)
                //如果能够计算24点
            { 
                tbResult.Text = Cal[0];
                //输出计算过程 
            }
            else { 
                tbResult.Text = "无法计算24点";
            }
        }
        
        private void tbNum1_TextChanged(object sender, EventArgs e)
        {
            tbNum1.Text = System.Text.RegularExpressions.Regex.Replace(tbNum1.Text,"[^0-9]","");
            //正则表达式替换,只允许出现0-9的数字
        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {
            tbNum2.Text = System.Text.RegularExpressions.Regex.Replace(tbNum2.Text, "[^0-9]", "");
            //正则表达式替换,只允许出现0-9的数字
        }

        private void tbNum3_TextChanged(object sender, EventArgs e)
        {
            tbNum3.Text = System.Text.RegularExpressions.Regex.Replace(tbNum3.Text, "[^0-9]", "");
            //正则表达式替换,只允许出现0-9的数字
        }

        private void tbNum4_TextChanged(object sender, EventArgs e)
        {
            tbNum4.Text = System.Text.RegularExpressions.Regex.Replace(tbNum4.Text, "[^0-9]", "");
            //正则表达式替换,只允许出现0-9的数字
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            DataTable re = new DataTable();
            try
            {
                if (int.Parse(re.Compute(tbCalculate.Text, "false").ToString()) == 24)
                //判断用户输入的计算过程能不能计算出24
                { MessageBox.Show("答对了", "提示"); }
                else { MessageBox.Show("答错了", "提示"); }
            }
            catch (Exception E)
            {
              MessageBox.Show("不符合规范\n" + E.Message, "提示");
                
            }
        }

        private void btRefresh4Num_Click(object sender, EventArgs e)
        {
            float[] cards = new float[4];
            //声明一个float数组用来存放四个数值
            for (int i = 1; i <= 4; ++i)
            //给每个label的Text循环赋值
            {
                Label label = (Label)this.tlpPoint24.Controls["lbNum" + i.ToString()];
                //label每次指定为label i
                RandomNum.Next(1, 10);
                //随机生成1-10之间的数,不包括10
                num[i - 1] = int.Parse(RandomNum.Next(1, 10).ToString());
                //强制类型转换float为int
                label.Text = num[i - 1].ToString();
                //显示数值
                cards[i - 1] = int.Parse(label.Text);
                //赋值到cards数组
            }
            if (cal(cards) != 1)
            {
                btRefresh4Num_Click(this, e);
                //如果计算不了24点,重新生成4个数
            }

        }

        private void Point24_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mygame.GameCentre.MainForm.Show();
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("通过4个数字进行加减乘除运算来得到24,注意,只能使用+-*/()", "玩法介绍");
        
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
    }
}
