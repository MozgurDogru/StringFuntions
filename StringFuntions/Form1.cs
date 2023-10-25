using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFuntions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartEnd_Click(object sender, EventArgs e)
        {

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrginal_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
        }

        private void btnStartEnd_Click_1(object sender, EventArgs e)
        {
            //if (txtInput.Text.StartsWith("al"))
            //{
            //    lblOutput.Text = "al ile başlar";
            //}
            //else 
            //{
            //    lblOutput.Text = "al ile başlamaz.";
            //}

            if (txtInput.Text.EndsWith("al"))
            {
                lblOutput.Text = "al ile biter";
            }
            else
            {
                lblOutput.Text = "al ile bitmez.";
            }
        }

        private void btnSubString_Click(object sender, EventArgs e)
        {
            //lblOutput.Text = txtInput.Text.Substring(5, 3); 
            lblOutput.Text = txtInput.Text.Substring( 3); 

        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            if(txtInput.Text.Contains('l'))
            //if(txtInput.Text.Contains("al"))
            {
                lblOutput.Text = "l içerir";
            }
            else
            {
                lblOutput.Text = "l içermez";
            }
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            //lblOutput.Text=txtInput.Text.Trim();
            //lblOutput.Text = txtInput.Text.TrimStart();
            //lblOutput.Text = txtInput.Text.TrimEnd();
            //char [] array= new char[] {'*',' ','/','\\'};
            //lblOutput.Text=txtInput.Text.Trim(array);

            char[] array = new char[] { '*', ' ', '/', '\\' };
            lblOutput.Text = txtInput.Text.Trim(new char[] { '*', ' ', '/', '\\' }); 
        


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text.Insert(0, "izmir");
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            //lblOutput.Text=txtInput.Text.IndexOf("a").ToString();
            //lblOutput.Text = txtInput.Text.LastIndexOf("a").ToString();
            //lblOutput.Text = txtInput.Text.IndexOf("demi").ToString();
            lblOutput.Text = txtInput.Text.IndexOf("e",2,4).ToString();



        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text.Remove(4,4);

        }

        private void btnReplace_Click_1(object sender, EventArgs e)
        {
            //lblOutput.Text = txtInput.Text.Replace('a', 'A');
            lblOutput.Text = txtInput.Text.Replace("dem","***");


        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            char []array = txtInput.Text.Reverse().ToArray();
            foreach (var item in array)
            {
                lbxOutput.Items.Add(item);
            }
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            lblOutput.Text+= txtInput.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            lblOutput.Text+= txtInput.Text.ToLower();
        }

        private void btnToChar_Click(object sender, EventArgs e)
        {
            char[] array=txtInput.Text.ToCharArray();
            foreach (var item in array)
            {
                lbxOutput.Items.Add(item);
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            //string[] array = txtInput.Text.Split();
            string[] array = txtInput.Text.Split(new char[] { '*',' ','.'});


            lbxOutput.Items.AddRange(array);
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            txtInput.Text=txtInput.Text.ToUpper();

            char[] array = new char[] { 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
            lblOutput.Text = "";
            for (int i = 0; i <txtInput.Text.Length; i++)
            {
                if (!array.Contains(txtInput.Text[i]))
                {
                    lblOutput.Text += txtInput.Text[i];

                }
            }
        }
    }
}
