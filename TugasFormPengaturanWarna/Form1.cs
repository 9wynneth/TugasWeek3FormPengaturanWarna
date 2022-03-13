using System;
using System.Drawing;
using System.Windows.Forms;

namespace TugasFormPengaturanWarna
{
    public partial class FormPengaturanWarna : Form
    {
        public FormPengaturanWarna()
        {
            InitializeComponent();
        }
        int fontsize = 19;
        private void btnProses_Click(object sender, EventArgs e)
        {
           
            if (textBoxInput.Text.Substring(0, 4).ToUpper().Contains("ISI:"))
            {
                lblOutput.Text = textBoxInput.Text.Substring(4);
            }

            else if (textBoxInput.Text.Contains("BESARKAN"))
            {
                lblOutput.Font = new Font("Segoe UI", fontsize + 1, FontStyle.Regular);
                fontsize += 1;
            }
            else if (textBoxInput.Text.Contains("KECILKAN"))
            {
                lblOutput.Font = new Font("Segoe UI", fontsize - 1, FontStyle.Regular);
                fontsize -= 1;
            }
            else if (textBoxInput.Text.Contains("SHOWN"))
            {
                lblOutput.Show();
            }
            else if (textBoxInput.Text.Contains("HIDE"))
            {
                lblOutput.Hide();
            }
            else if (textBoxInput.Text.Contains("WARNA:"))
            {
                if (textBoxInput.Text.Contains("MERAH"))
                {
                    lblOutput.ForeColor = Color.Red;
                }
                if (textBoxInput.Text.Contains("BIRU"))
                {
                    lblOutput.ForeColor = Color.Blue;
                }
                if (textBoxInput.Text.Contains("HIJAU"))
                {
                    lblOutput.ForeColor = Color.Green;
                }
                if (textBoxInput.Text.Contains("DEFAULT"))
                {
                    lblOutput.ForeColor = Color.Black;
                }
            }
            else if (textBoxInput.Text.Contains("RESTART"))
            {
                lblOutput.ForeColor = Color.Black;
                lblOutput.Font = new Font("Segoe UI", 18);
                lblOutput.Text = "[EMPTY]";
            }
            else //if (!textBoxInput.Text.Contains("ISI:") || !textBoxInput.Text.Contains("SHOWN") || !textBoxInput.Text.Contains("HIDE") || !textBoxInput.Text.Contains("WARNA:") || !textBoxInput.Text.Contains("RESTART"))
            {
                MessageBox.Show("Syntax tidak terdaftar!");

            }
        }

    }
}
