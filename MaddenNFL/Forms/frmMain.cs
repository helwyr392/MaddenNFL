using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaddenNFL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Init status bar
            Version ver = new Version(Application.ProductVersion);
            FileVersionInfo info = FileVersionInfo.GetVersionInfo(
                                              Path.GetFileName(
                                              Application.ExecutablePath));

            stStrip.ForeColor = Color.LightSlateGray;
            stlblVersion.Text = String.Format("Version: {0}.{1}.{2}", ver.Major, ver.Minor, ver.Build);
            stlblUser.Text = String.Format("Current User: {0}", Environment.UserName);
            stlblCopyright.Text = info.LegalCopyright;
        }

        // Menu button mouse enter event
        private void btnButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnPlayers":
                    btnPlayers.ForeColor = Color.Gainsboro;
                    break;
                case "btnSeason":
                    btnSeason.ForeColor = Color.Gainsboro;
                    break;
                case "btnCoaches":
                    btnCoaches.ForeColor = Color.Gainsboro;
                    break;
                case "btnGames":
                    btnGames.ForeColor = Color.Gainsboro;
                    break;
                case "btnDraft":
                    btnDraft.ForeColor = Color.Gainsboro;
                    break;
                case "btnRosters":
                    btnRosters.ForeColor = Color.Gainsboro;
                    break;
            }

        }

        // Menu button mouse leave event
        private void btnButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btnPlayers":
                    btnPlayers.ForeColor = Color.FromArgb(0, 58, 115);
                    break;
                case "btnSeason":
                    btnSeason.ForeColor = Color.FromArgb(0, 58, 115);
                    break;
                case "btnCoaches":
                    btnCoaches.ForeColor = Color.FromArgb(0, 58, 115);
                    break;
                case "btnGames":
                    btnGames.ForeColor = Color.FromArgb(0, 58, 115);
                    break;
                case "btnDraft":
                    btnDraft.ForeColor = Color.FromArgb(0, 58, 115);
                    break;
                case "btnRosters":
                    btnRosters.ForeColor = Color.FromArgb(0, 58, 115);
                    break;
            }

        }
    }
}
