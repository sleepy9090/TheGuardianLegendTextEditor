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
    public partial class FormInGameText : Form {

        string path = "";

        public FormInGameText() {
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

                backend.getText(absoluteFilename, textBoxInGame1, 0xD, 0x15649, 2);
                backend.getText(absoluteFilename, textBoxInGame2, 0xF, 0x15657, 2);
                backend.getText(absoluteFilename, textBoxInGame3, 0xB, 0x15667, 2);
                backend.getText(absoluteFilename, textBoxInGame4, 0x7, 0x15673, 2);
                backend.getText(absoluteFilename, textBoxInGame5, 0x10, 0x1567B, 2);
                backend.getText(absoluteFilename, textBoxInGame6, 0xD, 0x1568C, 2);
                backend.getText(absoluteFilename, textBoxInGame7, 0xB, 0x1569A, 2);
                backend.getText(absoluteFilename, textBoxInGame8, 0xA, 0x156A6, 2);
                backend.getText(absoluteFilename, textBoxInGame9, 0x10, 0x156B1, 2);
                backend.getText(absoluteFilename, textBoxInGame10, 0xF, 0x156C2, 2);

                backend.getText(absoluteFilename, textBoxInGame11, 0xE, 0x156D2, 2);
                backend.getText(absoluteFilename, textBoxInGame12, 0xD, 0x156E1, 2);
                backend.getText(absoluteFilename, textBoxInGame13, 0xF, 0x156EF, 2);
                backend.getText(absoluteFilename, textBoxInGame14, 0x9, 0x156FF, 2);
                backend.getText(absoluteFilename, textBoxInGame15, 0x10, 0x15709, 2);
                backend.getText(absoluteFilename, textBoxInGame16, 0xA, 0x1571A, 2);
                backend.getText(absoluteFilename, textBoxInGame17, 0x10, 0x15725, 2);
                backend.getText(absoluteFilename, textBoxInGame18, 0xF, 0x15736, 2);
                backend.getText(absoluteFilename, textBoxInGame19, 0xE, 0x15746, 2);
                backend.getText(absoluteFilename, textBoxInGame20, 0xD, 0x15755, 2);

                backend.getText(absoluteFilename, textBoxInGame21, 0xB, 0x15763, 2);
                backend.getText(absoluteFilename, textBoxInGame22, 0x9, 0x1576F, 2);
                backend.getText(absoluteFilename, textBoxInGame23, 0x8, 0x15779, 2);
                backend.getText(absoluteFilename, textBoxInGame24, 0x9, 0x15782, 2);
                backend.getText(absoluteFilename, textBoxInGame25, 0xF, 0x1578C, 2);
                backend.getText(absoluteFilename, textBoxInGame26, 0xF, 0x1579C, 2);
                backend.getText(absoluteFilename, textBoxInGame27, 0x10, 0x157AC, 2);
                backend.getText(absoluteFilename, textBoxInGame28, 0x2, 0x157BD, 2);
                backend.getText(absoluteFilename, textBoxInGame29, 0xF, 0x157C0, 2);
                backend.getText(absoluteFilename, textBoxInGame30, 0xA, 0x157D0, 2);

                backend.getText(absoluteFilename, textBoxInGame31, 0x10, 0x157DB, 2);
                backend.getText(absoluteFilename, textBoxInGame32, 0xB, 0x157EC, 2);
                backend.getText(absoluteFilename, textBoxInGame33, 0xC, 0x157F8, 2);
                backend.getText(absoluteFilename, textBoxInGame34, 0xE, 0x15805, 2);
                backend.getText(absoluteFilename, textBoxInGame35, 0xD, 0x15814, 2);
                backend.getText(absoluteFilename, textBoxInGame36, 0xB, 0x15822, 2);
                backend.getText(absoluteFilename, textBoxInGame37, 0xD, 0x1582E, 2);
                backend.getText(absoluteFilename, textBoxInGame38, 0x10, 0x1583C, 2);
                backend.getText(absoluteFilename, textBoxInGame39, 0xA, 0x1584D, 2);
                backend.getText(absoluteFilename, textBoxInGame40, 0xC, 0x15858, 2);

                backend.getText(absoluteFilename, textBoxInGame41, 0xA, 0x15865, 2);
                backend.getText(absoluteFilename, textBoxInGame42, 0xB, 0x15870, 2);
                backend.getText(absoluteFilename, textBoxInGame43, 0xC, 0x1587C, 2);
                backend.getText(absoluteFilename, textBoxInGame44, 0xE, 0x15889, 2);
                backend.getText(absoluteFilename, textBoxInGame45, 0x9, 0x15898, 2);
                backend.getText(absoluteFilename, textBoxInGame46, 0xC, 0x158A2, 2);
                backend.getText(absoluteFilename, textBoxInGame47, 0xB, 0x158AF, 2);
                backend.getText(absoluteFilename, textBoxInGame48, 0x7, 0x158BB, 2);
                backend.getText(absoluteFilename, textBoxInGame49, 0xA, 0x158C3, 2);
                backend.getText(absoluteFilename, textBoxInGame50, 0x7, 0x158CE, 2);

                backend.getText(absoluteFilename, textBoxInGame51, 0xF, 0x158D6, 2);
                backend.getText(absoluteFilename, textBoxInGame52, 0x10, 0x158E6, 2);
                backend.getText(absoluteFilename, textBoxInGame53, 0x10, 0x158F7, 2);
                backend.getText(absoluteFilename, textBoxInGame54, 0x5, 0x15908, 2);
                backend.getText(absoluteFilename, textBoxInGame55, 0xC, 0x1590E, 2);
                backend.getText(absoluteFilename, textBoxInGame56, 0x10, 0x1591B, 2);
                backend.getText(absoluteFilename, textBoxInGame57, 0xA, 0x1592C, 2);
                backend.getText(absoluteFilename, textBoxInGame58, 0xF, 0x15937, 2);
                backend.getText(absoluteFilename, textBoxInGame59, 0xB, 0x15947, 2);
                backend.getText(absoluteFilename, textBoxInGame60, 0xD, 0x15953, 2);

                backend.getText(absoluteFilename, textBoxInGame61, 0x10, 0x15961, 2);
                backend.getText(absoluteFilename, textBoxInGame62, 0x7, 0x15972, 2);
                backend.getText(absoluteFilename, textBoxInGame63, 0xF, 0x1597A, 2);
                backend.getText(absoluteFilename, textBoxInGame64, 0xF, 0x1598A, 2);
                backend.getText(absoluteFilename, textBoxInGame65, 0x4, 0x1599A, 2);
                backend.getText(absoluteFilename, textBoxInGame66, 0xC, 0x1599F, 2);
                backend.getText(absoluteFilename, textBoxInGame67, 0xF, 0x159AC, 2);
                backend.getText(absoluteFilename, textBoxInGame68, 0x9, 0x159BC, 2);
                backend.getText(absoluteFilename, textBoxInGame69, 0xD, 0x159C6, 2);
                backend.getText(absoluteFilename, textBoxInGame70, 0x9, 0x159D4, 2);

                backend.getText(absoluteFilename, textBoxInGame71, 0x7, 0x159DE, 2);
                backend.getText(absoluteFilename, textBoxInGame72, 0xE, 0x159E6, 2);
                backend.getText(absoluteFilename, textBoxInGame73, 0xB, 0x159F5, 2);
                backend.getText(absoluteFilename, textBoxInGame74, 0x10, 0x15A01, 2);
                backend.getText(absoluteFilename, textBoxInGame75, 0xE, 0x15A12, 2);
                backend.getText(absoluteFilename, textBoxInGame76, 0xE, 0x15A21, 2);
                backend.getText(absoluteFilename, textBoxInGame77, 0xD, 0x15A30, 2);
                backend.getText(absoluteFilename, textBoxInGame78, 0x10, 0x15A3E, 2);
                backend.getText(absoluteFilename, textBoxInGame79, 0x9, 0x15A4F, 2);
                backend.getText(absoluteFilename, textBoxInGame80, 0xC, 0x15A59, 2);

                backend.getText(absoluteFilename, textBoxInGame81, 0xD, 0x15A66, 2);
                backend.getText(absoluteFilename, textBoxInGame82, 0xE, 0x15A74, 2);
                backend.getText(absoluteFilename, textBoxInGame83, 0xD, 0x15A83, 2);
                backend.getText(absoluteFilename, textBoxInGame84, 0x7, 0x15A91, 2);
                backend.getText(absoluteFilename, textBoxInGame85, 0xA, 0x15A99, 2);
                backend.getText(absoluteFilename, textBoxInGame86, 0xF, 0x15AA4, 2);
                backend.getText(absoluteFilename, textBoxInGame87, 0xC, 0x15AB4, 2);
                backend.getText(absoluteFilename, textBoxInGame88, 0x5, 0x15AC1, 2);
                backend.getText(absoluteFilename, textBoxInGame89, 0xA, 0x15AC7, 2);
                backend.getText(absoluteFilename, textBoxInGame90, 0xD, 0x15AD2, 2);

                backend.getText(absoluteFilename, textBoxInGame91, 0xD, 0x15AE0, 2);
                backend.getText(absoluteFilename, textBoxInGame92, 0xA, 0x15AEE, 2);
                backend.getText(absoluteFilename, textBoxInGame93, 0xD, 0x15AF9, 2);
                backend.getText(absoluteFilename, textBoxInGame94, 0xC, 0x15B07, 2);
                backend.getText(absoluteFilename, textBoxInGame95, 0xE, 0x15B14, 2);
                backend.getText(absoluteFilename, textBoxInGame96, 0xA, 0x15B23, 2);
                backend.getText(absoluteFilename, textBoxInGame97, 0xE, 0x15B2E, 2);
                backend.getText(absoluteFilename, textBoxInGame98, 0xD, 0x15B3D, 2);
                backend.getText(absoluteFilename, textBoxInGame99, 0x10, 0x15B4B, 2);
                backend.getText(absoluteFilename, textBoxInGame100, 0x8, 0x15B5C, 2);

                backend.getText(absoluteFilename, textBoxInGame101, 0xC, 0x15B65, 2);
                backend.getText(absoluteFilename, textBoxInGame102, 0xC, 0x15B72, 2);
                backend.getText(absoluteFilename, textBoxInGame103, 0xB, 0x15B7F, 2);
                backend.getText(absoluteFilename, textBoxInGame104, 0xC, 0x15B8B, 2);
                backend.getText(absoluteFilename, textBoxInGame105, 0x4, 0x15B98, 2);
                backend.getText(absoluteFilename, textBoxInGame106, 0x9, 0x15B9D, 2);
                backend.getText(absoluteFilename, textBoxInGame107, 0x8, 0x15BA7, 2);
                backend.getText(absoluteFilename, textBoxInGame108, 0x9, 0x15BB0, 2);
                backend.getText(absoluteFilename, textBoxInGame109, 0xC, 0x15BBA, 2);
                backend.getText(absoluteFilename, textBoxInGame110, 0x5, 0x15BC7, 2);

                backend.getText(absoluteFilename, textBoxInGame111, 0xA, 0x15BCD, 2);
                backend.getText(absoluteFilename, textBoxInGame112, 0x8, 0x15BD8, 2);
                backend.getText(absoluteFilename, textBoxInGame113, 0xB, 0x15BE1, 2);
                backend.getText(absoluteFilename, textBoxInGame114, 0xB, 0x15BED, 2);
                backend.getText(absoluteFilename, textBoxInGame115, 0xB, 0x15BF9, 2);
                backend.getText(absoluteFilename, textBoxInGame116, 0x10, 0x15C05, 2);
                backend.getText(absoluteFilename, textBoxInGame117, 0xB, 0x15C16, 2);
                backend.getText(absoluteFilename, textBoxInGame118, 0x8, 0x15C22, 2);
                backend.getText(absoluteFilename, textBoxInGame119, 0x8, 0x15C2B, 2);
                backend.getText(absoluteFilename, textBoxInGame120, 0x7, 0x15C34, 2);

                backend.getText(absoluteFilename, textBoxInGame121, 0xB, 0x15C3D, 2);
                backend.getText(absoluteFilename, textBoxInGame122, 0x9, 0x15C49, 2);
                backend.getText(absoluteFilename, textBoxInGame123, 0x9, 0x15C53, 2);
                backend.getText(absoluteFilename, textBoxInGame124, 0xA, 0x15C5D, 2);
                backend.getText(absoluteFilename, textBoxInGame125, 0xA, 0x15C68, 2);
                backend.getText(absoluteFilename, textBoxInGame126, 0x9, 0x15C73, 2);
                backend.getText(absoluteFilename, textBoxInGame127, 0xA, 0x15C7D, 2);
                backend.getText(absoluteFilename, textBoxInGame128, 0x8, 0x15C88, 2);
                backend.getText(absoluteFilename, textBoxInGame129, 0x8, 0x15C91, 2);
                backend.getText(absoluteFilename, textBoxInGame130, 0x5, 0x15C9A, 2);

                backend.getText(absoluteFilename, textBoxInGame131, 0x9, 0x15CA0, 2);
                backend.getText(absoluteFilename, textBoxInGame132, 0xC, 0x15CAA, 2);
                backend.getText(absoluteFilename, textBoxInGame133, 0xE, 0x15CB7, 2);
                backend.getText(absoluteFilename, textBoxInGame134, 0x5, 0x15CC6, 2);
                backend.getText(absoluteFilename, textBoxInGame135, 0xB, 0x15CCC, 2);
                backend.getText(absoluteFilename, textBoxInGame136, 0x5, 0x15CD8, 2);
                backend.getText(absoluteFilename, textBoxInGame137, 0xF, 0x15CDE, 2);
                backend.getText(absoluteFilename, textBoxInGame138, 0xC, 0x15CEE, 2);
                backend.getText(absoluteFilename, textBoxInGame139, 0xC, 0x15CFB, 2);
                backend.getText(absoluteFilename, textBoxInGame140, 0x8, 0x15D08, 2);

                backend.getText(absoluteFilename, textBoxInGame141, 0xC, 0x15D11, 2);
                backend.getText(absoluteFilename, textBoxInGame142, 0xB, 0x15D1E, 2);
                backend.getText(absoluteFilename, textBoxInGame143, 0xB, 0x15D2A, 2);
                backend.getText(absoluteFilename, textBoxInGame144, 0x5, 0x15D36, 2);
                backend.getText(absoluteFilename, textBoxInGame145, 0x9, 0x15D3C, 2);
                backend.getText(absoluteFilename, textBoxInGame146, 0x6, 0x15D46, 2);
                backend.getText(absoluteFilename, textBoxInGame147, 0xB, 0x15D4D, 2);
                backend.getText(absoluteFilename, textBoxInGame148, 0x9, 0x15D59, 2);
                backend.getText(absoluteFilename, textBoxInGame149, 0xE, 0x15D63, 2);
                backend.getText(absoluteFilename, textBoxInGame150, 0xC, 0x15D72, 2);

                backend.getText(absoluteFilename, textBoxInGame151, 0xC, 0x15D7F, 2);
                backend.getText(absoluteFilename, textBoxInGame152, 0xE, 0x15D8C, 2);
                backend.getText(absoluteFilename, textBoxInGame153, 0x8, 0x15D9B, 2);
                backend.getText(absoluteFilename, textBoxInGame154, 0xE, 0x15DA4, 2);
                backend.getText(absoluteFilename, textBoxInGame155, 0xD, 0x15D83, 2);
                backend.getText(absoluteFilename, textBoxInGame156, 0x9, 0x15DC1, 2);
                backend.getText(absoluteFilename, textBoxInGame157, 0xD, 0x15DCB, 2);
                backend.getText(absoluteFilename, textBoxInGame158, 0xF, 0x15DD9, 2);
                backend.getText(absoluteFilename, textBoxInGame159, 0x8, 0x15DE9, 2);
                backend.getText(absoluteFilename, textBoxInGame160, 0xC, 0x15DF2, 2);

                backend.getText(absoluteFilename, textBoxInGame161, 0xA, 0x15DFF, 2);
                backend.getText(absoluteFilename, textBoxInGame162, 0xD, 0x15E0A, 2);
                backend.getText(absoluteFilename, textBoxInGame163, 0x10, 0x15E18, 2);
                backend.getText(absoluteFilename, textBoxInGame164, 0xC, 0x15E29, 2);
                backend.getText(absoluteFilename, textBoxInGame165, 0xC, 0x15E36, 2);
                backend.getText(absoluteFilename, textBoxInGame166, 0xB, 0x15E43, 2);
                backend.getText(absoluteFilename, textBoxInGame167, 0xC, 0x15E4F, 2);
                backend.getText(absoluteFilename, textBoxInGame168, 0xE, 0x15E5C, 2);
                backend.getText(absoluteFilename, textBoxInGame169, 0xE, 0x15E6B, 2);
                backend.getText(absoluteFilename, textBoxInGame170, 0x9, 0x15E7A, 2);

                backend.getText(absoluteFilename, textBoxInGame171, 0x8, 0x15E84, 2);
                backend.getText(absoluteFilename, textBoxInGame172, 0x11, 0x15E8D, 2);
                backend.getText(absoluteFilename, textBoxInGame173, 0xF, 0x15E9F, 2);
                backend.getText(absoluteFilename, textBoxInGame174, 0xF, 0x15EAF, 2);
                backend.getText(absoluteFilename, textBoxInGame175, 0x5, 0x15EBF, 2);
                backend.getText(absoluteFilename, textBoxInGame176, 0xD, 0x15EC5, 2);
                backend.getText(absoluteFilename, textBoxInGame177, 0xA, 0x15ED3, 2);
                backend.getText(absoluteFilename, textBoxInGame178, 0xB, 0x15EDE, 2);
                backend.getText(absoluteFilename, textBoxInGame179, 0x9, 0x15EEA, 2);
                backend.getText(absoluteFilename, textBoxInGame180, 0x10, 0x15EF4, 2);

                backend.getText(absoluteFilename, textBoxInGame181, 0xE, 0x15F05, 2);
                backend.getText(absoluteFilename, textBoxInGame182, 0xB, 0x15F14, 2);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame1, 0x15649, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame2, 0x15657, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame3, 0x15667, 2);
                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame4, 0x15673, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame5, 0x1567B, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame6, 0x1568C, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame7, 0x1569A, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame8, 0x156A6, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame9, 0x156B1, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame10, 0x156C2, 2);

                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame11, 0x156D2, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame12, 0x156E1, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame13, 0x156EF, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame14, 0x156FF, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame15, 0x15709, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame16, 0x1571A, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame17, 0x15725, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame18, 0x15736, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame19, 0x15746, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame20, 0x15755, 2);

                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame21, 0x15763, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame22, 0x1576F, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame23, 0x15779, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame24, 0x15782, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame25, 0x1578C, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame26, 0x1579C, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame27, 0x157AC, 2);
                backend.updateROMText(absoluteFilename, 0x2, textBoxInGame28, 0x157BD, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame29, 0x157C0, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame30, 0x157D0, 2);

                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame31, 0x157DB, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame32, 0x157EC, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame33, 0x157F8, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame34, 0x15805, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame35, 0x15814, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame36, 0x15822, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame37, 0x1582E, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame38, 0x1583C, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame39, 0x1584D, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame40, 0x15858, 2);

                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame41, 0x15865, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame42, 0x15870, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame43, 0x1587C, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame44, 0x15889, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame45, 0x15898, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame46, 0x158A2, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame47, 0x158AF, 2);
                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame48, 0x158BB, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame49, 0x158C3, 2);
                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame50, 0x158CE, 2);

                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame51, 0x158D6, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame52, 0x158E6, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame53, 0x158F7, 2);
                backend.updateROMText(absoluteFilename, 0x5, textBoxInGame54, 0x15908, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame55, 0x1590E, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame56, 0x1591B, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame57, 0x1592C, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame58, 0x15937, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame59, 0x15947, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame60, 0x15953, 2);

                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame61, 0x15961, 2);
                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame62, 0x15972, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame63, 0x1597A, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame64, 0x1598A, 2);
                backend.updateROMText(absoluteFilename, 0x4, textBoxInGame65, 0x1599A, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame66, 0x1599F, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame67, 0x159AC, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame68, 0x159BC, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame69, 0x159C6, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame70, 0x159D4, 2);

                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame71, 0x159DE, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame72, 0x159E6, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame73, 0x159F5, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame74, 0x15A01, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame75, 0x15A12, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame76, 0x15A21, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame77, 0x15A30, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame78, 0x15A3E, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame79, 0x15A4F, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame80, 0x15A59, 2);

                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame81, 0x15A66, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame82, 0x15A74, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame83, 0x15A83, 2);
                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame84, 0x15A91, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame85, 0x15A99, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame86, 0x15AA4, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame87, 0x15AB4, 2);
                backend.updateROMText(absoluteFilename, 0x5, textBoxInGame88, 0x15AC1, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame89, 0x15AC7, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame90, 0x15AD2, 2);

                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame91, 0x15AE0, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame92, 0x15AEE, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame93, 0x15AF9, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame94, 0x15B07, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame95, 0x15B14, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame96, 0x15B23, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame97, 0x15B2E, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame98, 0x15B3D, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame99, 0x15B4B, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame100, 0x15B5C, 2);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame101, 0x15B65, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame102, 0x15B72, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame103, 0x15B7F, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame104, 0x15B8B, 2);
                backend.updateROMText(absoluteFilename, 0x4, textBoxInGame105, 0x15B98, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame106, 0x15B9D, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame107, 0x15BA7, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame108, 0x15BB0, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame109, 0x15BBA, 2);
                backend.updateROMText(absoluteFilename, 0x5, textBoxInGame110, 0x15BC7, 2);

                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame111, 0x15BCD, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame112, 0x15BD8, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame113, 0x15BE1, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame114, 0x15BED, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame115, 0x15BF9, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame116, 0x15C05, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame117, 0x15C16, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame118, 0x15C22, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame119, 0x15C2B, 2);
                backend.updateROMText(absoluteFilename, 0x7, textBoxInGame120, 0x15C34, 2);

                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame121, 0x15C3D, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame122, 0x15C49, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame123, 0x15C53, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame124, 0x15C5D, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame125, 0x15C68, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame126, 0x15C73, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame127, 0x15C7D, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame128, 0x15C88, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame129, 0x15C91, 2);
                backend.updateROMText(absoluteFilename, 0x5, textBoxInGame130, 0x15C9A, 2);

                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame131, 0x15CA0, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame132, 0x15CAA, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame133, 0x15CB7, 2);
                backend.updateROMText(absoluteFilename, 0x5, textBoxInGame134, 0x15CC6, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame135, 0x15CCC, 2);
                backend.updateROMText(absoluteFilename, 0x5, textBoxInGame136, 0x15CD8, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame137, 0x15CDE, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame138, 0x15CEE, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame139, 0x15CFB, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame140, 0x15D08, 2);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame141, 0x15D11, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame142, 0x15D1E, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame143, 0x15D2A, 2);
                backend.updateROMText(absoluteFilename, 0x5, textBoxInGame144, 0x15D36, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame145, 0x15D3C, 2);
                backend.updateROMText(absoluteFilename, 0x6, textBoxInGame146, 0x15D46, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame147, 0x15D4D, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame148, 0x15D59, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame149, 0x15D63, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame150, 0x15D72, 2);

                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame151, 0x15D7F, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame152, 0x15D8C, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame153, 0x15D9B, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame154, 0x15DA4, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame155, 0x15D83, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame156, 0x15DC1, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame157, 0x15DCB, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame158, 0x15DD9, 2);
                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame159, 0x15DE9, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame160, 0x15DF2, 2);

                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame161, 0x15DFF, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame162, 0x15E0A, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame163, 0x15E18, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame164, 0x15E29, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame165, 0x15E36, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame166, 0x15E43, 2);
                backend.updateROMText(absoluteFilename, 0xC, textBoxInGame167, 0x15E4F, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame168, 0x15E5C, 2);
                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame169, 0x15E6B, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame170, 0x15E7A, 2);

                backend.updateROMText(absoluteFilename, 0x8, textBoxInGame171, 0x15E84, 2);
                backend.updateROMText(absoluteFilename, 0x11, textBoxInGame172, 0x15E8D, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame173, 0x15E9F, 2);
                backend.updateROMText(absoluteFilename, 0xF, textBoxInGame174, 0x15EAF, 2);
                backend.updateROMText(absoluteFilename, 0x5, textBoxInGame175, 0x15EBF, 2);
                backend.updateROMText(absoluteFilename, 0xD, textBoxInGame176, 0x15EC5, 2);
                backend.updateROMText(absoluteFilename, 0xA, textBoxInGame177, 0x15ED3, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame178, 0x15EDE, 2);
                backend.updateROMText(absoluteFilename, 0x9, textBoxInGame179, 0x15EEA, 2);
                backend.updateROMText(absoluteFilename, 0x10, textBoxInGame180, 0x15EF4, 2);

                backend.updateROMText(absoluteFilename, 0xE, textBoxInGame181, 0x15F05, 2);
                backend.updateROMText(absoluteFilename, 0xB, textBoxInGame182, 0x15F14, 2);

                MessageBox.Show("Updated Text!", "The Guardian Legend Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxInGame1.MaxLength = 0xD;
            textBoxInGame2.MaxLength = 0xF;
            textBoxInGame3.MaxLength = 0xB;
            textBoxInGame4.MaxLength = 0x7;
            textBoxInGame5.MaxLength = 0x10;
            textBoxInGame6.MaxLength = 0xD;
            textBoxInGame7.MaxLength = 0xB;
            textBoxInGame8.MaxLength = 0xA;
            textBoxInGame9.MaxLength = 0x10;
            textBoxInGame10.MaxLength = 0xF;

            textBoxInGame11.MaxLength = 0xE;
            textBoxInGame12.MaxLength = 0xD;
            textBoxInGame13.MaxLength = 0xF;
            textBoxInGame14.MaxLength = 0x9;
            textBoxInGame15.MaxLength = 0x10;
            textBoxInGame16.MaxLength = 0xA;
            textBoxInGame17.MaxLength = 0x10;
            textBoxInGame18.MaxLength = 0xF;
            textBoxInGame19.MaxLength = 0xE;
            textBoxInGame20.MaxLength = 0xD;

            textBoxInGame21.MaxLength = 0xB;
            textBoxInGame22.MaxLength = 0x9;
            textBoxInGame23.MaxLength = 0x8;
            textBoxInGame24.MaxLength = 0x9;
            textBoxInGame25.MaxLength = 0xF;
            textBoxInGame26.MaxLength = 0xF;
            textBoxInGame27.MaxLength = 0x10;
            textBoxInGame28.MaxLength = 0x2;
            textBoxInGame29.MaxLength = 0xF;
            textBoxInGame30.MaxLength = 0xA;

            textBoxInGame31.MaxLength = 0x10;
            textBoxInGame32.MaxLength = 0xB;
            textBoxInGame33.MaxLength = 0xC;
            textBoxInGame34.MaxLength = 0xE;
            textBoxInGame35.MaxLength = 0xD;
            textBoxInGame36.MaxLength = 0xB;
            textBoxInGame37.MaxLength = 0xD;
            textBoxInGame38.MaxLength = 0x10;
            textBoxInGame39.MaxLength = 0xA;
            textBoxInGame40.MaxLength = 0xC;

            textBoxInGame41.MaxLength = 0xA;
            textBoxInGame42.MaxLength = 0xB;
            textBoxInGame43.MaxLength = 0xC;
            textBoxInGame44.MaxLength = 0xE;
            textBoxInGame45.MaxLength = 0x9;
            textBoxInGame46.MaxLength = 0xC;
            textBoxInGame47.MaxLength = 0xB;
            textBoxInGame48.MaxLength = 0x7;
            textBoxInGame49.MaxLength = 0xA;
            textBoxInGame50.MaxLength = 0x7;

            textBoxInGame51.MaxLength = 0xF;
            textBoxInGame52.MaxLength = 0x10;
            textBoxInGame53.MaxLength = 0x10;
            textBoxInGame54.MaxLength = 0x5;
            textBoxInGame55.MaxLength = 0xC;
            textBoxInGame56.MaxLength = 0x10;
            textBoxInGame57.MaxLength = 0xA;
            textBoxInGame58.MaxLength = 0xF;
            textBoxInGame59.MaxLength = 0xB;
            textBoxInGame60.MaxLength = 0xD;

            textBoxInGame61.MaxLength = 0x10;
            textBoxInGame62.MaxLength = 0x7;
            textBoxInGame63.MaxLength = 0xF;
            textBoxInGame64.MaxLength = 0xF;
            textBoxInGame65.MaxLength = 0x4;
            textBoxInGame66.MaxLength = 0xC;
            textBoxInGame67.MaxLength = 0xF;
            textBoxInGame68.MaxLength = 0x9;
            textBoxInGame69.MaxLength = 0xD;
            textBoxInGame70.MaxLength = 0x9;

            textBoxInGame71.MaxLength = 0x7;
            textBoxInGame72.MaxLength = 0xE;
            textBoxInGame73.MaxLength = 0xB;
            textBoxInGame74.MaxLength = 0x10;
            textBoxInGame75.MaxLength = 0xE;
            textBoxInGame76.MaxLength = 0xE;
            textBoxInGame77.MaxLength = 0xD;
            textBoxInGame78.MaxLength = 0x10;
            textBoxInGame79.MaxLength = 0x9;
            textBoxInGame80.MaxLength = 0xC;

            textBoxInGame81.MaxLength = 0xD;
            textBoxInGame82.MaxLength = 0xE;
            textBoxInGame83.MaxLength = 0xD;
            textBoxInGame84.MaxLength = 0x7;
            textBoxInGame85.MaxLength = 0xA;
            textBoxInGame86.MaxLength = 0xF;
            textBoxInGame87.MaxLength = 0xC;
            textBoxInGame88.MaxLength = 0x5;
            textBoxInGame89.MaxLength = 0xA;
            textBoxInGame90.MaxLength = 0xD;

            textBoxInGame91.MaxLength = 0xD;
            textBoxInGame92.MaxLength = 0xA;
            textBoxInGame93.MaxLength = 0xD;
            textBoxInGame94.MaxLength = 0xC;
            textBoxInGame95.MaxLength = 0xE;
            textBoxInGame96.MaxLength = 0xA;
            textBoxInGame97.MaxLength = 0xE;
            textBoxInGame98.MaxLength = 0xD;
            textBoxInGame99.MaxLength = 0x10;
            textBoxInGame100.MaxLength = 0x8;

            textBoxInGame101.MaxLength = 0xC;
            textBoxInGame102.MaxLength = 0xC;
            textBoxInGame103.MaxLength = 0xB;
            textBoxInGame104.MaxLength = 0xC;
            textBoxInGame105.MaxLength = 0x4;
            textBoxInGame106.MaxLength = 0x9;
            textBoxInGame107.MaxLength = 0x8;
            textBoxInGame108.MaxLength = 0x9;
            textBoxInGame109.MaxLength = 0xC;
            textBoxInGame110.MaxLength = 0x5;

            textBoxInGame111.MaxLength = 0xA;
            textBoxInGame112.MaxLength = 0x8;
            textBoxInGame113.MaxLength = 0xB;
            textBoxInGame114.MaxLength = 0xB;
            textBoxInGame115.MaxLength = 0xB;
            textBoxInGame116.MaxLength = 0x10;
            textBoxInGame117.MaxLength = 0xB;
            textBoxInGame118.MaxLength = 0x8;
            textBoxInGame119.MaxLength = 0x8;
            textBoxInGame120.MaxLength = 0x7;

            textBoxInGame121.MaxLength = 0xB;
            textBoxInGame122.MaxLength = 0x9;
            textBoxInGame123.MaxLength = 0x9;
            textBoxInGame124.MaxLength = 0xA;
            textBoxInGame125.MaxLength = 0xA;
            textBoxInGame126.MaxLength = 0x9;
            textBoxInGame127.MaxLength = 0xA;
            textBoxInGame128.MaxLength = 0x8;
            textBoxInGame129.MaxLength = 0x8;
            textBoxInGame130.MaxLength = 0x5;

            textBoxInGame131.MaxLength = 0x9;
            textBoxInGame132.MaxLength = 0xC;
            textBoxInGame133.MaxLength = 0xE;
            textBoxInGame134.MaxLength = 0x5;
            textBoxInGame135.MaxLength = 0xB;
            textBoxInGame136.MaxLength = 0x5;
            textBoxInGame137.MaxLength = 0xF;
            textBoxInGame138.MaxLength = 0xC;
            textBoxInGame139.MaxLength = 0xC;
            textBoxInGame140.MaxLength = 0x8;

            textBoxInGame141.MaxLength = 0xC;
            textBoxInGame142.MaxLength = 0xB;
            textBoxInGame143.MaxLength = 0xB;
            textBoxInGame144.MaxLength = 0x5;
            textBoxInGame145.MaxLength = 0x9;
            textBoxInGame146.MaxLength = 0x6;
            textBoxInGame147.MaxLength = 0xB;
            textBoxInGame148.MaxLength = 0x9;
            textBoxInGame149.MaxLength = 0xE;
            textBoxInGame150.MaxLength = 0xC;

            textBoxInGame151.MaxLength = 0xC;
            textBoxInGame152.MaxLength = 0xE;
            textBoxInGame153.MaxLength = 0x8;
            textBoxInGame154.MaxLength = 0xE;
            textBoxInGame155.MaxLength = 0xD;
            textBoxInGame156.MaxLength = 0x9;
            textBoxInGame157.MaxLength = 0xD;
            textBoxInGame158.MaxLength = 0xF;
            textBoxInGame159.MaxLength = 0x8;
            textBoxInGame160.MaxLength = 0xC;

            textBoxInGame161.MaxLength = 0xA;
            textBoxInGame162.MaxLength = 0xD;
            textBoxInGame163.MaxLength = 0x10;
            textBoxInGame164.MaxLength = 0xC;
            textBoxInGame165.MaxLength = 0xC;
            textBoxInGame166.MaxLength = 0xB;
            textBoxInGame167.MaxLength = 0xC;
            textBoxInGame168.MaxLength = 0xE;
            textBoxInGame169.MaxLength = 0xE;
            textBoxInGame170.MaxLength = 0x9;

            textBoxInGame171.MaxLength = 0x8;
            textBoxInGame172.MaxLength = 0x11;
            textBoxInGame173.MaxLength = 0xF;
            textBoxInGame174.MaxLength = 0xF;
            textBoxInGame175.MaxLength = 0x5;
            textBoxInGame176.MaxLength = 0xD;
            textBoxInGame177.MaxLength = 0xA;
            textBoxInGame178.MaxLength = 0xB;
            textBoxInGame179.MaxLength = 0x9;
            textBoxInGame180.MaxLength = 0x10;

            textBoxInGame181.MaxLength = 0xE;
            textBoxInGame182.MaxLength = 0xB;
        }

        private void FormInGameText_Load(object sender, EventArgs e) {
            setMaxLengthOfTextBoxes();
            readRomText();
        }
    }
}
