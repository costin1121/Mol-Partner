using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MolPartner
{
	public partial class frmSettings : Form
	{
		public string usernameTBI;
		public string passwordTBI;
		public string serverDatabase;
		public string usernameDatabase;
		public string passwordDatabase;
		public string usernameMol;
		public string passwordMol;
		public string intervalVerificare;
		
		public frmSettings()
		{
			InitializeComponent();
		}

		public void writeRegisty()
		{
			RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\MolB2B Partner\Optiuni");
  
			key.SetValue("username_tbi", edUsernameAPI.Text);
			key.SetValue("password_tbi", edPasswordAPI.Text);
			key.SetValue("server_databse", edServerDatabase.Text);
			key.SetValue("username_database", edUsernameDatabase.Text);
			key.SetValue("password_database", edPasswordDatabase.Text);
			key.SetValue("username_mol", edUsernameMol.Text);
			key.SetValue("password_mol", edPasswordMol.Text);
			key.SetValue("interval_verificare", ndInterval.Value.ToString());

			key.Close();
		}

		public void readRegistry()
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\MolB2B Partner\Optiuni");
			string keyName = @"HKEY_CURRENT_USER\SOFTWARE\MolB2B Partner\Optiuni";
			if (Registry.GetValue(keyName, "username_tbi", null) != null)
			{
				usernameTBI = key.GetValue("username_tbi").ToString();
			}
			else
			{
				usernameTBI = "";
			}
			if (Registry.GetValue(keyName, "password_tbi", null) != null)
			{
				passwordTBI = key.GetValue("password_tbi").ToString();
			}
			else
			{
				passwordTBI = "";
			}
			if (Registry.GetValue(keyName, "server_databse", null) != null)
			{
				serverDatabase = key.GetValue("server_databse").ToString();
			}
			else
			{
				serverDatabase = "";
			}
			if (Registry.GetValue(keyName, "username_database", null) != null)
			{
				usernameDatabase = key.GetValue("username_database").ToString();
			}
			else
			{
				usernameDatabase = "";
			}
			if (Registry.GetValue(keyName, "password_database", null) != null)
			{
				passwordDatabase = key.GetValue("password_database").ToString();
			}
			else
			{
				passwordDatabase = "";
			}
			if (Registry.GetValue(keyName, "username_mol", null) != null)
			{
				usernameMol = key.GetValue("username_mol").ToString();
			}
			else
			{
				usernameMol = "";
			}
			if (Registry.GetValue(keyName, "password_mol", null) != null)
			{
				passwordMol = key.GetValue("password_mol").ToString();
			}
			else
			{
				passwordMol = "";
			}

			if (Registry.GetValue(keyName, "interval_verificare", null) != null)
			{
				intervalVerificare = key.GetValue("interval_verificare").ToString();
			}
			else
			{
				intervalVerificare = "1";
			}
		}

		private void btnExitSettings_Click(object sender, EventArgs e)
		{
			
			
		}

		private void btnExitSettings_Click_1(object sender, EventArgs e)
		{
			this.Close();

		}

		private void btnBaza_Click(object sender, EventArgs e)
		{
			panelAPI.Visible = false;
			panelDatabase.Visible = true;
			panelSetariGenerale.Visible = false;
			lbltitle.Text = "Baza de Date";
			
		}

		private void btnAPITBI_Click(object sender, EventArgs e)
		{
			panelAPI.Visible = true;
			panelDatabase.Visible = false;
			panelSetariGenerale.Visible = false;
			lbltitle.Text = "Access API TBI";
		}

		private void edServer_TextChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void btnSetariGenerale_Click(object sender, EventArgs e)
		{
			panelAPI.Visible = false;
			panelDatabase.Visible = false;
			panelSetariGenerale.Visible = true;
			lbltitle.Text = "Setari Generale";
		}

		private void frmSettings_Load(object sender, EventArgs e)
		{
			readRegistry();
			edUsernameAPI.Text = usernameTBI;
			edPasswordAPI.Text = passwordTBI;
			edServerDatabase.Text = serverDatabase;
			edUsernameDatabase.Text = usernameDatabase;
			edPasswordDatabase.Text = passwordDatabase;
			edUsernameMol.Text = usernameMol;
			edPasswordMol.Text = passwordMol;
			ndInterval.Value = Convert.ToDecimal(intervalVerificare);

			panelAPI.Visible = true;
			panelDatabase.Visible = false;
			panelSetariGenerale.Visible = false;
			lbltitle.Text = "Access API TBI";
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			writeRegisty();
			frmMain.main.log = "[" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "] - " + "Optiunile au fost salvate cu success!" + Environment.NewLine;
			this.Close();
		}
	}
}
