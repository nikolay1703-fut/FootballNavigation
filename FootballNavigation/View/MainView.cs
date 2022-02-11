using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FootballNavigation.View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnField_Click(object sender, EventArgs e)
        {
            FieldView fieldView = new FieldView();
            fieldView.Show();
            this.Hide();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            ManagerView managerView = new ManagerView();
            managerView.Show();
            this.Hide();
        }
    }
}
