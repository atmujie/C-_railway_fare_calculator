using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 铁路票价计算
{
    public partial class Frame : Form
    {
        private const double P = 0.05861;
        private double r; // 基本票价
        // 定义里程
        private double distance;
        public Frame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ordinaryType_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mileage_TextChanged(object sender, EventArgs e)
        {

        }

        // 判断里程输入是否合法
        private bool judge()
        {
            mileage.ForeColor = Color.Black;

            if (mileage.Text != "")
            {
                Regex reg = new Regex("^[0-9]+$");
                Match ma = reg.Match(mileage.Text);
                if (ma.Success) {
                    distance = Convert.ToDouble(mileage.Text);
                    if(distance > 0) return true;
                    else return false;
                } 
                else
                {
                    mileage.ForeColor = Color.Red;
                    mileage.Text = "必须输入数字";
                    return false;
                } 
            }
            else
            {
                mileage.ForeColor = Color.Red;
                mileage.Text = "请输入里程";
                return false;
            }

        }

        // 计算收费总里程
        private double surplus()
        {
            double initSect = 0;
            double shortDistance = 0;
            if (distance <= 200 && distance > 0)
            {
                initSect = 1;
                shortDistance = 10;
            }
            else if (distance <= 400 && distance > 200)
            {
                initSect = 200;
                shortDistance = 20;
            }
            else if (distance <= 700 && distance > 400)
            {
                initSect = 400;
                shortDistance = 30;
            }
            else if (distance <= 1100 && distance > 700)
            {
                initSect = 700;
                shortDistance = 40;
            }
            else if (distance <= 1600 && distance > 1100)
            {
                initSect = 1100;
                shortDistance = 50;
            }
            else if (distance <= 2200 && distance > 1600)
            {
                initSect = 1600;
                shortDistance = 60;
            }
            else if (distance <= 2900 && distance > 2200)
            {
                initSect = 2200;
                shortDistance = 70;
            }
            else if (distance <= 3700 && distance > 2900)
            {
                initSect = 2900;
                shortDistance = 80;
            }
            else if (distance <= 4600 && distance > 3700)
            {
                initSect = 3700;
                shortDistance = 90;
            }
            else if (distance > 4600)
            {
                initSect = 4600;
                shortDistance = 100;
            }
            else
            {
                MessageBox.Show("里程错误");
            }
            double douSect = (distance - initSect) / shortDistance;
            double sect = douSect % 0.5;
            if(sect != 0)
            {
                douSect = douSect - sect + 0.5;
            }
            // Console.WriteLine(initSect + douSect * shortDistance);
            return initSect + douSect * shortDistance;
        }

        // 按里程计算硬座基本票价
        private double calculation() 
        {
            double distanceRes = surplus();
            r = 0;
            if (distance <= 200)
            {
                r = P * distanceRes;
            }
            else if (distance <= 500 && distance > 200)
            {
                r = P * (200 + 0.9 * (distanceRes - 200));
            }
            else if (distance <= 1000 && distance > 500)
            {
                r = P * (200 + 270 +  + 0.8 * (distanceRes - 500));
            }
            else if (distance <= 1500 && distance > 1000)
            {
                r = P * (200 + 270 + 400 + 0.7 * (distanceRes - 1000));
            }
            else if (distance <= 2500 && distance > 1500)
            {
                r = P * (200 + 270 + 400 + 350 + 0.6 * (distanceRes - 1500));
            }
            else if (distance > 2500)
            {
                r = P * (200 + 270 + 400 + 350 + 600 + 0.5 * (distanceRes - 2500));
            }
            else
            {
                MessageBox.Show("里程错误");
            }
            // Console.WriteLine(r);
            return r * 1.5;
        }

        // 单选框检查
        private bool judgeType()
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            bool flag4 = false;
            if (ordinaryType.Checked == true || fastType.Checked == true || expressTpye.Checked == true) flag1 = true;
            if (hardSeatType.Checked == true || hardSleepType.Checked == true || softSleepType.Checked == true ) flag2 = true;
            if (yesStudy.Checked == true || noStudy.Checked == true) flag3 =  true ;
            if (yesAir.Checked == true || noAir.Checked == true) flag4 = true;
            if (flag1 == true && flag2 == true && flag3 == true && flag4 == true) return true;
            else return false;
        }

        // 空调附加票价
        private double airAtt(double m)
        {
            double r = 0;
            if (yesAir.Checked == true) r = m * 0.25;
            else if (noAir.Checked == true) r = 0;
            else MessageBox.Show("空调附加票价计算未知错误");
            return r * 1.5;
        }

        // 列车座位附加票价
        private double seatAtt(double m)
        {
            double r = 0;
            if (hardSeatType.Checked == true) r = 0;
            else if (hardSleepType.Checked == true) r = m * 0.2 + 10;
            else if (softSleepType.Checked == true) r = m * 0.8 + 10;
            else MessageBox.Show("座位附加票计算未知错误");
            return r * 1.5;
        }

        // 列车类型计算附加票价
        private double additional(double m)
        {
            double r = 0;
            // 普通类型列车，不附加
            if (ordinaryType.Checked == true)   r = 0;
            // 快速列车附加 20%
            else if (fastType.Checked == true)  r = m * 0.2;
            // 特快列车附加 40%
            else if (expressTpye.Checked == true)   r = m * 0.4;
            else MessageBox.Show("列车附加票计算未知错误");
            return r * 1.5;
        }

        private void getRes_Click(object sender, EventArgs e)
        {
            double distanceRes = 0;
            long resNum = 0;
            if (judgeType() == true)
            {
                if (judge() == true)
                {
                    distanceRes = calculation(); // 计算基本票价
                    if (yesStudy.Checked == true) distanceRes = distanceRes * 0.5;
                    if (noStudy.Checked == true) distanceRes = distanceRes * 1;
                    double res = distanceRes + additional(distanceRes) + seatAtt(distanceRes) + airAtt(distanceRes) + distanceRes * 0.02;
                    resNum = Convert.ToInt64(res);
                    MessageBox.Show("火车票票价大约" + resNum + "元");
                }
                else
                {
                    MessageBox.Show("里程输入错误");
                }
            }
            else
            {
                MessageBox.Show("请正确选择选项");
            }
        }
    }
}
