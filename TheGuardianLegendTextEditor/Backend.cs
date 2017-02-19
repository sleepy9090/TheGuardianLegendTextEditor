using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford 2016
 */
namespace TheGuardianLegendTextEditor {
    class Backend {

        int textFlag = 0;

        public void getText(string path, TextBox texboxname, int length, int offset, int tableNumber) {

            string romCodeString = "";
            string ddAsciiOut = "";
            string tempHexString = "";
            int x = 0;
            using (FileStream fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read)) {
                fileStream.Seek(offset, SeekOrigin.Begin);

                while (x < length) {
                    romCodeString = fileStream.ReadByte().ToString("X");
                    //if length is single digit add a 0 ( 1 now is 01)
                    if (romCodeString.Length == 1) {
                        romCodeString = "0" + romCodeString;
                    }
                    tempHexString = romCodeString;

                    if (tableNumber == 0) {
                        decodeRomText(tempHexString);
                    } else if (tableNumber == 1) {
                        decodeRomText2(tempHexString);
                    } else if (tableNumber == 2) {
                        decodeRomText3(tempHexString);
                    } else {
                        decodeRomText(tempHexString);
                    }

                    if (textFlag == 0) {
                        if (tableNumber == 0) {
                            ddAsciiOut += decodeRomText(tempHexString);
                        } else if (tableNumber == 1) {
                            ddAsciiOut += decodeRomText2(tempHexString);
                        } else if (tableNumber == 2) {
                            ddAsciiOut += decodeRomText3(tempHexString);
                        } else {
                            decodeRomText(tempHexString);
                        }
                    }
                    x++;
                }

                // Build and append
                texboxname.Text += ddAsciiOut;
            }

        }

        public void updateROMText(string absoluteFilename, int length, TextBox textBox, int offset, int tableNumber) {

            string newGLString = textBox.Text;

            newGLString = newGLString.PadRight(length);
            string hexReturn = "";
            string tempascii = "";
            string[] newGLStringArray = new string[length];
            byte[] newGLStringByteArray = new byte[length];
            int[] glDecimal = new int[length];
            string[] glFinal = new string[length];
            string[] gls = new string[length];

            int x = 0;
            while (x < length) {
                newGLStringArray[x] = newGLString[x].ToString();
                tempascii = newGLStringArray[x];
                if (tableNumber == 0) {
                    hexReturn += encodeRomText(tempascii);
                } else if (tableNumber == 1) {
                    hexReturn += encodeRomText2(tempascii);
                } else if (tableNumber == 2) {
                    hexReturn += encodeRomText3(tempascii);
                } else {
                    hexReturn += encodeRomText(tempascii);
                }
                x++;
            }

            int i = 0;
            int j = 0;
            while (i < length) {
                gls[i] = hexReturn[j].ToString() + hexReturn[j + 1].ToString();
                i++;
                j += 2;
            }

            int q = 0;
            while (q < length) {
                glDecimal[q] = int.Parse(gls[q], System.Globalization.NumberStyles.HexNumber);
                glFinal[q] = glDecimal[q].ToString();
                newGLStringByteArray[q] = byte.Parse(glFinal[q]);
                q++;
            }

            using (FileStream fileStream = new FileStream(@absoluteFilename, FileMode.Open, FileAccess.Write)) {
                fileStream.Seek(offset, SeekOrigin.Begin);
                q = 0;
                while (q < length) {
                    fileStream.WriteByte(newGLStringByteArray[q]);
                    q++;
                }
            }
        }

