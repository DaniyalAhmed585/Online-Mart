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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else textBox1.UseSystemPasswordChar = true;
            //jab textbox ki multiline property true hogi tou ye work nahi karega.
            //jab ye property true nahi  hogi tou textbox single line hoga or ye work karega.
            //albatta agar hum password character set karden tou phir ye multiline mai bhi work karega.
        }
    }
}
