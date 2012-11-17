using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AAA
{
    public partial class manager_window : Form
    {
        public manager_window()
        {
            InitializeComponent();
        }

        private void manager_window_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350,200);
        }
    }
}
