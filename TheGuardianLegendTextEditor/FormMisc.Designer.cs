namespace TheGuardianLegendTextEditor {
    partial class FormMisc {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMisc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMisc6 = new System.Windows.Forms.TextBox();
            this.textBoxMisc5 = new System.Windows.Forms.TextBox();
            this.textBoxMisc4 = new System.Windows.Forms.TextBox();
            this.textBoxMisc3 = new System.Windows.Forms.TextBox();
            this.textBoxMisc2 = new System.Windows.Forms.TextBox();
            this.textBoxMisc1 = new System.Windows.Forms.TextBox();
            this.buttonUpdateText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMisc6);
            this.groupBox1.Controls.Add(this.textBoxMisc5);
            this.groupBox1.Controls.Add(this.textBoxMisc4);
            this.groupBox1.Controls.Add(this.textBoxMisc3);
            this.groupBox1.Controls.Add(this.textBoxMisc2);
            this.groupBox1.Controls.Add(this.textBoxMisc1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxMisc6
            // 
            this.textBoxMisc6.Location = new System.Drawing.Point(6, 149);
            this.textBoxMisc6.Name = "textBoxMisc6";
            this.textBoxMisc6.Size = new System.Drawing.Size(200, 20);
            this.textBoxMisc6.TabIndex = 5;
            // 
            // textBoxMisc5
            // 
            this.textBoxMisc5.Location = new System.Drawing.Point(6, 123);
            this.textBoxMisc5.Name = "textBoxMisc5";
            this.textBoxMisc5.Size = new System.Drawing.Size(200, 20);
            this.textBoxMisc5.TabIndex = 4;
            // 
            // textBoxMisc4
            // 
            this.textBoxMisc4.Location = new System.Drawing.Point(6, 97);
            this.textBoxMisc4.Name = "textBoxMisc4";
            this.textBoxMisc4.Size = new System.Drawing.Size(200, 20);
            this.textBoxMisc4.TabIndex = 3;
            // 
            // textBoxMisc3
            // 
            this.textBoxMisc3.Location = new System.Drawing.Point(6, 71);
            this.textBoxMisc3.Name = "textBoxMisc3";
            this.textBoxMisc3.Size = new System.Drawing.Size(200, 20);
            this.textBoxMisc3.TabIndex = 2;
            // 
            // textBoxMisc2
            // 
            this.textBoxMisc2.Location = new System.Drawing.Point(6, 45);
            this.textBoxMisc2.Name = "textBoxMisc2";
            this.textBoxMisc2.Size = new System.Drawing.Size(200, 20);
            this.textBoxMisc2.TabIndex = 1;
            // 
            // textBoxMisc1
            // 
            this.textBoxMisc1.Location = new System.Drawing.Point(6, 19);
            this.textBoxMisc1.Name = "textBoxMisc1";
            this.textBoxMisc1.Size = new System.Drawing.Size(200, 20);
            this.textBoxMisc1.TabIndex = 0;
            // 
            // buttonUpdateText
            // 
            this.buttonUpdateText.Location = new System.Drawing.Point(143, 200);
            this.buttonUpdateText.Name = "buttonUpdateText";
            this.buttonUpdateText.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateText.TabIndex = 1;
            this.buttonUpdateText.Text = "&Update Text";
            this.buttonUpdateText.UseVisualStyleBackColor = true;
            this.buttonUpdateText.Click += new System.EventHandler(this.buttonUpdateText_Click);
            // 
            // FormMisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 229);
            this.Controls.Add(this.buttonUpdateText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMisc";
            this.Text = "Misc";
            this.Load += new System.EventHandler(this.FormMisc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxMisc6;
        private System.Windows.Forms.TextBox textBoxMisc5;
        private System.Windows.Forms.TextBox textBoxMisc4;
        private System.Windows.Forms.TextBox textBoxMisc3;
        private System.Windows.Forms.TextBox textBoxMisc2;
        private System.Windows.Forms.TextBox textBoxMisc1;
        private System.Windows.Forms.Button buttonUpdateText;
    }
}