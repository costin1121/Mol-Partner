namespace MolPartner
{
	partial class frmSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnExitSettings = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSetariGenerale = new System.Windows.Forms.Button();
			this.btnBaza = new System.Windows.Forms.Button();
			this.btnAPITBI = new System.Windows.Forms.Button();
			this.panelAPI = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.edPasswordAPI = new System.Windows.Forms.TextBox();
			this.edUsernameAPI = new System.Windows.Forms.TextBox();
			this.panelDatabase = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.edServerDatabase = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.edPasswordDatabase = new System.Windows.Forms.TextBox();
			this.edUsernameDatabase = new System.Windows.Forms.TextBox();
			this.panelSetariGenerale = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.ndInterval = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.edPasswordMol = new System.Windows.Forms.TextBox();
			this.edUsernameMol = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.lbltitle = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panelAPI.SuspendLayout();
			this.panelDatabase.SuspendLayout();
			this.panelSetariGenerale.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ndInterval)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExitSettings
			// 
			this.btnExitSettings.FlatAppearance.BorderSize = 0;
			this.btnExitSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExitSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExitSettings.ForeColor = System.Drawing.Color.White;
			this.btnExitSettings.Location = new System.Drawing.Point(589, 3);
			this.btnExitSettings.Name = "btnExitSettings";
			this.btnExitSettings.Size = new System.Drawing.Size(22, 25);
			this.btnExitSettings.TabIndex = 15;
			this.btnExitSettings.Text = "X";
			this.btnExitSettings.UseVisualStyleBackColor = true;
			this.btnExitSettings.Click += new System.EventHandler(this.btnExitSettings_Click_1);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.panel1.Controls.Add(this.btnSetariGenerale);
			this.panel1.Controls.Add(this.btnBaza);
			this.panel1.Controls.Add(this.btnAPITBI);
			this.panel1.Controls.Add(this.btnExitSettings);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(614, 58);
			this.panel1.TabIndex = 16;
			// 
			// btnSetariGenerale
			// 
			this.btnSetariGenerale.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnSetariGenerale.FlatAppearance.BorderSize = 0;
			this.btnSetariGenerale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetariGenerale.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetariGenerale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btnSetariGenerale.Image = global::MolPartener.Properties.Resources.settings;
			this.btnSetariGenerale.Location = new System.Drawing.Point(320, 0);
			this.btnSetariGenerale.Name = "btnSetariGenerale";
			this.btnSetariGenerale.Size = new System.Drawing.Size(167, 58);
			this.btnSetariGenerale.TabIndex = 18;
			this.btnSetariGenerale.Text = "Setari Generale";
			this.btnSetariGenerale.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnSetariGenerale.UseVisualStyleBackColor = true;
			this.btnSetariGenerale.Click += new System.EventHandler(this.btnSetariGenerale_Click);
			// 
			// btnBaza
			// 
			this.btnBaza.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnBaza.FlatAppearance.BorderSize = 0;
			this.btnBaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBaza.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btnBaza.Image = global::MolPartener.Properties.Resources.database;
			this.btnBaza.Location = new System.Drawing.Point(163, 0);
			this.btnBaza.Name = "btnBaza";
			this.btnBaza.Size = new System.Drawing.Size(157, 58);
			this.btnBaza.TabIndex = 17;
			this.btnBaza.Text = "Baza de Date";
			this.btnBaza.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnBaza.UseVisualStyleBackColor = true;
			this.btnBaza.Click += new System.EventHandler(this.btnBaza_Click);
			// 
			// btnAPITBI
			// 
			this.btnAPITBI.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnAPITBI.FlatAppearance.BorderSize = 0;
			this.btnAPITBI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAPITBI.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAPITBI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btnAPITBI.Image = global::MolPartener.Properties.Resources.api_component;
			this.btnAPITBI.Location = new System.Drawing.Point(0, 0);
			this.btnAPITBI.Name = "btnAPITBI";
			this.btnAPITBI.Size = new System.Drawing.Size(163, 58);
			this.btnAPITBI.TabIndex = 16;
			this.btnAPITBI.Text = "Access API TBI";
			this.btnAPITBI.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnAPITBI.UseVisualStyleBackColor = true;
			this.btnAPITBI.Click += new System.EventHandler(this.btnAPITBI_Click);
			// 
			// panelAPI
			// 
			this.panelAPI.Controls.Add(this.label2);
			this.panelAPI.Controls.Add(this.label1);
			this.panelAPI.Controls.Add(this.edPasswordAPI);
			this.panelAPI.Controls.Add(this.edUsernameAPI);
			this.panelAPI.Location = new System.Drawing.Point(0, 102);
			this.panelAPI.Name = "panelAPI";
			this.panelAPI.Size = new System.Drawing.Size(608, 180);
			this.panelAPI.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label2.Location = new System.Drawing.Point(147, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 17);
			this.label2.TabIndex = 15;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label1.Location = new System.Drawing.Point(144, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 14;
			this.label1.Text = "Username";
			// 
			// edPasswordAPI
			// 
			this.edPasswordAPI.BackColor = System.Drawing.Color.White;
			this.edPasswordAPI.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.edPasswordAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edPasswordAPI.ForeColor = System.Drawing.Color.Black;
			this.edPasswordAPI.Location = new System.Drawing.Point(216, 108);
			this.edPasswordAPI.Multiline = true;
			this.edPasswordAPI.Name = "edPasswordAPI";
			this.edPasswordAPI.PasswordChar = '*';
			this.edPasswordAPI.Size = new System.Drawing.Size(241, 27);
			this.edPasswordAPI.TabIndex = 13;
			// 
			// edUsernameAPI
			// 
			this.edUsernameAPI.BackColor = System.Drawing.Color.White;
			this.edUsernameAPI.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.edUsernameAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edUsernameAPI.ForeColor = System.Drawing.Color.Black;
			this.edUsernameAPI.Location = new System.Drawing.Point(216, 63);
			this.edUsernameAPI.Multiline = true;
			this.edUsernameAPI.Name = "edUsernameAPI";
			this.edUsernameAPI.Size = new System.Drawing.Size(241, 27);
			this.edUsernameAPI.TabIndex = 12;
			// 
			// panelDatabase
			// 
			this.panelDatabase.Controls.Add(this.label5);
			this.panelDatabase.Controls.Add(this.edServerDatabase);
			this.panelDatabase.Controls.Add(this.label3);
			this.panelDatabase.Controls.Add(this.label4);
			this.panelDatabase.Controls.Add(this.edPasswordDatabase);
			this.panelDatabase.Controls.Add(this.edUsernameDatabase);
			this.panelDatabase.Location = new System.Drawing.Point(3, 102);
			this.panelDatabase.Name = "panelDatabase";
			this.panelDatabase.Size = new System.Drawing.Size(608, 177);
			this.panelDatabase.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label5.Location = new System.Drawing.Point(163, 54);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "Server";
			// 
			// edServerDatabase
			// 
			this.edServerDatabase.BackColor = System.Drawing.Color.White;
			this.edServerDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.edServerDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edServerDatabase.ForeColor = System.Drawing.Color.Black;
			this.edServerDatabase.Location = new System.Drawing.Point(216, 49);
			this.edServerDatabase.Multiline = true;
			this.edServerDatabase.Name = "edServerDatabase";
			this.edServerDatabase.Size = new System.Drawing.Size(241, 27);
			this.edServerDatabase.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label3.Location = new System.Drawing.Point(147, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label4.Location = new System.Drawing.Point(144, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "Username";
			// 
			// edPasswordDatabase
			// 
			this.edPasswordDatabase.BackColor = System.Drawing.Color.White;
			this.edPasswordDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.edPasswordDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edPasswordDatabase.ForeColor = System.Drawing.Color.Black;
			this.edPasswordDatabase.Location = new System.Drawing.Point(216, 127);
			this.edPasswordDatabase.Multiline = true;
			this.edPasswordDatabase.Name = "edPasswordDatabase";
			this.edPasswordDatabase.PasswordChar = '*';
			this.edPasswordDatabase.Size = new System.Drawing.Size(241, 27);
			this.edPasswordDatabase.TabIndex = 13;
			// 
			// edUsernameDatabase
			// 
			this.edUsernameDatabase.BackColor = System.Drawing.Color.White;
			this.edUsernameDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.edUsernameDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edUsernameDatabase.ForeColor = System.Drawing.Color.Black;
			this.edUsernameDatabase.Location = new System.Drawing.Point(216, 87);
			this.edUsernameDatabase.Multiline = true;
			this.edUsernameDatabase.Name = "edUsernameDatabase";
			this.edUsernameDatabase.Size = new System.Drawing.Size(241, 27);
			this.edUsernameDatabase.TabIndex = 12;
			// 
			// panelSetariGenerale
			// 
			this.panelSetariGenerale.Controls.Add(this.label9);
			this.panelSetariGenerale.Controls.Add(this.label8);
			this.panelSetariGenerale.Controls.Add(this.ndInterval);
			this.panelSetariGenerale.Controls.Add(this.label6);
			this.panelSetariGenerale.Controls.Add(this.label7);
			this.panelSetariGenerale.Controls.Add(this.edPasswordMol);
			this.panelSetariGenerale.Controls.Add(this.edUsernameMol);
			this.panelSetariGenerale.Location = new System.Drawing.Point(0, 102);
			this.panelSetariGenerale.Name = "panelSetariGenerale";
			this.panelSetariGenerale.Size = new System.Drawing.Size(611, 180);
			this.panelSetariGenerale.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label9.Location = new System.Drawing.Point(339, 157);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 13);
			this.label9.TabIndex = 25;
			this.label9.Text = "minute";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label8.Location = new System.Drawing.Point(125, 153);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(118, 17);
			this.label8.TabIndex = 24;
			this.label8.Text = "Interval Verificare";
			// 
			// ndInterval
			// 
			this.ndInterval.Location = new System.Drawing.Point(246, 154);
			this.ndInterval.Name = "ndInterval";
			this.ndInterval.Size = new System.Drawing.Size(87, 20);
			this.ndInterval.TabIndex = 23;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label6.Location = new System.Drawing.Point(177, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 17);
			this.label6.TabIndex = 22;
			this.label6.Text = "Password";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.label7.Location = new System.Drawing.Point(174, 69);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 17);
			this.label7.TabIndex = 21;
			this.label7.Text = "Username";
			// 
			// edPasswordMol
			// 
			this.edPasswordMol.BackColor = System.Drawing.Color.White;
			this.edPasswordMol.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.edPasswordMol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edPasswordMol.ForeColor = System.Drawing.Color.Black;
			this.edPasswordMol.Location = new System.Drawing.Point(246, 109);
			this.edPasswordMol.Multiline = true;
			this.edPasswordMol.Name = "edPasswordMol";
			this.edPasswordMol.PasswordChar = '*';
			this.edPasswordMol.Size = new System.Drawing.Size(241, 27);
			this.edPasswordMol.TabIndex = 20;
			// 
			// edUsernameMol
			// 
			this.edUsernameMol.BackColor = System.Drawing.Color.White;
			this.edUsernameMol.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.edUsernameMol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edUsernameMol.ForeColor = System.Drawing.Color.Black;
			this.edUsernameMol.Location = new System.Drawing.Point(246, 64);
			this.edUsernameMol.Multiline = true;
			this.edUsernameMol.Name = "edUsernameMol";
			this.edUsernameMol.Size = new System.Drawing.Size(241, 27);
			this.edUsernameMol.TabIndex = 19;
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
			this.btnOk.Image = global::MolPartener.Properties.Resources.check;
			this.btnOk.Location = new System.Drawing.Point(527, 288);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(81, 34);
			this.btnOk.TabIndex = 20;
			this.btnOk.Text = "Ok";
			this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// lbltitle
			// 
			this.lbltitle.AutoSize = true;
			this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
			this.lbltitle.Location = new System.Drawing.Point(12, 61);
			this.lbltitle.Name = "lbltitle";
			this.lbltitle.Size = new System.Drawing.Size(96, 32);
			this.lbltitle.TabIndex = 21;
			this.lbltitle.Text = "Setari";
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
			this.ClientSize = new System.Drawing.Size(614, 333);
			this.Controls.Add(this.lbltitle);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelAPI);
			this.Controls.Add(this.panelSetariGenerale);
			this.Controls.Add(this.panelDatabase);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Setari";
			this.Load += new System.EventHandler(this.frmSettings_Load);
			this.panel1.ResumeLayout(false);
			this.panelAPI.ResumeLayout(false);
			this.panelAPI.PerformLayout();
			this.panelDatabase.ResumeLayout(false);
			this.panelDatabase.PerformLayout();
			this.panelSetariGenerale.ResumeLayout(false);
			this.panelSetariGenerale.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ndInterval)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExitSettings;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAPITBI;
		private System.Windows.Forms.Button btnSetariGenerale;
		private System.Windows.Forms.Button btnBaza;
		private System.Windows.Forms.Panel panelAPI;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edPasswordAPI;
		private System.Windows.Forms.TextBox edUsernameAPI;
		private System.Windows.Forms.Panel panelDatabase;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edServerDatabase;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edPasswordDatabase;
		private System.Windows.Forms.TextBox edUsernameDatabase;
		private System.Windows.Forms.Panel panelSetariGenerale;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown ndInterval;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edPasswordMol;
		private System.Windows.Forms.TextBox edUsernameMol;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label lbltitle;
	}
}