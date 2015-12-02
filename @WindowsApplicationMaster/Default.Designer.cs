namespace _WindowsApplicationMaster
{
    partial class Default
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.tbDefault = new System.Windows.Forms.TableLayoutPanel();
            this.pnDefault = new System.Windows.Forms.Panel();
            this.tbHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbDefault = new System.Windows.Forms.PictureBox();
            this.tbMenu = new System.Windows.Forms.TableLayoutPanel();
            this.mnHome = new System.Windows.Forms.Button();
            this.mnAboutUs = new System.Windows.Forms.Button();
            this.tbFooter = new System.Windows.Forms.TableLayoutPanel();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.pnHR = new System.Windows.Forms.Panel();
            this.tbMenuTop = new System.Windows.Forms.TableLayoutPanel();
            this.btClose = new System.Windows.Forms.Button();
            this.btMove = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btMaximize = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbDefault.SuspendLayout();
            this.tbHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).BeginInit();
            this.tbMenu.SuspendLayout();
            this.tbFooter.SuspendLayout();
            this.tbMenuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDefault
            // 
            this.tbDefault.BackColor = System.Drawing.Color.White;
            this.tbDefault.ColumnCount = 1;
            this.tbDefault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbDefault.Controls.Add(this.pnDefault, 0, 3);
            this.tbDefault.Controls.Add(this.tbHeader, 0, 1);
            this.tbDefault.Controls.Add(this.tbMenu, 0, 2);
            this.tbDefault.Controls.Add(this.tbFooter, 0, 5);
            this.tbDefault.Controls.Add(this.pnHR, 0, 4);
            this.tbDefault.Controls.Add(this.tbMenuTop, 0, 0);
            this.tbDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDefault.Location = new System.Drawing.Point(1, 1);
            this.tbDefault.Margin = new System.Windows.Forms.Padding(0);
            this.tbDefault.Name = "tbDefault";
            this.tbDefault.RowCount = 6;
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbDefault.Size = new System.Drawing.Size(722, 417);
            this.tbDefault.TabIndex = 4;
            // 
            // pnDefault
            // 
            this.pnDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDefault.Location = new System.Drawing.Point(3, 116);
            this.pnDefault.Name = "pnDefault";
            this.pnDefault.Size = new System.Drawing.Size(716, 278);
            this.pnDefault.TabIndex = 0;
            // 
            // tbHeader
            // 
            this.tbHeader.AutoSize = true;
            this.tbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.tbHeader.ColumnCount = 2;
            this.tbHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbHeader.Controls.Add(this.lblHeader, 1, 0);
            this.tbHeader.Controls.Add(this.pbDefault, 0, 0);
            this.tbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHeader.Location = new System.Drawing.Point(0, 20);
            this.tbHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tbHeader.Name = "tbHeader";
            this.tbHeader.RowCount = 1;
            this.tbHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbHeader.Size = new System.Drawing.Size(722, 70);
            this.tbHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(77, 17);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(254, 36);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "ApplicationMaster";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbDefault
            // 
            this.pbDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDefault.BackColor = System.Drawing.Color.Transparent;
            this.pbDefault.Image = global::_WindowsApplicationMaster.Properties.Resources.icDefault;
            this.pbDefault.Location = new System.Drawing.Point(5, 3);
            this.pbDefault.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pbDefault.Name = "pbDefault";
            this.pbDefault.Size = new System.Drawing.Size(64, 64);
            this.pbDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDefault.TabIndex = 1;
            this.pbDefault.TabStop = false;
            // 
            // tbMenu
            // 
            this.tbMenu.AutoSize = true;
            this.tbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(232)))));
            this.tbMenu.ColumnCount = 3;
            this.tbMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbMenu.Controls.Add(this.mnHome, 1, 0);
            this.tbMenu.Controls.Add(this.mnAboutUs, 2, 0);
            this.tbMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMenu.Location = new System.Drawing.Point(0, 90);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.RowCount = 1;
            this.tbMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbMenu.Size = new System.Drawing.Size(722, 23);
            this.tbMenu.TabIndex = 2;
            // 
            // mnHome
            // 
            this.mnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(238)))));
            this.mnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnHome.FlatAppearance.BorderSize = 0;
            this.mnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(238)))));
            this.mnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.mnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnHome.ForeColor = System.Drawing.Color.Black;
            this.mnHome.Location = new System.Drawing.Point(20, 0);
            this.mnHome.Margin = new System.Windows.Forms.Padding(0);
            this.mnHome.Name = "mnHome";
            this.mnHome.Size = new System.Drawing.Size(75, 23);
            this.mnHome.TabIndex = 0;
            this.mnHome.Text = "Home";
            this.mnHome.UseVisualStyleBackColor = false;
            this.mnHome.Click += new System.EventHandler(this.mnHome_Click);
            // 
            // mnAboutUs
            // 
            this.mnAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(238)))));
            this.mnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mnAboutUs.FlatAppearance.BorderSize = 0;
            this.mnAboutUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(238)))));
            this.mnAboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.mnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnAboutUs.ForeColor = System.Drawing.Color.Black;
            this.mnAboutUs.Location = new System.Drawing.Point(95, 0);
            this.mnAboutUs.Margin = new System.Windows.Forms.Padding(0);
            this.mnAboutUs.Name = "mnAboutUs";
            this.mnAboutUs.Size = new System.Drawing.Size(75, 23);
            this.mnAboutUs.TabIndex = 0;
            this.mnAboutUs.Text = "AboutUs";
            this.mnAboutUs.UseVisualStyleBackColor = false;
            this.mnAboutUs.Click += new System.EventHandler(this.mnAboutUs_Click);
            // 
            // tbFooter
            // 
            this.tbFooter.AutoSize = true;
            this.tbFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbFooter.ColumnCount = 2;
            this.tbFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbFooter.Controls.Add(this.lblCredit, 0, 0);
            this.tbFooter.Controls.Add(this.lblFooter, 1, 0);
            this.tbFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFooter.Location = new System.Drawing.Point(0, 398);
            this.tbFooter.Margin = new System.Windows.Forms.Padding(0);
            this.tbFooter.Name = "tbFooter";
            this.tbFooter.Padding = new System.Windows.Forms.Padding(3);
            this.tbFooter.RowCount = 1;
            this.tbFooter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbFooter.Size = new System.Drawing.Size(722, 19);
            this.tbFooter.TabIndex = 3;
            // 
            // lblCredit
            // 
            this.lblCredit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(6, 3);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(44, 13);
            this.lblCredit.TabIndex = 0;
            this.lblCredit.Text = "lblCredit";
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(669, 3);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(47, 13);
            this.lblFooter.TabIndex = 1;
            this.lblFooter.Text = "lblFooter";
            // 
            // pnHR
            // 
            this.pnHR.BackColor = System.Drawing.Color.Silver;
            this.pnHR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHR.Location = new System.Drawing.Point(0, 397);
            this.pnHR.Margin = new System.Windows.Forms.Padding(0);
            this.pnHR.Name = "pnHR";
            this.pnHR.Size = new System.Drawing.Size(722, 1);
            this.pnHR.TabIndex = 4;
            // 
            // tbMenuTop
            // 
            this.tbMenuTop.AutoSize = true;
            this.tbMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.tbMenuTop.ColumnCount = 5;
            this.tbMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbMenuTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbMenuTop.Controls.Add(this.btClose, 4, 0);
            this.tbMenuTop.Controls.Add(this.btMove, 0, 0);
            this.tbMenuTop.Controls.Add(this.btMinimize, 2, 0);
            this.tbMenuTop.Controls.Add(this.btMaximize, 3, 0);
            this.tbMenuTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMenuTop.Location = new System.Drawing.Point(0, 0);
            this.tbMenuTop.Margin = new System.Windows.Forms.Padding(0);
            this.tbMenuTop.Name = "tbMenuTop";
            this.tbMenuTop.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbMenuTop.RowCount = 1;
            this.tbMenuTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbMenuTop.Size = new System.Drawing.Size(722, 20);
            this.tbMenuTop.TabIndex = 5;
            this.tbMenuTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbMenuTop_MouseDown);
            this.tbMenuTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbMenuTop_MouseMove);
            this.tbMenuTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbMenuTop_MouseUp);
            // 
            // btClose
            // 
            this.btClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(702, 2);
            this.btClose.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(16, 16);
            this.btClose.TabIndex = 1;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMove
            // 
            this.btMove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMove.BackColor = System.Drawing.Color.Transparent;
            this.btMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMove.FlatAppearance.BorderSize = 0;
            this.btMove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMove.Image = ((System.Drawing.Image)(resources.GetObject("btMove.Image")));
            this.btMove.Location = new System.Drawing.Point(2, 2);
            this.btMove.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btMove.Name = "btMove";
            this.btMove.Size = new System.Drawing.Size(16, 16);
            this.btMove.TabIndex = 3;
            this.btMove.UseVisualStyleBackColor = false;
            this.btMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btMove_MouseDown);
            this.btMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btMove_MouseMove);
            this.btMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btMove_MouseUp);
            // 
            // btMinimize
            // 
            this.btMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btMinimize.Image")));
            this.btMinimize.Location = new System.Drawing.Point(666, 2);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(16, 16);
            this.btMinimize.TabIndex = 2;
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btMaximize
            // 
            this.btMaximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaximize.FlatAppearance.BorderSize = 0;
            this.btMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximize.Image = global::_WindowsApplicationMaster.Properties.Resources.icMaximizeFlat;
            this.btMaximize.Location = new System.Drawing.Point(684, 2);
            this.btMaximize.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.btMaximize.Name = "btMaximize";
            this.btMaximize.Size = new System.Drawing.Size(16, 16);
            this.btMaximize.TabIndex = 2;
            this.btMaximize.UseVisualStyleBackColor = false;
            this.btMaximize.Click += new System.EventHandler(this.btMaximize_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(724, 419);
            this.Controls.Add(this.tbDefault);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Default";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FlatTheme";
            this.Load += new System.EventHandler(this.Default_Load);
            this.tbDefault.ResumeLayout(false);
            this.tbDefault.PerformLayout();
            this.tbHeader.ResumeLayout(false);
            this.tbHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).EndInit();
            this.tbMenu.ResumeLayout(false);
            this.tbFooter.ResumeLayout(false);
            this.tbFooter.PerformLayout();
            this.tbMenuTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbDefault;
        private System.Windows.Forms.Panel pnDefault;
        private System.Windows.Forms.TableLayoutPanel tbHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tbMenu;
        private System.Windows.Forms.Button mnHome;
        private System.Windows.Forms.Button mnAboutUs;
        private System.Windows.Forms.TableLayoutPanel tbFooter;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnHR;
        private System.Windows.Forms.TableLayoutPanel tbMenuTop;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Button btMove;
        private System.Windows.Forms.Button btMaximize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbDefault;
    }
}