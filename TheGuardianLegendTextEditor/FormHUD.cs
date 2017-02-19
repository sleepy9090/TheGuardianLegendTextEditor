using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford 2016
 */
namespace TheGuardianLegendTextEditor {
    public partial class FormHUD : Form {

        string path = "";

        public FormHUD() {
            InitializeComponent();
        }

        public string sendPathToOtherForm {
            get {
                return path;
            }
            set {
                path = value;
            }
        }

        private void readRomText() {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.getText(absoluteFilename, textBoxHUD1, 0x2, 0x1A4, 0);
                backend.getText(absoluteFilename, textBoxHUD2, 0x4, 0x1AC, 0);
                backend.getText(absoluteFilename, textBoxHUD3, 0x4, 0x1B9, 0);
                backend.getText(absoluteFilename, textBoxHUD4, 0x4, 0x1E175, 0);
                backend.getText(absoluteFilename, textBoxHUD5, 0x1, 0x1E19B, 0);
                backend.getText(absoluteFilename, textBoxHUD6, 0x1, 0x1E1AC, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x2, textBoxHUD1, 0x1A4, 0);
                backend.updateROMText(absoluteFilename, 0x4, textBoxHUD2, 0x1AC, 0);
                backend.updateROMText(absoluteFilename, 0x4, textBoxHUD3, 0x1B9, 0);
                backend.updateROMText(absoluteFilename, 0x4, textBoxHUD4, 0x1E175, 0);
                backend.updateROMText(absoluteFilename, 0x1, textBoxHUD5, 0x1E19B, 0);
                backend.updateROMText(absoluteFilename, 0x1, textBoxHUD6, 0x1E1AC, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxHUD1.MaxLength = 0x2;
            textBoxHUD2.MaxLength = 0x4;
            textBoxHUD3.MaxLength = 0x4;
            textBoxHUD4.MaxLength = 0x4;
            textBoxHUD5.MaxLength = 0x1;
            textBoxHUD6.MaxLength = 0x1;
        }

        private void FormHUD_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
