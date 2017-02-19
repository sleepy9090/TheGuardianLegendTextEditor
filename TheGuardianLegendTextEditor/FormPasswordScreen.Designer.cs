namespace TheGuardianLegendTextEditor {
    partial class FormPasswordScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPasswordScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPasswordScreen6 = new System.Windows.Forms.TextBox();
            this.textBoxPasswordScreen5 = new System.Windows.Forms.TextBox();
            this.textBoxPasswordScreen4 = new System.Windows.Forms.TextBox();
            this.textBoxPasswordScreen3 = new System.Windows.Forms.TextBox();
            this.textBoxPasswordScreen2 = new System.Windows.Forms.TextBox();
            this.textBoxPasswordScreen1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBoxPasswordScreen6);
            this.groupBox1.Controls.Add(this.textBoxPasswordScreen5);
            this.groupBox1.Controls.Add(this.textBoxPasswordScreen4);
            this.groupBox1.Controls.Add(this.textBoxPasswordScreen3);
            this.groupBox1.Controls.Add(this.textBoxPasswordScreen2);
            this.groupBox1.Controls.Add(this.textBoxPasswordScreen1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 225);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPasswordScreen6
            // 
            this.textBoxPasswordScreen6.Location = new System.Drawing.Point(6, 149);
            this.textBoxPasswordScreen6.Name = "textBoxPasswordScreen6";
            this.textBoxPasswordScreen6.Size = new System.Drawing.Size(150, 20);
            this.textBoxPasswordScreen6.TabIndex = 5;
            // 
            // textBoxPasswordScreen5
            // 
            this.textBoxPasswordScreen5.Location = new System.Drawing.Point(6, 123);
            this.textBoxPasswordScreen5.Name = "textBoxPasswordScreen5";
            this.textBoxPasswordScreen5.Size = new System.Drawing.Size(150, 20);
            this.textBoxPasswordScreen5.TabIndex = 4;
            // 
            // textBoxPasswordScreen4
            // 
            this.textBoxPasswordScreen4.Location = new System.Drawing.Point(6, 97);
            this.textBoxPasswordScreen4.Name = "textBoxPasswordScreen4";
            this.textBoxPasswordScreen4.Size = new System.Drawing.Size(150, 20);
            this.textBoxPasswordScreen4.TabIndex = 3;
            // 
            // textBoxPasswordScreen3
            // 
            this.textBoxPasswordScreen3.Location = new System.Drawing.Point(6, 71);
            this.textBoxPasswordScreen3.Name = "textBoxPasswordScreen3";
            this.textBoxPasswordScreen3.Size = new System.Drawing.Size(150, 20);
            this.textBoxPasswordScreen3.TabIndex = 2;
            // 
            // textBoxPasswordScreen2
            // 
            this.textBoxPasswordScreen2.Location = new System.Drawing.Point(6, 45);
            this.textBoxPasswordScreen2.Name = "textBoxPasswordScreen2";
            this.textBoxPasswordScreen2.Size = new System.Drawing.Size(150, 20);
            this.textBoxPasswordScreen2.TabIndex = 1;
            // 
            // textBoxPasswordScreen1
            // 
            this.textBoxPasswordScreen1.Location = new System.Drawing.Point(6, 19);
            this.textBoxPasswordScreen1.Name = "textBoxPasswordScreen1";
            this.textBoxPasswordScreen1.Size = new System.Drawing.Size(150, 20);
            this.textBoxPasswordScreen1.TabIndex = 0;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(355, 278);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // FormPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 307);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPasswordScreen";
            this.Text = "Password Screen";
            this.Load += new System.EventHandler(this.FormPasswordScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxPasswordScreen6;
        private System.Windows.Forms.TextBox textBoxPasswordScreen5;
        private System.Windows.Forms.TextBox textBoxPasswordScreen4;
        private System.Windows.Forms.TextBox textBoxPasswordScreen3;
        private System.Windows.Forms.TextBox textBoxPasswordScreen2;
        private System.Windows.Forms.TextBox textBoxPasswordScreen1;
        private System.Windows.Forms.Button buttonUpdateText;
    }
}