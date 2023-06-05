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

        private Araba secilenAraba;
        private void Form1_Load(object sender, EventArgs e)
        {
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
            }

        }

        public void buttonOlustur_Click(object sender, EventArgs e)
        {
            secilenAraba = new Araba
            {
                arabaTuru = (AracTuru)comboBoxAracTuru.SelectedItem,
                arabaKasaTipi = (KasaTipi)comboBoxKasaTipi.SelectedItem,
                arabaMarka = (Marka)comboBoxAracMarka.SelectedItem,
                arabaModel = (Model)comboBoxAracModel.SelectedItem,
                arabaSanzimanTuru = (SanzimanTuru)comboBoxSanzimanTuru.SelectedItem,
                arabaYakitTuru = (YakitTuru)comboBoxYakitTuru.SelectedItem,
                ModelYili = ((short)numericUpDownAracModel.Value),
                MotorGucu = (short)numericUpDownAracModel.Value,
                Garanti = checkBoxGaranti.Checked,
                aracınRengi = colorDialog1,
                arabaResim = buttonArabaResim.Image,

            };

            pictureBox1.Image = secilenAraba.arabaResim;
            listBox1.Items.Add(secilenAraba);

            Araba araba = new Araba(); araba.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                secilenAraba = listBox1.SelectedItem as Araba;
                comboBoxAracMarka.Text = secilenAraba.arabaMarka.ToString();
                comboBoxAracModel.Text = secilenAraba.arabaModel.ToString();
                comboBoxKasaTipi.Text = secilenAraba.arabaKasaTipi.ToString();
            }

        }
    }
}

