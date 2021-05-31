using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1
{
   
    public partial class Form1 : Form
    {
        //Лист билбордов
        List<Billboard> billboards = new List<Billboard>(); 
        
        public Form1()
        {
            InitializeComponent();

            //Добавление в лист
            billboards.Add(new Billboard("adress1", false));
            billboards.Add(new Billboard("adress2", false));
            billboards.Add(new Billboard("adress3", false));
            billboards.Add(new Billboard("adress4", true, new DateTime(2020,12,29),new DateTime(2021,12,29)));
           
            //Заполнение лист-бокса
            fillListBox(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            try
            {
                int idx = listBox1.SelectedIndex;
                billboards.RemoveAt(idx);
                listBox1.Items.RemoveAt(idx);
            }
            catch
            {
                MessageBox.Show("Не выбран элемент");
            }
          }

        private void addButt_Click(object sender, EventArgs e)
        {
            //Открытие формы changeBoard с намереньем 0
            ChangeBoard changeBoard = new ChangeBoard(billboards,listBox1,0);
            changeBoard.ShowDialog();
        }
        void fillListBox()
        {
            listBox1.Items.Clear();
            for(int i = 0; i < billboards.Count; i++)
            {
                listBox1.Items.Add(billboards[i].adress);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = listBox1.SelectedIndex;

            if (idx == -1) return;
            adress.Text = "Адрес билборда: " + billboards[idx].adress;
            if (billboards[idx].rented)
            {
                rented.Text = "Арендован: да";
                
                rentFrom.Text = "С "+ billboards[idx].rentFrom;
                rentTo.Text = "По " + billboards[idx].rentTo;
            }
            else
            {
                rented.Text = "Арендован: нет";
                rentFrom.Text = "";
                rentTo.Text = "";
            }
        }

        private void editButt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран элемент");
                return;
            }
            //Открытие формы changeBoard с намереньем 1
            ChangeBoard changeBoard = new ChangeBoard(billboards, listBox1, 1);
            changeBoard.ShowDialog();
        }

        private void rentButt_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран элемент");
                return;
            }
           
            if (billboards[listBox1.SelectedIndex].rented)
            {
                MessageBox.Show("Данный билборд уже арендован");
                return;
            }
            ChangeBoard changeBoard = new ChangeBoard(billboards, listBox1, 2);
            changeBoard.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fillListBox();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangeBoard changeBoard = new ChangeBoard(billboards, listBox1, 3);
            changeBoard.ShowDialog();
        }
    }
}
