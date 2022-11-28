using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class signupForm : Form
    {
        Client client = new Client();
        public signupForm()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Call Verification method and SignUp method from the client class.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!Verification())
            {
                MessageBox.Show("Put something in the textbox");
                return;
            }
            else
            {
            client.SignUp(usernameTextBox.Text.ToString(), passwordTextBox.Text.ToString(), comboBox1.SelectedItem.ToString());

            }
        }

        /// <summary>
        /// Verification for user input
        /// </summary>
        /// <returns></returns>
        public bool Verification()
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) && string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

    }
}
