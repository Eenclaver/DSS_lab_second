﻿using System;
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
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
            if (!Matrix.canSave)
            {
                MessageBox.Show("Функции сохранения отключены в связи с тем что не введены нужные данные");
                bt_save.Enabled = false;
                bt_result.Enabled = false;
            }
            else
            {
                bt_save.Enabled = true;
                bt_result.Enabled = true;
                if (!Matrix.canSaveResult)
                {
                    MessageBox.Show("Функция сохранения результата отключена в связи с тем что результат не был получен или значения после его получения были изменены");
                    bt_result.Enabled = false;
                }
            }
        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            double filedata;
            // получаем выбранный файл
            string filename = openFile.FileName;
            // читаем файл в строку
            string[] fileText = System.IO.File.ReadAllLines(filename);
            try
            {
                if (fileText.Length > 8) { double bonk = Convert.ToDouble("Bonk!"); }
                for (int i = 0; i < fileText.Length; i++)
                {
                    filedata = Convert.ToDouble(fileText[i]);
                }
                /*Matrix.lines = Convert.ToDouble(fileText[0]);
                Matrix.columns = Convert.ToDouble(fileText[1]);
                Matrix.dgw = Convert.ToDouble(fileText[2]);*/
                FileForm.ActiveForm.Hide();
                StartForm MyForm2 = new StartForm();
                MyForm2.ShowDialog();
                Close();

                MessageBox.Show("Файл открыт");
            }
            catch
            {
                MessageBox.Show("Пожалуйста, введите верные данные", "Ахтунг!Ошибка", MessageBoxButtons.OK);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            string[] filedata = new string[8];
            filedata[0] = Convert.ToString(Matrix.lines);
            filedata[1] = Convert.ToString(Matrix.columns);
            filedata[2] = Convert.ToString(Matrix.dgw);
            // получаем выбранный файл
            string filename = saveFile.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllLines(filename, filedata);
            MessageBox.Show("Файл сохранен");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            FileForm.ActiveForm.Hide();
            StartForm MyForm2 = new StartForm();
            MyForm2.ShowDialog();
            Close();
        }

        private void bt_result_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            string[] filedata = new string[9];
            filedata[0] = "Кордината X точки:" + Convert.ToString(Matrix.lines);
            filedata[1] = "Кордината Y точки:" + Convert.ToString(Matrix.columns);
            filedata[2] = "Кордината X первой точки треугольника:" + Convert.ToString(Matrix.dgw);
            // получаем выбранный файл
            string filename = saveFile.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllLines(filename, filedata);
            MessageBox.Show("Файл сохранен");
        }
    }
}
