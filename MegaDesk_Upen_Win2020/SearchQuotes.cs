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
    public partial class SearchQuotes : Form
    {
        private Form _mainMenu;

        public SearchQuotes(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

        }
    }
}
