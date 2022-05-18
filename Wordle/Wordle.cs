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

namespace Wordle
{
    public partial class Wordle : Form
    {

        public static class Globals
        {

        }

        string[] st = new string[12972];
        string correct_word;

        public Wordle()
        {
            InitializeComponent();
            this.KeyPreview = true;



            StreamReader fi = new StreamReader(@"D:\Wordle\Wordle\valid-wordle-words.txt");
            int i = 0;

            for (; i < 12972; i++)  
            {
                st[i] = fi.ReadLine();
            }
            Random rnd = new Random();
            int value = rnd.Next(0, i);
            correct_word = st[value];

            fi.Close();
        }


        public void Correcting_word_1_collumn()
        {
            string word1 = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text;
            bool match;
            match = false;
            int j = 0;
            while ( (j < 12972) && (match == false) ) 
            {
                if (st[j] == word1)
                    {
                        match = true;
                    }
                j++;
            }
            if (match == true)
            {
                Checking1();
            }
            else
            {
                Incorrect_word1();
            }
            if (word1 == correct_word)
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result != DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Correcting_word_2_collumn()
        {
            string word1 = textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text;
            bool match;
            match = false;
            int j = 0;
            while ((j < 12972) && (match == false))    
            {
                if (st[j] == word1)
                {
                    match = true;
                }
                j++;
            }
            if (match == true)
            {
                Checking2();
            }
            else
            {
                Incorrect_word2();
            }
            if (word1 == correct_word)
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result != DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Correcting_word_3_collumn()
        {
            string word1 = textBox11.Text + textBox12.Text + textBox13.Text + textBox14.Text + textBox15.Text;
            bool match;
            match = false;
            int j = 0;
            while ((j < 12972) && (match == false))  
            {
                if (st[j] == word1)
                {
                    match = true;
                }
                j++;
            }
            if (match == true)
            {
                Checking3();
            }
            else
            {
                Incorrect_word3();
            }
            if (word1 == correct_word)
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result != DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Correcting_word_4_collumn()
        {
            string word1 = textBox16.Text + textBox17.Text + textBox18.Text + textBox19.Text + textBox20.Text;
            bool match;
            match = false;
            int j = 0;
            while ((j < 12972) && (match == false))   
            {
                if (st[j] == word1)
                {
                    match = true;
                }
                j++;
            }
            if (match == true)
            {
                Checking4();
            }
            else
            {
                Incorrect_word4();
            }
            if (word1 == correct_word)
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result != DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Correcting_word_5_collumn()
        {
            string word1 = textBox21.Text + textBox22.Text + textBox23.Text + textBox24.Text + textBox25.Text;
            bool match;
            match = false;
            int j = 0;
            while ((j < 12972) && (match == false))   
            {
                if (st[j] == word1)
                {
                    match = true;
                }
                j++;
            }
            if (match == true)
            {
                Checking5();
            }
            else
            {
                Incorrect_word5();
            }
            if (word1 == correct_word)
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result != DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Correcting_word_6_collumn()
        {
            string word1 = textBox26.Text + textBox27.Text + textBox28.Text + textBox29.Text + textBox30.Text;
            bool match;
            match = false;
            int j = 0;
            while ((j < 12972) && (match == false))    
            {
                if (st[j] == word1)
                {
                    match = true;
                }
                j++;
            }
            if (match == true)
            {
                Checking6();
            }
            else
            {
                Incorrect_word6();
            }
            
        }


        public void Checking1()
        {

            int i;
            for( i = 0; i < 5; i++)
            {
                if (textBox1.Text == Convert.ToString(correct_word[i]))
                {
                    textBox1.BackColor = Color.Yellow;
                }
            } 
            for (i = 0; i < 5; i++)
            {
                if (textBox2.Text == Convert.ToString(correct_word[i]))
                {
                    textBox2.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox3.Text == Convert.ToString(correct_word[i]))
                {
                    textBox3.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox4.Text == Convert.ToString(correct_word[i]))
                {
                    textBox4.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox5.Text == Convert.ToString(correct_word[i]))
                {
                    textBox5.BackColor = Color.Yellow;
                }
            }


            if (Convert.ToString(correct_word[0]) == textBox1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[1]) == textBox2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[2]) == textBox3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[3]) == textBox4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[4]) == textBox5.Text)
            {
                textBox5.BackColor = Color.Green;
            }

            Overall_check1();

        }

        public void Checking2()
        {

            int i;
            for (i = 0; i < 5; i++)
            {
                if (textBox6.Text == Convert.ToString(correct_word[i]))
                {
                    textBox6.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox7.Text == Convert.ToString(correct_word[i]))
                {
                    textBox7.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox8.Text == Convert.ToString(correct_word[i]))
                {
                    textBox8.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox9.Text == Convert.ToString(correct_word[i]))
                {
                    textBox9.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox10.Text == Convert.ToString(correct_word[i]))
                {
                    textBox10.BackColor = Color.Yellow;
                }
            }


            if (Convert.ToString(correct_word[0]) == textBox6.Text)
            {
                textBox6.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[1]) == textBox7.Text)
            {
                textBox7.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[2]) == textBox8.Text)
            {
                textBox8.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[3]) == textBox9.Text)
            {
                textBox9.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[4]) == textBox10.Text)
            {
                textBox10.BackColor = Color.Green;
            }

            Overall_check2();

        }

        public void Checking3()
        {

            int i;
            for (i = 0; i < 5; i++)
            {
                if (textBox11.Text == Convert.ToString(correct_word[i]))
                {
                    textBox11.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox12.Text == Convert.ToString(correct_word[i]))
                {
                    textBox12.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox13.Text == Convert.ToString(correct_word[i]))
                {
                    textBox13.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox14.Text == Convert.ToString(correct_word[i]))
                {
                    textBox14.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox15.Text == Convert.ToString(correct_word[i]))
                {
                    textBox15.BackColor = Color.Yellow;
                }
            }


            if (Convert.ToString(correct_word[0]) == textBox11.Text)
            {
                textBox11.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[1]) == textBox12.Text)
            {
                textBox12.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[2]) == textBox13.Text)
            {
                textBox13.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[3]) == textBox14.Text)
            {
                textBox14.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[4]) == textBox15.Text)
            {
                textBox15.BackColor = Color.Green;
            }

            Overall_check3();

        }

        public void Checking4()
        {

            int i;
            for (i = 0; i < 5; i++)
            {
                if (textBox16.Text == Convert.ToString(correct_word[i]))
                {
                    textBox16.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox17.Text == Convert.ToString(correct_word[i]))
                {
                    textBox17.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox18.Text == Convert.ToString(correct_word[i]))
                {
                    textBox18.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox19.Text == Convert.ToString(correct_word[i]))
                {
                    textBox19.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox20.Text == Convert.ToString(correct_word[i]))
                {
                    textBox20.BackColor = Color.Yellow;
                }
            }


            if (Convert.ToString(correct_word[0]) == textBox16.Text)
            {
                textBox16.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[1]) == textBox17.Text)
            {
                textBox17.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[2]) == textBox18.Text)
            {
                textBox18.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[3]) == textBox19.Text)
            {
                textBox19.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[4]) == textBox20.Text)
            {
                textBox20.BackColor = Color.Green;
            }

            Overall_check4();

        }

        public void Checking5()
        {

            int i;
            for (i = 0; i < 5; i++)
            {
                if (textBox21.Text == Convert.ToString(correct_word[i]))
                {
                    textBox21.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox22.Text == Convert.ToString(correct_word[i]))
                {
                    textBox22.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox23.Text == Convert.ToString(correct_word[i]))
                {
                    textBox23.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox24.Text == Convert.ToString(correct_word[i]))
                {
                    textBox24.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox25.Text == Convert.ToString(correct_word[i]))
                {
                    textBox25.BackColor = Color.Yellow;
                }
            }


            if (Convert.ToString(correct_word[0]) == textBox21.Text)
            {
                textBox21.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[1]) == textBox22.Text)
            {
                textBox22.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[2]) == textBox23.Text)
            {
                textBox23.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[3]) == textBox24.Text)
            {
                textBox24.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[4]) == textBox25.Text)
            {
                textBox25.BackColor = Color.Green;
            }

            Overall_check5();

        }

        public void Checking6()
        {

            int i;
            for (i = 0; i < 5; i++)
            {
                if (textBox26.Text == Convert.ToString(correct_word[i]))
                {
                    textBox26.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox27.Text == Convert.ToString(correct_word[i]))
                {
                    textBox27.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox28.Text == Convert.ToString(correct_word[i]))
                {
                    textBox28.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox29.Text == Convert.ToString(correct_word[i]))
                {
                    textBox29.BackColor = Color.Yellow;
                }
            }
            for (i = 0; i < 5; i++)
            {
                if (textBox30.Text == Convert.ToString(correct_word[i]))
                {
                    textBox30.BackColor = Color.Yellow;
                }
            }


            if (Convert.ToString(correct_word[0]) == textBox26.Text)
            {
                textBox26.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[1]) == textBox27.Text)
            {
                textBox27.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[2]) == textBox28.Text)
            {
                textBox28.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[3]) == textBox29.Text)
            {
                textBox29.BackColor = Color.Green;
            }
            if (Convert.ToString(correct_word[4]) == textBox30.Text)
            {
                textBox30.BackColor = Color.Green;
            }

            Finale_check();

        }

        public void Finale_check()
        {
            if ((textBox26.BackColor == Color.Green) && (textBox27.BackColor == Color.Green) && (textBox28.BackColor == Color.Green) && (textBox29.BackColor == Color.Green) && (textBox30.BackColor == Color.Green))
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            else
            {
                var result1 = MessageBox.Show("Ви програли!" + " Загадане слово було " + correct_word, "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result1 == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result1 == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Overall_check1()
        {
            if ((textBox1.BackColor == Color.Green) && (textBox2.BackColor == Color.Green) && (textBox3.BackColor == Color.Green) && (textBox4.BackColor == Color.Green) && (textBox5.BackColor == Color.Green))
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Overall_check2()
        {
            if ((textBox6.BackColor == Color.Green) && (textBox7.BackColor == Color.Green) && (textBox8.BackColor == Color.Green) && (textBox9.BackColor == Color.Green) && (textBox10.BackColor == Color.Green))
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Overall_check3()
        {
            if ((textBox11.BackColor == Color.Green) && (textBox12.BackColor == Color.Green) && (textBox13.BackColor == Color.Green) && (textBox14.BackColor == Color.Green) && (textBox15.BackColor == Color.Green))
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Overall_check4()
        {
            if ((textBox16.BackColor == Color.Green) && (textBox17.BackColor == Color.Green) && (textBox18.BackColor == Color.Green) && (textBox19.BackColor == Color.Green) && (textBox20.BackColor == Color.Green))
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        public void Overall_check5()
        {
            if ((textBox21.BackColor == Color.Green) && (textBox22.BackColor == Color.Green) && (textBox23.BackColor == Color.Green) && (textBox24.BackColor == Color.Green) && (textBox25.BackColor == Color.Green))
            {
                var result = MessageBox.Show("Ви перемогли!", "Повідомлення", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    this.Close();
                }
                if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }



        public void Incorrect_word1()
        {
            MessageBox.Show("Схоже що Wordle не знає такого слова", "Помилка", MessageBoxButtons.OK);
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
        }

        public void Incorrect_word2()
        {
            MessageBox.Show("Схоже що Wordle не знає такого слова", "Помилка", MessageBoxButtons.OK);
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox10.ReadOnly = false;
        }

        public void Incorrect_word3()
        {
            MessageBox.Show("Схоже що Wordle не знає такого слова", "Помилка", MessageBoxButtons.OK);
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox11.ReadOnly = false;
            textBox12.ReadOnly = false;
            textBox13.ReadOnly = false;
            textBox14.ReadOnly = false;
            textBox15.ReadOnly = false;
        }

        public void Incorrect_word4()
        {
            MessageBox.Show("Схоже що Wordle не знає такого слова", "Помилка", MessageBoxButtons.OK);
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox16.ReadOnly = false;
            textBox17.ReadOnly = false;
            textBox18.ReadOnly = false;
            textBox19.ReadOnly = false;
            textBox20.ReadOnly = false;
        }

        public void Incorrect_word5()
        {
            MessageBox.Show("Схоже що Wordle не знає такого слова", "Помилка", MessageBoxButtons.OK);
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox21.ReadOnly = false;
            textBox22.ReadOnly = false;
            textBox23.ReadOnly = false;
            textBox24.ReadOnly = false;
            textBox25.ReadOnly = false;
        }

        public void Incorrect_word6()
        {
            MessageBox.Show("Схоже що Wordle не знає такого слова", "Помилка", MessageBoxButtons.OK);
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox26.ReadOnly = false;
            textBox27.ReadOnly = false;
            textBox28.ReadOnly = false;
            textBox29.ReadOnly = false;
            textBox30.ReadOnly = false;
        }







        public System.Windows.Forms.Keys KeyCode { get; }




        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви справді бажаєте вийти?", "Вихід", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }// Кнопка выйти

        private void Rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У грі є загадане слово , яке треба вгадати. На це гравець має шість спроб. Сама гра зроблена у вигляді матриці 5 на 6, у верхній рядок потрібно вписати будь-яке слово. Якщо хоча б одна літера вгадана правильно, вона буде підсвічена зеленим, якщо літера є у слові, але в іншому місці – її тло стане жовтим. Якщо букви взагалі немає у слові, фон залишиться сірим. ", "Правила", MessageBoxButtons.OK);
        }// Правила

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гра була створена найталановитішим учнем!", "Про гру", MessageBoxButtons.OK);
        } //Про игру

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.Blue;
        }// Цвета фона

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.White;
        }// Цвета фона

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.Cyan;
        }// Цвета фона

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.Purple;
        }// Цвета фона

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.Pink;
        }// Цвета фона

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Чорний":
                    textBox1.ForeColor = Color.Black;
                    textBox2.ForeColor = Color.Black;
                    textBox3.ForeColor = Color.Black;
                    textBox4.ForeColor = Color.Black;
                    textBox5.ForeColor = Color.Black;
                    textBox6.ForeColor = Color.Black;
                    textBox7.ForeColor = Color.Black;
                    textBox8.ForeColor = Color.Black;
                    textBox9.ForeColor = Color.Black;
                    textBox10.ForeColor = Color.Black;
                    textBox11.ForeColor = Color.Black;
                    textBox12.ForeColor = Color.Black;
                    textBox13.ForeColor = Color.Black;
                    textBox14.ForeColor = Color.Black;
                    textBox15.ForeColor = Color.Black;
                    textBox16.ForeColor = Color.Black;
                    textBox17.ForeColor = Color.Black;
                    textBox18.ForeColor = Color.Black;
                    textBox19.ForeColor = Color.Black;
                    textBox20.ForeColor = Color.Black;
                    textBox21.ForeColor = Color.Black;
                    textBox22.ForeColor = Color.Black;
                    textBox23.ForeColor = Color.Black;
                    textBox24.ForeColor = Color.Black;
                    textBox25.ForeColor = Color.Black;
                    textBox26.ForeColor = Color.Black;
                    textBox27.ForeColor = Color.Black;
                    textBox28.ForeColor = Color.Black;
                    textBox29.ForeColor = Color.Black;
                    textBox30.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    Rules.ForeColor = Color.Black;
                    comboBox1.ForeColor = Color.Black;
                    aboutGameToolStripMenuItem.ForeColor = Color.Black;
                    viewToolStripMenuItem.ForeColor = Color.Black;
                    backgroundColorToolStripMenuItem.ForeColor = Color.Black;
                    ////
                    blueToolStripMenuItem1.ForeColor = Color.Black;
                    whiteToolStripMenuItem.ForeColor = Color.Black;
                    cyanToolStripMenuItem.ForeColor = Color.Black;
                    purpleToolStripMenuItem.ForeColor = Color.Black;
                    pinkToolStripMenuItem.ForeColor = Color.Black;
                    fileToolStripMenuItem.ForeColor = Color.Black;
                    exitToolStripMenuItem.ForeColor = Color.Black;
                    break;

                case "Бірюзовий":
                    textBox1.ForeColor = Color.Cyan;
                    textBox2.ForeColor = Color.Cyan;
                    textBox3.ForeColor = Color.Cyan;
                    textBox4.ForeColor = Color.Cyan;
                    textBox5.ForeColor = Color.Cyan;
                    textBox6.ForeColor = Color.Cyan;
                    textBox7.ForeColor = Color.Cyan;
                    textBox8.ForeColor = Color.Cyan;
                    textBox9.ForeColor = Color.Cyan;
                    textBox10.ForeColor = Color.Cyan;
                    textBox11.ForeColor = Color.Cyan;
                    textBox12.ForeColor = Color.Cyan;
                    textBox13.ForeColor = Color.Cyan;
                    textBox14.ForeColor = Color.Cyan;
                    textBox15.ForeColor = Color.Cyan;
                    textBox16.ForeColor = Color.Cyan;
                    textBox17.ForeColor = Color.Cyan;
                    textBox18.ForeColor = Color.Cyan;
                    textBox19.ForeColor = Color.Cyan;
                    textBox20.ForeColor = Color.Cyan;
                    textBox21.ForeColor = Color.Cyan;
                    textBox22.ForeColor = Color.Cyan;
                    textBox23.ForeColor = Color.Cyan;
                    textBox24.ForeColor = Color.Cyan;
                    textBox25.ForeColor = Color.Cyan;
                    textBox26.ForeColor = Color.Cyan;
                    textBox27.ForeColor = Color.Cyan;
                    textBox28.ForeColor = Color.Cyan;
                    textBox29.ForeColor = Color.Cyan;
                    textBox30.ForeColor = Color.Cyan;
                    label1.ForeColor = Color.Cyan;
                    label2.ForeColor = Color.Cyan;
                    Rules.ForeColor = Color.Cyan;
                    comboBox1.ForeColor = Color.Cyan;
                    aboutGameToolStripMenuItem.ForeColor = Color.Cyan;
                    viewToolStripMenuItem.ForeColor = Color.Cyan;
                    backgroundColorToolStripMenuItem.ForeColor = Color.Cyan;
                    blueToolStripMenuItem1.ForeColor = Color.Cyan;
                    whiteToolStripMenuItem.ForeColor = Color.Cyan;
                    purpleToolStripMenuItem.ForeColor = Color.Cyan;
                    cyanToolStripMenuItem.ForeColor = Color.Cyan;
                    pinkToolStripMenuItem.ForeColor = Color.Cyan;
                    fileToolStripMenuItem.ForeColor = Color.Cyan;
                    exitToolStripMenuItem.ForeColor = Color.Cyan;
                    break;

                case "Рожевий":
                    textBox1.ForeColor = Color.Pink;
                    textBox2.ForeColor = Color.Pink;
                    textBox3.ForeColor = Color.Pink;
                    textBox4.ForeColor = Color.Pink;
                    textBox5.ForeColor = Color.Pink;
                    textBox6.ForeColor = Color.Pink;
                    textBox7.ForeColor = Color.Pink;
                    textBox8.ForeColor = Color.Pink;
                    textBox9.ForeColor = Color.Pink;
                    textBox10.ForeColor = Color.Pink;
                    textBox11.ForeColor = Color.Pink;
                    textBox12.ForeColor = Color.Pink;
                    textBox13.ForeColor = Color.Pink;
                    textBox14.ForeColor = Color.Pink;
                    textBox15.ForeColor = Color.Pink;
                    textBox16.ForeColor = Color.Pink;
                    textBox17.ForeColor = Color.Pink;
                    textBox18.ForeColor = Color.Pink;
                    textBox19.ForeColor = Color.Pink;
                    textBox20.ForeColor = Color.Pink;
                    textBox21.ForeColor = Color.Pink;
                    textBox22.ForeColor = Color.Pink;
                    textBox23.ForeColor = Color.Pink;
                    textBox24.ForeColor = Color.Pink;
                    textBox25.ForeColor = Color.Pink;
                    textBox26.ForeColor = Color.Pink;
                    textBox27.ForeColor = Color.Pink;
                    textBox28.ForeColor = Color.Pink;
                    textBox29.ForeColor = Color.Pink;
                    textBox30.ForeColor = Color.Pink;
                    label1.ForeColor = Color.Pink;
                    label2.ForeColor = Color.Pink;
                    Rules.ForeColor = Color.Pink;
                    comboBox1.ForeColor = Color.Pink;
                    aboutGameToolStripMenuItem.ForeColor = Color.Pink;
                    viewToolStripMenuItem.ForeColor = Color.Pink;
                    backgroundColorToolStripMenuItem.ForeColor = Color.Pink;
                    blueToolStripMenuItem1.ForeColor = Color.Pink;
                    whiteToolStripMenuItem.ForeColor = Color.Pink;
                    purpleToolStripMenuItem.ForeColor = Color.Pink;
                    cyanToolStripMenuItem.ForeColor = Color.Pink;
                    pinkToolStripMenuItem.ForeColor = Color.Pink;
                    fileToolStripMenuItem.ForeColor = Color.Pink;
                    exitToolStripMenuItem.ForeColor = Color.Pink;
                    break;

                case "Фіолетовий":
                    textBox1.ForeColor = Color.Purple;
                    textBox2.ForeColor = Color.Purple;
                    textBox3.ForeColor = Color.Purple;
                    textBox4.ForeColor = Color.Purple;
                    textBox5.ForeColor = Color.Purple;
                    textBox6.ForeColor = Color.Purple;
                    textBox7.ForeColor = Color.Purple;
                    textBox8.ForeColor = Color.Purple;
                    textBox9.ForeColor = Color.Purple;
                    textBox10.ForeColor = Color.Purple;
                    textBox11.ForeColor = Color.Purple;
                    textBox12.ForeColor = Color.Purple;
                    textBox13.ForeColor = Color.Purple;
                    textBox14.ForeColor = Color.Purple;
                    textBox15.ForeColor = Color.Purple;
                    textBox16.ForeColor = Color.Purple;
                    textBox17.ForeColor = Color.Purple;
                    textBox18.ForeColor = Color.Purple;
                    textBox19.ForeColor = Color.Purple;
                    textBox20.ForeColor = Color.Purple;
                    textBox21.ForeColor = Color.Purple;
                    textBox22.ForeColor = Color.Purple;
                    textBox23.ForeColor = Color.Purple;
                    textBox24.ForeColor = Color.Purple;
                    textBox25.ForeColor = Color.Purple;
                    textBox26.ForeColor = Color.Purple;
                    textBox27.ForeColor = Color.Purple;
                    textBox28.ForeColor = Color.Purple;
                    textBox29.ForeColor = Color.Purple;
                    textBox30.ForeColor = Color.Purple;
                    label1.ForeColor = Color.Purple;
                    label2.ForeColor = Color.Purple;
                    Rules.ForeColor = Color.Purple;
                    comboBox1.ForeColor = Color.Purple;
                    aboutGameToolStripMenuItem.ForeColor = Color.Purple;
                    viewToolStripMenuItem.ForeColor = Color.Purple;
                    backgroundColorToolStripMenuItem.ForeColor = Color.Purple;
                    blueToolStripMenuItem1.ForeColor = Color.Purple;
                    whiteToolStripMenuItem.ForeColor = Color.Purple;
                    purpleToolStripMenuItem.ForeColor = Color.Purple;
                    cyanToolStripMenuItem.ForeColor = Color.Purple;
                    pinkToolStripMenuItem.ForeColor = Color.Purple;
                    fileToolStripMenuItem.ForeColor = Color.Purple;
                    exitToolStripMenuItem.ForeColor = Color.Purple;
                    break;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Right) 
            {
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox1.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox1.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox4.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox2.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox4.Text.Length == 0)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox5.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox3.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                Correcting_word_1_collumn();
            }
            if (textBox5.Text.Length == 1)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox6.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox4.Focus();
            }
        }


        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox6.Text.Length == 0)
            {
                textBox7.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox7.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox5.Focus();
            }
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox7.Text.Length == 0)
            {
                textBox8.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox8.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox6.Focus();
            }
        }

        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox8.Text.Length == 0)
            {
                textBox9.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox9.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox7.Focus();
            }
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox9.Text.Length == 0)
            {
                textBox10.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox10.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox8.Focus();
            }
        }

        private void textBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.ReadOnly = true;
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox10.ReadOnly = true;
                Correcting_word_2_collumn();
            }
                if (textBox10.Text.Length == 1)
            {
                textBox11.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox11.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox9.Focus();
            }
        }

        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox11.Text.Length == 0)
            {
                textBox12.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox12.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox10.Focus();
            }
        }

        private void textBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox12.Text.Length == 0)
            {
                textBox13.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox13.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox11.Focus();
            }
        }

        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox13.Text.Length == 0)
            {
                textBox14.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox14.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox12.Focus();
            }
        }

        private void textBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox14.Text.Length == 0)
            {
                textBox15.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox15.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox13.Focus();
            }
        }

        private void textBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox11.ReadOnly = true;
                textBox12.ReadOnly = true;
                textBox13.ReadOnly = true;
                textBox14.ReadOnly = true;
                textBox15.ReadOnly = true;
                Correcting_word_3_collumn();
            }
            if (textBox15.Text.Length == 1)
            {
                textBox16.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox16.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox14.Focus();
            }
        }

        private void textBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox16.Text.Length == 0)
            {
                textBox17.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox17.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox15.Focus();
            }
        }

        private void textBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox17.Text.Length == 0)
            {
                textBox18.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox18.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox16.Focus();
            }
        }

        private void textBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox18.Text.Length == 0)
            {
                textBox19.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox19.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox17.Focus();
            }
        }

        private void textBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox19.Text.Length == 0)
            {
                textBox20.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox20.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox18.Focus();
            }
        }

        private void textBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox16.ReadOnly = true;
                textBox17.ReadOnly = true;
                textBox18.ReadOnly = true;
                textBox19.ReadOnly = true;
                textBox20.ReadOnly = true;
                Correcting_word_4_collumn();
            }
            if (textBox20.Text.Length == 1)
            {
                textBox21.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox21.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox19.Focus();
            }
        }

        private void textBox21_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox21.Text.Length == 0)
            {
                textBox22.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox22.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox20.Focus();
            }
        }

        private void textBox22_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox22.Text.Length == 0)
            {
                textBox23.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox23.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox21.Focus();
            }
        }

        private void textBox23_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox23.Text.Length == 0)
            {
                textBox24.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox24.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox22.Focus();
            }
        }

        private void textBox24_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox24.Text.Length == 0)
            {
                textBox25.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox25.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox23.Focus();
            }
        }

        private void textBox25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox21.ReadOnly = true;
                textBox22.ReadOnly = true;
                textBox23.ReadOnly = true;
                textBox24.ReadOnly = true;
                textBox25.ReadOnly = true;
                Correcting_word_5_collumn();
            }
            if (textBox25.Text.Length == 1)
            {
                textBox26.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox26.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox24.Focus();
            }
        }

        private void textBox26_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox26.Text.Length == 0)
            {
                textBox27.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox27.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox25.Focus();
            }
        }

        private void textBox27_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox27.Text.Length == 0)
            {
                textBox28.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox28.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox26.Focus();
            }
        }

        private void textBox28_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox28.Text.Length == 0)
            {
                textBox29.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox29.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox27.Focus();
            }
        }

        private void textBox29_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox29.Text.Length == 0)
            {
                textBox30.Focus();
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox30.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox28.Focus();
            }
        }

        private void textBox30_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox26.ReadOnly = true;
                textBox27.ReadOnly = true;
                textBox28.ReadOnly = true;
                textBox29.ReadOnly = true;
                textBox30.ReadOnly = true;
                Correcting_word_6_collumn();
            }
            if (textBox30.Text.Length >= 0)
            {
                textBox30.Text = null;
            }
            if (e.KeyCode == Keys.Right)
            {
                textBox30.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                textBox29.Focus();
            }
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }


