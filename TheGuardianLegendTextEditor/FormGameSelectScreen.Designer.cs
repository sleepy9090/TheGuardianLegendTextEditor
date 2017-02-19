namespace TheGuardianLegendTextEditor {
    partial class FormGameSelectScreen {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameSelectScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxGameSelectScreen3 = new System.Windows.Forms.TextBox();
            this.textBoxGameSelectScreen2 = new System.Windows.Forms.TextBox();
            this.textBoxGameSelectScreen1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxGameSelectScreen3);
            this.groupBox1.Controls.Add(this.textBoxGameSelectScreen2);
            this.groupBox1.Controls.Add(this.textBoxGameSelectScreen1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxGameSelectScreen3
            // 
            this.textBoxGameSelectScreen3.Location = new System.Drawing.Point(6, 71);
            this.textBoxGameSelectScreen3.Name = "textBoxGameSelectScreen3";
            this.textBoxGameSelectScreen3.Size = new System.Drawing.Size(300, 20);
            this.textBoxGameSelectScreen3.TabIndex = 3;
            // 
            // textBoxGameSelectScreen2
            // 
            this.textBoxGameSelectScreen2.Location = new System.Drawing.Point(6, 45);
            this.textBoxGameSelectScreen2.Name = "textBoxGameSelectScreen2";
            this.textBoxGameSelectScreen2.Size = new System.Drawing.Size(300, 20);
            this.textBoxGameSelectScreen2.TabIndex = 2;
            // 
            // textBoxGameSelectScreen1
            // 
            this.textBoxGameSelectScreen1.Location = new System.Drawing.Point(6, 19);
            this.textBoxGameSelectScreen1.Name = "textBoxGameSelectScreen1";
            this.textBoxGameSelectScreen1.Size = new System.Drawing.Size(300, 20);
            this.textBoxGameSelectScreen1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(243, 352);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // FormGameSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 382);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGameSelectScreen";
            this.Text = "Game Select Screen";
            this.Load += new System.EventHandler(this.FormGameSelectScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxGameSelectScreen3;
        private System.Windows.Forms.TextBox textBoxGameSelectScreen2;
        private System.Windows.Forms.TextBox textBoxGameSelectScreen1;
        private System.Windows.Forms.Button buttonUpdateText;
    }
}