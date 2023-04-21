using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS_second
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
/*(Code from first lab, copied it here soican use some basic functions that are alredy written)
 using firstLab.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace firstLab
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            tb_firstTriangleX.Text = Triangle.firstX.ToString();
            tb_secondTriangleX.Text = Triangle.secondX.ToString();
            tb_thirdTriangleX.Text = Triangle.thirdX.ToString();
            tb_firstTriangleY.Text = Triangle.firstY.ToString();
            tb_secondTriangleY.Text= Triangle.secondY.ToString();
            tb_thirdTriangleY.Text= Triangle.thirdY.ToString();
            tb_dotX.Text= Dot.dotX.ToString();
            tb_dotY.Text= Dot.dotY.ToString();
            string welcomeState= System.IO.File.ReadAllText("Cache");
            if (welcomeState == "Welcome")
            {
                MessageBox.Show("Для заданной точки и треугольника на плоскости определить, принадлежит ли точка треугольнику.", "Сошнев Андрей 415а, работа номер 1, вариант 6", MessageBoxButtons.OK);
            }
            else
            {
                if(welcomeState == "FileForm")
                {
                    System.IO.File.WriteAllText("Cache", "Welcome"); 
                }
                else
                {
                    cb_welcome.Checked = true;
                }
            }
        }
        private void Form1_Shown(Object sender, EventArgs e)
        {
            
        }

        private void inputMask(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 43 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            if (e.KeyChar == 47) e.Handled = true;
            if (e.KeyChar == 46) e.Handled = true;
        }


        private void bt_answer_Click(object sender, EventArgs e)
        {
            if (isATriangle(Convert.ToDouble(tb_firstTriangleX.Text), Convert.ToDouble(tb_secondTriangleX.Text), Convert.ToDouble(tb_thirdTriangleX.Text), Convert.ToDouble(tb_firstTriangleY.Text), Convert.ToDouble(tb_secondTriangleY.Text), Convert.ToDouble(tb_thirdTriangleY.Text)))
            {
                double a = (Convert.ToDouble(tb_firstTriangleX.Text) - Convert.ToDouble(tb_dotX.Text)) * (Convert.ToDouble(tb_secondTriangleY.Text) - Convert.ToDouble(tb_firstTriangleY.Text)) - (Convert.ToDouble(tb_secondTriangleX.Text) - Convert.ToDouble(tb_firstTriangleX.Text)) * (Convert.ToDouble(tb_firstTriangleY.Text) - Convert.ToDouble(tb_dotY.Text));
                double b = (Convert.ToDouble(tb_secondTriangleX.Text) - Convert.ToDouble(tb_dotX.Text)) * (Convert.ToDouble(tb_thirdTriangleY.Text) - Convert.ToDouble(tb_secondTriangleY.Text)) - (Convert.ToDouble(tb_thirdTriangleX.Text) - Convert.ToDouble(tb_secondTriangleX.Text)) * (Convert.ToDouble(tb_secondTriangleY.Text) - Convert.ToDouble(tb_dotX.Text));
                double c = (Convert.ToDouble(tb_thirdTriangleX.Text) - Convert.ToDouble(tb_dotX.Text)) * (Convert.ToDouble(tb_firstTriangleY.Text) - Convert.ToDouble(tb_thirdTriangleY.Text)) - (Convert.ToDouble(tb_firstTriangleX.Text) - Convert.ToDouble(tb_thirdTriangleX.Text)) * (Convert.ToDouble(tb_thirdTriangleY.Text) - Convert.ToDouble(tb_dotY.Text));

                lb_answer.Visible = true;
                if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                {

                    lb_answer.Text = "Принадлежит треугольнику";
                }
                else
                {
                    lb_answer.Text = "Не принадлежит треугольнику";
                }
                Triangle.answerState = lb_answer.Text;
                Triangle.canSaveResult = true;
            }
            else
            {
                MessageBox.Show("Не треугольник", "Ахтунг!Ошибка", MessageBoxButtons.OK);
                Triangle.answerState = "Не треугольник";
                Triangle.canSaveResult = false;
            }

        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                double num = Convert.ToDouble(tb.Text);
                Triangle.canSaveResult = false;//Так как меняем значение в текст боксе то результат сохранить нельзя
            }
            catch
            {
                MessageBox.Show("Пожалуйста, введите верные данные", "Ахтунг!Ошибка", MessageBoxButtons.OK);
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                tb.Clear();
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle.firstX = Convert.ToDouble(tb_firstTriangleX.Text);
                Triangle.firstY = Convert.ToDouble(tb_firstTriangleY.Text);
                Triangle.secondX = Convert.ToDouble(tb_secondTriangleX.Text);
                Triangle.secondY = Convert.ToDouble(tb_secondTriangleY.Text);
                Triangle.thirdX = Convert.ToDouble(tb_thirdTriangleX.Text);
                Triangle.thirdY = Convert.ToDouble(tb_thirdTriangleY.Text);
                Dot.dotX = Convert.ToDouble(tb_dotX.Text);
                Dot.dotY = Convert.ToDouble(tb_dotY.Text);
                Triangle.canSave = true;
            }
            catch
            {
                Triangle.canSave = false;
            }
            System.IO.File.WriteAllText("Cache", "FileForm");
            StartForm.ActiveForm.Hide();
            FileForm MyForm2 = new FileForm();
            MyForm2.ShowDialog();
            Close();
        }

        private void cb_Welcome_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_welcome.Checked == true)
            {
                System.IO.File.WriteAllText("Cache", "noWelcome");
            }
            else
            {
                System.IO.File.WriteAllText("Cache", "Welcome");
            }
        }

        private void bt_tests_Click(object sender, EventArgs e)
        {
            int numTest = 0;
            double a;
            double b;
            double c;
            double z;
            try
            {
                while (numTest < 5)
                {
                    a = (numTest - numTest) * (numTest - numTest) - (numTest - numTest) * (numTest - numTest);
                    b = (numTest - numTest) * (numTest - numTest) - (numTest - numTest) * (numTest - numTest);
                    c = (numTest - numTest) * (numTest - numTest) - (numTest - numTest) * (numTest - numTest);
                    z = a + b + c;
                    numTest += 1;
                }
                MessageBox.Show("Модульные тесты прошли успешно!", "Всё супер!", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Ошибка в тесте номер:"+numTest+1, "Ахтунг!Ошибка", MessageBoxButtons.OK);
            }
        }

        private bool isATriangle(double Xa,double Xb,double Xc,double Ya,double Yb, double Yc)
        {
            bool answer=true;
            double AB=Math.Sqrt(Math.Pow(Xb-Xa,2)+Math.Pow(Yb-Ya,2));
            double BC = Math.Sqrt(Math.Pow(Xc - Xb, 2) + Math.Pow(Yc - Yb, 2));
            double CA = Math.Sqrt(Math.Pow(Xa - Xc, 2) + Math.Pow(Ya - Yc, 2));
            if (AB + BC <= CA || BC + CA <= AB || CA + AB <= BC)
            {
                answer=false;
            }

            return answer;
        }
    }
}

 */