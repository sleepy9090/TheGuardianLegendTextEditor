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
    public partial class FormGameSelectScreen : Form {

        string path = "";

        public FormGameSelectScreen() {
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

                backend.getText(absoluteFilename, textBoxGameSelectScreen1, 0xB, 0x855, 0);
                backend.getText(absoluteFilename, textBoxGameSelectScreen2, 0x8, 0x870, 0);
                backend.getText(absoluteFilename, textBoxGameSelectScreen3, 0x11, 0x88D, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0xB, textBoxGameSelectScreen1, 0x855, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxGameSelectScreen2, 0x870, 0);
                backend.updateROMText(absoluteFilename, 0x11, textBoxGameSelectScreen3, 0x88D, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxGameSelectScreen1.MaxLength = 0xB;
            textBoxGameSelectScreen2.MaxLength = 0x8;
            textBoxGameSelectScreen3.MaxLength = 0x11;
        }

        private void FormGameSelectScreen_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
