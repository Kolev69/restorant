using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestorantGeorgi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            grpmainmeal.Hide();
            grpdessert.Hide();
            grpalcohol.Hide();
            grpsoftdrinks.Hide();
           // grphotdrinks.Hide();
        }

        private void btnmain_Click(object sender, EventArgs e)
        {
            grpmainmeal.Show();
        }

        private void btnaddmainmeal_Click(object sender, EventArgs e)
        {
            if (txtpile.Text != "0")
                listBox1.Items.Add($"{lblpile.Text} - {txtpile.Text}бр.");

            if (txtpork.Text != "0")
                listBox1.Items.Add($"{lblpork.Text} - {txtpork.Text}бр.");

            if (txtpasta.Text != "0")
                listBox1.Items.Add($"{lblpasta.Text} - {txtpasta.Text}бр.");

        }

        private void btndesert_Click(object sender, EventArgs e)
        {
            grpdessert.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttiramisu.Text != "0")
                listBox1.Items.Add($"{lbltiramisu.Text} - {txttiramisu.Text}бр.");

            if (txtsladoled.Text != "0")
                listBox1.Items.Add($"{lblsladoled.Text} - {txtsladoled.Text}бр.");

            if (txttorta.Text != "0")
                listBox1.Items.Add($"{lbltorta.Text} - {txttorta.Text}бр.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtwisky.Text != "0")
                listBox1.Items.Add($"{lblwisky.Text} - {txtwisky.Text}бр.");

            if (txtvodka.Text != "0")
                listBox1.Items.Add($"{lblvodka.Text} - {txtvodka.Text}бр.");

            if (txtmoet.Text != "0")
                listBox1.Items.Add($"{lblmoet.Text} - {txtmoet.Text}бр.");
        }

        private void btnalkohol_Click(object sender, EventArgs e)
        {
            grpalcohol.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void btnsoftdrinks_Click(object sender, EventArgs e)
        {
            grpsoftdrinks.Show();
        }

        private void btnaddsoft_Click(object sender, EventArgs e)
        {
            if (txtfanta.Text != "0")
                listBox1.Items.Add($"{lblfanta.Text} - {txtfanta.Text}бр.");

            if (txtkola.Text != "0")
                listBox1.Items.Add($"{lblkola.Text} - {txtkola.Text}бр.");

            if (txtsprite.Text != "0")
                listBox1.Items.Add($"{lblsprite.Text} - {txtsprite.Text}бр.");
        }

        private void btnhotdrinks_Click(object sender, EventArgs e)
        {
           // grphotdrinks.Show();
        }

        private void btnaddhot_Click(object sender, EventArgs e)
        {
            //if (txtmlqko.Text != "0")
              //  listBox1.Items.Add($"{lblmlqko.Text} - {txtmlqko.Text}бр.");

            //if (txtchoko.Text != "0")
            //    listBox1.Items.Add($"{lblchoko.Text} - {txtchoko.Text}бр.");
            
            //if (txtchai.Text != "0")
              //  listBox1.Items.Add($"{lblchai.Text} - {txtchai.Text}бр.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int firstbox=(int.Parse(txtpile.Text)*10)+ (int.Parse(txtpork.Text) * 13)+ (int.Parse(txtpasta.Text) * 15);
            int secondbox = (int.Parse(txttiramisu.Text) * 6) + (int.Parse(txtsladoled.Text) * 8) + (int.Parse(txttorta.Text) * 20);
            int thirdbox = (int.Parse(txtwisky.Text) * 120) + (int.Parse(txtvodka.Text) * 60) + (int.Parse(txtmoet.Text) * 300);
            int fourthbox = (int.Parse(txtfanta.Text) * 7) + (int.Parse(txtkola.Text) * 8) + (int.Parse(txtsprite.Text) * 6);
            //int fifthbox = (int.Parse(txtmlqko.Text) * 4) + (int.Parse(txtchoko.Text) * 12) + (int.Parse(txtchai.Text) * 2);
            int result = firstbox+ secondbox + thirdbox + fourthbox;
            string listBoxItems = "";
            foreach (var item in listBox1.Items)
            {
                listBoxItems += item.ToString() + Environment.NewLine;
            }

            // Display the sorted items in a MessageBox
            MessageBox.Show($"{listBoxItems}\n{result}лв.","сметка");
        }
    }
}
