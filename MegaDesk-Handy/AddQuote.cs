using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Handy
{
    public partial class AddQuote : Form
    {
        private Form _mainMenu;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();
            // assign private variables
            _mainMenu = mainMenu;

            // assign min/max of controls
            this.numDeskDepth.Minimum = Desk.MIN_DEPTH;
            this.numDeskDepth.Maximum = Desk.MAX_DEPTH;

            this.numDeskWidth.Minimum = Desk.MIN_WIDTH;
            this.numDeskWidth.Maximum = Desk.MAX_WIDTH;

            this.numNumberOfDrawers.Minimum = Desk.MIN_DESK_DRAWERS;
            this.numNumberOfDrawers.Maximum = Desk.MAX_DESK_DRAWERS;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            //((Form)this.Tag).Show();
            _mainMenu.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk();

            desk.Depth = numDeskDepth.Value;
        }
    }
}
