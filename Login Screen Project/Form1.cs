using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            pnlSlide.Location = new Point(137, 114);
            pnlSignUp.Visible = false;
        }

     
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            pnlSlide.Location = new Point(219, 112);
            pnlSignUp.Visible= true;

        }

     

    

        private void lblAlreadyHaveAccount_Click(object sender, EventArgs e)
        {
            pnlSlide.Location = new Point(137, 114);
            pnlSignUp.Visible = false;
        }

      
    }
}
