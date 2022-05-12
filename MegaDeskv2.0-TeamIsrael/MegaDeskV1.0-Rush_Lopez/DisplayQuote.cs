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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string firstName, string lastName)
        {
            InitializeComponent();
            lblLastName.Text = firstName;
            lblLastName.Text = lastName;
            //lblWidth.Text = width;
            //lblDepth.Text = depth;
            //lblDrawers.Text = drawers;
            //lblSurface.Text = surface;
            //lblMaterial.Text = material;
            //lblPrice.Text = price;
            
        }

        public DisplayQuote()
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void lblClientName_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
