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
            numericUpDownAracHP.Value = 1000;
            numericUpDownAracModel.Value = 2005;
            AracTuru[] aracTurleri = (AracTuru[])Enum.GetValues(typeof(AracTuru));
            comboBoxAracTuru.DataSource = aracTurleri;
            KasaTipi[] kasaTipleri = (KasaTipi[])Enum.GetValues(typeof(KasaTipi));
            comboBoxKasaTipi.DataSource = kasaTipleri;
            Marka[] markalar = (Marka[])Enum.GetValues(typeof(Marka));
            comboBoxAracMarka.DataSource = markalar;
            SanzimanTuru[] sanzimanTurleri = (SanzimanTuru[])Enum.GetValues(typeof(SanzimanTuru));
            comboBoxSanzimanTuru.DataSource = sanzimanTurleri;
            YakitTuru[] yakitTurleri = (YakitTuru[])Enum.GetValues(typeof(YakitTuru));
            comboBoxYakitTuru.DataSource = yakitTurleri;
            Model[] modeller = (Model[])Enum.GetValues(typeof(Model));
            comboBoxAracModel.DataSource = modeller;


            string path = @"C:\Users\omerf\source\repos\CarShow\CarShow\Image\AllCar\";
            foreach (string image in Directory.GetFiles(path))
            {
                PictureBox picture = new PictureBox();
                picture.ImageLocation = image;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Width = 150;
                picture.Height = 100;
                picture.Click += Picture_Click;
                flowLayoutPanel1.Controls.Add(picture);

            }

        }

        private void Picture_Click(object? sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(((PictureBox)sender).ImageLocation);
            MessageBox.Show(fi.Name);
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
                buttonArabaResim.BackgroundImage = Image.FromFile(selectedFilePath);
                pictureBox1.Image = Image.FromFile(selectedFilePath);
            }

        }

        public void buttonOlustur_Click(object sender, EventArgs e)
        {
            Araba araba = new Araba
            {
                arabaTuru = (AracTuru)comboBoxAracTuru.SelectedItem,
                arabaKasaTipi = (KasaTipi)comboBoxKasaTipi.SelectedItem,
                arabaMarka = (Marka)comboBoxAracMarka.SelectedItem,
                arabaModel = (Model)comboBoxAracModel.SelectedItem,
                arabaSanzimanTuru = (SanzimanTuru)comboBoxSanzimanTuru.SelectedItem,
                arabaYakitTuru = (YakitTuru)comboBoxYakitTuru.SelectedItem,
                ModelYili = ((short)numericUpDownAracModel.Value),
                MotorGucu = (short)numericUpDownAracHP.Value,
                Garanti = lblGarantiDurumu.Text,
                aracınRengi = labelColor.BackColor,
                arabaResim = buttonArabaResim.BackgroundImage,

            };

            pictureBox1.Image = araba.arabaResim;
            secilenAraba.Add(araba);
            araba.ToString();
            listBox1.DataSource = null;
            listBox1.DataSource = secilenAraba;
            Clear();
        }
        public void Clear()
        {
            foreach (Control control in Controls)
            {
                switch (control)
                {
                    case ComboBox:
                        comboBoxAracTuru.SelectedIndex = -1;
                        comboBoxKasaTipi.SelectedIndex = -1;
                        comboBoxAracMarka.SelectedIndex = -1;
                        comboBoxYakitTuru.SelectedIndex = -1;
                        comboBoxSanzimanTuru.SelectedIndex = -1;
                        comboBoxAracModel.SelectedIndex = -1;
                        break;

                    case NumericUpDown:
                        numericUpDownAracModel.Value = 2005;
                        numericUpDownAracHP.Value = 1000;
                        break;

                    case Button:
                        buttonArabaResim.BackgroundImage = null;
                        break;

                    case PictureBox:
                        pictureBox1.Image = null;
                        break;

                    case Label:
                        labelColor.BackColor = Color.White;
                        break;
                    case CheckBox:
                        checkBoxGaranti.Checked = true;
                        break;
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                comboBoxAracTuru.Text = secilenAraba[listBox1.SelectedIndex].arabaTuru.ToString();
                comboBoxKasaTipi.Text = secilenAraba[listBox1.SelectedIndex].arabaKasaTipi.ToString();
                comboBoxAracMarka.Text = secilenAraba[listBox1.SelectedIndex].arabaMarka.ToString();
                comboBoxAracModel.Text = secilenAraba[listBox1.SelectedIndex].arabaModel.ToString();
                comboBoxSanzimanTuru.Text = secilenAraba[listBox1.SelectedIndex].arabaSanzimanTuru.ToString();
                comboBoxYakitTuru.Text = secilenAraba[listBox1.SelectedIndex].arabaYakitTuru.ToString();
                numericUpDownAracModel.Value = secilenAraba[listBox1.SelectedIndex].ModelYili;
                numericUpDownAracHP.Value = secilenAraba[listBox1.SelectedIndex].MotorGucu;
                labelColor.BackColor = secilenAraba[listBox1.SelectedIndex].aracınRengi;
                pictureBox1.Image = secilenAraba[listBox1.SelectedIndex].arabaResim;
            }

        }

        private void checkBoxGaranti_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxGaranti.Checked)
            {
                lblGarantiDurumu.Text = "Garanti Eklendi";
                lblGarantiDurumu.BackColor = Color.Green;
            }

            else if (!checkBoxGaranti.Checked)
            {
                lblGarantiDurumu.Text = "Garanti Eklenmedi";
                lblGarantiDurumu.BackColor = Color.Red;
            }
        }

        private void comboBoxAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAracMarka.SelectedItem != null)
            {
                Marka selectedMarka = (Marka)comboBoxAracMarka.SelectedItem;
                AracTuru selectedAracTur = (AracTuru)comboBoxAracTuru.SelectedItem;
                if (selectedMarka == Marka.Ford)
                {
                    if (selectedAracTur == AracTuru.Binek)
                    {

                        comboBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                            .Cast<Model>()
                            .Where(model => model == Model.Focus || model == Model.Fiesta)
                            .ToList();
                    }
                    else
                    {

                        comboBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                            .Cast<Model>()
                            .Where(model => model == Model.Tourneo || model == Model.TourneoCustom)
                            .ToList();
                    }
                }

                else if (selectedMarka == Marka.Volkswagen)
                {
                    if (selectedAracTur == AracTuru.Binek)
                    {

                        comboBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                            .Cast<Model>()
                            .Where(model => model == Model.Golf)
                            .ToList();
                    }
                    else
                    {

                        comboBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                            .Cast<Model>()
                            .Where(model => model == Model.Transpotter || model == Model.Cady)
                            .ToList();
                    }
                }
                else if (selectedMarka == Marka.Renault)
                {
                    if (selectedAracTur == AracTuru.Binek)
                    {
                        comboBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                        .Cast<Model>()
                        .Where(model => model == Model.Megane)
                        .ToList();
                    }
                    else
                    {
                        comboBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                        .Cast<Model>()
                        .Where(model => model == Model.Traffic)
                        .ToList();
                    }

                }
                else if (selectedMarka == Marka.Fiat)
                {
                    if (selectedAracTur == AracTuru.Binek)
                    {
                        comboBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                        .Cast<Model>()
                        .Where(model => model == Model.Fiat500 || model == Model.Fiat500e)
                        .ToList();
                    }
                    else
                    {
                        comboBoxAracModel.DataSource = Enum.GetValues(typeof(Model))
                        .Cast<Model>()
                        .Where(model => model == Model.Doblo)
                        .ToList();
                    }

                }
            }
        }
    }
}

