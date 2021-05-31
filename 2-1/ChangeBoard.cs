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
    public partial class ChangeBoard : Form
    {
        List<Billboard> billboards;
        ListBox listBox;
        int idx = -1;

        public ChangeBoard(List<Billboard> billboards1, ListBox listBox1,int intent)
        {
            InitializeComponent();

            billboards = billboards1;
            listBox = listBox1;
            switch (intent)
            {
                case 0:
                    this.Name = "Добавление";
                    button2.Text = "Добавить";

                    break;

                case 1:
                    this.Name = "Изменение";
                    idx = listBox.SelectedIndex;
                    checkBox1.Checked = billboards[idx].rented;
                   // if (checkBox1.Checked) 
                    adressBox.Text = billboards[idx].adress;
                    button2.Text = "Изменить";
                    break;

                case 2:
                    this.Name = "Арендование";
                    idx = listBox.SelectedIndex;
                    adressBox.Text = billboards[idx].adress;
                    button2.Text = "Арендовать";
                    adressBox.Enabled = false;
                    checkBox1.Visible = false;
                    checkBox1.Checked = true;
                    break;
                case 3:
                    this.Name = "Поиск";
                    label1.Visible = false;
                    adressBox.Visible = false;
                    button2.Text = "Найти";
                    checkBox1.Visible = false;
                    checkBox1.Checked = true;
                    break;
            }
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)        
                groupBox1.Visible = true;            
            else groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (button2.Text)
            {
                case "Добавить":
                    try
                    {
                        if (adressBox.Text == "") throw new Exception();

                        if (checkBox1.Checked)
                            billboards.Add(new Billboard(adressBox.Text, true, new DateTime(Convert.ToInt32(yearFrom.Text), Convert.ToInt32(mFrom.Text), Convert.ToInt32(dFrom.Text)), new DateTime(Convert.ToInt32(yTo.Text), Convert.ToInt32(mTo.Text), Convert.ToInt32(dTo.Text))
                                ));
                        else
                            billboards.Add(new Billboard(adressBox.Text, false)); ;


                          listBox.Items.Add(adressBox.Text);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Неккоректные данные");
                    }
                    break;

                case "Изменить":

                    try
                    {
                        if (checkBox1.Checked)
                            billboards[listBox.SelectedIndex] = (new Billboard(adressBox.Text, true, new DateTime(Convert.ToInt32(yearFrom.Text), Convert.ToInt32(mFrom.Text), Convert.ToInt32(dFrom.Text)), new DateTime(Convert.ToInt32(yTo.Text), Convert.ToInt32(mTo.Text), Convert.ToInt32(dTo.Text))
                                ));
                        else
                            billboards[listBox.SelectedIndex] = (new Billboard(adressBox.Text, false));
                        listBox.Items[idx] = adressBox.Text;
                    }
                    catch
                    {
                        MessageBox.Show("Неккоректные данные");
                    }
                    this.Close();
                 break;

                case "Арендовать":

                    try
                    {
                        if (checkBox1.Checked)
                            billboards[listBox.SelectedIndex] = (new Billboard(adressBox.Text, true, new DateTime(Convert.ToInt32(yearFrom.Text), Convert.ToInt32(mFrom.Text), Convert.ToInt32(dFrom.Text)), new DateTime(Convert.ToInt32(yTo.Text), Convert.ToInt32(mTo.Text), Convert.ToInt32(dTo.Text))
                                ));
                        else
                            billboards[listBox.SelectedIndex] = (new Billboard(adressBox.Text, false));
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Неккоректные данные");
                    }
                    break;
                case "Найти":

                    DateTime dateFrom = new DateTime(0), dateTo = new DateTime(0);
                    try
                    {
                        dateFrom = new DateTime(Convert.ToInt32(yearFrom.Text), Convert.ToInt32(mFrom.Text), Convert.ToInt32(dFrom.Text));
                        dateTo = new DateTime(Convert.ToInt32(yTo.Text), Convert.ToInt32(mTo.Text), Convert.ToInt32(dTo.Text));
                        int test = DateTime.Compare(dateFrom, dateTo);
                    }
                    catch
                    {
                        MessageBox.Show("Неккоректный формат даты");
                    }
                    listBox.Items.Clear();
                    for (int i = 0; i < billboards.Count; i++)
                    {
                        if (!billboards[i].rented || ((DateTime.Compare(dateFrom, billboards[i].rentTo) > 0 && DateTime.Compare(dateTo, billboards[i].rentTo) > 0) || (DateTime.Compare(dateFrom, billboards[i].rentFrom) < 0 && DateTime.Compare(dateTo, billboards[i].rentFrom) < 0)))
                        listBox.Items.Add(billboards[i].adress);
                    }

                    break;
            }
           
        }
    }
}
