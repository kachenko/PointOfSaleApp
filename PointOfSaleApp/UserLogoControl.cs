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
            fullNameLabel.Text = MyUserClass.userFullName;
            roleLabel.Text = MyUserClass.userRole;
        }
    }
}
