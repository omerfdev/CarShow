namespace CarShow
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxCar = new GroupBox();
            checkBoxGaranti = new CheckBox();
            label4 = new Label();
            buttonOlustur = new Button();
            buttonAracResim = new Button();
            buttonArabaResim = new Button();
            labelColor = new Label();
            buttonAracRenk = new Button();
            label2 = new Label();
            label1 = new Label();
            numericUpDownAracHP = new NumericUpDown();
            numericUpDownAracModel = new NumericUpDown();
            comboBoxKasaTipi = new ComboBox();
            comboBoxYakitTuru = new ComboBox();
            comboBoxSanzimanTuru = new ComboBox();
            comboBoxAracModel = new ComboBox();
            comboBoxAracMarka = new ComboBox();
            comboBoxAracTuru = new ComboBox();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            groupBoxCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAracHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAracModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCar
            // 
            groupBoxCar.Controls.Add(checkBoxGaranti);
            groupBoxCar.Controls.Add(label4);
            groupBoxCar.Controls.Add(buttonOlustur);
            groupBoxCar.Controls.Add(buttonAracResim);
            groupBoxCar.Controls.Add(buttonArabaResim);
            groupBoxCar.Controls.Add(labelColor);
            groupBoxCar.Controls.Add(buttonAracRenk);
            groupBoxCar.Controls.Add(label2);
            groupBoxCar.Controls.Add(label1);
            groupBoxCar.Controls.Add(numericUpDownAracHP);
            groupBoxCar.Controls.Add(numericUpDownAracModel);
            groupBoxCar.Controls.Add(comboBoxKasaTipi);
            groupBoxCar.Controls.Add(comboBoxYakitTuru);
            groupBoxCar.Controls.Add(comboBoxSanzimanTuru);
            groupBoxCar.Controls.Add(comboBoxAracModel);
            groupBoxCar.Controls.Add(comboBoxAracMarka);
            groupBoxCar.Controls.Add(comboBoxAracTuru);
            groupBoxCar.Location = new Point(12, 12);
            groupBoxCar.Name = "groupBoxCar";
            groupBoxCar.Size = new Size(301, 593);
            groupBoxCar.TabIndex = 0;
            groupBoxCar.TabStop = false;
            groupBoxCar.Text = "Cars";
            // 
            // checkBoxGaranti
            // 
            checkBoxGaranti.AutoSize = true;
            checkBoxGaranti.Location = new Point(158, 363);
            checkBoxGaranti.Name = "checkBoxGaranti";
            checkBoxGaranti.Size = new Size(124, 24);
            checkBoxGaranti.TabIndex = 16;
            checkBoxGaranti.Text = "Garanti Olsun ";
            checkBoxGaranti.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 364);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 15;
            label4.Text = "Garanti Durumu";
            // 
            // buttonOlustur
            // 
            buttonOlustur.Location = new Point(191, 416);
            buttonOlustur.Name = "buttonOlustur";
            buttonOlustur.Size = new Size(94, 29);
            buttonOlustur.TabIndex = 14;
            buttonOlustur.Text = "Oluştur";
            buttonOlustur.UseVisualStyleBackColor = true;
            buttonOlustur.Click += buttonOlustur_Click;
            // 
            // buttonAracResim
            // 
            buttonAracResim.Location = new Point(6, 416);
            buttonAracResim.Name = "buttonAracResim";
            buttonAracResim.Size = new Size(108, 29);
            buttonAracResim.TabIndex = 13;
            buttonAracResim.Text = "Aracın Resmi";
            buttonAracResim.UseVisualStyleBackColor = true;
            buttonAracResim.Click += buttonAracResim_Click;
            // 
            // buttonArabaResim
            // 
            buttonArabaResim.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonArabaResim.BackgroundImageLayout = ImageLayout.Stretch;
            buttonArabaResim.Location = new Point(6, 451);
            buttonArabaResim.Name = "buttonArabaResim";
            buttonArabaResim.Size = new Size(286, 136);
            buttonArabaResim.TabIndex = 12;
            buttonArabaResim.UseVisualStyleBackColor = true;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(179, 317);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(89, 20);
            labelColor.TabIndex = 11;
            labelColor.Text = "                    ";
            // 
            // buttonAracRenk
            // 
            buttonAracRenk.Location = new Point(6, 313);
            buttonAracRenk.Name = "buttonAracRenk";
            buttonAracRenk.Size = new Size(108, 29);
            buttonAracRenk.TabIndex = 10;
            buttonAracRenk.Text = "Araç Rengi";
            buttonAracRenk.UseVisualStyleBackColor = true;
            buttonAracRenk.Click += buttonAracRenk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 268);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 9;
            label2.Text = "Motor Gücü";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 268);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 8;
            label1.Text = "Model";
            // 
            // numericUpDownAracHP
            // 
            numericUpDownAracHP.Location = new Point(225, 266);
            numericUpDownAracHP.Maximum = new decimal(new int[] { 3200, 0, 0, 0 });
            numericUpDownAracHP.Name = "numericUpDownAracHP";
            numericUpDownAracHP.Size = new Size(67, 27);
            numericUpDownAracHP.TabIndex = 7;
            numericUpDownAracHP.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // numericUpDownAracModel
            // 
            numericUpDownAracModel.Location = new Point(58, 266);
            numericUpDownAracModel.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownAracModel.Name = "numericUpDownAracModel";
            numericUpDownAracModel.Size = new Size(69, 27);
            numericUpDownAracModel.TabIndex = 6;
            numericUpDownAracModel.Value = new decimal(new int[] { 2005, 0, 0, 0 });
            // 
            // comboBoxKasaTipi
            // 
            comboBoxKasaTipi.FormattingEnabled = true;
            comboBoxKasaTipi.Location = new Point(6, 196);
            comboBoxKasaTipi.Name = "comboBoxKasaTipi";
            comboBoxKasaTipi.Size = new Size(279, 28);
            comboBoxKasaTipi.TabIndex = 5;
            // 
            // comboBoxYakitTuru
            // 
            comboBoxYakitTuru.FormattingEnabled = true;
            comboBoxYakitTuru.Location = new Point(6, 162);
            comboBoxYakitTuru.Name = "comboBoxYakitTuru";
            comboBoxYakitTuru.Size = new Size(279, 28);
            comboBoxYakitTuru.TabIndex = 4;
            // 
            // comboBoxSanzimanTuru
            // 
            comboBoxSanzimanTuru.FormattingEnabled = true;
            comboBoxSanzimanTuru.Location = new Point(6, 128);
            comboBoxSanzimanTuru.Name = "comboBoxSanzimanTuru";
            comboBoxSanzimanTuru.Size = new Size(279, 28);
            comboBoxSanzimanTuru.TabIndex = 3;
            // 
            // comboBoxAracModel
            // 
            comboBoxAracModel.FormattingEnabled = true;
            comboBoxAracModel.Location = new Point(6, 94);
            comboBoxAracModel.Name = "comboBoxAracModel";
            comboBoxAracModel.Size = new Size(279, 28);
            comboBoxAracModel.TabIndex = 2;
            // 
            // comboBoxAracMarka
            // 
            comboBoxAracMarka.FormattingEnabled = true;
            comboBoxAracMarka.Location = new Point(6, 60);
            comboBoxAracMarka.Name = "comboBoxAracMarka";
            comboBoxAracMarka.Size = new Size(279, 28);
            comboBoxAracMarka.TabIndex = 1;
            // 
            // comboBoxAracTuru
            // 
            comboBoxAracTuru.FormattingEnabled = true;
            comboBoxAracTuru.Location = new Point(6, 26);
            comboBoxAracTuru.Name = "comboBoxAracTuru";
            comboBoxAracTuru.Size = new Size(279, 28);
            comboBoxAracTuru.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(319, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(595, 404);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(920, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 617);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(groupBoxCar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Araba Galeri";
            Load += Form1_Load;
            groupBoxCar.ResumeLayout(false);
            groupBoxCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAracHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAracModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCar;
        private ComboBox comboBoxAracModel;
        private ComboBox comboBoxAracMarka;
        private ComboBox comboBoxAracTuru;
        private ComboBox comboBoxKasaTipi;
        private ComboBox comboBoxYakitTuru;
        private ComboBox comboBoxSanzimanTuru;
        private Label label1;
        private NumericUpDown numericUpDownAracHP;
        private NumericUpDown numericUpDownAracModel;
        private Label label2;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Label labelColor;
        private Button buttonAracRenk;
        private Button buttonOlustur;
        private Button buttonAracResim;
        private Button buttonArabaResim;
        private CheckBox checkBoxGaranti;
        private Label label4;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
    }
}