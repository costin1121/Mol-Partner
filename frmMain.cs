using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.Threading;

namespace MolPartner
{
	public partial class frmMain : Form
    {
		internal static frmMain main;
		internal string log
		{
			get { return rtLog.Text.ToString(); }
			set { rtLog.AppendText(value); }
		}
		Thread th;
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public frmMain()
        {
            InitializeComponent();
			main = this;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
			CheckForIllegalCrossThreadCalls = false;
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);
			frmSettings settings = new frmSettings();
			settings.Show();
		}

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }



        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.log = "[" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "] - " + "Aplicatia a fost pornita!" + Environment.NewLine;
		}

		private void btnVerificareManuala_Click(object sender, EventArgs e)
		{
			utils.startBot("", "", "", "", "", "test", "test", 1);
		}
	}
}
