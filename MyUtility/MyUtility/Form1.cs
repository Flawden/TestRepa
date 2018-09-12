using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUtility
{
    public partial class Form1 : Form
    {
        float count = 0f;
        int forRandom = 0;
        Random rnd = new Random();
        int countb = 0;
        int countGen = 0;
        char[] SC = new char[] { '_', ':', '#', '@', '*' };
        string pass;

        public Form1()
        {
            InitializeComponent();
            LoadNotepaad();
            CLGen.SetItemChecked(0, true);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            try
            {
                count--;
                CountLB.Text = count.ToString();
            }
            catch
            {
                DiaLab.Text = "Что то пошло не так";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            try
            {
                count++;
                CountLB.Text = count.ToString();
            }
            catch
            {
                DiaLab.Text = "Что то пошло не так";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Counter_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа содержит полезные для жизни утилиты, но главное призвана помочь мне изучить C#. \n\nАвтор: Snelk.", "О программе");
        }

        private void Counter_Click_1(object sender, EventArgs e)
        {

        }

        private void Umnozenie_Click(object sender, EventArgs e)
        {
            try
            {
                count = count * 2;
                CountLB.Text = count.ToString();
            }
           catch
            {
                DiaLab.Text = "Что то пошло не так";
            }
        }

        private void Delenie_Click(object sender, EventArgs e)
        {
            try
            {
                count = count / 2;
                CountLB.Text = count.ToString();
            }
            catch
            {
                DiaLab.Text = "Что то пошло не так";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            CountLB.Text = count.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MinGen_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CountRand_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                forRandom = rnd.Next(Convert.ToInt32(MinGen.Value), Convert.ToInt32(MaxGen.Value));
                CountRand.Text = forRandom.ToString();
                RandTextBox.AppendText(forRandom + "; ");
            }
            catch
            {
                DiaLB2.Text = "Что то пошло не так";
            }
        }

        private void RandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MaxGen_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RandTextBox.Text = "";
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RandTextBox.Text);
        }

        private void InsertData_Click(object sender, EventArgs e)
        {
          Notepaad.AppendText(DateTime.Now.ToShortDateString() + " ");
        }

        private void Notepaad_TextChanged(object sender, EventArgs e)
        {
            if (Notepaad.Text == "Даниил лох")
            {
                Notepaad.Text = "Егор лох";
            }
             
        }

        private void посчитатьСимволыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countb = Convert.ToInt32(Notepaad.TextLength);
            MessageBox.Show("Вы ввели " + countb + " символов, включая пробелы.");
        }

        private void InsertTime_Click(object sender, EventArgs e)
        {
            Notepaad.AppendText(DateTime.Now.ToShortTimeString() + " ");
        }

        private void Save_Click(object sender, EventArgs e)
        {
           
        }

        private void Load_Click(object sender, EventArgs e)
        {
            
        }

       private void Save_Click_1(object sender, EventArgs e)
        {
            try
            {
                Notepaad.SaveFile("notepad.rtf");
            }
            
            catch
            {
                MessageBox.Show("Какая то дичь с сохранением");
            }
        }

        void LoadNotepaad()
        {
            try
            {
                Notepaad.LoadFile("notepad.rtf");
            }

            catch
            {
                MessageBox.Show("Какая то дичь с загрузкой");
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadNotepaad();
        }

        private void KeyGen_Click(object sender, EventArgs e)
        {
            if (CLGen.CheckedItems.Count == 0) { return; }
            string password = "";
            for (int i = 0; i < NumGen.Value; i++)
            {
                countGen = rnd.Next(0, CLGen.CheckedItems.Count);
                string s = CLGen.CheckedItems[countGen].ToString();
                switch (s)
                {
                    case "Цифры":
                        password += rnd.Next(0, 9);
                        break;
                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы(заглавные)":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += SC[rnd.Next(0, SC.Length)];
                        break;
                }
                        pass = password;
                        textBoxGen.Text = password;
                }
            }
        private void CLGen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(pass);
        }
    }

       
    }

