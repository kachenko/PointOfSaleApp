using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApp
{
    public partial class UserLogoControl : UserControl
    {
        public UserLogoControl()
        {
            InitializeComponent();
        }

        private void UserLogoControl_Load(object sender, EventArgs e)
        {
            fullNameLabel.Location = new Point(5, 91);
            fullNameLabel.Text = "Hello, " + MyUserClass.userLogin + "!";
        }
    }
}
