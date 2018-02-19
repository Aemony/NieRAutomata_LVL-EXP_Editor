using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NieRAutomata_LVL_EXP_Editor
{
    public partial class Form1 : Form
    {
        private string _filePath = null;
        private static int _intBlockOffset = 231196;
        private static int _intBlockLength = 4;
        private uint _intExperience = 0;
        private byte[] _byteExperience = new byte[_intBlockLength];

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenSlot_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Yes;

            if (_filePath != null)
            {
                dialogResult = MessageBox.Show("You already have a file opened. Opening another will discard all unsaved changes.\n\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }

            if (dialogResult == DialogResult.Yes)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\NieR_Automata",
                    Filter = "Save File (SlotData_#.dat)|SlotData_*.dat",
                    Title = "Open slot file"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = openFileDialog.FileName;
                    textBoxFilePath.Text = _filePath;
                    textBoxFilePath.SelectionStart = textBoxFilePath.Text.Length;

                    // Read the file
                    using (Stream stream = openFileDialog.OpenFile())
                    {
                        stream.Position = _intBlockOffset;
                        stream.Read(_byteExperience, 0, _intBlockLength);
                    }

                    _intExperience = BitConverter.ToUInt32(_byteExperience, 0);
                    textBoxExperience.Text = _intExperience.ToString();
                    comboBoxLevel.SelectedIndex = 0;

#if DEBUG
                    Console.WriteLine("Read:");
                    Console.WriteLine(BitConverter.ToString(_byteExperience));
                    Console.WriteLine(_intExperience.ToString());
#endif

                    // Enable the GUI
                    buttonSave.Enabled = true;
                    comboBoxLevel.Enabled = true;
                    textBoxExperience.Enabled = true;
                }
            }
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((string)comboBoxLevel.SelectedItem)
            {
                case "1":
                    textBoxExperience.Text = "0";
                    break;
                case "2":
                    textBoxExperience.Text = "48";
                    break;
                case "3":
                    textBoxExperience.Text = "139";
                    break;
                case "4":
                    textBoxExperience.Text = "294";
                    break;
                case "5":
                    textBoxExperience.Text = "525";
                    break;
                case "6":
                    textBoxExperience.Text = "843";
                    break;
                case "7":
                    textBoxExperience.Text = "1259";
                    break;
                case "8":
                    textBoxExperience.Text = "1782";
                    break;
                case "9":
                    textBoxExperience.Text = "2421";
                    break;
                case "10":
                    textBoxExperience.Text = "3184";
                    break;
                case "15":
                    textBoxExperience.Text = "9139";
                    break;
                case "20":
                    textBoxExperience.Text = "19309";
                    break;
                case "25":
                    textBoxExperience.Text = "34493";
                    break;
                case "30":
                    textBoxExperience.Text = "55412";
                    break;
                case "35":
                    textBoxExperience.Text = "82730";
                    break;
                case "40":
                    textBoxExperience.Text = "117070";
                    break;
                case "45":
                    textBoxExperience.Text = "159016";
                    break;
                case "50":
                    textBoxExperience.Text = "209127";
                    break;
                case "55":
                    textBoxExperience.Text = "267937";
                    break;
                case "60":
                    textBoxExperience.Text = "335956";
                    break;
                case "65":
                    textBoxExperience.Text = "413680";
                    break;
                case "70":
                    textBoxExperience.Text = "501585";
                    break;
                case "75":
                    textBoxExperience.Text = "600135";
                    break;
                case "80":
                    textBoxExperience.Text = "709780";
                    break;
                case "85":
                    textBoxExperience.Text = "830958";
                    break;
                case "90":
                    textBoxExperience.Text = "964096";
                    break;
                case "95":
                    textBoxExperience.Text = "1109612";
                    break;
                case "99":
                    textBoxExperience.Text = "1235211";
                    break;
                default:
                    textBoxExperience.Text = _intExperience.ToString();
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to save your changes to the slot file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            
            if (dialogResult == DialogResult.Yes)
            {
                uint newExperience = UInt32.Parse(textBoxExperience.Text);

                BitConverter.GetBytes(newExperience).CopyTo(_byteExperience, 0);

#if DEBUG
                Console.WriteLine("Wrote:");
                Console.WriteLine(BitConverter.ToString(_byteExperience));
#endif

                // Create a backup first
                File.Copy(_filePath, _filePath + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss.bak"));

                // Now overwrite the data
                using (Stream stream = File.Open(_filePath, FileMode.Open, FileAccess.Write))
                {
                    stream.Position = _intBlockOffset;
                    stream.Write(_byteExperience, 0, _intBlockLength);
                }
                
                MessageBox.Show("Changes were saved!", "Save complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
