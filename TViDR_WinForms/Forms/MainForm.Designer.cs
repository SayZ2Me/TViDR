namespace TViDR_WinForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Header = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ButtonLabWork3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ButtonLabWork2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ButtonLabWork1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button_Minimize1 = new TViDR_WinForms.UserControls.Button_Minimize();
            this.button_Close1 = new TViDR_WinForms.UserControls.Button_Close();
            this.button_Maximize1 = new TViDR_WinForms.UserControls.Button_Maximize();
            this.Header.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(12)))), ((int)(((byte)(30)))));
            this.Header.Controls.Add(this.panel4);
            this.Header.Controls.Add(this.button_Minimize1);
            this.Header.Controls.Add(this.button_Close1);
            this.Header.Controls.Add(this.button_Maximize1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(3, 3);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1258, 42);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::TViDR_WinForms.Properties.Resources.App_Logo;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(42, 42);
            this.panel4.TabIndex = 3;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SidePanel.Controls.Add(this.panel7);
            this.SidePanel.Controls.Add(this.panel6);
            this.SidePanel.Controls.Add(this.panel5);
            this.SidePanel.Controls.Add(this.panel3);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(3, 45);
            this.SidePanel.MinimumSize = new System.Drawing.Size(250, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 633);
            this.SidePanel.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ButtonLabWork3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 150);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel7.Size = new System.Drawing.Size(250, 75);
            this.panel7.TabIndex = 3;
            // 
            // ButtonLabWork3
            // 
            this.ButtonLabWork3.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLabWork3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLabWork3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLabWork3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(12)))), ((int)(((byte)(30)))));
            this.ButtonLabWork3.FlatAppearance.BorderSize = 2;
            this.ButtonLabWork3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLabWork3.Font = new System.Drawing.Font("Geometria", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonLabWork3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.ButtonLabWork3.Location = new System.Drawing.Point(5, 5);
            this.ButtonLabWork3.Name = "ButtonLabWork3";
            this.ButtonLabWork3.Size = new System.Drawing.Size(240, 70);
            this.ButtonLabWork3.TabIndex = 1;
            this.ButtonLabWork3.Text = "Laboratory work\r\nData compression\r\n";
            this.ButtonLabWork3.UseVisualStyleBackColor = false;
            this.ButtonLabWork3.Click += new System.EventHandler(this.ButtonLabWork3_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.ButtonLabWork2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 75);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel6.Size = new System.Drawing.Size(250, 75);
            this.panel6.TabIndex = 2;
            // 
            // ButtonLabWork2
            // 
            this.ButtonLabWork2.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLabWork2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLabWork2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLabWork2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(12)))), ((int)(((byte)(30)))));
            this.ButtonLabWork2.FlatAppearance.BorderSize = 2;
            this.ButtonLabWork2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLabWork2.Font = new System.Drawing.Font("Geometria", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonLabWork2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.ButtonLabWork2.Location = new System.Drawing.Point(5, 5);
            this.ButtonLabWork2.Name = "ButtonLabWork2";
            this.ButtonLabWork2.Size = new System.Drawing.Size(240, 70);
            this.ButtonLabWork2.TabIndex = 1;
            this.ButtonLabWork2.Text = "Laboratory work\r\nPlane traversal";
            this.ButtonLabWork2.UseVisualStyleBackColor = false;
            this.ButtonLabWork2.Click += new System.EventHandler(this.ButtonLabWork2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ButtonLabWork1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panel5.Size = new System.Drawing.Size(250, 75);
            this.panel5.TabIndex = 1;
            // 
            // ButtonLabWork1
            // 
            this.ButtonLabWork1.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLabWork1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLabWork1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLabWork1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(12)))), ((int)(((byte)(30)))));
            this.ButtonLabWork1.FlatAppearance.BorderSize = 2;
            this.ButtonLabWork1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLabWork1.Font = new System.Drawing.Font("Geometria", 14F, System.Drawing.FontStyle.Bold);
            this.ButtonLabWork1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(42)))), ((int)(((byte)(88)))));
            this.ButtonLabWork1.Location = new System.Drawing.Point(5, 5);
            this.ButtonLabWork1.Name = "ButtonLabWork1";
            this.ButtonLabWork1.Size = new System.Drawing.Size(240, 70);
            this.ButtonLabWork1.TabIndex = 1;
            this.ButtonLabWork1.Text = "Laboratory work\r\nColor rendering";
            this.ButtonLabWork1.UseVisualStyleBackColor = false;
            this.ButtonLabWork1.Click += new System.EventHandler(this.ButtonLabWork1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::TViDR_WinForms.Properties.Resources.STANKIN_Logo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 150);
            this.panel3.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.Color.Black;
            this.MainPanel.Location = new System.Drawing.Point(253, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1008, 633);
            this.MainPanel.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(253, 45);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 633);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // button_Minimize1
            // 
            this.button_Minimize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize1.BackColor = System.Drawing.Color.Transparent;
            this.button_Minimize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Minimize1.BackgroundImage")));
            this.button_Minimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Minimize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Minimize1.Location = new System.Drawing.Point(1166, 9);
            this.button_Minimize1.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.button_Minimize1.Name = "button_Minimize1";
            this.button_Minimize1.Size = new System.Drawing.Size(21, 21);
            this.button_Minimize1.TabIndex = 2;
            // 
            // button_Close1
            // 
            this.button_Close1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close1.BackColor = System.Drawing.Color.Transparent;
            this.button_Close1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Close1.BackgroundImage")));
            this.button_Close1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Close1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close1.Location = new System.Drawing.Point(1228, 9);
            this.button_Close1.Margin = new System.Windows.Forms.Padding(5, 9, 9, 5);
            this.button_Close1.Name = "button_Close1";
            this.button_Close1.Size = new System.Drawing.Size(21, 21);
            this.button_Close1.TabIndex = 0;
            // 
            // button_Maximize1
            // 
            this.button_Maximize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Maximize1.BackColor = System.Drawing.Color.Transparent;
            this.button_Maximize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Maximize1.BackgroundImage")));
            this.button_Maximize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Maximize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Maximize1.Location = new System.Drawing.Point(1197, 9);
            this.button_Maximize1.Margin = new System.Windows.Forms.Padding(5, 9, 5, 5);
            this.button_Maximize1.Name = "button_Maximize1";
            this.button_Maximize1.Size = new System.Drawing.Size(21, 21);
            this.button_Maximize1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(12)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Geometria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Header.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel MainPanel;
        private UserControls.Button_Minimize button_Minimize1;
        private UserControls.Button_Maximize button_Maximize1;
        private UserControls.Button_Close button_Close1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ButtonLabWork1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button ButtonLabWork3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button ButtonLabWork2;
    }
}