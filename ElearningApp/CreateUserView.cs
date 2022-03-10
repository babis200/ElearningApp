using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin2DotNet.Controls;

namespace ElearningApp
{
    public partial class CreateUserView : MaterialForm
    {
        public CreateUserView()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //only teachers and admins can create students

            //only admins can create teachers

            //students cant create new users
        }
    }
}
