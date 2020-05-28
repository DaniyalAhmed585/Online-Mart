using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Online_Mart
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C49EKOG\SQLEXPRESS;
                 Initial Catalog=OnlineMart;User ID=daniyal;Password=acha;");
            SqlCommand cmd = new SqlCommand();
            if (Form1.s == 1)
            {
                cmd = new SqlCommand("SELECT * FROM GroceryandStaples", conn);
                n.Text = "Suji";
                p.Text = Convert.ToString(52);
                q.Text = Convert.ToString(500 + " gm");
            }
            else if(Form1.s==2)
            {
                cmd = new SqlCommand("SELECT * FROM CannedandFrozenFoods", conn);
                n.Text = "Black Olives";
                p.Text = Convert.ToString(250);
                q.Text = Convert.ToString(250 + " gm");
            }
            else if(Form1.s==3)
            {
                cmd = new SqlCommand("SELECT * FROM HouseholdNeeds", conn);
                n.Text = "Liquid Bleach";
                p.Text = Convert.ToString(2384);
                q.Text = Convert.ToString(2.72 + " Ltr");
            }
            else if (Form1.s ==4)
            {
                cmd = new SqlCommand("SELECT * FROM BreakfastAndDairy", conn);
                n.Text = "Nesvita";
                p.Text = Convert.ToString(160);
                q.Text = Convert.ToString(1 + " Ltr");
            }
            else if (Form1.s ==5)
            {
                cmd = new SqlCommand("SELECT * FROM PersonalCare", conn);
                n.Text = "Lux Soap Trio Pack";
                p.Text = Convert.ToString(204);
                q.Text = Convert.ToString(3 + " Pcs");
            }
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            BindingSource source = new BindingSource();
            source.DataSource = reader;

            dataGridView1.DataSource = source;
            conn.Close();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineMartDataSet8.Grocery_and_Staples' table. You can move, or remove it, as needed.
            //this.grocery_and_StaplesTableAdapter1.Fill(this.onlineMartDataSet8.Grocery_and_Staples);
            // TODO: This line of code loads data into the 'onlineMartDataSet7.Grocery_and_Staples' table. You can move, or remove it, as needed.
            //this.grocery_and_StaplesTableAdapter.Fill(this.onlineMartDataSet7.Grocery_and_Staples);
            // TODO: This line of code loads data into the 'onlineMartDataSet6.GroceryandStaples' table. You can move, or remove it, as needed.
            //this.groceryandStaplesTableAdapter.Fill(this.onlineMartDataSet6.GroceryandStaples);
            // TODO: This line of code loads data into the 'onlineMartDataSet5.GroceryandStaples' table. You can move, or remove it, as needed.
            //this.groceryandStaplesTableAdapter1.Fill(this.onlineMartDataSet5.GroceryandStaples);
            // TODO: This line of code loads data into the 'onlineMartDataSet4.GroceryandStaples' table. You can move, or remove it, as needed.
            // this.groceryandStaplesTableAdapter.Fill(this.onlineMartDataSet4.GroceryandStaples);

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n.Text = dataGridView1.CurrentCell.Value.ToString();
            if (n.Text == "")
            {
                p.Text = Convert.ToString("");
                q.Text = Convert.ToString("");
            }
            if (n.Text == "Suji")
            {
                p.Text = Convert.ToString(52);
                q.Text = Convert.ToString(500+" gm");
            }
            if (n.Text == "Maida")
            {
                p.Text = Convert.ToString(55);
                q.Text = Convert.ToString(500+" gm");
            }
            if (n.Text == "Atta")
            {
                p.Text = Convert.ToString(635);
                q.Text = Convert.ToString(10+" kg");
            }
            if (n.Text == "Baisan")
            {
                p.Text = Convert.ToString(80);
                q.Text = Convert.ToString(500+" gm");
            }
            if(n.Text=="Daal Chana")
            {
                p.Text = Convert.ToString(85);
                q.Text = Convert.ToString(500+" gm");
            }
            if (n.Text == "Daal Moong")
            {
                p.Text = Convert.ToString(110);
                q.Text = Convert.ToString(500+" gm");
            }
            if (n.Text == "Daal Maash")
            {
                p.Text = Convert.ToString(100);
                q.Text = Convert.ToString(500+" gm");
            }
            if (n.Text == "Daal Masoor")
            {
                p.Text = Convert.ToString(90);
                q.Text = Convert.ToString(500+" gm");
            }
            if (n.Text == "Daal Arhar")
            {
                p.Text = Convert.ToString(135);
                q.Text = Convert.ToString(500+" gm");
            }
            if (n.Text == "Daal MasoorWhole")
            {
                p.Text = Convert.ToString(100);
                q.Text = Convert.ToString(500+" gm");
            }
            if (n.Text == "Dalya")
            {
                p.Text = Convert.ToString(110);
                q.Text = Convert.ToString(50+" gm");
            }
            if (n.Text == "White Basmati Rice")
            {
                p.Text = Convert.ToString(500);
                q.Text = Convert.ToString(5+" kg");
            }
            if (n.Text == "Sagoo Dana")
            {
                p.Text = Convert.ToString(100);
                q.Text = Convert.ToString(50+" gm");
            }
            if (n.Text == "Kernal Basmati Rice")
            {
                p.Text = Convert.ToString(675);
                q.Text = Convert.ToString(5+" kg");
            }
            if (n.Text == "Desi Ghee Tin")
            {
                p.Text = Convert.ToString(500);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Ghee Tin")
            {
                p.Text = Convert.ToString(300);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Ghee Poly Bag")
            {
                p.Text = Convert.ToString(75);
                q.Text = Convert.ToString(1+" pouch");
            }
            if (n.Text == "Canola Oil")
            {
                p.Text = Convert.ToString(500);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Soyabean Oil")
            {
                p.Text = Convert.ToString(500);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Olive Oil")
            {
                p.Text = Convert.ToString(575);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Sunflower Oil")
            {
                p.Text = Convert.ToString(480);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Corn Oil")
            {
                p.Text = Convert.ToString(675);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Mustard Oil")
            {
                p.Text = Convert.ToString(400);
                q.Text = Convert.ToString(1+" kg");
            }
            if(n.Text=="Black Olives")
            {
                p.Text = Convert.ToString(250);
                q.Text = Convert.ToString(250+" gm");
            }
            if (n.Text == "Pineapple Slices Tin")
            {
                p.Text = Convert.ToString(150);
                q.Text = Convert.ToString(200+" gm");
            }
            if (n.Text == "Mixed Fruit Slices Tin")
            {
                p.Text = Convert.ToString(150);
                q.Text = Convert.ToString(200+" gm");
            }
            if (n.Text == "Green Olives")
            {
                p.Text = Convert.ToString(200);
                q.Text = Convert.ToString(250+" gm");
            }
            if (n.Text == "Chicken Seekh Kabab")
            {
                p.Text = Convert.ToString(600);
                q.Text = Convert.ToString(12+" Pcs");
            }
            if (n.Text == "Chicken Kofta")
            {
                p.Text = Convert.ToString(800);
                q.Text = Convert.ToString(14+" Pcs");
            }
            if (n.Text == "Chicken Nuggets")
            {
                p.Text = Convert.ToString(500);
                q.Text = Convert.ToString(20+" Pcs");
            }
            if (n.Text == "Chicken Shami Kabab")
            {
                p.Text = Convert.ToString(450);
                q.Text = Convert.ToString(12+" Pcs");
            }
            if(n.Text=="Nido")
            {
                p.Text = Convert.ToString(449);
                q.Text = Convert.ToString(390+" gm");
            }
            if (n.Text == "Koko Krunch Cereal")
            {
                p.Text = Convert.ToString(535);
                q.Text = Convert.ToString(330+" gm");
            }
            if (n.Text == "Wheat Flakes")
            {
                p.Text = Convert.ToString(250);
                q.Text = Convert.ToString(250+" gm");
            }
            if (n.Text == "Corn Flakes")
            {
                p.Text = Convert.ToString(220);
                q.Text = Convert.ToString(250+" gm");
            }
            if (n.Text == "Mozzarella Cheese")
            {
                p.Text = Convert.ToString(620);
                q.Text = Convert.ToString(400+" gm");
            }
            if (n.Text == "Cheddar Cheese")
            {
                p.Text = Convert.ToString(550);
                q.Text = Convert.ToString(400+" gm");
            }
            if (n.Text == "Butter")
            {
                p.Text = Convert.ToString(135);
                q.Text = Convert.ToString(100+" gm");
            }
            if (n.Text == "Nesvita")
            {
                p.Text = Convert.ToString(160);
                q.Text = Convert.ToString(1+" Ltr");
            }

            if (n.Text == "Dawn Bread")
            {
                p.Text = Convert.ToString(80);
                q.Text = Convert.ToString(1+" Pc");
            }
            if (n.Text == "Bun")
            {
                p.Text = Convert.ToString(50);
                q.Text = Convert.ToString(4+" Pcs");
            }
            if (n.Text == "Golden Eggs Pack")
            {
                p.Text = Convert.ToString(91);
                q.Text = Convert.ToString(6+" Pcs");
            }
            if (n.Text == "Liquid Bleach")
            {
                p.Text = Convert.ToString(2384);
                q.Text = Convert.ToString(2.72+" Ltr");
            }
            if (n.Text == "Ariel Original Detergent")
            {
                p.Text = Convert.ToString(310);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Lemon Max Powder")
            {
                p.Text = Convert.ToString(80);
                q.Text = Convert.ToString(900+" gm");
            }
            if (n.Text == "Surf Excel")
            {
                p.Text = Convert.ToString(405);
                q.Text = Convert.ToString(1+" kg");
            }
            if (n.Text == "Ariel Original Excel Gel")
            {
                p.Text = Convert.ToString(1217);
                q.Text = Convert.ToString(888+" ml");
            }
            if (n.Text == "Lemon Max Power Cleaner")
            {
                p.Text = Convert.ToString(65);
                q.Text = Convert.ToString(430+" gm");
            }
            if (n.Text == "Spontex Spiral")
            {
                p.Text = Convert.ToString(99);
                q.Text = Convert.ToString(2+" Pcs");
            }
            if (n.Text == "Vim Lemon Gel")
            {
                p.Text = Convert.ToString(247);
                q.Text = Convert.ToString(500+" ml");
            }
            if (n.Text == "Dry Mop Set")
            {
                p.Text = Convert.ToString(375);
                q.Text = Convert.ToString(1+" Pc");
            }
            if (n.Text == "Coconut Broom")
            {
                p.Text = Convert.ToString(90);
                q.Text = Convert.ToString(1+" Pc");
            }
            if (n.Text == "Flower Broom")
            {
                p.Text = Convert.ToString(99);
                q.Text = Convert.ToString(1+" Pc");
            }
            if (n.Text == "Scotch Brite")
            {
                p.Text = Convert.ToString(65);
                q.Text = Convert.ToString(1+" Pc");
            }
            if (n.Text == "Lux Soap Trio Pack")
            {
                p.Text = Convert.ToString(204);
                q.Text = Convert.ToString(3+" Pcs");
            }
            if (n.Text == "Hand Sanitizer")
            {
                p.Text = Convert.ToString(209);
                q.Text = Convert.ToString(60+" ml");
            }
            if (n.Text == "Body Wash")
            {
                p.Text = Convert.ToString(499);
                q.Text = Convert.ToString(500+" ml");
            }
            if (n.Text == "Hand Wash")
            {
                p.Text = Convert.ToString(118);
                q.Text = Convert.ToString(225+" ml");
            }
            if (n.Text == "Shower Gel")
            {
                p.Text = Convert.ToString(299);
                q.Text = Convert.ToString(250+" ml");
            }
            if (n.Text == "Shampoo")
            {
                p.Text = Convert.ToString(200);
                q.Text = Convert.ToString(185+" ml");
            }
            if (n.Text == "Hair Oil")
            {
                p.Text = Convert.ToString(170);
                q.Text = Convert.ToString(100+" ml");
            }
            if (n.Text == "Hair Gel")
            {
                p.Text = Convert.ToString(379);
                q.Text = Convert.ToString(150+" ml");
            }
            if(n.Text=="Fairness Cream")
            {
                p.Text = Convert.ToString(241);
                q.Text = Convert.ToString(50+" gm");
            }
            if (n.Text == "Lotion")
            {
                p.Text = Convert.ToString(260);
                q.Text = Convert.ToString(200+" ml");
            }
            if (n.Text == "Wipes")
            {
                p.Text = Convert.ToString(209);
                q.Text = Convert.ToString(30+" Pcs");
            }
            if (n.Text == "Face Wash")
            {
                p.Text = Convert.ToString(1100);
                q.Text = Convert.ToString(150+" ml");
            }
            if (n.Text == "Tooth Paste")
            {
                p.Text = Convert.ToString(105);
                q.Text = Convert.ToString(100+" gm");
            }
            if (n.Text == "Tooth Brush")
            {
                p.Text = Convert.ToString(171);
                q.Text = Convert.ToString(2+" Pcs");
            }
            if (n.Text == "Mouth Wash")
            {
                p.Text = Convert.ToString(213);
                q.Text = Convert.ToString(500+" ml");
            }
            if (n.Text == "Cotton Buds")
            {
                p.Text = Convert.ToString(135);
                q.Text = Convert.ToString(200+" Pcs");
            }


        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down||e.KeyCode==Keys.Up||e.KeyCode==Keys.Left||e.KeyCode==Keys.Right||e.KeyCode==Keys.Tab)
            {
                n.Text = dataGridView1.CurrentCell.Value.ToString();
                if (n.Text == "")
                {
                    p.Text = Convert.ToString("");
                    q.Text = Convert.ToString("");
                }
                if (n.Text == "Suji")
                {
                    p.Text = Convert.ToString(52);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Maida")
                {
                    p.Text = Convert.ToString(55);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Atta")
                {
                    p.Text = Convert.ToString(635);
                    q.Text = Convert.ToString(10 + " kg");
                }
                if (n.Text == "Baisan")
                {
                    p.Text = Convert.ToString(80);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Daal Chana")
                {
                    p.Text = Convert.ToString(85);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Daal Moong")
                {
                    p.Text = Convert.ToString(110);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Daal Maash")
                {
                    p.Text = Convert.ToString(100);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Daal Masoor")
                {
                    p.Text = Convert.ToString(90);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Daal Arhar")
                {
                    p.Text = Convert.ToString(135);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Daal MasoorWhole")
                {
                    p.Text = Convert.ToString(100);
                    q.Text = Convert.ToString(500 + " gm");
                }
                if (n.Text == "Dalya")
                {
                    p.Text = Convert.ToString(110);
                    q.Text = Convert.ToString(50 + " gm");
                }
                if (n.Text == "White Basmati Rice")
                {
                    p.Text = Convert.ToString(500);
                    q.Text = Convert.ToString(5 + " kg");
                }
                if (n.Text == "Sagoo Dana")
                {
                    p.Text = Convert.ToString(100);
                    q.Text = Convert.ToString(50 + " gm");
                }
                if (n.Text == "Kernal Basmati Rice")
                {
                    p.Text = Convert.ToString(675);
                    q.Text = Convert.ToString(5 + " kg");
                }
                if (n.Text == "Desi Ghee Tin")
                {
                    p.Text = Convert.ToString(500);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Ghee Tin")
                {
                    p.Text = Convert.ToString(300);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Ghee Poly Bag")
                {
                    p.Text = Convert.ToString(75);
                    q.Text = Convert.ToString(1 + " pouch");
                }
                if (n.Text == "Canola Oil")
                {
                    p.Text = Convert.ToString(500);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Soyabean Oil")
                {
                    p.Text = Convert.ToString(500);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Olive Oil")
                {
                    p.Text = Convert.ToString(575);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Sunflower Oil")
                {
                    p.Text = Convert.ToString(480);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Corn Oil")
                {
                    p.Text = Convert.ToString(675);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Mustard Oil")
                {
                    p.Text = Convert.ToString(400);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Black Olives")
                {
                    p.Text = Convert.ToString(250);
                    q.Text = Convert.ToString(250 + " gm");
                }
                if (n.Text == "Pineapple Slices Tin")
                {
                    p.Text = Convert.ToString(150);
                    q.Text = Convert.ToString(200 + " gm");
                }
                if (n.Text == "Mixed Fruit Slices Tin")
                {
                    p.Text = Convert.ToString(150);
                    q.Text = Convert.ToString(200 + " gm");
                }
                if (n.Text == "Green Olives")
                {
                    p.Text = Convert.ToString(200);
                    q.Text = Convert.ToString(250 + " gm");
                }
                if (n.Text == "Chicken Seekh Kabab")
                {
                    p.Text = Convert.ToString(600);
                    q.Text = Convert.ToString(12 + " Pcs");
                }
                if (n.Text == "Chicken Kofta")
                {
                    p.Text = Convert.ToString(800);
                    q.Text = Convert.ToString(14 + " Pcs");
                }
                if (n.Text == "Chicken Nuggets")
                {
                    p.Text = Convert.ToString(500);
                    q.Text = Convert.ToString(20 + " Pcs");
                }
                if (n.Text == "Chicken Shami Kabab")
                {
                    p.Text = Convert.ToString(450);
                    q.Text = Convert.ToString(12 + " Pcs");
                }
                if (n.Text == "Nido")
                {
                    p.Text = Convert.ToString(449);
                    q.Text = Convert.ToString(390 + " gm");
                }
                if (n.Text == "Koko Krunch Cereal")
                {
                    p.Text = Convert.ToString(535);
                    q.Text = Convert.ToString(330 + " gm");
                }
                if (n.Text == "Wheat Flakes")
                {
                    p.Text = Convert.ToString(250);
                    q.Text = Convert.ToString(250 + " gm");
                }
                if (n.Text == "Corn Flakes")
                {
                    p.Text = Convert.ToString(220);
                    q.Text = Convert.ToString(250 + " gm");
                }
                if (n.Text == "Mozzarella Cheese")
                {
                    p.Text = Convert.ToString(620);
                    q.Text = Convert.ToString(400 + " gm");
                }
                if (n.Text == "Cheddar Cheese")
                {
                    p.Text = Convert.ToString(550);
                    q.Text = Convert.ToString(400 + " gm");
                }
                if (n.Text == "Butter")
                {
                    p.Text = Convert.ToString(135);
                    q.Text = Convert.ToString(100 + " gm");
                }
                if (n.Text == "Nesvita")
                {
                    p.Text = Convert.ToString(160);
                    q.Text = Convert.ToString(1 + " Ltr");
                }

                if (n.Text == "Dawn Bread")
                {
                    p.Text = Convert.ToString(80);
                    q.Text = Convert.ToString(1 + " Pc");
                }
                if (n.Text == "Bun")
                {
                    p.Text = Convert.ToString(50);
                    q.Text = Convert.ToString(4 + " Pcs");
                }
                if (n.Text == "Golden Eggs Pack")
                {
                    p.Text = Convert.ToString(91);
                    q.Text = Convert.ToString(6 + " Pcs");
                }
                if (n.Text == "Liquid Bleach")
                {
                    p.Text = Convert.ToString(2384);
                    q.Text = Convert.ToString(2.72 + " Ltr");
                }
                if (n.Text == "Ariel Original Detergent")
                {
                    p.Text = Convert.ToString(310);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Lemon Max Powder")
                {
                    p.Text = Convert.ToString(80);
                    q.Text = Convert.ToString(900 + " gm");
                }
                if (n.Text == "Surf Excel")
                {
                    p.Text = Convert.ToString(405);
                    q.Text = Convert.ToString(1 + " kg");
                }
                if (n.Text == "Ariel Original Excel Gel")
                {
                    p.Text = Convert.ToString(1217);
                    q.Text = Convert.ToString(888 + " ml");
                }
                if (n.Text == "Lemon Max Power Cleaner")
                {
                    p.Text = Convert.ToString(65);
                    q.Text = Convert.ToString(430 + " gm");
                }
                if (n.Text == "Spontex Spiral")
                {
                    p.Text = Convert.ToString(99);
                    q.Text = Convert.ToString(2 + " Pcs");
                }
                if (n.Text == "Vim Lemon Gel")
                {
                    p.Text = Convert.ToString(247);
                    q.Text = Convert.ToString(500 + " ml");
                }
                if (n.Text == "Dry Mop Set")
                {
                    p.Text = Convert.ToString(375);
                    q.Text = Convert.ToString(1 + " Pc");
                }
                if (n.Text == "Coconut Broom")
                {
                    p.Text = Convert.ToString(90);
                    q.Text = Convert.ToString(1 + " Pc");
                }
                if (n.Text == "Flower Broom")
                {
                    p.Text = Convert.ToString(99);
                    q.Text = Convert.ToString(1 + " Pc");
                }
                if (n.Text == "Scotch Brite")
                {
                    p.Text = Convert.ToString(65);
                    q.Text = Convert.ToString(1 + " Pc");
                }
                if (n.Text == "Lux Soap Trio Pack")
                {
                    p.Text = Convert.ToString(204);
                    q.Text = Convert.ToString(3 + " Pcs");
                }
                if (n.Text == "Hand Sanitizer")
                {
                    p.Text = Convert.ToString(209);
                    q.Text = Convert.ToString(60 + " ml");
                }
                if (n.Text == "Body Wash")
                {
                    p.Text = Convert.ToString(499);
                    q.Text = Convert.ToString(500 + " ml");
                }
                if (n.Text == "Hand Wash")
                {
                    p.Text = Convert.ToString(118);
                    q.Text = Convert.ToString(225 + " ml");
                }
                if (n.Text == "Shower Gel")
                {
                    p.Text = Convert.ToString(299);
                    q.Text = Convert.ToString(250 + " ml");
                }
                if (n.Text == "Shampoo")
                {
                    p.Text = Convert.ToString(200);
                    q.Text = Convert.ToString(185 + " ml");
                }
                if (n.Text == "Hair Oil")
                {
                    p.Text = Convert.ToString(170);
                    q.Text = Convert.ToString(100 + " ml");
                }
                if (n.Text == "Hair Gel")
                {
                    p.Text = Convert.ToString(379);
                    q.Text = Convert.ToString(150 + " ml");
                }
                if (n.Text == "Fairness Cream")
                {
                    p.Text = Convert.ToString(241);
                    q.Text = Convert.ToString(50 + " gm");
                }
                if (n.Text == "Lotion")
                {
                    p.Text = Convert.ToString(260);
                    q.Text = Convert.ToString(200 + " ml");
                }
                if (n.Text == "Wipes")
                {
                    p.Text = Convert.ToString(209);
                    q.Text = Convert.ToString(30 + " Pcs");
                }
                if (n.Text == "Face Wash")
                {
                    p.Text = Convert.ToString(1100);
                    q.Text = Convert.ToString(150 + " ml");
                }
                if (n.Text == "Tooth Paste")
                {
                    p.Text = Convert.ToString(105);
                    q.Text = Convert.ToString(100 + " gm");
                }
                if (n.Text == "Tooth Brush")
                {
                    p.Text = Convert.ToString(171);
                    q.Text = Convert.ToString(2 + " Pcs");
                }
                if (n.Text == "Mouth Wash")
                {
                    p.Text = Convert.ToString(213);
                    q.Text = Convert.ToString(500 + " ml");
                }
                if (n.Text == "Cotton Buds")
                {
                    p.Text = Convert.ToString(135);
                    q.Text = Convert.ToString(200 + " Pcs");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); 
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button3_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape||e.KeyCode==Keys.Back)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
        }
        
        //public static  int count = -1;
        // public static string total = "";
        //public static string[] names = new string[10];
        public static List<string> names = new List<string>();
        public static List<string> prices = new List<string>();
        public static List<int> totalprice = new List<int>();
        public static List<int> qty = new List<int>();
        //public static string[] prices;
        private void button1_Click(object sender, EventArgs e)
        {
            //count++;
            //names = 
            //prices = new string[count + 1];
            //total += Convert.ToString(p.Text);
            //names[count] = Convert.ToString(n.Text);
            names.Add(n.Text);
            prices.Add(p.Text);
            qty.Add(Convert.ToInt32 (numericUpDown1.Value.ToString()));
            
            //string a = "";
            //   int b = 0, c = 0;
            //a = Convert.ToString(p.Text);
            //b = Convert.ToInt32(numericUpDown1.Value);
            //c = Convert.ToInt32(a) * b;
            totalprice.Add(Convert.ToInt32(numericUpDown1.Value.ToString()) * Convert.ToInt32(Convert.ToString(p.Text)));
            numericUpDown1.Value = 1;
            //names[count+1] = Convert.ToString(p.Text);
            //names[count + 2] = Convert.ToString(q.Text);
            //Form3.array[count] = names[count];
            //Form3.array[count + 1] = names[count + 1];
            //Form3.array[count + 2] = names[count + 2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }


        
        
    }
}
