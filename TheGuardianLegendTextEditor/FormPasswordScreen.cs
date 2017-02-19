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
    public partial class FormPasswordScreen : Form {

        string path = "";

        public FormPasswordScreen() {
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

                backend.getText(absoluteFilename, textBoxPasswordScreen1, 0x6, 0xC736, 0);
                backend.getText(absoluteFilename, textBoxPasswordScreen2, 0xA, 0xC742, 0);
                backend.getText(absoluteFilename, textBoxPasswordScreen3, 0xA, 0xC788, 0);
                backend.getText(absoluteFilename, textBoxPasswordScreen4, 0x9, 0xC7E0, 0);
                backend.getText(absoluteFilename, textBoxPasswordScreen5, 0xD, 0xC811, 0);
                backend.getText(absoluteFilename, textBoxPasswordScreen6, 0xB, 0xCB6F, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x6, textBoxPasswordScreen1, 0xC736, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxPasswordScreen2, 0xC742, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxPasswordScreen3, 0xC788, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxPasswordScreen4, 0xC7E0, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxPasswordScreen5, 0xC811, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxPasswordScreen6, 0xCB6F, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxPasswordScreen1.MaxLength = 0x6;
            textBoxPasswordScreen1.MaxLength = 0xA;
            textBoxPasswordScreen1.MaxLength = 0xA;
            textBoxPasswordScreen1.MaxLength = 0x9;
            textBoxPasswordScreen1.MaxLength = 0xD;
            textBoxPasswordScreen1.MaxLength = 0xB;
        }

        private void FormPasswordScreen_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
