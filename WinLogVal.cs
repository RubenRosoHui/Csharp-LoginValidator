using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibLoginValidator;
namespace WinLoginValidator
{
    public partial class WinLogVal : Form
    {
        private LoginValidator login = new LoginValidator();
        public WinLogVal()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login.Authorize() == null)
            {
                MessageBox.Show("Error please enter a username and password", "Failed Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (login.Authorize() == false)
            {
                MessageBox.Show("Authorization Unsuccessful please try again","Failed Authorization",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else 
            {
                MessageBox.Show("Authorization Successful");
                
                Application.Exit();
            }
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtUsername.Focus();

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { login.username = null; }
            else { login.username = txtUsername.Text; }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") { login.password = null; }
            else { login.password = txtPassword.Text; }
            
            
        }
    }
}
