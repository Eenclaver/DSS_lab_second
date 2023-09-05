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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            tb_lines.Text = Convert.ToString(Matrix.lines);
            tb_columns.Text = Convert.ToString(Matrix.columns);
            dgw_Matrix.Columns.Add("", "");
            dgw_Matrix.Rows.Add("", "");
            string welcomeState = System.IO.File.ReadAllText("Cache");
            Matrix.cacheState = welcomeState;
            if (welcomeState == "Welcome")
            {
                cb_welcome.Checked = true;
                MessageBox.Show("Напишите программу, удаляющую из массива все дублирующиеся элементы.", "Сошнев Андрей 415а, работа номер 2, вариант 7", MessageBoxButtons.OK);
            }
            else
            {
                if (welcomeState == "FileForm")
                {
                    System.IO.File.WriteAllText("Cache", Matrix.cacheState);
                    dgw_Matrix = Matrix.dgw;
                }
                else
                {
                    cb_welcome.Checked = false;
                }
            }

        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                if (tb.Text.Length > 0) { double num = Convert.ToDouble(tb.Text); }

                Matrix.canSaveResult = false;//Так как меняем значение в текст боксе то результат сохранить нельзя
            }
            catch
            {
                MessageBox.Show("Пожалуйста, введите верные данные", "Ахтунг!Ошибка", MessageBoxButtons.OK);
                System.Windows.Forms.TextBox tb = (System.Windows.Forms.TextBox)sender;
                tb.Clear();
            }
        }

        private void inputMask(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 43 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
            if (e.KeyChar == 47) e.Handled = true;
            if (e.KeyChar == 46) e.Handled = true;
        }

        private void cb_Welcome_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_welcome.Checked == true)
            {
                System.IO.File.WriteAllText("Cache", "Welcome");
                Matrix.cacheState = "Welcome";
            }
            else
            {
                System.IO.File.WriteAllText("Cache", "noWelcome");
                Matrix.cacheState = "noWelcome";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            Matrix.canSaveResult = false;
            Matrix.columns =Convert.ToInt32(tb_columns.Text);
            Matrix.lines=Convert.ToInt32(tb_lines.Text);
            dgw_Matrix.Columns.Clear();
            for(int i = 0; i < Matrix.columns; i++)
            {
                dgw_Matrix.Columns.Add("","");
            }
            for (int i = 0; i < Matrix.lines; i++)
            {
                dgw_Matrix.Rows.Add("", "");
            }
        }

        private void bt_del_Click(object sender, EventArgs e)
        {
            Matrix.canSaveResult = true;
            List<string> oneElements = new List<string>();
            oneElements.Add(Convert.ToString(dgw_Matrix[0, 0].Value));
            for(int i = 0; i < Matrix.lines; i++)
            {
                for(int j = 0; j < Matrix.columns; j++) 
                {
                    if (!oneElements.Contains(Convert.ToString(dgw_Matrix[i, j].Value)))
                    {
                        oneElements.Add(Convert.ToString(dgw_Matrix[i, j].Value));
                    }
                }
            }
            if (oneElements.Count<Matrix.columns*Matrix.lines)
            {
                while(oneElements.Count != Matrix.columns * Matrix.lines)
                {
                    oneElements.Add(Convert.ToString(0));
                }
            }
            int count = 0;
            for (int i = 0; i < Matrix.lines; i++)
            {
                for (int j = 0; j < Matrix.columns; j++)
                {
                    dgw_Matrix[i, j].Value = oneElements[count];
                    count++;
                }
            }
            Matrix.resDgw = dgw_Matrix;
        }

        private void bt_fileWork_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(dgw_Matrix[0,0].Value);
                Matrix.canSave = true;
            }
            catch
            {
                Matrix.canSave = false;
            }
            System.IO.File.WriteAllText("Cache", "FileForm");
            StartForm.ActiveForm.Hide();
            FileForm MyForm2 = new FileForm();
            MyForm2.ShowDialog();
            Close();
        }
    }
}