using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Trending
{
    public partial class frmAddNews : Form
    {
        public frmAddNews()
        {
            InitializeComponent();
        }

        private void frmAddNews_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFeed_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
