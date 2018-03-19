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
        const int Smallprize = 10, Prize = 20, Mention = 9;
        
        public frmChocolateBoxes()
        {
            InitializeComponent();
            //hiding labels
            lblHonorable.Hide();
            lblPrize.Hide();
            lblsmall.Hide();
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
            if (NumberofChocolate <= Mention)
            {
                lblHonorable.Show();
                picPrize.Image = Properties.Resources.Scroll;
            }
            else if (NumberofChocolate >= Smallprize && NumberofChocolate < Prize)
            {
                lblsmall.Show();
                picPrize.Image = Properties.Resources.smallPrize1;
            }
            else if (NumberofChocolate >= Prize)
            {
                lblPrize.Show();
                picPrize.Image = Properties.Resources.Prize;
            }

        }
    }
}
