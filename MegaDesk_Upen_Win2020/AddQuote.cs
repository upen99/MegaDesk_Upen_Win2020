using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Upen_Win2020
{

    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        public AddQuote(Form MainMenu)
        {
            InitializeComponent();
            _mainMenu = MainMenu;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
