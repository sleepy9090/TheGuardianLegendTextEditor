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
    public partial class FormStory : Form {

        string path = "";

        public FormStory() {
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

                backend.getText(absoluteFilename, textBoxStory1, 0x1B, 0x6FA, 0);
                backend.getText(absoluteFilename, textBoxStory2, 0x1C, 0x719, 0);
                backend.getText(absoluteFilename, textBoxStory3, 0x1D, 0x739, 0);
                backend.getText(absoluteFilename, textBoxStory4, 0x18, 0x75A, 0);
                backend.getText(absoluteFilename, textBoxStory5, 0x18, 0x776, 0);
                backend.getText(absoluteFilename, textBoxStory6, 0x1B, 0x792, 0);
                backend.getText(absoluteFilename, textBoxStory7, 0x16, 0x7B1, 0);
                backend.getText(absoluteFilename, textBoxStory8, 0xC, 0x7C8, 0);
                backend.getText(absoluteFilename, textBoxStory9, 0x17, 0x7DB, 0);
                backend.getText(absoluteFilename, textBoxStory10, 0x1C, 0x7F6, 0);
                backend.getText(absoluteFilename, textBoxStory11, 0x1B, 0x816, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x1B, textBoxStory1, 0x6FA, 0);
                backend.updateROMText(absoluteFilename, 0x1C, textBoxStory2, 0x719, 0);
                backend.updateROMText(absoluteFilename, 0x1D, textBoxStory3, 0x739, 0);
                backend.updateROMText(absoluteFilename, 0x18, textBoxStory4, 0x75A, 0);
                backend.updateROMText(absoluteFilename, 0x18, textBoxStory5, 0x776, 0);
                backend.updateROMText(absoluteFilename, 0x1B, textBoxStory6, 0x792, 0);
                backend.updateROMText(absoluteFilename, 0x16, textBoxStory7, 0x7B1, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxStory8, 0x7C8, 0);
                backend.updateROMText(absoluteFilename, 0x17, textBoxStory9, 0x7DB, 0);
                backend.updateROMText(absoluteFilename, 0x1C, textBoxStory10, 0x7F6, 0);
                backend.updateROMText(absoluteFilename, 0x1B, textBoxStory11, 0x816, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxStory1.MaxLength = 0x1B;
            textBoxStory2.MaxLength = 0x1C;
            textBoxStory3.MaxLength = 0x1D;
            textBoxStory4.MaxLength = 0x18;
            textBoxStory5.MaxLength = 0x18;
            textBoxStory6.MaxLength = 0x1B;
            textBoxStory7.MaxLength = 0x16;
            textBoxStory8.MaxLength = 0xC;
            textBoxStory9.MaxLength = 0x17;
            textBoxStory10.MaxLength = 0x1C;
            textBoxStory11.MaxLength = 0x1B;
        }

        private void FormStory_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
