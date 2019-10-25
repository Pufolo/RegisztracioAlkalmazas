namespace RegisztraciosAlkazmazas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNev = new System.Windows.Forms.Label();
            this.labelSzulDate = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.labelhobbi = new System.Windows.Forms.Label();
            this.labelNewH = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxNewH = new System.Windows.Forms.TextBox();
            this.btnFerfi = new System.Windows.Forms.RadioButton();
            this.btnNo = new System.Windows.Forms.RadioButton();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonbetolt = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.saveFileDialogMentes = new System.Windows.Forms.SaveFileDialog();
            this.dateTimePickerSzul = new System.Windows.Forms.DateTimePicker();
            this.listBoxHobbik = new System.Windows.Forms.ListBox();
            this.openFileDialogBetoltes = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(10, 9);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(30, 13);
            this.labelNev.TabIndex = 0;
            this.labelNev.Text = "Név:";
            this.labelNev.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSzulDate
            // 
            this.labelSzulDate.AutoSize = true;
            this.labelSzulDate.Location = new System.Drawing.Point(10, 45);
            this.labelSzulDate.Name = "labelSzulDate";
            this.labelSzulDate.Size = new System.Drawing.Size(65, 13);
            this.labelSzulDate.TabIndex = 1;
            this.labelSzulDate.Text = "Szül. dátum:";
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.Location = new System.Drawing.Point(10, 80);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(32, 13);
            this.labelNem.TabIndex = 2;
            this.labelNem.Text = "Nem:";
            // 
            // labelhobbi
            // 
            this.labelhobbi.AutoSize = true;
            this.labelhobbi.Location = new System.Drawing.Point(357, 9);
            this.labelhobbi.Name = "labelhobbi";
            this.labelhobbi.Size = new System.Drawing.Size(82, 13);
            this.labelhobbi.TabIndex = 3;
            this.labelhobbi.Text = "Kedvenc hobbi:";
            this.labelhobbi.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelNewH
            // 
            this.labelNewH.AutoSize = true;
            this.labelNewH.Location = new System.Drawing.Point(308, 275);
            this.labelNewH.Name = "labelNewH";
            this.labelNewH.Size = new System.Drawing.Size(49, 13);
            this.labelNewH.TabIndex = 4;
            this.labelNewH.Text = "Új hobbi:";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(90, 6);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 6;
            // 
            // textBoxNewH
            // 
            this.textBoxNewH.Location = new System.Drawing.Point(363, 272);
            this.textBoxNewH.Name = "textBoxNewH";
            this.textBoxNewH.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewH.TabIndex = 7;
            this.textBoxNewH.TextChanged += new System.EventHandler(this.textBoxNewH_TextChanged);
            this.textBoxNewH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNewH_KeyDown);
            // 
            // btnFerfi
            // 
            this.btnFerfi.AutoSize = true;
            this.btnFerfi.Location = new System.Drawing.Point(90, 80);
            this.btnFerfi.Name = "btnFerfi";
            this.btnFerfi.Size = new System.Drawing.Size(31, 17);
            this.btnFerfi.TabIndex = 8;
            this.btnFerfi.TabStop = true;
            this.btnFerfi.Text = "F";
            this.btnFerfi.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.AutoSize = true;
            this.btnNo.Location = new System.Drawing.Point(157, 80);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(33, 17);
            this.btnNo.TabIndex = 9;
            this.btnNo.TabStop = true;
            this.btnNo.Text = "N";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(388, 309);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 11;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.buttonHozzaad_Click);
            // 
            // buttonbetolt
            // 
            this.buttonbetolt.Location = new System.Drawing.Point(388, 366);
            this.buttonbetolt.Name = "buttonbetolt";
            this.buttonbetolt.Size = new System.Drawing.Size(75, 23);
            this.buttonbetolt.TabIndex = 12;
            this.buttonbetolt.Text = "Betöltés";
            this.buttonbetolt.UseVisualStyleBackColor = true;
            this.buttonbetolt.Click += new System.EventHandler(this.buttonbetolt_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(282, 366);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 13;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // dateTimePickerSzul
            // 
            this.dateTimePickerSzul.Location = new System.Drawing.Point(90, 45);
            this.dateTimePickerSzul.Name = "dateTimePickerSzul";
            this.dateTimePickerSzul.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerSzul.TabIndex = 15;
            // 
            // listBoxHobbik
            // 
            this.listBoxHobbik.FormattingEnabled = true;
            this.listBoxHobbik.Items.AddRange(new object[] {
            "úszás ",
            "horgászat",
            "futás"});
            this.listBoxHobbik.Location = new System.Drawing.Point(343, 25);
            this.listBoxHobbik.Name = "listBoxHobbik";
            this.listBoxHobbik.Size = new System.Drawing.Size(120, 95);
            this.listBoxHobbik.TabIndex = 16;
            // 
            // openFileDialogBetoltes
            // 
            this.openFileDialogBetoltes.FileName = "openFileDialogBetoltes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(487, 401);
            this.Controls.Add(this.listBoxHobbik);
            this.Controls.Add(this.dateTimePickerSzul);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonbetolt);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnFerfi);
            this.Controls.Add(this.textBoxNewH);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.labelNewH);
            this.Controls.Add(this.labelhobbi);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelSzulDate);
            this.Controls.Add(this.labelNev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelSzulDate;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.Label labelhobbi;
        private System.Windows.Forms.Label labelNewH;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxNewH;
        private System.Windows.Forms.RadioButton btnFerfi;
        private System.Windows.Forms.RadioButton btnNo;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonbetolt;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMentes;
        private System.Windows.Forms.DateTimePicker dateTimePickerSzul;
        private System.Windows.Forms.ListBox listBoxHobbik;
        private System.Windows.Forms.OpenFileDialog openFileDialogBetoltes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

