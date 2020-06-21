namespace Print3D
{
    partial class FormPrint3D
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint3D));
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelDekstop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGroot = new System.Windows.Forms.PictureBox();
            this.labelClock = new System.Windows.Forms.Label();
            this.iconButtonColor = new FontAwesome.Sharp.IconButton();
            this.iconButtonHelp = new FontAwesome.Sharp.IconButton();
            this.iconButtonNew = new FontAwesome.Sharp.IconButton();
            this.iconButtonRnd = new FontAwesome.Sharp.IconButton();
            this.iconButtonError = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxDom = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.iconButtonMin = new FontAwesome.Sharp.IconButton();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.labelTextH = new System.Windows.Forms.Label();
            this.iconPictureBoxH = new FontAwesome.Sharp.IconPictureBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelShadow = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelDekstop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroot)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDom)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxH)).BeginInit();
            this.SuspendLayout();
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть окно";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 26);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.iconButtonColor);
            this.panelMenu.Controls.Add(this.iconButtonHelp);
            this.panelMenu.Controls.Add(this.iconButtonNew);
            this.panelMenu.Controls.Add(this.iconButtonRnd);
            this.panelMenu.Controls.Add(this.iconButtonError);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 760);
            this.panelMenu.TabIndex = 8;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "3dPrint";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // panelDekstop
            // 
            this.panelDekstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(105)))));
            this.panelDekstop.Controls.Add(this.panelShadow);
            this.panelDekstop.Controls.Add(this.panel);
            this.panelDekstop.Controls.Add(this.pictureBox1);
            this.panelDekstop.Controls.Add(this.pictureBoxGroot);
            this.panelDekstop.Controls.Add(this.labelClock);
            this.panelDekstop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDekstop.Location = new System.Drawing.Point(221, 0);
            this.panelDekstop.Name = "panelDekstop";
            this.panelDekstop.Size = new System.Drawing.Size(1299, 760);
            this.panelDekstop.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(952, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxGroot
            // 
            this.pictureBoxGroot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxGroot.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGroot.Image")));
            this.pictureBoxGroot.Location = new System.Drawing.Point(-47, 502);
            this.pictureBoxGroot.Name = "pictureBoxGroot";
            this.pictureBoxGroot.Size = new System.Drawing.Size(384, 248);
            this.pictureBoxGroot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGroot.TabIndex = 3;
            this.pictureBoxGroot.TabStop = false;
            // 
            // labelClock
            // 
            this.labelClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClock.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelClock.Location = new System.Drawing.Point(1032, 103);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(218, 73);
            this.labelClock.TabIndex = 2;
            this.labelClock.Text = "Время";
            // 
            // iconButtonColor
            // 
            this.iconButtonColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonColor.FlatAppearance.BorderSize = 0;
            this.iconButtonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonColor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonColor.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonColor.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.iconButtonColor.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonColor.IconSize = 50;
            this.iconButtonColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonColor.Location = new System.Drawing.Point(0, 344);
            this.iconButtonColor.Name = "iconButtonColor";
            this.iconButtonColor.Rotation = 0D;
            this.iconButtonColor.Size = new System.Drawing.Size(221, 56);
            this.iconButtonColor.TabIndex = 13;
            this.iconButtonColor.Text = "Тёмная тема";
            this.iconButtonColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonColor.UseVisualStyleBackColor = true;
            this.iconButtonColor.Click += new System.EventHandler(this.iconButtonColor_Click);
            // 
            // iconButtonHelp
            // 
            this.iconButtonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHelp.FlatAppearance.BorderSize = 0;
            this.iconButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHelp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconButtonHelp.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonHelp.IconSize = 50;
            this.iconButtonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHelp.Location = new System.Drawing.Point(0, 288);
            this.iconButtonHelp.Name = "iconButtonHelp";
            this.iconButtonHelp.Rotation = 0D;
            this.iconButtonHelp.Size = new System.Drawing.Size(221, 56);
            this.iconButtonHelp.TabIndex = 12;
            this.iconButtonHelp.Text = "Помощь";
            this.iconButtonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHelp.UseVisualStyleBackColor = true;
            this.iconButtonHelp.Click += new System.EventHandler(this.iconButtonHelp_Click);
            // 
            // iconButtonNew
            // 
            this.iconButtonNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonNew.FlatAppearance.BorderSize = 0;
            this.iconButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNew.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonNew.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonNew.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonNew.IconSize = 50;
            this.iconButtonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNew.Location = new System.Drawing.Point(0, 232);
            this.iconButtonNew.Name = "iconButtonNew";
            this.iconButtonNew.Rotation = 0D;
            this.iconButtonNew.Size = new System.Drawing.Size(221, 56);
            this.iconButtonNew.TabIndex = 11;
            this.iconButtonNew.Text = "Распознавание";
            this.iconButtonNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNew.UseVisualStyleBackColor = true;
            this.iconButtonNew.Click += new System.EventHandler(this.iconButtonNew_Click);
            // 
            // iconButtonRnd
            // 
            this.iconButtonRnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonRnd.FlatAppearance.BorderSize = 0;
            this.iconButtonRnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRnd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonRnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonRnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonRnd.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.iconButtonRnd.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonRnd.IconSize = 50;
            this.iconButtonRnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRnd.Location = new System.Drawing.Point(0, 176);
            this.iconButtonRnd.Name = "iconButtonRnd";
            this.iconButtonRnd.Rotation = 0D;
            this.iconButtonRnd.Size = new System.Drawing.Size(221, 56);
            this.iconButtonRnd.TabIndex = 10;
            this.iconButtonRnd.Text = "Random";
            this.iconButtonRnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRnd.UseVisualStyleBackColor = true;
            this.iconButtonRnd.Click += new System.EventHandler(this.iconButtonRnd_Click);
            // 
            // iconButtonError
            // 
            this.iconButtonError.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonError.FlatAppearance.BorderSize = 0;
            this.iconButtonError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonError.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonError.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonError.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonError.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonError.IconSize = 50;
            this.iconButtonError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonError.Location = new System.Drawing.Point(0, 120);
            this.iconButtonError.Name = "iconButtonError";
            this.iconButtonError.Rotation = 0D;
            this.iconButtonError.Size = new System.Drawing.Size(221, 56);
            this.iconButtonError.TabIndex = 9;
            this.iconButtonError.Text = "Ошибки печати";
            this.iconButtonError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonError.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonError.UseVisualStyleBackColor = true;
            this.iconButtonError.Click += new System.EventHandler(this.iconButtonError_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelLogo.Controls.Add(this.pictureBoxDom);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(221, 120);
            this.panelLogo.TabIndex = 8;
            // 
            // pictureBoxDom
            // 
            this.pictureBoxDom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDom.Image")));
            this.pictureBoxDom.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxDom.Name = "pictureBoxDom";
            this.pictureBoxDom.Size = new System.Drawing.Size(100, 88);
            this.pictureBoxDom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDom.TabIndex = 1;
            this.pictureBoxDom.TabStop = false;
            this.pictureBoxDom.Click += new System.EventHandler(this.pictureBoxDom_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel.Controls.Add(this.iconButtonMin);
            this.panel.Controls.Add(this.iconButtonExit);
            this.panel.Controls.Add(this.labelTextH);
            this.panel.Controls.Add(this.iconPictureBoxH);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1299, 80);
            this.panel.TabIndex = 8;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // iconButtonMin
            // 
            this.iconButtonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMin.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMin.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMin.IconSize = 19;
            this.iconButtonMin.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButtonMin.Location = new System.Drawing.Point(1239, -6);
            this.iconButtonMin.Name = "iconButtonMin";
            this.iconButtonMin.Rotation = 0D;
            this.iconButtonMin.Size = new System.Drawing.Size(27, 26);
            this.iconButtonMin.TabIndex = 4;
            this.iconButtonMin.UseVisualStyleBackColor = false;
            this.iconButtonMin.Click += new System.EventHandler(this.iconButtonMin_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonExit.IconSize = 19;
            this.iconButtonExit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.iconButtonExit.Location = new System.Drawing.Point(1272, -2);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(27, 26);
            this.iconButtonExit.TabIndex = 2;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click);
            // 
            // labelTextH
            // 
            this.labelTextH.AutoSize = true;
            this.labelTextH.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextH.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTextH.Location = new System.Drawing.Point(68, 21);
            this.labelTextH.Name = "labelTextH";
            this.labelTextH.Size = new System.Drawing.Size(199, 32);
            this.labelTextH.TabIndex = 1;
            this.labelTextH.Text = "Главное меню";
            // 
            // iconPictureBoxH
            // 
            this.iconPictureBoxH.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBoxH.ForeColor = System.Drawing.Color.DarkOrchid;
            this.iconPictureBoxH.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBoxH.IconColor = System.Drawing.Color.DarkOrchid;
            this.iconPictureBoxH.Location = new System.Drawing.Point(27, 24);
            this.iconPictureBoxH.Name = "iconPictureBoxH";
            this.iconPictureBoxH.Size = new System.Drawing.Size(35, 32);
            this.iconPictureBoxH.TabIndex = 0;
            this.iconPictureBoxH.TabStop = false;
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(0, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1299, 8);
            this.panelShadow.TabIndex = 9;
            // 
            // FormPrint3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 760);
            this.Controls.Add(this.panelDekstop);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormPrint3D";
            this.Load += new System.EventHandler(this.FormPrint3D_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelDekstop.ResumeLayout(false);
            this.panelDekstop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroot)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDom)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel panelDekstop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxGroot;
        private System.Windows.Forms.Label labelClock;
        private FontAwesome.Sharp.IconButton iconButtonColor;
        private FontAwesome.Sharp.IconButton iconButtonHelp;
        private FontAwesome.Sharp.IconButton iconButtonNew;
        private FontAwesome.Sharp.IconButton iconButtonRnd;
        private FontAwesome.Sharp.IconButton iconButtonError;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxDom;
        private System.Windows.Forms.Panel panel;
        private FontAwesome.Sharp.IconButton iconButtonMin;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private System.Windows.Forms.Label labelTextH;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxH;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panelShadow;
    }
}

