namespace Print3D
{
    partial class FormDetection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetection));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cameraSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOrjinalOrProcessImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiOrSingleTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxKek = new System.Windows.Forms.PictureBox();
            this.pbOrjinalimage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrjinalimage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraSettingsToolStripMenuItem,
            this.imageProcessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1395, 29);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cameraSettingsToolStripMenuItem
            // 
            this.cameraSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.cameraSettingsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cameraSettingsToolStripMenuItem.Name = "cameraSettingsToolStripMenuItem";
            this.cameraSettingsToolStripMenuItem.Size = new System.Drawing.Size(81, 25);
            this.cameraSettingsToolStripMenuItem.Text = "Камера";
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.setToolStripMenuItem.Text = "Установить";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.startToolStripMenuItem.Text = "Начать";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.stopToolStripMenuItem.Text = "Остановить";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.clearToolStripMenuItem.Text = "Очистить";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // imageProcessToolStripMenuItem
            // 
            this.imageProcessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorTrackingToolStripMenuItem,
            this.showOrjinalOrProcessImageToolStripMenuItem,
            this.multiOrSingleTrackingToolStripMenuItem});
            this.imageProcessToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imageProcessToolStripMenuItem.Name = "imageProcessToolStripMenuItem";
            this.imageProcessToolStripMenuItem.Size = new System.Drawing.Size(220, 25);
            this.imageProcessToolStripMenuItem.Text = "Обработка изображения";
            // 
            // colorTrackingToolStripMenuItem
            // 
            this.colorTrackingToolStripMenuItem.Name = "colorTrackingToolStripMenuItem";
            this.colorTrackingToolStripMenuItem.Size = new System.Drawing.Size(512, 26);
            this.colorTrackingToolStripMenuItem.Text = "Отслеживание цвета";
            this.colorTrackingToolStripMenuItem.Click += new System.EventHandler(this.colorTrackingToolStripMenuItem_Click);
            // 
            // showOrjinalOrProcessImageToolStripMenuItem
            // 
            this.showOrjinalOrProcessImageToolStripMenuItem.Checked = true;
            this.showOrjinalOrProcessImageToolStripMenuItem.CheckOnClick = true;
            this.showOrjinalOrProcessImageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOrjinalOrProcessImageToolStripMenuItem.Name = "showOrjinalOrProcessImageToolStripMenuItem";
            this.showOrjinalOrProcessImageToolStripMenuItem.Size = new System.Drawing.Size(512, 26);
            this.showOrjinalOrProcessImageToolStripMenuItem.Text = "Показать оригинал или преобразование изображения";
            this.showOrjinalOrProcessImageToolStripMenuItem.Click += new System.EventHandler(this.showOrjinalOrProcessImageToolStripMenuItem_Click);
            // 
            // multiOrSingleTrackingToolStripMenuItem
            // 
            this.multiOrSingleTrackingToolStripMenuItem.Checked = true;
            this.multiOrSingleTrackingToolStripMenuItem.CheckOnClick = true;
            this.multiOrSingleTrackingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.multiOrSingleTrackingToolStripMenuItem.Name = "multiOrSingleTrackingToolStripMenuItem";
            this.multiOrSingleTrackingToolStripMenuItem.Size = new System.Drawing.Size(512, 26);
            this.multiOrSingleTrackingToolStripMenuItem.Text = "Множественное или единичное отслеживание";
            this.multiOrSingleTrackingToolStripMenuItem.Click += new System.EventHandler(this.multiOrSingleTrackingToolStripMenuItem_Click);
            // 
            // pictureBoxKek
            // 
            this.pictureBoxKek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxKek.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKek.Image")));
            this.pictureBoxKek.Location = new System.Drawing.Point(1152, 12);
            this.pictureBoxKek.Name = "pictureBoxKek";
            this.pictureBoxKek.Size = new System.Drawing.Size(231, 112);
            this.pictureBoxKek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKek.TabIndex = 10;
            this.pictureBoxKek.TabStop = false;
            // 
            // pbOrjinalimage
            // 
            this.pbOrjinalimage.BackColor = System.Drawing.Color.Gainsboro;
            this.pbOrjinalimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOrjinalimage.Location = new System.Drawing.Point(12, 68);
            this.pbOrjinalimage.Name = "pbOrjinalimage";
            this.pbOrjinalimage.Size = new System.Drawing.Size(638, 401);
            this.pbOrjinalimage.TabIndex = 9;
            this.pbOrjinalimage.TabStop = false;
            // 
            // FormDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 736);
            this.Controls.Add(this.pictureBoxKek);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbOrjinalimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDetection";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrjinalimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cameraSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOrjinalOrProcessImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiOrSingleTrackingToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxKek;
        private System.Windows.Forms.PictureBox pbOrjinalimage;
    }
}