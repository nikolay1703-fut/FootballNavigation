using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FootballNavigation.View
{
    public partial class ManagerView : Form
    {
        public ManagerView()
        {
            InitializeComponent();
        }

        //this button returns us to the MainView
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainView mainView = new MainView();
            mainView.Show();
            this.Hide();
        }
    }
}
