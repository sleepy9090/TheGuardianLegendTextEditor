namespace TheGuardianLegendTextEditor {
    partial class FormHUD {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHUD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxHUD6 = new System.Windows.Forms.TextBox();
            this.textBoxHUD4 = new System.Windows.Forms.TextBox();
            this.textBoxHUD5 = new System.Windows.Forms.TextBox();
            this.textBoxHUD3 = new System.Windows.Forms.TextBox();
            this.textBoxHUD2 = new System.Windows.Forms.TextBox();
            this.textBoxHUD1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBoxHUD6);
            this.groupBox1.Controls.Add(this.textBoxHUD4);
            this.groupBox1.Controls.Add(this.textBoxHUD5);
            this.groupBox1.Controls.Add(this.textBoxHUD3);
            this.groupBox1.Controls.Add(this.textBoxHUD2);
            this.groupBox1.Controls.Add(this.textBoxHUD1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 225);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxHUD6
            // 
            this.textBoxHUD6.Location = new System.Drawing.Point(6, 149);
            this.textBoxHUD6.Name = "textBoxHUD6";
            this.textBoxHUD6.Size = new System.Drawing.Size(100, 20);
            this.textBoxHUD6.TabIndex = 6;
            // 
            // textBoxHUD4
            // 
            this.textBoxHUD4.Location = new System.Drawing.Point(6, 97);
            this.textBoxHUD4.Name = "textBoxHUD4";
            this.textBoxHUD4.Size = new System.Drawing.Size(100, 20);
            this.textBoxHUD4.TabIndex = 5;
            // 
            // textBoxHUD5
            // 
            this.textBoxHUD5.Location = new System.Drawing.Point(6, 123);
            this.textBoxHUD5.Name = "textBoxHUD5";
            this.textBoxHUD5.Size = new System.Drawing.Size(100, 20);
            this.textBoxHUD5.TabIndex = 4;
            // 
            // textBoxHUD3
            // 
            this.textBoxHUD3.Location = new System.Drawing.Point(6, 71);
            this.textBoxHUD3.Name = "textBoxHUD3";
            this.textBoxHUD3.Size = new System.Drawing.Size(100, 20);
            this.textBoxHUD3.TabIndex = 2;
            // 
            // textBoxHUD2
            // 
            this.textBoxHUD2.Location = new System.Drawing.Point(6, 45);
            this.textBoxHUD2.Name = "textBoxHUD2";
            this.textBoxHUD2.Size = new System.Drawing.Size(100, 20);
            this.textBoxHUD2.TabIndex = 1;
            // 
            // textBoxHUD1
            // 
            this.textBoxHUD1.Location = new System.Drawing.Point(6, 19);
            this.textBoxHUD1.Name = "textBoxHUD1";
            this.textBoxHUD1.Size = new System.Drawing.Size(100, 20);
            this.textBoxHUD1.TabIndex = 0;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(305, 274);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // FormHUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 303);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHUD";
            this.Text = "H.U.D.";
            this.Load += new System.EventHandler(this.FormHUD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxHUD6;
        private System.Windows.Forms.TextBox textBoxHUD4;
        private System.Windows.Forms.TextBox textBoxHUD5;
        private System.Windows.Forms.TextBox textBoxHUD3;
        private System.Windows.Forms.TextBox textBoxHUD2;
        private System.Windows.Forms.TextBox textBoxHUD1;
        private System.Windows.Forms.Button buttonUpdateText;
    }
}