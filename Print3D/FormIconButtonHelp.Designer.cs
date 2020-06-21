namespace Print3D
{
    partial class FormIconButtonHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIconButtonHelp));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBoxDom = new System.Windows.Forms.PictureBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.White;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox.Location = new System.Drawing.Point(116, 73);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox.Size = new System.Drawing.Size(867, 68);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "\n- по нажатию на эту иконку происходит переход в  главное меню.\n";
            // 
            // pictureBoxDom
            // 
            this.pictureBoxDom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDom.Image")));
            this.pictureBoxDom.Location = new System.Drawing.Point(12, 59);
            this.pictureBoxDom.Name = "pictureBoxDom";
            this.pictureBoxDom.Size = new System.Drawing.Size(100, 88);
            this.pictureBoxDom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDom.TabIndex = 12;
            this.pictureBoxDom.TabStop = false;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxText.BackColor = System.Drawing.Color.White;
            this.richTextBoxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxText.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxText.Location = new System.Drawing.Point(11, 166);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.ReadOnly = true;
            this.richTextBoxText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxText.Size = new System.Drawing.Size(1018, 517);
            this.richTextBoxText.TabIndex = 10;
            this.richTextBoxText.Text = resources.GetString("richTextBoxText.Text");
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelp.Image")));
            this.pictureBoxHelp.Location = new System.Drawing.Point(1046, 52);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(215, 500);
            this.pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHelp.TabIndex = 11;
            this.pictureBoxHelp.TabStop = false;
            // 
            // FormIconButtonHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 734);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.pictureBoxDom);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.pictureBoxHelp);
            this.Name = "FormIconButtonHelp";
            this.Text = "FormIconButtonHelp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox pictureBoxDom;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
    }
}