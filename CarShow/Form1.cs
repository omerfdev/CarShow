using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CarShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Araba> secilenAraba = new List<Araba>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Böyle de yapılabilir...
            //comboBoxAracTuru.Items.AddRange(System.Enum.GetNames(typeof(AracTuru)));
            //comboBoxAracMarka.Items.AddRange(System.Enum.GetNames(typeof(Marka)));
            //comboBoxAracModel.Items.AddRange(System.Enum.GetNames(typeof(Model)));
            //comboBoxSanzimanTuru.Items.AddRange(System.Enum.GetNames(typeof(SanzimanTuru)));
            //comboBoxYakitTuru.Items.AddRange(System.Enum.GetNames(typeof(YakitTuru)));
            //comboBoxKasaTipi.Items.AddRange(System.Enum.GetNames(typeof(KasaTipi)));
            nmrcUpDownAracHP.Value = 1000;
            nmrcUpDownAracModel.Value = 2005;
            AracTuru[] aracTurleri = (AracTuru[])Enum.GetValues(typeof(AracTuru));
            cmbBoxAracTuru.DataSource = aracTurleri;
            KasaTipi[] kasaTipleri = (KasaTipi[])Enum.GetValues(typeof(KasaTipi));
            cmbBoxKasaTipi.DataSource = kasaTipleri;
            Marka[] markalar = (Marka[])Enum.GetValues(typeof(Marka));
            cmbBoxAracMarka.DataSource = markalar;
            SanzimanTuru[] sanzimanTurleri = (SanzimanTuru[])Enum.GetValues(typeof(SanzimanTuru));
            cmbBoxSanzimanTuru.DataSource = sanzimanTurleri;
            YakitTuru[] yakitTurleri = (YakitTuru[])Enum.GetValues(typeof(YakitTuru));
            cmbBoxYakitTuru.DataSource = yakitTurleri;
            Model[] modeller = (Model[])Enum.GetValues(typeof(Model));
            cmbBoxAracModel.DataSource = modeller;


            string path = @"C:\Users\omerf\source\repos\CarShow\CarShow\Image\AllCar\";
            foreach (string image in Directory.GetFiles(path))
            {
                PictureBox picture = new PictureBox();
                picture.ImageLocation = image;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Width = 150;
                picture.Height = 100;
                picture.Click += Picture_Click;
                flwPanelAraba.Controls.Add(picture);

            }

        }

        private void Picture_Click(object? sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(((PictureBox)sender).ImageLocation);
            MessageBox.Show(fi.Name);

            // flowLayoutPanel1.Controls.Remove(((PictureBox)sender));
        }

        private void buttonAracRenk_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                labelColor.BackColor = selectedColor;
            }
        }

        private void buttonAracResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Resim Seç";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                btnArabaResim.BackgroundImage = Image.FromFile(selectedFilePath);
                pcBoxAracResim.Image = Image.FromFile(selectedFilePath);
            }

        }

        public void buttonOlustur_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba
            {
                arabaTuru = (AracTuru)cmbBoxAracTuru.SelectedItem,
                arabaKasaTipi = (KasaTipi)cmbBoxKasaTipi.SelectedItem,
                arabaMarka = (Marka)cmbBoxAracMarka.SelectedItem,
                arabaModel = (Model)cmbBoxAracModel.SelectedItem,
                arabaSanzimanTuru = (SanzimanTuru)cmbBoxSanzimanTuru.SelectedItem,
                arabaYakitTuru = (YakitTuru)cmbBoxYakitTuru.SelectedItem,
                ModelYili = ((short)nmrcUpDownAracModel.Value),
                MotorGucu = (short)nmrcUpDownAracHP.Value,
                Garanti = lblGarantiDurumu.Text,
                aracınRengi = labelColor.BackColor,
                arabaResim = btnArabaResim.BackgroundImage,

            };

            pcBoxAracResim.Image = araba.arabaResim;
            secilenAraba.Add(araba);
            araba.ToString();
            lstBoxAraba.DataSource = null;
            lstBoxAraba.DataSource = secilenAraba;
            Clear();
        }
        public void Clear()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case ComboBox:
                        cmbBoxAracTuru.SelectedIndex = -1;
                        cmbBoxKasaTipi.SelectedIndex = -1;
                        cmbBoxAracMarka.SelectedIndex = -1;
                        cmbBoxYakitTuru.SelectedIndex = -1;
                        cmbBoxSanzimanTuru.SelectedIndex = -1;
                        cmbBoxAracModel.SelectedIndex = -1;
                        break;

                    case NumericUpDown:
                        nmrcUpDownAracModel.Value = 2005;
                        nmrcUpDownAracHP.Value = 1000;
                        break;

                    case Button:
                        btnArabaResim.BackgroundImage = null;
                        break;

                    case PictureBox:
                        pcBoxAracResim.Image = null;
                        break;

                    case Label:
                        labelColor.BackColor = Color.White;
                        break;
                    case CheckBox:
                        chkBoxGaranti.Checked = true;
                        break;
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstBoxAraba.SelectedIndex != -1)
            {
                cmbBoxAracTuru.Text = secilenAraba[lstBoxAraba.SelectedIndex].arabaTuru.ToString();
                cmbBoxKasaTipi.Text = secilenAraba[lstBoxAraba.SelectedIndex].arabaKasaTipi.ToString();
                cmbBoxAracMarka.Text = secilenAraba[lstBoxAraba.SelectedIndex].arabaMarka.ToString();
                cmbBoxAracModel.Text = secilenAraba[lstBoxAraba.SelectedIndex].arabaModel.ToString();
                cmbBoxSanzimanTuru.Text = secilenAraba[lstBoxAraba.SelectedIndex].arabaSanzimanTuru.ToString();
                cmbBoxYakitTuru.Text = secilenAraba[lstBoxAraba.SelectedIndex].arabaYakitTuru.ToString();
                nmrcUpDownAracModel.Value = secilenAraba[lstBoxAraba.SelectedIndex].ModelYili;
                nmrcUpDownAracHP.Value = secilenAraba[lstBoxAraba.SelectedIndex].MotorGucu;
                labelColor.BackColor = secilenAraba[lstBoxAraba.SelectedIndex].aracınRengi;
                pcBoxAracResim.Image = secilenAraba[lstBoxAraba.SelectedIndex].arabaResim;
            }

        }

        private void checkBoxGaranti_CheckedChanged(object sender, EventArgs e)
        {

            if (chkBoxGaranti.Checked)
            {
                lblGarantiDurumu.Text = "Garanti Eklendi";
                lblGarantiDurumu.BackColor = Color.Green;
            }

            else if (!chkBoxGaranti.Checked)
            {
                lblGarantiDurumu.Text = "Garanti Eklenmedi";
                lblGarantiDurumu.BackColor = Color.Red;
            }
        }

        private void comboBoxAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxAracMarka.SelectedItem != null)
            {
                Marka selectedMarka = (Marka)cmbBoxAracMarka.SelectedItem;
                AracTuru selectedAracTur = (AracTuru)cmbBoxAracTuru.SelectedItem;
                if (selectedMarka == Marka.Ford)
                {
                    if (selectedAracTur == AracTuru.Binek)
                    {

                        cmbBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                            .Cast<Model>()
                            .Where(model => model == Model.Focus || model == Model.Fiesta)
                            .ToList();
                    }
                    else
                    {

                        cmbBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                            .Cast<Model>()
                            .Where(model => model == Model.Tourneo || model == Model.TourneoCustom)
                            .ToList();
                    }
                }

                else if (selectedMarka == Marka.Volkswagen)
                {
                    if (selectedAracTur == AracTuru.Binek)
                    {

                        cmbBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                            .Cast<Model>()
                            .Where(model => model == Model.Golf)
                            .ToList();
                    }
                    else
                    {

                        cmbBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                            .Cast<Model>()
                            .Where(model => model == Model.Transpotter || model == Model.Cady)
                            .ToList();
                    }
                }
                else if (selectedMarka == Marka.Renault)
                {
                    if (selectedAracTur == AracTuru.Binek)
                    {
                        cmbBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                        .Cast<Model>()
                        .Where(model => model == Model.Megane)
                        .ToList();
                    }
                    else
                    {
                        cmbBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                        .Cast<Model>()
                        .Where(model => model == Model.Traffic)
                        .ToList();
                    }

                }
                else if (selectedMarka == Marka.Fiat)
                {
                    if (selectedAracTur == AracTuru.Binek)
                    {
                        cmbBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                        .Cast<Model>()
                        .Where(model => model == Model.Fiat500 || model == Model.Fiat500e)
                        .ToList();
                    }
                    else
                    {
                        cmbBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                        .Cast<Model>()
                        .Where(model => model == Model.Doblo)
                        .ToList();
                    }

                }
            }
        }
    }
}

