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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void buttonOpenROM_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file...";
            ofd.Filter = "nes files (*.nes)|*.nes|All files (*.*)|*.*";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK) {
                textBoxAbsoluteFilename.Text = ofd.FileName;

                clearTextBoxes();
                readRomText();
            }
        }

        private void clearTextBoxes() {
            textBoxTitleScreen1.Clear();
            textBoxTitleScreen2.Clear();
            textBoxTitleScreen3.Clear();
            textBoxTitleScreen4.Clear();
            textBoxTitleScreen5.Clear();
            textBoxTitleScreen6.Clear();
            textBoxTitleScreen7.Clear();
            textBoxTitleScreen8.Clear();
            textBoxTitleScreen9.Clear();
        }

        private void readRomText() {
            try {
                string absoluteFilename = textBoxAbsoluteFilename.Text;

                Backend backend = new Backend();

                backend.getText(absoluteFilename, textBoxTitleScreen1, 0x14, 0x298, 0);
                backend.getText(absoluteFilename, textBoxTitleScreen2, 0x2, 0x60D, 0);
                backend.getText(absoluteFilename, textBoxTitleScreen3, 0x2, 0x648, 0);
                backend.getText(absoluteFilename, textBoxTitleScreen4, 0x18, 0x653, 0);
                backend.getText(absoluteFilename, textBoxTitleScreen5, 0x17, 0x672, 0);
                backend.getText(absoluteFilename, textBoxTitleScreen6, 0xD, 0x68C, 0);
                backend.getText(absoluteFilename, textBoxTitleScreen7, 0xB, 0x69C, 0);
                backend.getText(absoluteFilename, textBoxTitleScreen8, 0x18, 0x6AA, 0);
                backend.getText(absoluteFilename, textBoxTitleScreen9, 0x14, 0x6C6, 0);

                enableButtons();
                enableMenuItems();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void enableButtons() {
            buttonUpdateText.Enabled = true;
        }

        private void enableMenuItems() {
            creditsToolStripMenuItem.Enabled = true;
            endingToolStripMenuItem.Enabled = true;
            gameSelectScreenToolStripMenuItem.Enabled = true;
            hUDToolStripMenuItem.Enabled = true;
            inGameTextToolStripMenuItem.Enabled = true;
            inventoryScreenToolStripMenuItem.Enabled = true;
            miscToolStripMenuItem.Enabled = true;
            passwordScreenToolStripMenuItem.Enabled = true;
            storyToolStripMenuItem.Enabled = true;
            updateTextToolStripMenuItem.Enabled = true;
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {

            try {
                string absoluteFilename = textBoxAbsoluteFilename.Text;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x14, textBoxTitleScreen1, 0x298, 0);
                backend.updateROMText(absoluteFilename, 0x2, textBoxTitleScreen2, 0x60D, 0);
                backend.updateROMText(absoluteFilename, 0x2, textBoxTitleScreen3, 0x648, 0);
                backend.updateROMText(absoluteFilename, 0x18, textBoxTitleScreen4, 0x653, 0);
                backend.updateROMText(absoluteFilename, 0x17, textBoxTitleScreen5, 0x672, 0);
                backend.updateROMText(absoluteFilename, 0xD, textBoxTitleScreen6, 0x68C, 0);
                backend.updateROMText(absoluteFilename, 0xB, textBoxTitleScreen7, 0x69C, 0);
                backend.updateROMText(absoluteFilename, 0x18, textBoxTitleScreen8, 0x6AA, 0);
                backend.updateROMText(absoluteFilename, 0x14, textBoxTitleScreen9, 0x6C6, 0);

                MessageBox.Show("Updated Text!", "The Guardian Legend NES Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxTitleScreen1.MaxLength = 0x14;
            textBoxTitleScreen2.MaxLength = 0x2;
            textBoxTitleScreen3.MaxLength = 0x2;
            textBoxTitleScreen4.MaxLength = 0x18;
            textBoxTitleScreen5.MaxLength = 0x17;
            textBoxTitleScreen6.MaxLength = 0xD;
            textBoxTitleScreen7.MaxLength = 0xB;
            textBoxTitleScreen8.MaxLength = 0x18;
            textBoxTitleScreen9.MaxLength = 0x14;
        }

        private void Form1GuardianLegend_Load(object sender, EventArgs e) {
            disableMenuItems();
            disableButtons();
            setMaxLengthOfTextBoxes();
        }

        private void disableMenuItems() {
            creditsToolStripMenuItem.Enabled = false;
            endingToolStripMenuItem.Enabled = false;
            gameSelectScreenToolStripMenuItem.Enabled = false;
            hUDToolStripMenuItem.Enabled = false;
            inGameTextToolStripMenuItem.Enabled = false;
            inventoryScreenToolStripMenuItem.Enabled = false;
            miscToolStripMenuItem.Enabled = false;
            passwordScreenToolStripMenuItem.Enabled = false;
            storyToolStripMenuItem.Enabled = false;
            updateTextToolStripMenuItem.Enabled = false;
        }

        private void disableButtons() {
            buttonUpdateText.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void updateTextToolStripMenuItem_Click(object sender, EventArgs e) {
            buttonUpdateText_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e) {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void hUDToolStripMenuItem_Click(object sender, EventArgs e) {
            FormHUD formHUD = new FormHUD();
            formHUD.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formHUD.ShowDialog();
        }

        private void storyToolStripMenuItem_Click(object sender, EventArgs e) {
            FormStory formStory = new FormStory();
            formStory.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formStory.ShowDialog();
        }

        private void gameSelectScreenToolStripMenuItem_Click(object sender, EventArgs e) {
            FormGameSelectScreen formGameSelectScreen = new FormGameSelectScreen();
            formGameSelectScreen.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formGameSelectScreen.ShowDialog();
        }

        private void endingToolStripMenuItem_Click(object sender, EventArgs e) {
            FormEnding formEnding = new FormEnding();
            formEnding.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formEnding.ShowDialog();
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e) {
            FormCredits formCredits = new FormCredits();
            formCredits.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formCredits.ShowDialog();
        }

        private void miscToolStripMenuItem_Click(object sender, EventArgs e) {
            FormMisc formMisc = new FormMisc();
            formMisc.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formMisc.ShowDialog();
        }

        private void passwordScreenToolStripMenuItem_Click(object sender, EventArgs e) {
            FormPasswordScreen formPasswordScreen = new FormPasswordScreen();
            formPasswordScreen.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formPasswordScreen.ShowDialog();
        }

        private void inventoryScreenToolStripMenuItem_Click(object sender, EventArgs e) {
            FormInventoryScreen formInventoryScreen = new FormInventoryScreen();
            formInventoryScreen.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formInventoryScreen.ShowDialog();
        }

        private void inGameTextToolStripMenuItem_Click(object sender, EventArgs e) {
            FormInGameText formInGameText = new FormInGameText();
            formInGameText.sendPathToOtherForm = textBoxAbsoluteFilename.Text;
            formInGameText.ShowDialog();
        }

        private void openROMToolStripMenuItem_Click_1(object sender, EventArgs e) {
            buttonOpenROM_Click(sender, e);
        }
    }
}
