/*
 * Created by: Allison Cook
 * Created on: 19 March, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program shows what the user gets for the number of chocolate boxes they sold
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocolateBoxesAllisonC
{
    public partial class frmChocolateBoxes : Form
    {
        //variables
        int NumberofChocolate;

        //constants
        const int Smallprize = 10, Prize = 20;
        
        public frmChocolateBoxes()
        {
            InitializeComponent();
            //hiding labels
            lblHonorable.Hide();
            lblPrize.Hide();
            lblsmall.Hide();
            lblTry.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //closes the program when clicked
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //hiding labels
            lblHonorable.Hide();
            lblPrize.Hide();
            lblsmall.Hide();
            lblTry.Hide();

            //show one label
            lblget.Show();

            //make sure the user enter a number
            try
            {
                NumberofChocolate = Convert.ToInt32(txtNumberOfBoxes.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }

            //if they got a certain amount change the prize
            if (NumberofChocolate > 50)
            {
                MessageBox.Show("Please enter a realistic number");
            }
            else
            {
                if (NumberofChocolate <= 0)
                {
                    lblTry.Show();
                    lblget.Hide();
                    picPrize.Visible = false;
                }
                else
                {
                    if (NumberofChocolate > Prize)
                    {
                        lblPrize.Show();
                        picPrize.Image = Properties.Resources.Prize;
                        picPrize.Visible = true;
                    }
                    else
                    {
                        if (NumberofChocolate < Smallprize)
                        {
                            lblHonorable.Show();
                            picPrize.Image = Properties.Resources.Scroll;
                            picPrize.Visible = true;
                        }
                        else
                        {
                            lblsmall.Show();
                            picPrize.Image = Properties.Resources.smallPrize1;
                            picPrize.Visible = true;
                        }
                    }
                }
            }
        }
    }
}
