using Restaurant.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Möchten Sie den Program schließen ?","Achtung",MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnAnmelden_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string passWort = tbPassWort.Text;
            if(Login(userName,passWort))
            {
                RestaurantVerwaltungfenster restaurantVerwaltungfenster = new RestaurantVerwaltungfenster();
                this.Hide();
                restaurantVerwaltungfenster.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie haben das Passwort falsch eingegeben");
            }
        }

        private bool Login(string userName,string passWort)
        {
            return KontoDAO.Instance.Login(userName, passWort);
        }
    }
}
