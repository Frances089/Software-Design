using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareDesign_Application
{
    public partial class POS : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        db_connection_pos posdb_connect = new db_connection_pos();
        double Discount;
        
        public POS()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {

            posdb_connect.pos_sql = "SELECT * FROM pos_itemnameTbl INNER JOIN pos_picpathTbl ON pos_itemnameTbl.stock_id=pos_picpathTbl.stock_id INNER JOIN pos_priceTbl ON  pos_picpathTbl.stock_id= pos_priceTbl.stock_id WHERE pos_itemnameTbl.stock_id = '4'";
            posdb_connect.pos_cmd();
            posdb_connect.pos_sqladapterSelect();
            posdb_connect.sqldataset();

            pos_imageLbl1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            pos_imageLbl2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            pos_imageLbl3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            pos_imageLbl4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            pos_imageLbl5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            pos_imageLbl6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            pos_imageLbl7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            pos_imageLbl8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            pos_imageLbl9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            pos_imageLbl10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            pos_imageLbl11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            pos_imageLbl12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            pos_imageLbl13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            pos_imageLbl14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            pos_imageLbl15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            pos_imageLbl16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            pos_imageLbl17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            pos_imageLbl18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            pos_imageLbl19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            pos_imageLbl20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();



            picpathTxtbox1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            picpathTxtbox2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            picpathTxtbox3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            picpathTxtbox4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            picpathTxtbox5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            picpathTxtbox6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            picpathTxtbox7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            picpathTxtbox8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            picpathTxtbox9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            picpathTxtbox10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            picpathTxtbox11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            picpathTxtbox12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            picpathTxtbox13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            picpathTxtbox14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            picpathTxtbox15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            picpathTxtbox16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            picpathTxtbox17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            picpathTxtbox18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            picpathTxtbox19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            picpathTxtbox20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();



            pos_priceLbl1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][45].ToString();
            pos_priceLbl2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
            pos_priceLbl3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
            pos_priceLbl4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
            pos_priceLbl5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
            pos_priceLbl6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
            pos_priceLbl7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
            pos_priceLbl8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
            pos_priceLbl9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
            pos_priceLbl10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
            pos_priceLbl11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
            pos_priceLbl12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
            pos_priceLbl13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
            pos_priceLbl14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
            pos_priceLbl15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
            pos_priceLbl16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
            pos_priceLbl17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
            pos_priceLbl18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
            pos_priceLbl19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
            pos_priceLbl20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();

            



            lightsPicbox1.Image = Image.FromFile(picpathTxtbox1.Text);
            lightsPicbox2.Image = Image.FromFile(picpathTxtbox2.Text);
            lightsPicbox3.Image = Image.FromFile(picpathTxtbox3.Text);
            lightsPicbox4.Image = Image.FromFile(picpathTxtbox4.Text);
            lightsPicbox5.Image = Image.FromFile(picpathTxtbox5.Text);
            lightsPicbox6.Image = Image.FromFile(picpathTxtbox6.Text);
            lightsPicbox7.Image = Image.FromFile(picpathTxtbox7.Text);
            lightsPicbox8.Image = Image.FromFile(picpathTxtbox8.Text);
            lightsPicbox9.Image = Image.FromFile(picpathTxtbox9.Text);
            lightsPicbox10.Image = Image.FromFile(picpathTxtbox10.Text);
            lightsPicbox11.Image = Image.FromFile(picpathTxtbox11.Text);
            lightsPicbox12.Image = Image.FromFile(picpathTxtbox12.Text);
            lightsPicbox13.Image = Image.FromFile(picpathTxtbox13.Text);
            lightsPicbox14.Image = Image.FromFile(picpathTxtbox14.Text);
            lightsPicbox15.Image = Image.FromFile(picpathTxtbox15.Text);
            lightsPicbox16.Image = Image.FromFile(picpathTxtbox16.Text);
            lightsPicbox17.Image = Image.FromFile(picpathTxtbox17.Text);
            lightsPicbox18.Image = Image.FromFile(picpathTxtbox18.Text);
            lightsPicbox19.Image = Image.FromFile(picpathTxtbox19.Text);
            lightsPicbox20.Image = Image.FromFile(picpathTxtbox20.Text);


            this.BackColor = Color.White;
            //codes for puting value of picturebox and load it to once the form will be loaded 
           
            // disabling of textboxes during loading of the form to avoid editing the displayed value

            itemnameTxtbox.Enabled = false;
            priceTxtbox.Enabled = false;
            discounted_amountTxtbox.Enabled = false;
            discount_amountTxtbox.Enabled = false;
            total_discount_amountTxtbox.Enabled = false;
            total_discount_givenTxtbox.Enabled = false;
            total_quantityTxtbox.Enabled = false;
            changeTxtbox.Enabled = false;

            picpathTxtbox1.Hide();
            picpathTxtbox2.Hide();
            picpathTxtbox3.Hide();
            picpathTxtbox4.Hide();
            picpathTxtbox5.Hide();
            picpathTxtbox6.Hide();
            picpathTxtbox7.Hide();
            picpathTxtbox8.Hide();
            picpathTxtbox9.Hide();
            picpathTxtbox10.Hide();
            picpathTxtbox11.Hide();
            picpathTxtbox12.Hide();
            picpathTxtbox13.Hide();
            picpathTxtbox14.Hide();
            picpathTxtbox15.Hide();
            picpathTxtbox16.Hide();
            picpathTxtbox17.Hide();
            picpathTxtbox18.Hide();
            picpathTxtbox19.Hide();
            picpathTxtbox20.Hide();


           


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lightsPicbox1_Click(object sender, EventArgs e)
        {
              itemnameTxtbox.Text= pos_imageLbl1.Text;
              priceTxtbox.Text = pos_priceLbl1.Text;

            quantityTxtbox.Focus();

        }

        private void lightsPicbox2_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl2.Text;
            priceTxtbox.Text = pos_priceLbl2.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox3_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl3.Text;
            priceTxtbox.Text = pos_priceLbl3.Text;
            quantityTxtbox.Focus();

        }

        private void lightsPicbox4_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl4.Text;
            priceTxtbox.Text = pos_priceLbl4.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox5_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl5.Text;
            priceTxtbox.Text = pos_priceLbl5.Text;
            quantityTxtbox.Focus();

        }

        private void lightsPicbox6_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl6.Text;
            priceTxtbox.Text = pos_priceLbl6.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox7_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl7.Text;
            priceTxtbox.Text = pos_priceLbl7.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox8_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl8.Text;
            priceTxtbox.Text = pos_priceLbl8.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox9_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl9.Text;
            priceTxtbox.Text = pos_priceLbl9.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox10_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl10.Text;
            priceTxtbox.Text = pos_priceLbl10.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox11_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl11.Text;
            priceTxtbox.Text = pos_priceLbl11.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox12_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl12.Text;
            priceTxtbox.Text = pos_priceLbl12.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox13_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl13.Text;
            priceTxtbox.Text = pos_priceLbl13.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox14_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl14.Text;
            priceTxtbox.Text = pos_priceLbl14.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox15_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl15.Text;
            priceTxtbox.Text = pos_priceLbl15.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox16_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl16.Text;
            priceTxtbox.Text = pos_priceLbl16.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox17_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl17.Text;
            priceTxtbox.Text = pos_priceLbl17.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox18_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl18.Text;
            priceTxtbox.Text = pos_priceLbl18.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox19_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl19.Text;
            priceTxtbox.Text = pos_priceLbl19.Text;
            quantityTxtbox.Focus();
        }

        private void lightsPicbox20_Click(object sender, EventArgs e)
        {
            itemnameTxtbox.Text = pos_imageLbl20.Text;
            priceTxtbox.Text = pos_priceLbl20.Text;
            quantityTxtbox.Focus();
        }

        private void total_quantityTxtbox_TextChanged(object sender, EventArgs e)
        {
            
                total_quantityTxtbox.Text = quantityTxtbox.Text;
          
        }

        private void discount_option_seniorRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double Quantity, TotalPrice, Price, NewPrice, Discountedamount;
            

            Discount = 0.2;

            try
            {
                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();
            }
            catch
            {
                MessageBox.Show("Please Input the Quantity First");
                discount_option_seniorRdbtn.Checked = false;
            }



        }

        private void discount_option_with_discount_cardRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            double Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            Discount = 0.1;
            try
            {


                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();
            }
            catch
            {
                MessageBox.Show("Please Input the Quantity First");
                discount_option_with_discount_cardRdbtn.Checked = false;
            }

        }

        private void discount_option_employeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {

            double Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            Discount = 0.15;
            try
            {

                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();

            }
            catch
            {
                MessageBox.Show("Please Input the Quantity First");
                discount_option_employeeRdbtn.Checked = false;
            }

        }

        private void discount_option_no_discountRdbtn_CheckedChanged(object sender, EventArgs e)
        {

            double Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            Discount = 0;

            try
            {

                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();
            }
            catch
            {
                MessageBox.Show("Please Input the Quantity First");
                discount_option_no_discountRdbtn.Checked = false;

            }
            


        }

        private void changeTxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {

            double  Quantity, TotalPrice, Price, NewPrice, Discountedamount;

            try
            {



                Quantity = Convert.ToDouble(total_quantityTxtbox.Text);
                Price = Convert.ToDouble(priceTxtbox.Text);

                TotalPrice = Quantity * Price;

                NewPrice = TotalPrice * Discount;

                Discountedamount = TotalPrice - NewPrice;
                discount_amountTxtbox.Text = NewPrice.ToString();
                discounted_amountTxtbox.Text = Discountedamount.ToString();
                total_discount_givenTxtbox.Text = Discount.ToString();
                total_discount_amountTxtbox.Text = discounted_amountTxtbox.Text;


                total_discount_givenTxtbox.Text = Discount.ToString();
                total_discount_amountTxtbox.Text = discounted_amountTxtbox.Text;

                double Cashgiven, TotalChange, Priceamount;
                Priceamount = Convert.ToDouble(total_discount_amountTxtbox.Text);
                Cashgiven = Convert.ToDouble(cash_givenTxtbox.Text);
                TotalChange = Cashgiven - Priceamount;
                changeTxtbox.Text = TotalChange.ToString();

                if ( Cashgiven < Discountedamount)
                {
                    cash_givenTxtbox.Clear();
                    changeTxtbox.Clear();
                    MessageBox.Show("Please Enter The Right Payment");
                }
            }
            catch
            {

            }
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            
                itemnameTxtbox.Clear();
                priceTxtbox.Clear();
                quantityTxtbox.Clear();
                discounted_amountTxtbox.Clear();
                discount_amountTxtbox.Clear();
                
           
        }

        private void itemnameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
