using System;
using System.Drawing;
using System.Windows.Forms;

namespace YPlaylist
{
    public partial class MainForm : Form
    {
        private static MainForm _instance;

        public static MainForm Instance()
        {
            if (_instance == null)
                _instance = new MainForm();

            return _instance;
        }

        public MainForm()
        {
            InitializeComponent();
        }
        
        public void ChangeControl(UserControl control)
        {
            this.Controls.Clear();
            control.Location = new Point(0, 0);
            this.Controls.Add(control);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WelcomeControl mc1 = new WelcomeControl();
            mc1.Location = new Point(0, 0);
            this.Controls.Add(mc1);
        }
    }
}