        private string decodeRomText(string tempHexString) {
            string glAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "20":
                    glAscii += " ";
                    break;
                case "2D":
                    glAscii += "-";
                    break;
                case "30":
                    glAscii += "0";
                    break;
                case "31":
                    glAscii += "1";
                    break;
                case "32":
                    glAscii += "2";
                    break;
                case "33":
                    glAscii += "3";
                    break;
                case "34":
                    glAscii += "4";
                    break;
                case "35":
                    glAscii += "5";
                    break;
                case "36":
                    glAscii += "6";
                    break;
                case "37":
                    glAscii += "7";
                    break;
                case "38":
                    glAscii += "8";
                    break;
                case "39":
                    glAscii += "9";
                    break;
                //case "3A":
                //    glAscii += ""; // this is the heart shape
                //    break;
                case "3B":
                    glAscii += ";";
                    break;
                case "3C":
                    glAscii += ",";
                    break;
                case "3D":
                    glAscii += "-";
                    break;
                case "3F":
                    glAscii += "?";
                    break;
                case "40":
                    glAscii += "©";
                    break;
                case "41":
                    glAscii += "A";
                    break;
                case "42":
                    glAscii += "B";
                    break;
                case "43":
                    glAscii += "C";
                    break;
                case "44":
                    glAscii += "D";
                    break;
                case "45":
                    glAscii += "E";
                    break;
                case "46":
                    glAscii += "F";
                    break;
                case "47":
                    glAscii += "G";
                    break;
                case "48":
                    glAscii += "H";
                    break;
                case "49":
                    glAscii += "I";
                    break;
                case "4A":
                    glAscii += "J";
                    break;
                case "4B":
                    glAscii += "K";
                    break;
                case "4C":
                    glAscii += "L";
                    break;
                case "4D":
                    glAscii += "M";
                    break;
                case "4E":
                    glAscii += "N";
                    break;
                case "4F":
                    glAscii += "O";
                    break;
                case "50":
                    glAscii += "P";
                    break;
                case "51":
                    glAscii += "Q";
                    break;
                case "52":
                    glAscii += "R";
                    break;
                case "53":
                    glAscii += "S";
                    break;
                case "54":
                    glAscii += "T";
                    break;
                case "55":
                    glAscii += "U";
                    break;
                case "56":
                    glAscii += "V";
                    break;
                case "57":
                    glAscii += "W";
                    break;
                case "58":
                    glAscii += "X";
                    break;
                case "59":
                    glAscii += "Y";
                    break;
                case "5A":
                    glAscii += "Z";
                    break;
                case "5B":
                    glAscii += ".";
                    break;
                case "5C":
                    glAscii += ",";
                    break;
                case "5D":
                    glAscii += "-";
                    break;
                case "5E":
                    glAscii += "^"; // Fancy M
                    break;
                case "61":
                    glAscii += "a";
                    break;
                case "62":
                    glAscii += "b";
                    break;
                case "63":
                    glAscii += "c";
                    break;
                case "64":
                    glAscii += "d";
                    break;
                case "65":
                    glAscii += "e";
                    break;
                case "66":
                    glAscii += "f";
                    break;
                case "67":
                    glAscii += "g";
                    break;
                case "68":
                    glAscii += "h";
                    break;
                case "69":
                    glAscii += "i";
                    break;
                case "6A":
                    glAscii += "j";
                    break;
                case "6B":
                    glAscii += "k";
                    break;
                case "6C":
                    glAscii += "l";
                    break;
                case "6D":
                    glAscii += "m";
                    break;
                case "6E":
                    glAscii += "n";
                    break;
                case "6F":
                    glAscii += "o";
                    break;
                case "70":
                    glAscii += "p";
                    break;
                case "71":
                    glAscii += "q";
                    break;
                case "72":
                    glAscii += "r";
                    break;
                case "73":
                    glAscii += "s";
                    break;
                case "74":
                    glAscii += "t";
                    break;
                case "75":
                    glAscii += "u";
                    break;
                case "76":
                    glAscii += "v";
                    break;
                case "77":
                    glAscii += "w";
                    break;
                case "78":
                    glAscii += "x";
                    break;
                case "79":
                    glAscii += "y";
                    break;
                case "7A":
                    glAscii += "z";
                    break;
                default:
                    glAscii += " ";
                    textFlag = 1;
                    break;
            }

