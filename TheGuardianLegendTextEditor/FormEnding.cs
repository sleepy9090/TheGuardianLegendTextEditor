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
    public partial class FormEnding : Form {

        string path = "";

        public FormEnding() {
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

                backend.getText(absoluteFilename, textBoxFormEnding1, 0x10, 0x1F69A, 0);
                backend.getText(absoluteFilename, textBoxFormEnding2, 0x7, 0xA0B, 0);
                backend.getText(absoluteFilename, textBoxFormEnding3, 0x9, 0xA16, 0);
                backend.getText(absoluteFilename, textBoxFormEnding4, 0xB, 0xA22, 0);
                backend.getText(absoluteFilename, textBoxFormEnding5, 0x8, 0xA31, 0);
                backend.getText(absoluteFilename, textBoxFormEnding6, 0x7, 0xA3D, 0);
                backend.getText(absoluteFilename, textBoxFormEnding7, 0x10, 0x8A61, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x10, textBoxFormEnding1, 0x1F69A, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxFormEnding2, 0xA0B, 0);
                backend.updateROMText(absoluteFilename, 0x9, textBoxFormEnding3, 0xA16, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxFormEnding4, 0xA22, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxFormEnding5, 0xA31, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxFormEnding6, 0xA3D, 0);
                backend.updateROMText(absoluteFilename, 0x10, textBoxFormEnding7, 0x8A61, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxFormEnding1.MaxLength = 0x10;
            textBoxFormEnding2.MaxLength = 0x7;
            textBoxFormEnding3.MaxLength = 0x9;
            textBoxFormEnding4.MaxLength = 0xB;
            textBoxFormEnding5.MaxLength = 0x8;
            textBoxFormEnding6.MaxLength = 0x7;
            textBoxFormEnding7.MaxLength = 0x10;
        }

        private void FormEnding_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }

    }
}
