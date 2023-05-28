using System.Security.Cryptography.X509Certificates;

namespace CarShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxAracTuru.Items.AddRange(System.Enum.GetNames(typeof(AracTuru)));
            comboBoxAracMarka.Items.AddRange(System.Enum.GetNames(typeof(Marka)));
            comboBoxAracModel.Items.AddRange(System.Enum.GetNames(typeof(Model)));
            comboBoxSanzimanTuru.Items.AddRange(System.Enum.GetNames(typeof(SanzimanTuru)));
            comboBoxYakitTuru.Items.AddRange(System.Enum.GetNames(typeof(YakitTuru)));
            comboBoxKasaTipi.Items.AddRange(System.Enum.GetNames(typeof(KasaTipi)));
            numericUpDownAracHP.Value = 1000;
            numericUpDownAracModel.Value = 2005;

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
            numericUpDownAracHP.Value = 1000;
            numericUpDownAracModel.Value = 2005;
            Araba araba = new Araba();            
            listBox1.Items.Add(numericUpDownAracModel.Value + " " + numericUpDownAracHP.Value + " " + comboBoxAracMarka.SelectedItem + " " + comboBoxAracModel.SelectedItem + " " + comboBoxAracTuru.SelectedItem + " " + comboBoxKasaTipi.SelectedItem + " " + comboBoxSanzimanTuru.SelectedItem + " " + comboBoxYakitTuru.SelectedItem);
        }

    }
}