            return glAscii;
        }

        private string decodeRomText2(string tempHexString) {
            string glAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "20":
                    glAscii += " ";
                    break;
                case "30":
                    glAscii += "0";
                    break;
                case "31":
                    glAscii += "1";
                    break;
                case "32":
                    glAscii += "2";
                    break;
                case "33":
                    glAscii += "3";
                    break;
                case "34":
                    glAscii += "4";
                    break;
                case "35":
                    glAscii += "5";
                    break;
                case "36":
                    glAscii += "6";
                    break;
                case "37":
                    glAscii += "7";
                    break;
                case "38":
                    glAscii += "8";
                    break;
                case "39":
                    glAscii += "9";
                    break;
                //case "3A":
                //    glAscii += ""; // this is the heart shape
                //    break;
                case "3B":
                    glAscii += ";";
                    break;
                case "3C":
                    glAscii += ",";
                    break;
                case "3D":
                    glAscii += "-";
                    break;
                case "3F":
                    glAscii += "?";
                    break;
                case "40":
                    glAscii += "©";
                    break;
                case "41":
                    glAscii += "A";
                    break;
                case "42":
                    glAscii += "B";
                    break;
                case "43":
                    glAscii += "C";
                    break;
                case "44":
                    glAscii += "D";
                    break;
                case "45":
                    glAscii += "E";
                    break;
                case "46":
                    glAscii += "F";
                    break;
                case "47":
                    glAscii += "G";
                    break;
                case "48":
                    glAscii += "H";
                    break;
                case "49":
                    glAscii += "I";
                    break;
                case "4A":
                    glAscii += "J";
                    break;
                case "4B":
                    glAscii += "K";
                    break;
                case "4C":
                    glAscii += "L";
                    break;
                case "4D":
                    glAscii += "M";
                    break;
                case "4E":
                    glAscii += "N";
                    break;
                case "4F":
                    glAscii += "O";
                    break;
                case "50":
                    glAscii += "P";
                    break;
                case "51":
                    glAscii += "Q";
                    break;
                case "52":
                    glAscii += "R";
                    break;
                case "53":
                    glAscii += "S";
                    break;
                case "54":
                    glAscii += "T";
                    break;
                case "55":
                    glAscii += "U";
                    break;
                case "56":
                    glAscii += "V";
                    break;
                case "57":
                    glAscii += "W";
                    break;
                case "58":
                    glAscii += "X";
                    break;
                case "59":
                    glAscii += "Y";
                    break;
                case "5A":
                    glAscii += "Z";
                    break;
                case "5B":
                    glAscii += ".";
                    break;
                case "5C":
                    glAscii += ",";
                    break;
                case "5D":
                    glAscii += "-";
                    break;
                case "5E":
                    glAscii += "^"; // Fancy M
                    break;
                case "80":
                    glAscii += "`";
                    break;
                case "81":
                    glAscii += "a";
                    break;
                case "82":
                    glAscii += "b";
                    break;
                case "83":
                    glAscii += "c";
                    break;
                case "84":
                    glAscii += "d";
                    break;
                case "85":
                    glAscii += "e";
                    break;
                case "86":
                    glAscii += "f";
                    break;
                case "87":
                    glAscii += "g";
                    break;
                case "88":
                    glAscii += "h";
                    break;
                case "89":
                    glAscii += "i";
                    break;
                case "8A":
                    glAscii += "j";
                    break;
                case "8B":
                    glAscii += "k";
                    break;
                case "8C":
                    glAscii += "l";
                    break;
                case "8D":
                    glAscii += "m";
                    break;
                case "8E":
                    glAscii += "n";
                    break;
                case "8F":
                    glAscii += "o";
                    break;
                case "90":
                    glAscii += "p";
                    break;
                case "91":
                    glAscii += "q";
                    break;
                case "92":
                    glAscii += "r";
                    break;
                case "93":
                    glAscii += "s";
                    break;
                case "94":
                    glAscii += "t";
                    break;
                case "95":
                    glAscii += "u";
                    break;
                case "96":
                    glAscii += "v";
                    break;
                case "97":
                    glAscii += "w";
                    break;
                case "98":
                    glAscii += "x";
                    break;
                case "99":
                    glAscii += "y";
                    break;
                case "9A":
                    glAscii += "z";
                    break;
                case "9B":
                    glAscii += "!";
                    break;
                case "9C":
                    glAscii += "?";
                    break;
                default:
                    glAscii += " ";
                    textFlag = 1;
                    break;
            }

            return glAscii;
        }

        private string decodeRomText3(string tempHexString) {
            string glAscii = "";
            textFlag = 0;

            switch (tempHexString) {
                case "20":
                    glAscii += " ";
                    break;
                case "30":
                    glAscii += "0";
                    break;
                case "31":
                    glAscii += "1";
                    break;
                case "32":
                    glAscii += "2";
                    break;
                case "33":
                    glAscii += "3";
                    break;
                case "34":
                    glAscii += "4";
                    break;
                case "35":
                    glAscii += "5";
                    break;
                case "36":
                    glAscii += "6";
                    break;
                case "37":
                    glAscii += "7";
                    break;
                case "38":
                    glAscii += "8";
                    break;
                case "39":
                    glAscii += "9";
                    break;
                //case "3A":
                //    glAscii += ""; // this is the heart shape
                //    break;
                case "3B":
                    glAscii += ";";
                    break;
                case "3C":
                    glAscii += ",";
                    break;
                case "3D":
                    glAscii += "-";
                    break;
                case "3F":
                    glAscii += "?";
                    break;
                case "40":
                    glAscii += "©";
                    break;
                case "41":
                    glAscii += "A";
                    break;
                case "42":
                    glAscii += "B";
                    break;
                case "43":
                    glAscii += "C";
                    break;
                case "44":
                    glAscii += "D";
                    break;
                case "45":
                    glAscii += "E";
                    break;
                case "46":
                    glAscii += "F";
                    break;
                case "47":
                    glAscii += "G";
                    break;
                case "48":
                    glAscii += "H";
                    break;
                case "49":
                    glAscii += "I";
                    break;
                case "4A":
                    glAscii += "J";
                    break;
                case "4B":
                    glAscii += "K";
                    break;
                case "4C":
                    glAscii += "L";
                    break;
                case "4D":
                    glAscii += "M";
                    break;
                case "4E":
                    glAscii += "N";
                    break;
                case "4F":
                    glAscii += "O";
                    break;
                case "50":
                    glAscii += "P";
                    break;
                case "51":
                    glAscii += "Q";
                    break;
                case "52":
                    glAscii += "R";
                    break;
                case "53":
                    glAscii += "S";
                    break;
                case "54":
                    glAscii += "T";
                    break;
                case "55":
                    glAscii += "U";
                    break;
                case "56":
                    glAscii += "V";
                    break;
                case "57":
                    glAscii += "W";
                    break;
                case "58":
                    glAscii += "X";
                    break;
                case "59":
                    glAscii += "Y";
                    break;
                case "5A":
                    glAscii += "Z";
                    break;
                case "5B":
                    glAscii += ".";
                    break;
                case "5C":
                    glAscii += ",";
                    break;
                case "5D":
                    glAscii += "-";
                    break;
                case "5E":
                    glAscii += "\"";
                    break;
                case "61":
                    glAscii += "a";
                    break;
                case "62":
                    glAscii += "b";
                    break;
                case "63":
                    glAscii += "c";
                    break;
                case "64":
                    glAscii += "d";
                    break;
                case "65":
                    glAscii += "e";
                    break;
                case "66":
                    glAscii += "f";
                    break;
                case "67":
                    glAscii += "g";
                    break;
                case "68":
                    glAscii += "h";
                    break;
                case "69":
                    glAscii += "i";
                    break;
                case "6A":
                    glAscii += "j";
                    break;
                case "6B":
                    glAscii += "k";
                    break;
                case "6C":
                    glAscii += "l";
                    break;
                case "6D":
                    glAscii += "m";
                    break;
                case "6E":
                    glAscii += "n";
                    break;
                case "6F":
                    glAscii += "o";
                    break;
                case "70":
                    glAscii += "p";
                    break;
                case "71":
                    glAscii += "q";
                    break;
                case "72":
                    glAscii += "r";
                    break;
                case "73":
                    glAscii += "s";
                    break;
                case "74":
                    glAscii += "t";
                    break;
                case "75":
                    glAscii += "u";
                    break;
                case "76":
                    glAscii += "v";
                    break;
                case "77":
                    glAscii += "w";
                    break;
                case "78":
                    glAscii += "x";
                    break;
                case "79":
                    glAscii += "y";
                    break;
                case "7A":
                    glAscii += "z";
                    break;
                default:
                    glAscii += " ";
                    textFlag = 1;
                    break;
            }

            return glAscii;
        }

        public string encodeRomText(string tempascii) {
            string glHex = "";

            switch (tempascii) {
                case " ":
                    glHex += "20";
                    break;
                case "0":
                    glHex += "30";
                    break;
                case "1":
                    glHex += "31";
                    break;
                case "2":
                    glHex += "32";
                    break;
                case "3":
                    glHex += "33";
                    break;
                case "4":
                    glHex += "34";
                    break;
                case "5":
                    glHex += "35";
                    break;
                case "6":
                    glHex += "36";
                    break;
                case "7":
                    glHex += "37";
                    break;
                case "8":
                    glHex += "38";
                    break;
                case "9":
                    glHex += "39";
                    break;
                case ";":
                    glHex += "3B";
                    break;
                case ",":
                    glHex += "3C";
                    break;
                case "-":
                    glHex += "3D";
                    break;
                case "?":
                    glHex += "3F";
                    break;
                case "©":
                    glHex += "40";
                    break;
                case "A":
                    glHex += "41";
                    break;
                case "B":
                    glHex += "42";
                    break;
                case "C":
                    glHex += "43";
                    break;
                case "D":
                    glHex += "44";
                    break;
                case "E":
                    glHex += "45";
                    break;
                case "F":
                    glHex += "46";
                    break;
                case "G":
                    glHex += "47";
                    break;
                case "H":
                    glHex += "48";
                    break;
                case "I":
                    glHex += "49";
                    break;
                case "J":
                    glHex += "4A";
                    break;
                case "K":
                    glHex += "4B";
                    break;
                case "L":
                    glHex += "4C";
                    break;
                case "M":
                    glHex += "4D";
                    break;
                case "N":
                    glHex += "4E";
                    break;
                case "O":
                    glHex += "4F";
                    break;
                case "P":
                    glHex += "50";
                    break;
                case "Q":
                    glHex += "51";
                    break;
                case "R":
                    glHex += "52";
                    break;
                case "S":
                    glHex += "53";
                    break;
                case "T":
                    glHex += "54";
                    break;
                case "U":
                    glHex += "55";
                    break;
                case "V":
                    glHex += "56";
                    break;
                case "W":
                    glHex += "57";
                    break;
                case "X":
                    glHex += "58";
                    break;
                case "Y":
                    glHex += "59";
                    break;
                case "Z":
                    glHex += "5A";
                    break;
                case ".":
                    glHex += "5B";
                    break;
                //case ",":
                //    glHex += "5C";
                //    break;
                //case "-":
                //    // or 2D
                //    glHex += "5D";
                //    break;
                case "^":
                    glHex += "5E";
                    break;
                case "a":
                    glHex += "61";
                    break;
                case "b":
                    glHex += "62";
                    break;
                case "c":
                    glHex += "63";
                    break;
                case "d":
                    glHex += "64";
                    break;
                case "e":
                    glHex += "65";
                    break;
                case "f":
                    glHex += "66";
                    break;
                case "g":
                    glHex += "67";
                    break;
                case "h":
                    glHex += "68";
                    break;
                case "i":
                    glHex += "69";
                    break;
                case "j":
                    glHex += "6A";
                    break;
                case "k":
                    glHex += "6B";
                    break;
                case "l":
                    glHex += "6C";
                    break;
                case "m":
                    glHex += "6D";
                    break;
                case "n":
                    glHex += "6E";
                    break;
                case "o":
                    glHex += "6F";
                    break;
                case "p":
                    glHex += "70";
                    break;
                case "q":
                    glHex += "71";
                    break;
                case "r":
                    glHex += "72";
                    break;
                case "s":
                    glHex += "73";
                    break;
                case "t":
                    glHex += "74";
                    break;
                case "u":
                    glHex += "75";
                    break;
                case "v":
                    glHex += "76";
                    break;
                case "w":
                    glHex += "77";
                    break;
                case "x":
                    glHex += "78";
                    break;
                case "y":
                    glHex += "79";
                    break;
                case "z":
                    glHex += "7A";
                    break;
                default:
                    glHex += "20";
                    break;
            }

            return glHex;
        }

        public string encodeRomText2(string tempascii) {
            string glHex = "";

            switch (tempascii) {
                case " ":
                    glHex += "20";
                    break;
                case "0":
                    glHex += "30";
                    break;
                case "1":
                    glHex += "31";
                    break;
                case "2":
                    glHex += "32";
                    break;
                case "3":
                    glHex += "33";
                    break;
                case "4":
                    glHex += "34";
                    break;
                case "5":
                    glHex += "35";
                    break;
                case "6":
                    glHex += "36";
                    break;
                case "7":
                    glHex += "37";
                    break;
                case "8":
                    glHex += "38";
                    break;
                case "9":
                    glHex += "39";
                    break;
                case ";":
                    glHex += "3B";
                    break;
                case ",":
                    glHex += "3C";
                    break;
                case "-":
                    glHex += "3D";
                    break;
                case "?":
                    glHex += "3F";
                    break;
                case "©":
                    glHex += "40";
                    break;
                case "A":
                    glHex += "41";
                    break;
                case "B":
                    glHex += "42";
                    break;
                case "C":
                    glHex += "43";
                    break;
                case "D":
                    glHex += "44";
                    break;
                case "E":
                    glHex += "45";
                    break;
                case "F":
                    glHex += "46";
                    break;
                case "G":
                    glHex += "47";
                    break;
                case "H":
                    glHex += "48";
                    break;
                case "I":
                    glHex += "49";
                    break;
                case "J":
                    glHex += "4A";
                    break;
                case "K":
                    glHex += "4B";
                    break;
                case "L":
                    glHex += "4C";
                    break;
                case "M":
                    glHex += "4D";
                    break;
                case "N":
                    glHex += "4E";
                    break;
                case "O":
                    glHex += "4F";
                    break;
                case "P":
                    glHex += "50";
                    break;
                case "Q":
                    glHex += "51";
                    break;
                case "R":
                    glHex += "52";
                    break;
                case "S":
                    glHex += "53";
                    break;
                case "T":
                    glHex += "54";
                    break;
                case "U":
                    glHex += "55";
                    break;
                case "V":
                    glHex += "56";
                    break;
                case "W":
                    glHex += "57";
                    break;
                case "X":
                    glHex += "58";
                    break;
                case "Y":
                    glHex += "59";
                    break;
                case "Z":
                    glHex += "5A";
                    break;
                case ".":
                    glHex += "5B";
                    break;
                //case ",":
                //    glHex += "5C";
                //    break;
                //case "-":
                //    // or 2D
                //    glHex += "5D";
                //    break;
                case "^":
                    glHex += "5E";
                    break;
                case "`":
                case "'":
                    glHex += "80";
                    break;
                case "a":
                    glHex += "81";
                    break;
                case "b":
                    glHex += "82";
                    break;
                case "c":
                    glHex += "83";
                    break;
                case "d":
                    glHex += "84";
                    break;
                case "e":
                    glHex += "85";
                    break;
                case "f":
                    glHex += "86";
                    break;
                case "g":
                    glHex += "87";
                    break;
                case "h":
                    glHex += "88";
                    break;
                case "i":
                    glHex += "89";
                    break;
                case "j":
                    glHex += "8A";
                    break;
                case "k":
                    glHex += "8B";
                    break;
                case "l":
                    glHex += "8C";
                    break;
                case "m":
                    glHex += "8D";
                    break;
                case "n":
                    glHex += "8E";
                    break;
                case "o":
                    glHex += "8F";
                    break;
                case "p":
                    glHex += "90";
                    break;
                case "q":
                    glHex += "91";
                    break;
                case "r":
                    glHex += "92";
                    break;
                case "s":
                    glHex += "93";
                    break;
                case "t":
                    glHex += "94";
                    break;
                case "u":
                    glHex += "95";
                    break;
                case "v":
                    glHex += "96";
                    break;
                case "w":
                    glHex += "97";
                    break;
                case "x":
                    glHex += "98";
                    break;
                case "y":
                    glHex += "99";
                    break;
                case "z":
                    glHex += "9A";
                    break;
                case "!":
                    glHex += "9B";
                    break;
                //case "?":
                //    glHex += "9C";
                //    break;
                default:
                    glHex += "20";
                    break;
            }

            return glHex;
        }

        public string encodeRomText3(string tempascii) {
            string glHex = "";

            switch (tempascii) {
                case " ":
                    glHex += "20";
                    break;
                case "0":
                    glHex += "30";
                    break;
                case "1":
                    glHex += "31";
                    break;
                case "2":
                    glHex += "32";
                    break;
                case "3":
                    glHex += "33";
                    break;
                case "4":
                    glHex += "34";
                    break;
                case "5":
                    glHex += "35";
                    break;
                case "6":
                    glHex += "36";
                    break;
                case "7":
                    glHex += "37";
                    break;
                case "8":
                    glHex += "38";
                    break;
                case "9":
                    glHex += "39";
                    break;
                case ";":
                    glHex += "3B";
                    break;
                case ",":
                    glHex += "3C";
                    break;
                case "-":
                    glHex += "3D";
                    break;
                case "?":
                    glHex += "3F";
                    break;
                case "©":
                    glHex += "40";
                    break;
                case "A":
                    glHex += "41";
                    break;
                case "B":
                    glHex += "42";
                    break;
                case "C":
                    glHex += "43";
                    break;
                case "D":
                    glHex += "44";
                    break;
                case "E":
                    glHex += "45";
                    break;
                case "F":
                    glHex += "46";
                    break;
                case "G":
                    glHex += "47";
                    break;
                case "H":
                    glHex += "48";
                    break;
                case "I":
                    glHex += "49";
                    break;
                case "J":
                    glHex += "4A";
                    break;
                case "K":
                    glHex += "4B";
                    break;
                case "L":
                    glHex += "4C";
                    break;
                case "M":
                    glHex += "4D";
                    break;
                case "N":
                    glHex += "4E";
                    break;
                case "O":
                    glHex += "4F";
                    break;
                case "P":
                    glHex += "50";
                    break;
                case "Q":
                    glHex += "51";
                    break;
                case "R":
                    glHex += "52";
                    break;
                case "S":
                    glHex += "53";
                    break;
                case "T":
                    glHex += "54";
                    break;
                case "U":
                    glHex += "55";
                    break;
                case "V":
                    glHex += "56";
                    break;
                case "W":
                    glHex += "57";
                    break;
                case "X":
                    glHex += "58";
                    break;
                case "Y":
                    glHex += "59";
                    break;
                case "Z":
                    glHex += "5A";
                    break;
                case ".":
                    glHex += "5B";
                    break;
                //case ",":
                //    glHex += "5C";
                //    break;
                //case "-":
                //    // or 2D
                //    glHex += "5D";
                //    break;
                case "\"":
                    glHex += "5E";
                    break;
                case "a":
                    glHex += "61";
                    break;
                case "b":
                    glHex += "62";
                    break;
                case "c":
                    glHex += "63";
                    break;
                case "d":
                    glHex += "64";
                    break;
                case "e":
                    glHex += "65";
                    break;
                case "f":
                    glHex += "66";
                    break;
                case "g":
                    glHex += "67";
                    break;
                case "h":
                    glHex += "68";
                    break;
                case "i":
                    glHex += "69";
                    break;
                case "j":
                    glHex += "6A";
                    break;
                case "k":
                    glHex += "6B";
                    break;
                case "l":
                    glHex += "6C";
                    break;
                case "m":
                    glHex += "6D";
                    break;
                case "n":
                    glHex += "6E";
                    break;
                case "o":
                    glHex += "6F";
                    break;
                case "p":
                    glHex += "70";
                    break;
                case "q":
                    glHex += "71";
                    break;
                case "r":
                    glHex += "72";
                    break;
                case "s":
                    glHex += "73";
                    break;
                case "t":
                    glHex += "74";
                    break;
                case "u":
                    glHex += "75";
                    break;
                case "v":
                    glHex += "76";
                    break;
                case "w":
                    glHex += "77";
                    break;
                case "x":
                    glHex += "78";
                    break;
                case "y":
                    glHex += "79";
                    break;
                case "z":
                    glHex += "7A";
                    break;
                default:
                    glHex += "20";
                    break;
            }

            return glHex;
        }
    }
}
