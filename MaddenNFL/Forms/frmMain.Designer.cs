namespace MaddenNFL
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panMain = new System.Windows.Forms.Panel();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.btnSeason = new System.Windows.Forms.Button();
            this.btnCoaches = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnRosters = new System.Windows.Forms.Button();
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.stlblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlblCopyright = new System.Windows.Forms.ToolStripStatusLabel();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.stStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panMain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMain.Controls.Add(this.txtMain);
            this.panMain.Controls.Add(this.pbMain);
            this.panMain.ForeColor = System.Drawing.Color.Firebrick;
            this.panMain.Location = new System.Drawing.Point(41, 29);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(687, 320);
            this.panMain.TabIndex = 0;
            // 
            // txtMain
            // 
            this.txtMain.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMain.Font = new System.Drawing.Font("Franklin Gothic Heavy", 56.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.txtMain.Location = new System.Drawing.Point(277, 15);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ReadOnly = true;
            this.txtMain.Size = new System.Drawing.Size(388, 288);
            this.txtMain.TabIndex = 1;
            this.txtMain.TabStop = false;
            this.txtMain.Text = "Madden Franchise Tracker";
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMain.BackgroundImage")));
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMain.Location = new System.Drawing.Point(26, 15);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(227, 288);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // btnPlayers
            // 
            this.btnPlayers.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnPlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayers.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnPlayers.Location = new System.Drawing.Point(400, 422);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(302, 65);
            this.btnPlayers.TabIndex = 2;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = false;
            this.btnPlayers.MouseEnter += new System.EventHandler(this.btnButton_MouseEnter);
            this.btnPlayers.MouseLeave += new System.EventHandler(this.btnButton_MouseLeave);
            // 
            // btnSeason
            // 
            this.btnSeason.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSeason.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeason.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSeason.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnSeason.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeason.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnSeason.Location = new System.Drawing.Point(67, 422);
            this.btnSeason.Name = "btnSeason";
            this.btnSeason.Size = new System.Drawing.Size(302, 65);
            this.btnSeason.TabIndex = 1;
            this.btnSeason.Text = "Season";
            this.btnSeason.UseVisualStyleBackColor = false;
            this.btnSeason.MouseEnter += new System.EventHandler(this.btnButton_MouseEnter);
            this.btnSeason.MouseLeave += new System.EventHandler(this.btnButton_MouseLeave);
            // 
            // btnCoaches
            // 
            this.btnCoaches.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCoaches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoaches.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCoaches.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnCoaches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoaches.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoaches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnCoaches.Location = new System.Drawing.Point(400, 509);
            this.btnCoaches.Name = "btnCoaches";
            this.btnCoaches.Size = new System.Drawing.Size(302, 65);
            this.btnCoaches.TabIndex = 4;
            this.btnCoaches.Text = "Coaches";
            this.btnCoaches.UseVisualStyleBackColor = false;
            this.btnCoaches.MouseEnter += new System.EventHandler(this.btnButton_MouseEnter);
            this.btnCoaches.MouseLeave += new System.EventHandler(this.btnButton_MouseLeave);
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnGames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnGames.Location = new System.Drawing.Point(67, 509);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(302, 65);
            this.btnGames.TabIndex = 3;
            this.btnGames.Text = "Games";
            this.btnGames.UseVisualStyleBackColor = false;
            this.btnGames.MouseEnter += new System.EventHandler(this.btnButton_MouseEnter);
            this.btnGames.MouseLeave += new System.EventHandler(this.btnButton_MouseLeave);
            // 
            // btnDraft
            // 
            this.btnDraft.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDraft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDraft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraft.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnDraft.Location = new System.Drawing.Point(400, 596);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(302, 65);
            this.btnDraft.TabIndex = 6;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = false;
            this.btnDraft.MouseEnter += new System.EventHandler(this.btnButton_MouseEnter);
            this.btnDraft.MouseLeave += new System.EventHandler(this.btnButton_MouseLeave);
            // 
            // btnRosters
            // 
            this.btnRosters.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRosters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRosters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnRosters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnRosters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRosters.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRosters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(115)))));
            this.btnRosters.Location = new System.Drawing.Point(67, 596);
            this.btnRosters.Name = "btnRosters";
            this.btnRosters.Size = new System.Drawing.Size(302, 65);
            this.btnRosters.TabIndex = 5;
            this.btnRosters.Text = "Rosters";
            this.btnRosters.UseVisualStyleBackColor = false;
            this.btnRosters.MouseEnter += new System.EventHandler(this.btnButton_MouseEnter);
            this.btnRosters.MouseLeave += new System.EventHandler(this.btnButton_MouseLeave);
            // 
            // stStrip
            // 
            this.stStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblVersion,
            this.stlblUser,
            this.stlblSpacer,
            this.stlblCopyright});
            this.stStrip.Location = new System.Drawing.Point(0, 734);
            this.stStrip.Name = "stStrip";
            this.stStrip.Size = new System.Drawing.Size(769, 22);
            this.stStrip.TabIndex = 8;
            this.stStrip.Text = "statusStrip1";
            // 
            // stlblVersion
            // 
            this.stlblVersion.Name = "stlblVersion";
            this.stlblVersion.Size = new System.Drawing.Size(45, 17);
            this.stlblVersion.Text = "Version";
            // 
            // stlblUser
            // 
            this.stlblUser.Name = "stlblUser";
            this.stlblUser.Size = new System.Drawing.Size(102, 17);
            this.stlblUser.Text = "Current User: User";
            // 
            // stlblSpacer
            // 
            this.stlblSpacer.Name = "stlblSpacer";
            this.stlblSpacer.Size = new System.Drawing.Size(547, 17);
            this.stlblSpacer.Spring = true;
            // 
            // stlblCopyright
            // 
            this.stlblCopyright.Name = "stlblCopyright";
            this.stlblCopyright.Size = new System.Drawing.Size(60, 17);
            this.stlblCopyright.Text = "Copyright";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(769, 756);
            this.Controls.Add(this.stStrip);
            this.Controls.Add(this.btnDraft);
            this.Controls.Add(this.btnRosters);
            this.Controls.Add(this.btnCoaches);
            this.Controls.Add(this.btnGames);
            this.Controls.Add(this.btnSeason);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.panMain);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFL Franchise Tracker | Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panMain.ResumeLayout(false);
            this.panMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.stStrip.ResumeLayout(false);
            this.stStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Button btnSeason;
        private System.Windows.Forms.Button btnCoaches;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Button btnRosters;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.ToolStripStatusLabel stlblVersion;
        private System.Windows.Forms.ToolStripStatusLabel stlblUser;
        private System.Windows.Forms.ToolStripStatusLabel stlblSpacer;
        private System.Windows.Forms.ToolStripStatusLabel stlblCopyright;
        private System.Windows.Forms.TextBox txtMain;
    }
}

