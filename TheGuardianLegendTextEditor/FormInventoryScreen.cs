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
    public partial class FormInventoryScreen : Form {

        string path = "";

        public FormInventoryScreen() {
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

                backend.getText(absoluteFilename, textBoxInventoryScreen1, 0x3, 0x14541, 0); // KEY
                backend.getText(absoluteFilename, textBoxInventoryScreen2, 0x2, 0x1460D, 0); // NO
                backend.getText(absoluteFilename, textBoxInventoryScreen3, 0x1, 0x14613, 0); // -
                backend.getText(absoluteFilename, textBoxInventoryScreen4, 0x3, 0x14615, 0); // USE
                backend.getText(absoluteFilename, textBoxInventoryScreen5, 0x8, 0x1463B, 0); // CHIP MAX
                backend.getText(absoluteFilename, textBoxInventoryScreen6, 0xC, 0x14662, 0); // WEAPON POWER
                backend.getText(absoluteFilename, textBoxInventoryScreen7, 0x8, 0x14674, 0); // USE CHIP
                backend.getText(absoluteFilename, textBoxInventoryScreen8, 0x6, 0x14798, 0); // ATTACK
                backend.getText(absoluteFilename, textBoxInventoryScreen9, 0x6, 0x147B5, 0); // SHIELD

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x3, textBoxInventoryScreen1, 0x14541, 0);
                backend.updateROMText(absoluteFilename, 0x2, textBoxInventoryScreen2, 0x1460D, 0);
                backend.updateROMText(absoluteFilename, 0x1, textBoxInventoryScreen3, 0x14613, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxInventoryScreen4, 0x14615, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInventoryScreen5, 0x1463B, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInventoryScreen6, 0x14662, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInventoryScreen7, 0x14674, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxInventoryScreen8, 0x14798, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxInventoryScreen9, 0x147B5, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxInventoryScreen1.MaxLength = 0x3;
            textBoxInventoryScreen2.MaxLength = 0x2;
            textBoxInventoryScreen3.MaxLength = 0x1;
            textBoxInventoryScreen4.MaxLength = 0x3;
            textBoxInventoryScreen5.MaxLength = 0x8;
            textBoxInventoryScreen6.MaxLength = 0xC;
            textBoxInventoryScreen7.MaxLength = 0x8;
            textBoxInventoryScreen8.MaxLength = 0x6;
            textBoxInventoryScreen9.MaxLength = 0x6;
        }

        private void FormInventoryScreen_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
