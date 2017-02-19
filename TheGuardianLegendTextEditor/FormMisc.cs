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
    public partial class FormMisc : Form {

        string path = "";

        public FormMisc() {
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

                backend.getText(absoluteFilename, textBoxMisc1, 0xC, 0xC0D4, 0);
                backend.getText(absoluteFilename, textBoxMisc2, 0x14, 0xC16E, 0);
                backend.getText(absoluteFilename, textBoxMisc3, 0xA, 0xC243, 0);
                backend.getText(absoluteFilename, textBoxMisc4, 0xB, 0x1F5DE, 0);
                backend.getText(absoluteFilename, textBoxMisc5, 0x9, 0x24A, 0);
                backend.getText(absoluteFilename, textBoxMisc6, 0xC, 0xBB5, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0xC, textBoxMisc1, 0xC0D4, 0);
                backend.updateROMText(absoluteFilename, 0x14, textBoxMisc2, 0xC16E, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxMisc3, 0xC243, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxMisc4, 0x1F5DE, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxMisc5, 0x24A, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxMisc6, 0xBB5, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxMisc1.MaxLength = 0xC;
            textBoxMisc2.MaxLength = 0x14;
            textBoxMisc3.MaxLength = 0xA;
            textBoxMisc4.MaxLength = 0xB;
            textBoxMisc5.MaxLength = 0x9;
            textBoxMisc6.MaxLength = 0xC;
        }

        private void FormMisc_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
