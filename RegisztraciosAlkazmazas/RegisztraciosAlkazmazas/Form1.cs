using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztraciosAlkazmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialogMentes.FileOk += (senderFile, eFile) =>
             {
                 try
                 {
                     string fileName = saveFileDialogMentes.FileName;
                     using (var sw = new StreamWriter(fileName))
                     {
                         sw.WriteLine(textBoxNev.Text);
                         sw.WriteLine(dateTimePickerSzul.Text);
                         string nem;
                         if (btnFerfi.Checked)
                         {
                             nem = "férfi";
                         }
                         else
                         {
                             nem = "nő";
                         }
                         sw.WriteLine(nem);
                         sw.WriteLine(listBoxHobbik.SelectedItem);
                         sw.Close();
                     }

                 }
                 catch (IOException)
                 {

                     MessageBox.Show("Something went wrong :(((((");
                 }
             };
            openFileDialogBetoltes.FileOk += (senderFile, e) =>
             {
                 try
                 {
                     string[] sorok = File.ReadAllLines(openFileDialogBetoltes.FileName);
                     textBoxNev.Text = sorok[0];
                     dateTimePickerSzul.Text = sorok[1];
                     if (sorok[2] == "férfi")
                     {
                         btnFerfi.Checked = true;
                         btnNo.Checked = false;
                     }
                     else
                     {
                         btnNo.Checked = true;
                         btnFerfi.Checked = false;
                     }
                     string elem;
                     if (!listBoxHobbik.Items.Contains(sorok[3]))
                     {
                         listBoxHobbik.Items.Add(sorok[3]);
                         listBoxHobbik.SelectedItem = sorok[3];
                     }
                     else
                     {
                         foreach (var item in sorok)
                         {
                             if (item == sorok[3])
                             {
                                 listBoxHobbik.SelectedItem.Equals(item);
                             }
                         }
                     }
                 }
                 catch (IOException)
                 {
                     MessageBox.Show("AJAJAJAJAJAJAJAJ SIKERTELEN BETÖLTÉS!!");
                 }
             };
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (textBoxNev.Text != "" && dateTimePickerSzul.Text != "" && listBoxHobbik.SelectedIndex != -1 && (btnFerfi.Checked || btnNo.Checked))
            {
                saveFileDialogMentes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Valami nincs kitöltve!");
            }
        }

        private void buttonbetolt_Click(object sender, EventArgs e)
        {
            openFileDialogBetoltes.ShowDialog();
        }

        private void textBoxNewH_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBoxHobbik.Items.Add(textBoxNewH.Text);
                textBoxNewH.Text = "";
            }
        }

        private void buttonHozzaad_Click(object sender, EventArgs e)
        {
            listBoxHobbik.Items.Add(textBoxNewH.Text);
            textBoxNev.Text = "";
        }
    }
}
