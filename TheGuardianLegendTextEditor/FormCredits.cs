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
    public partial class FormCredits : Form {

        string path = "";

        public FormCredits() {
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

                backend.getText(absoluteFilename, textBoxCredits1, 0x7, 0xA47, 0);
                backend.getText(absoluteFilename, textBoxCredits2, 0xA, 0xA51, 0);
                backend.getText(absoluteFilename, textBoxCredits3, 0xC, 0xA5F, 0);
                backend.getText(absoluteFilename, textBoxCredits4, 0x8, 0xA70, 0);
                backend.getText(absoluteFilename, textBoxCredits5, 0x8, 0xA7C, 0);

                backend.getText(absoluteFilename, textBoxCredits6, 0x9, 0xA87, 0);
                backend.getText(absoluteFilename, textBoxCredits7, 0xE, 0xA94, 0);
                backend.getText(absoluteFilename, textBoxCredits8, 0x7, 0xAA5, 0);
                backend.getText(absoluteFilename, textBoxCredits9, 0xE, 0xAB0, 0);
                backend.getText(absoluteFilename, textBoxCredits10, 0x6, 0xAC1, 0);

                backend.getText(absoluteFilename, textBoxCredits11, 0x5, 0xACA, 0);
                backend.getText(absoluteFilename, textBoxCredits12, 0x6, 0xAD3, 0);
                backend.getText(absoluteFilename, textBoxCredits13, 0x5, 0xADC, 0);
                backend.getText(absoluteFilename, textBoxCredits14, 0xB, 0xAE5, 0);
                backend.getText(absoluteFilename, textBoxCredits15, 0x7, 0xAF4, 0);

                backend.getText(absoluteFilename, textBoxCredits16, 0x9, 0xAFE, 0);
                backend.getText(absoluteFilename, textBoxCredits17, 0x8, 0xB0B, 0);
                backend.getText(absoluteFilename, textBoxCredits18, 0xD, 0xB16, 0);
                backend.getText(absoluteFilename, textBoxCredits19, 0xE, 0xB26, 0);
                backend.getText(absoluteFilename, textBoxCredits20, 0x5, 0xB37, 0);

                backend.getText(absoluteFilename, textBoxCredits21, 0x6, 0xB3F, 0);
                backend.getText(absoluteFilename, textBoxCredits22, 0x5, 0xB48, 0);
                backend.getText(absoluteFilename, textBoxCredits23, 0x3, 0xB50, 0);
                backend.getText(absoluteFilename, textBoxCredits24, 0x6, 0xB56, 0);
                backend.getText(absoluteFilename, textBoxCredits25, 0x8, 0xB5F, 0);

                backend.getText(absoluteFilename, textBoxCredits26, 0xB, 0xB6B, 0);
                backend.getText(absoluteFilename, textBoxCredits27, 0xA, 0xB79, 0);
                backend.getText(absoluteFilename, textBoxCredits28, 0x7, 0xB86, 0);
                backend.getText(absoluteFilename, textBoxCredits29, 0xB, 0xB92, 0);
                backend.getText(absoluteFilename, textBoxCredits30, 0x4, 0xBA0, 0);

                backend.getText(absoluteFilename, textBoxCredits31, 0xB, 0xBA7, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x7, textBoxCredits1, 0xA47, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxCredits2, 0xA51, 0);
                backend.updateROMText(absoluteFilename, 0xC, textBoxCredits3, 0xA5F, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxCredits4, 0xA70, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxCredits5, 0xA7C, 0);

                backend.updateROMText(absoluteFilename, 0x9, textBoxCredits6, 0xA87, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxCredits7, 0xA94, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxCredits8, 0xAA5, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxCredits9, 0xAB0, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxCredits10, 0xAC1, 0);

                backend.updateROMText(absoluteFilename, 0x5, textBoxCredits11, 0xACA, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxCredits12, 0xAD3, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxCredits13, 0xADC, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxCredits14, 0xAE5, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxCredits15, 0xAF4, 0);

                backend.updateROMText(absoluteFilename, 0x9, textBoxCredits16, 0xAFE, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxCredits17, 0xB0B, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxCredits18, 0xB16, 0);
                backend.updateROMText(absoluteFilename, 0xE, textBoxCredits19, 0xB26, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxCredits20, 0xB37, 0);

                backend.updateROMText(absoluteFilename, 0x6, textBoxCredits21, 0xB3F, 0);
                backend.updateROMText(absoluteFilename, 0x5, textBoxCredits22, 0xB48, 0);
                backend.updateROMText(absoluteFilename, 0x3, textBoxCredits23, 0xB50, 0);
                backend.updateROMText(absoluteFilename, 0x6, textBoxCredits24, 0xB56, 0);
                backend.updateROMText(absoluteFilename, 0x8, textBoxCredits25, 0xB5F, 0);

                backend.updateROMText(absoluteFilename, 0xB, textBoxCredits26, 0xB6B, 0);
                backend.updateROMText(absoluteFilename, 0xA, textBoxCredits27, 0xB79, 0);
                backend.updateROMText(absoluteFilename, 0x7, textBoxCredits28, 0xB86, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxCredits29, 0xB92, 0);
                backend.updateROMText(absoluteFilename, 0x4, textBoxCredits30, 0xBA0, 0);

                backend.updateROMText(absoluteFilename, 0xB, textBoxCredits31, 0xBA7, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxCredits1.MaxLength = 0x7;
            textBoxCredits2.MaxLength = 0xA;
            textBoxCredits3.MaxLength = 0xC;
            textBoxCredits4.MaxLength = 0x8;
            textBoxCredits5.MaxLength = 0x8;

            textBoxCredits6.MaxLength = 0x9;
            textBoxCredits7.MaxLength = 0xE;
            textBoxCredits8.MaxLength = 0x7;
            textBoxCredits9.MaxLength = 0xE;
            textBoxCredits10.MaxLength = 0x6;

            textBoxCredits11.MaxLength = 0x5;
            textBoxCredits12.MaxLength = 0x6;
            textBoxCredits13.MaxLength = 0x5;
            textBoxCredits14.MaxLength = 0xB;
            textBoxCredits15.MaxLength = 0x7;

            textBoxCredits16.MaxLength = 0x9;
            textBoxCredits17.MaxLength = 0x8;
            textBoxCredits18.MaxLength = 0xD;
            textBoxCredits19.MaxLength = 0xE;
            textBoxCredits20.MaxLength = 0x5;

            textBoxCredits21.MaxLength = 0x6;
            textBoxCredits22.MaxLength = 0x5;
            textBoxCredits23.MaxLength = 0x3;
            textBoxCredits24.MaxLength = 0x6;
            textBoxCredits25.MaxLength = 0x8;

            textBoxCredits26.MaxLength = 0xB;
            textBoxCredits27.MaxLength = 0xA;
            textBoxCredits28.MaxLength = 0x7;
            textBoxCredits29.MaxLength = 0xB;
            textBoxCredits30.MaxLength = 0x4;

            textBoxCredits31.MaxLength = 0xB;
        }

        private void FormCredits_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
