using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Management_System
{
    public partial class NavbarControl : UserControl
    {
        public event EventHandler HomeClicked;


        public NavbarControl()
        {
            InitializeComponent();
        }

        private void NavbarControl_Load(object sender, EventArgs e)
        {
            Panel nav = new Panel();
            nav.Height = 300;
            nav.Dock = DockStyle.Top;
            this.Controls.Add(nav);


            pictureBox1.Image = Image.FromFile(Path.Combine("Assets", "Logo.png"));
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void Home_Click(object sender, EventArgs e)
        {
            HomeClicked?.Invoke(this, EventArgs.Empty);
        }

        

        
    }
}
