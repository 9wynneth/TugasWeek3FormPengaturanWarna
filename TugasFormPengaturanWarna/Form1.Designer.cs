
namespace TugasFormPengaturanWarna
{
    partial class FormPengaturanWarna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblinput = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.lblFItur = new System.Windows.Forms.Label();
            this.lblIsi = new System.Windows.Forms.Label();
            this.lblShown = new System.Windows.Forms.Label();
            this.lblHide = new System.Windows.Forms.Label();
            this.labelWarna = new System.Windows.Forms.Label();
            this.lblnote = new System.Windows.Forms.Label();
            this.lblBesarkan = new System.Windows.Forms.Label();
            this.lblKecilkan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Location = new System.Drawing.Point(18, 13);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(100, 25);
            this.lblinput.TabIndex = 0;
            this.lblinput.Text = "Input Data:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("SAPGUI-Icons", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.Location = new System.Drawing.Point(22, 41);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(434, 28);
            this.textBoxInput.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(12, 179);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(152, 48);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "[EMPTY]";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(22, 109);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(112, 34);
            this.btnProses.TabIndex = 3;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // lblFItur
            // 
            this.lblFItur.AutoSize = true;
            this.lblFItur.Location = new System.Drawing.Point(534, 13);
            this.lblFItur.Name = "lblFItur";
            this.lblFItur.Size = new System.Drawing.Size(137, 25);
            this.lblFItur.TabIndex = 4;
            this.lblFItur.Text = "Fitur command:";
            // 
            // lblIsi
            // 
            this.lblIsi.AutoSize = true;
            this.lblIsi.Location = new System.Drawing.Point(534, 44);
            this.lblIsi.Name = "lblIsi";
            this.lblIsi.Size = new System.Drawing.Size(169, 25);
            this.lblIsi.TabIndex = 5;
            this.lblIsi.Text = "ISI: Untuk mencetak";
            // 
            // lblShown
            // 
            this.lblShown.AutoSize = true;
            this.lblShown.Location = new System.Drawing.Point(534, 80);
            this.lblShown.Name = "lblShown";
            this.lblShown.Size = new System.Drawing.Size(336, 25);
            this.lblShown.TabIndex = 6;
            this.lblShown.Text = "SHOWN: Untuk memperlihatkan hasilnya";
            // 
            // lblHide
            // 
            this.lblHide.AutoSize = true;
            this.lblHide.Location = new System.Drawing.Point(534, 118);
            this.lblHide.Name = "lblHide";
            this.lblHide.Size = new System.Drawing.Size(257, 25);
            this.lblHide.TabIndex = 7;
            this.lblHide.Text = "HIDE: Untuk menutupi hasilnya";
            // 
            // labelWarna
            // 
            this.labelWarna.AutoSize = true;
            this.labelWarna.Location = new System.Drawing.Point(534, 154);
            this.labelWarna.Name = "labelWarna";
            this.labelWarna.Size = new System.Drawing.Size(323, 25);
            this.labelWarna.TabIndex = 8;
            this.labelWarna.Text = "WARNA: DEFAULT/MERAH/BIRU/HIJAU";
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnote.Location = new System.Drawing.Point(540, 265);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(264, 21);
            this.lblnote.TabIndex = 9;
            this.lblnote.Text = "*Harus ada tanda : setelah command";
            // 
            // lblBesarkan
            // 
            this.lblBesarkan.AutoSize = true;
            this.lblBesarkan.Location = new System.Drawing.Point(534, 187);
            this.lblBesarkan.Name = "lblBesarkan";
            this.lblBesarkan.Size = new System.Drawing.Size(292, 25);
            this.lblBesarkan.TabIndex = 11;
            this.lblBesarkan.Text = "BESARKAN: Membesarkan font size";
            // 
            // lblKecilkan
            // 
            this.lblKecilkan.AutoSize = true;
            this.lblKecilkan.Location = new System.Drawing.Point(534, 223);
            this.lblKecilkan.Name = "lblKecilkan";
            this.lblKecilkan.Size = new System.Drawing.Size(270, 25);
            this.lblKecilkan.TabIndex = 12;
            this.lblKecilkan.Text = "KECILKAN: Mengecilkan font size";
            this.lblKecilkan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormPengaturanWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 363);
            this.Controls.Add(this.lblKecilkan);
            this.Controls.Add(this.lblBesarkan);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.labelWarna);
            this.Controls.Add(this.lblHide);
            this.Controls.Add(this.lblShown);
            this.Controls.Add(this.lblIsi);
            this.Controls.Add(this.lblFItur);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.lblinput);
            this.Name = "FormPengaturanWarna";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label lblFItur;
        private System.Windows.Forms.Label lblIsi;
        private System.Windows.Forms.Label lblShown;
        private System.Windows.Forms.Label lblHide;
        private System.Windows.Forms.Label labelWarna;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.Label lblBesarkan;
        private System.Windows.Forms.Label lblKecilkan;
    }
}

