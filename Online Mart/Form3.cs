using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Mart
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       // public static string[] array = new string[Form2.mylist]; 
        private void Form3_Load(object sender, EventArgs e)
        {

            //for (int i = 0; i<Form2.names.Count ; i++)
            //{
            //    // string[] subitems = new string[] { Form2.names[i] };
            //    ListViewItem item = new ListViewItem(Form2.names,Form2.prices);
            //    listView1.Items.Add(item);
            //    if (listView1.Items.Count == Form2.names.Count)
            //        break;

            //}
            foreach (string item in Form2.names)
            {
                listView1.Items.Add(item);
            }
            for(int i=0;i<Form2.prices.Count;i++)
            {
                listView1.Items[i].SubItems.Add(Form2.prices[i]);
            }
            for(int i=0;i<Form2.qty.Count;i++)
            {
                listView1.Items[i].SubItems.Add(Convert.ToString (Form2.qty[i]));
            }
            for(int i=0;i<Form2.totalprice.Count;i++)
            {
                listView1.Items[i].SubItems.Add(Convert.ToString(Form2.totalprice[i]));
            }
            int subtotal = 0;
            for(int i=0;i<listView1.Items.Count;i++)
            {
                subtotal += Convert.ToInt32(listView1.Items[i].SubItems[3].Text);
            }
            label3.Text = subtotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text != Convert.ToString(0))
            {
                MessageBox.Show("Your Order Is Placed Successfully.\nIt will be delivered to you within a week.", "ThankYou For Shopping", MessageBoxButtons.OK);
                Form1 form1 = new Form1(); form1.Close();
                Form2 form2 = new Form2(); form2.Close();
                Form3 form3 = new Form3(); form3.Close();
                Application.Exit();
            }
            else if(label3.Text==Convert.ToString(0))
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("You haven't placed any order yet.\nDo you still want to exit?", "Reminder", MessageBoxButtons.YesNo);
                if(dr==DialogResult.Yes)
                {
                    Form1 form1 = new Form1(); form1.Close();
                    Form2 form2 = new Form2(); form2.Close();
                    Form3 form3 = new Form3(); form3.Close();
                    Application.Exit();
                }
                else if(dr==DialogResult.No)
                {
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
