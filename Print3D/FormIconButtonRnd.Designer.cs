namespace Print3D
{
    partial class FormIconButtonRnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIconButtonRnd));
            this.labelPer = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.pictureBoxDecor = new System.Windows.Forms.PictureBox();
            this.pictureBoxRnd = new System.Windows.Forms.PictureBox();
            this.pictureBoxRnd1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRnd1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPer
            // 
            this.labelPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPer.AutoSize = true;
            this.labelPer.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPer.Location = new System.Drawing.Point(541, 650);
            this.labelPer.Name = "labelPer";
            this.labelPer.Size = new System.Drawing.Size(0, 40);
            this.labelPer.TabIndex = 37;
            // 
            // labelError
            // 
            this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(16, 464);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(243, 42);
            this.labelError.TabIndex = 36;
            this.labelError.Text = "Вид ошибки -";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.BackColor = System.Drawing.Color.White;
            this.richTextBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxOutput.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(224, 316);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(645, 76);
            this.richTextBoxOutput.TabIndex = 35;
            this.richTextBoxOutput.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 42);
            this.label1.TabIndex = 34;
            this.label1.Text = "Проблема - ";
            // 
            // labelStart
            // 
            this.labelStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStart.Location = new System.Drawing.Point(265, 470);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(0, 36);
            this.labelStart.TabIndex = 33;
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMenu.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonMenu.ForeColor = System.Drawing.Color.Black;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButtonMenu.IconColor = System.Drawing.Color.Black;
            this.iconButtonMenu.IconSize = 100;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.Location = new System.Drawing.Point(929, 17);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Rotation = 0D;
            this.iconButtonMenu.Size = new System.Drawing.Size(458, 96);
            this.iconButtonMenu.TabIndex = 30;
            this.iconButtonMenu.Text = "Рандомные ошибки\r\n";
            this.iconButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMenu.UseVisualStyleBackColor = false;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            // 
            // pictureBoxDecor
            // 
            this.pictureBoxDecor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxDecor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDecor.Image")));
            this.pictureBoxDecor.Location = new System.Drawing.Point(886, 190);
            this.pictureBoxDecor.Name = "pictureBoxDecor";
            this.pictureBoxDecor.Size = new System.Drawing.Size(485, 292);
            this.pictureBoxDecor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDecor.TabIndex = 38;
            this.pictureBoxDecor.TabStop = false;
            // 
            // pictureBoxRnd
            // 
            this.pictureBoxRnd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRnd.Image")));
            this.pictureBoxRnd.Location = new System.Drawing.Point(7, 7);
            this.pictureBoxRnd.Name = "pictureBoxRnd";
            this.pictureBoxRnd.Size = new System.Drawing.Size(582, 120);
            this.pictureBoxRnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRnd.TabIndex = 31;
            this.pictureBoxRnd.TabStop = false;
            // 
            // pictureBoxRnd1
            // 
            this.pictureBoxRnd1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxRnd1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRnd1.Image")));
            this.pictureBoxRnd1.Location = new System.Drawing.Point(16, 604);
            this.pictureBoxRnd1.Name = "pictureBoxRnd1";
            this.pictureBoxRnd1.Size = new System.Drawing.Size(302, 125);
            this.pictureBoxRnd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRnd1.TabIndex = 32;
            this.pictureBoxRnd1.TabStop = false;
            // 
            // FormIconButtonRnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1395, 736);
            this.Controls.Add(this.iconButtonMenu);
            this.Controls.Add(this.labelPer);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.pictureBoxDecor);
            this.Controls.Add(this.pictureBoxRnd);
            this.Controls.Add(this.pictureBoxRnd1);
            this.Name = "FormIconButtonRnd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRnd1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPer;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStart;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private System.Windows.Forms.PictureBox pictureBoxDecor;
        private System.Windows.Forms.PictureBox pictureBoxRnd;
        private System.Windows.Forms.PictureBox pictureBoxRnd1;
    }
}