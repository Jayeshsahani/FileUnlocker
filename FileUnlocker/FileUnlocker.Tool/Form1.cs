using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileUnlocker.Tool
{
    public partial class MainForm : Form
    {
        private string character = string.Empty;
        List<string> keyWordslists = new List<string>();
        List<string> temp = new List<string>();
        long length = 0;
        char[] charArray;

        private char[] GetArray() => this.character.ToCharArray();

        private char GetFirstChar() => this.GetArray()[0];

        private List<string> WordIncrement(List<string> words, char[] charArray)
        {
            List<string> temp = new List<string>();
            foreach (string word in words)
            {
                foreach (var charaters in charArray)
                {
                    temp.Add(word + charaters);
                }
            }
            return temp;
        }


        public MainForm()
        {
            InitializeComponent();
            txtmin.Value = 8;
            txtmax.Value = 8;
        }

        private void opfd_FileOk(object sender, CancelEventArgs e)
        {
            txtfilepath.Text = opfd.FileName;
        }

        private void btnfileopen_Click(object sender, EventArgs e)
        {
            opfd.ShowDialog();
        }

        public async Task Run()
        {
            long minvalue = Convert.ToInt64(txtmin.Value) > 0 ? Convert.ToInt64(txtmin.Value) - 1 : 0;
            string startText = txtstarttext.Text;
            if (startText.Length < minvalue)
            {
                long startIndex = minvalue - startText.Length;
                for (int i = 0; i < startIndex; i++)
                {
                    startText += GetFirstChar();
                }
            }
            length = startText.Length;
            foreach (var first in charArray)
            {
                keyWordslists.Add(startText + first.ToString());
            }
            length++;
            temp = keyWordslists.Join(temp);
            bool isStop = false;
            foreach (var singlecharPassword in temp)
            {

                rtb.AppendText("\r\n" + singlecharPassword);
                rtb.ScrollToCaret();
                if (isValidPassword(singlecharPassword))
                {
                    isStop = true;
                    break;
                }

            }

            while (!isStop && length <= Convert.ToInt64(txtmax.Value))
            {
                temp = WordIncrement(temp, charArray);
                foreach (var password in temp)
                {
                    rtb.AppendText("\r\n" + password);
                    rtb.ScrollToCaret();
                    if (isValidPassword(password))
                    {
                        isStop = true;
                        break;
                    }
                }
                length++;

            }
        }
        public bool isValidPassword(string password)
        {

            try
            {
                PdfReader reader = new PdfReader(txtfilepath.Text, new System.Text.ASCIIEncoding().GetBytes(password));
                if (reader != null)
                {
                    rtb.AppendText("\r\n Your Password is " + password);
                    rtb.ScrollToCaret();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < chkPattern.Items.Count; i++)
            {
                if (chkPattern.GetItemChecked(i))
                {
                    str += chkPattern.Items[i];
                }
            }
            if (!string.IsNullOrEmpty(str))
            {
                character = str;
                charArray = GetArray();
                await this.Run();
            }
            else
            {
                MessageBox.Show("Please select pattern");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
