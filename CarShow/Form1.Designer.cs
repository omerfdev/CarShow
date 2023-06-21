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
            grpBoxCar = new GroupBox();
            lblGarantiDurumu = new Label();
            chkBoxGaranti = new CheckBox();
            label4 = new Label();
            btnOlustur = new Button();
            btnAracResim = new Button();
            btnArabaResim = new Button();
            labelColor = new Label();
            btnAracRenk = new Button();
            label2 = new Label();
            lblModel = new Label();
            nmrcUpDownAracHP = new NumericUpDown();
            nmrcUpDownAracModel = new NumericUpDown();
            cmbBoxKasaTipi = new ComboBox();
            cmbBoxYakitTuru = new ComboBox();
            cmbBoxSanzimanTuru = new ComboBox();
            cmbBoxAracModel = new ComboBox();
            cmbBoxAracMarka = new ComboBox();
            cmbBoxAracTuru = new ComboBox();
            lstBoxAraba = new ListBox();
            pcBoxAracResim = new PictureBox();
            clrDialog = new ColorDialog();
            opnFlDialogAracResim = new OpenFileDialog();
            flwPanelAraba = new FlowLayoutPanel();
            grpBoxCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownAracHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownAracModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxAracResim).BeginInit();
            SuspendLayout();
            // 
            // grpBoxCar
            // 
            grpBoxCar.Controls.Add(lblGarantiDurumu);
            grpBoxCar.Controls.Add(chkBoxGaranti);
            grpBoxCar.Controls.Add(label4);
            grpBoxCar.Controls.Add(btnOlustur);
            grpBoxCar.Controls.Add(btnAracResim);
            grpBoxCar.Controls.Add(btnArabaResim);
            grpBoxCar.Controls.Add(labelColor);
            grpBoxCar.Controls.Add(btnAracRenk);
            grpBoxCar.Controls.Add(label2);
            grpBoxCar.Controls.Add(lblModel);
            grpBoxCar.Controls.Add(nmrcUpDownAracHP);
            grpBoxCar.Controls.Add(nmrcUpDownAracModel);
            grpBoxCar.Controls.Add(cmbBoxKasaTipi);
            grpBoxCar.Controls.Add(cmbBoxYakitTuru);
            grpBoxCar.Controls.Add(cmbBoxSanzimanTuru);
            grpBoxCar.Controls.Add(cmbBoxAracModel);
            grpBoxCar.Controls.Add(cmbBoxAracMarka);
            grpBoxCar.Controls.Add(cmbBoxAracTuru);
            grpBoxCar.Location = new Point(12, 12);
            grpBoxCar.Name = "grpBoxCar";
            grpBoxCar.Size = new Size(301, 593);
            grpBoxCar.TabIndex = 0;
            grpBoxCar.TabStop = false;
            grpBoxCar.Text = "Cars";
            // 
            // lblGarantiDurumu
            // 
            lblGarantiDurumu.AutoSize = true;
            lblGarantiDurumu.Location = new Point(158, 393);
            lblGarantiDurumu.Name = "lblGarantiDurumu";
            lblGarantiDurumu.Size = new Size(0, 20);
            lblGarantiDurumu.TabIndex = 17;
            // 
            // chkBoxGaranti
            // 
            chkBoxGaranti.AutoSize = true;
            chkBoxGaranti.Location = new Point(158, 363);
            chkBoxGaranti.Name = "chkBoxGaranti";
            chkBoxGaranti.Size = new Size(18, 17);
            chkBoxGaranti.TabIndex = 16;
            chkBoxGaranti.UseVisualStyleBackColor = true;
            chkBoxGaranti.CheckedChanged += checkBoxGaranti_CheckedChanged;
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
            // btnOlustur
            // 
            btnOlustur.Location = new Point(191, 416);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(94, 29);
            btnOlustur.TabIndex = 14;
            btnOlustur.Text = "Oluştur";
            btnOlustur.UseVisualStyleBackColor = true;
            btnOlustur.Click += buttonOlustur_Click;
            // 
            // btnAracResim
            // 
            btnAracResim.Location = new Point(6, 416);
            btnAracResim.Name = "btnAracResim";
            btnAracResim.Size = new Size(108, 29);
            btnAracResim.TabIndex = 13;
            btnAracResim.Text = "Aracın Resmi";
            btnAracResim.UseVisualStyleBackColor = true;
            btnAracResim.Click += buttonAracResim_Click;
            // 
            // btnArabaResim
            // 
            btnArabaResim.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnArabaResim.BackgroundImageLayout = ImageLayout.Stretch;
            btnArabaResim.Location = new Point(6, 451);
            btnArabaResim.Name = "btnArabaResim";
            btnArabaResim.Size = new Size(200, 136);
            btnArabaResim.TabIndex = 12;
            btnArabaResim.UseVisualStyleBackColor = true;
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
            // btnAracRenk
            // 
            btnAracRenk.Location = new Point(6, 313);
            btnAracRenk.Name = "btnAracRenk";
            btnAracRenk.Size = new Size(108, 29);
            btnAracRenk.TabIndex = 10;
            btnAracRenk.Text = "Araç Rengi";
            btnAracRenk.UseVisualStyleBackColor = true;
            btnAracRenk.Click += buttonAracRenk_Click;
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
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(0, 268);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 8;
            lblModel.Text = "Model";
            // 
            // nmrcUpDownAracHP
            // 
            nmrcUpDownAracHP.Location = new Point(225, 266);
            nmrcUpDownAracHP.Maximum = new decimal(new int[] { 3200, 0, 0, 0 });
            nmrcUpDownAracHP.Name = "nmrcUpDownAracHP";
            nmrcUpDownAracHP.Size = new Size(67, 27);
            nmrcUpDownAracHP.TabIndex = 7;
            nmrcUpDownAracHP.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // nmrcUpDownAracModel
            // 
            nmrcUpDownAracModel.Location = new Point(58, 266);
            nmrcUpDownAracModel.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            nmrcUpDownAracModel.Name = "nmrcUpDownAracModel";
            nmrcUpDownAracModel.Size = new Size(69, 27);
            nmrcUpDownAracModel.TabIndex = 6;
            nmrcUpDownAracModel.Value = new decimal(new int[] { 2005, 0, 0, 0 });
            // 
            // cmbBoxKasaTipi
            // 
            cmbBoxKasaTipi.FormattingEnabled = true;
            cmbBoxKasaTipi.Location = new Point(6, 196);
            cmbBoxKasaTipi.Name = "cmbBoxKasaTipi";
            cmbBoxKasaTipi.Size = new Size(279, 28);
            cmbBoxKasaTipi.TabIndex = 5;
            // 
            // cmbBoxYakitTuru
            // 
            cmbBoxYakitTuru.FormattingEnabled = true;
            cmbBoxYakitTuru.Location = new Point(6, 162);
            cmbBoxYakitTuru.Name = "cmbBoxYakitTuru";
            cmbBoxYakitTuru.Size = new Size(279, 28);
            cmbBoxYakitTuru.TabIndex = 4;
            // 
            // cmbBoxSanzimanTuru
            // 
            cmbBoxSanzimanTuru.FormattingEnabled = true;
            cmbBoxSanzimanTuru.Location = new Point(6, 128);
            cmbBoxSanzimanTuru.Name = "cmbBoxSanzimanTuru";
            cmbBoxSanzimanTuru.Size = new Size(279, 28);
            cmbBoxSanzimanTuru.TabIndex = 3;
            // 
            // cmbBoxAracModel
            // 
            cmbBoxAracModel.FormattingEnabled = true;
            cmbBoxAracModel.Location = new Point(6, 94);
            cmbBoxAracModel.Name = "cmbBoxAracModel";
            cmbBoxAracModel.Size = new Size(279, 28);
            cmbBoxAracModel.TabIndex = 2;
            // 
            // cmbBoxAracMarka
            // 
            cmbBoxAracMarka.FormattingEnabled = true;
            cmbBoxAracMarka.Location = new Point(6, 60);
            cmbBoxAracMarka.Name = "cmbBoxAracMarka";
            cmbBoxAracMarka.Size = new Size(279, 28);
            cmbBoxAracMarka.TabIndex = 1;
            cmbBoxAracMarka.SelectedIndexChanged += comboBoxAracMarka_SelectedIndexChanged;
            // 
            // cmbBoxAracTuru
            // 
            cmbBoxAracTuru.FormattingEnabled = true;
            cmbBoxAracTuru.Location = new Point(6, 26);
            cmbBoxAracTuru.Name = "cmbBoxAracTuru";
            cmbBoxAracTuru.Size = new Size(279, 28);
            cmbBoxAracTuru.TabIndex = 0;
            // 
            // lstBoxAraba
            // 
            lstBoxAraba.FormattingEnabled = true;
            lstBoxAraba.ItemHeight = 20;
            lstBoxAraba.Location = new Point(319, 24);
            lstBoxAraba.Name = "lstBoxAraba";
            lstBoxAraba.Size = new Size(540, 384);
            lstBoxAraba.TabIndex = 1;
            lstBoxAraba.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pcBoxAracResim
            // 
            pcBoxAracResim.Location = new Point(446, 421);
            pcBoxAracResim.Name = "pcBoxAracResim";
            pcBoxAracResim.Size = new Size(297, 178);
            pcBoxAracResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pcBoxAracResim.TabIndex = 2;
            pcBoxAracResim.TabStop = false;
            // 
            // opnFlDialogAracResim
            // 
            opnFlDialogAracResim.FileName = "openFileDialog1";
            // 
            // flwPanelAraba
            // 
            flwPanelAraba.Location = new Point(923, 24);
            flwPanelAraba.Name = "flwPanelAraba";
            flwPanelAraba.Size = new Size(581, 575);
            flwPanelAraba.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1516, 617);
            Controls.Add(flwPanelAraba);
            Controls.Add(pcBoxAracResim);
            Controls.Add(lstBoxAraba);
            Controls.Add(grpBoxCar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Araba Galeri";
            Load += Form1_Load;
            grpBoxCar.ResumeLayout(false);
            grpBoxCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownAracHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrcUpDownAracModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxAracResim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxCar;
        private ComboBox cmbBoxAracModel;
        private ComboBox cmbBoxAracMarka;
        private ComboBox cmbBoxAracTuru;
        private ComboBox cmbBoxKasaTipi;
        private ComboBox cmbBoxYakitTuru;
        private ComboBox cmbBoxSanzimanTuru;
        private Label lblModel;
        private NumericUpDown nmrcUpDownAracHP;
        private NumericUpDown nmrcUpDownAracModel;
        private Label label2;
        private ListBox lstBoxAraba;
        private PictureBox pcBoxAracResim;
        private Label labelColor;
        private Button btnAracRenk;
        private Button btnOlustur;
        private Button btnAracResim;
        private Button btnArabaResim;
        private CheckBox chkBoxGaranti;
        private Label label4;
        private ColorDialog clrDialog;
        private OpenFileDialog opnFlDialogAracResim;
        private Label lblGarantiDurumu;
        private FlowLayoutPanel flwPanelAraba;
    }
}