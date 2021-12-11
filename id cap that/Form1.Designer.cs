namespace id_cap_that
{
    partial class shit
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
            this.input = new System.Windows.Forms.PictureBox();
            this.addpicture = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.addcaption = new System.Windows.Forms.Button();
            this.getpicture = new System.Windows.Forms.OpenFileDialog();
            this.caption = new System.Windows.Forms.TextBox();
            this.domain = new System.Windows.Forms.DomainUpDown();
            this.thecaption = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thecaption)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 108);
            this.input.MinimumSize = new System.Drawing.Size(460, 300);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(935, 477);
            this.input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.input.TabIndex = 0;
            this.input.TabStop = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            this.input.MouseMove += new System.Windows.Forms.MouseEventHandler(this.input_MouseMove);
            // 
            // addpicture
            // 
            this.addpicture.Location = new System.Drawing.Point(138, 69);
            this.addpicture.Name = "addpicture";
            this.addpicture.Size = new System.Drawing.Size(120, 33);
            this.addpicture.TabIndex = 1;
            this.addpicture.Text = "add a picture";
            this.addpicture.UseVisualStyleBackColor = true;
            this.addpicture.Click += new System.EventHandler(this.addpicture_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(264, 69);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 33);
            this.delete.TabIndex = 2;
            this.delete.Text = "discard";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // addcaption
            // 
            this.addcaption.Location = new System.Drawing.Point(12, 69);
            this.addcaption.Name = "addcaption";
            this.addcaption.Size = new System.Drawing.Size(120, 33);
            this.addcaption.TabIndex = 3;
            this.addcaption.Text = "add caption";
            this.addcaption.UseVisualStyleBackColor = true;
            this.addcaption.Click += new System.EventHandler(this.addcaption_Click);
            // 
            // getpicture
            // 
            this.getpicture.FileName = "picture1";
            this.getpicture.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // caption
            // 
            this.caption.Location = new System.Drawing.Point(12, 23);
            this.caption.Multiline = true;
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(832, 40);
            this.caption.TabIndex = 4;
            this.caption.Text = "write text here";
            this.caption.UseWaitCursor = true;
            this.caption.TextChanged += new System.EventHandler(this.caption_TextChanged);
            // 
            // domain
            // 
            this.domain.Location = new System.Drawing.Point(390, 69);
            this.domain.Name = "domain";
            this.domain.Size = new System.Drawing.Size(51, 22);
            this.domain.TabIndex = 5;
            this.domain.Text = "1";
            this.domain.SelectedItemChanged += new System.EventHandler(this.domain_SelectedItemChanged);
            this.domain.Scroll += new System.Windows.Forms.ScrollEventHandler(this.domain_Scroll);
            // 
            // thecaption
            // 
            this.thecaption.BackColor = System.Drawing.SystemColors.Control;
            this.thecaption.Location = new System.Drawing.Point(12, 120);
            this.thecaption.Name = "thecaption";
            this.thecaption.Size = new System.Drawing.Size(935, 465);
            this.thecaption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.thecaption.TabIndex = 6;
            this.thecaption.TabStop = false;
            this.thecaption.Click += new System.EventHandler(this.thecaption_Click);
            this.thecaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.thecaption_MouseDown);
            this.thecaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.thecaption_MouseMove);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(872, 74);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 7;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "color palette";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // shit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.thecaption);
            this.Controls.Add(this.domain);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.addcaption);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.addpicture);
            this.Controls.Add(this.input);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "shit";
            this.Text = "capturing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thecaption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox input;
        private System.Windows.Forms.Button addpicture;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addcaption;
        private System.Windows.Forms.OpenFileDialog getpicture;
        private System.Windows.Forms.TextBox caption;
        private System.Windows.Forms.DomainUpDown domain;
        private System.Windows.Forms.PictureBox thecaption;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button button1;
    }
}

