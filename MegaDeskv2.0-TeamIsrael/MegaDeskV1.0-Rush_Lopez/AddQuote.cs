using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskV1._0_Rush_Lopez     
{
        public partial class AddQuote : Form
        {
        private object tbWidth;

        public AddQuote()
                {
                    InitializeComponent();
                }

                private void label1_Click(object sender, EventArgs e)
                {

                }

                private void textBox1_TextChanged(object sender, EventArgs e)
                {

                }

                private void AddQuote_Load(object sender, EventArgs e)
                {

                }

                private void btnSave_Click(object sender, EventArgs e)
                {
                        // Collect data entry from form
                        string firstName = tbFirstName.Text;
                        string lastName = tbFirstName.Text;
                        //string width = tbWidth.Text;
                        //string depth = tbDepth.Text;
                        //string drawers = tbDrawers.Text;
                        //string surfaceMaterial = cbSurfaceMaterial.Text;
                        //string rushDays = cbRushDays.Text;
            
                        // Get current date and save to quote date textbox
                       // _ = DateTime.Now;

                        // Validate data entry

                        // If data is valid, send to display form
                        DisplayQuote displayQuote = new DisplayQuote();
                         displayQuote.ShowDialog();

                        // Save quote to file
        }

                private void tbWidth_Validating(object sender, CancelEventArgs e)
                {
                        // checks for an integer input and that checks for valid minimum and maximum values
                        int width;
                        if (!int.TryParse(tbDesktopWidth.Text, out width) || width < 24 || width > 96)
                        {
                            e.Cancel = true;
                            errorProvider.SetError(tbDesktopWidth, "Please enter a valid number between 24 and 96");
                            tbDesktopWidth.Focus();
                        } else {
                            errorProviderValid.SetError(tbDesktopWidth, "");  

                        }
                }

                void tbDepth_KeyPress(object depthSender, KeyPressEventArgs e)
                {
                        // Validate entry checking for valid integer input using a compound statement and the char data type with IsControl and IsDigit methods
                        if (Char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
                        {
                                e.Handled = true;
                                errorProvider.SetError(tbDesktopDepth, "Please enter a number");
                                tbDesktopDepth.Focus();
                        } 
                        else
                        {
                                e.Handled = true;                                
                                errorProvider.SetError(tbDesktopDepth, "");                                
                        }
                  }

        private void tbWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbFirstName, "Please enter first name");
                tbFirstName.Focus();                
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbFirstName, null);
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbLastName, "Please enter last name");
                tbLastName.Focus();

            }
            else
            {
                e.Cancel = false;
                errorProviderValid.SetError(tbLastName, "");
            }
        }

        private void tbDesktopDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
                errorProvider.SetError(tbDesktopDepth, "");
            }
            catch (Exception)
            {
                errorProvider.SetError(tbDesktopDepth, "Not an integer value.");
            }
        }

        private void tbDesktopDepth_Validating(object sender, CancelEventArgs e)
        {
            // checks for an integer input and that checks for valid minimum and maximum values
            int width;
            if (!int.TryParse(tbDesktopDepth.Text, out width) || width < 12 || width > 48)
            {
                e.Cancel = true;
                errorProvider.SetError(tbDesktopDepth, "Please enter a valid number between 12 and 48");
                tbDesktopDepth.Focus();
            }
            else
            {
                errorProviderValid.SetError(tbDesktopDepth, "");

            }
        }
    }        
 }
    
