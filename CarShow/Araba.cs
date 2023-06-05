using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShow
{
   
    public class Araba
    {
        List<Araba> secilenAraba=new List<Araba>();
        public AracTuru arabaTuru { get; set; }
        public KasaTipi arabaKasaTipi { get; set; }
        public Marka arabaMarka { get; set; }
        public Model arabaModel { get; set; }
        public SanzimanTuru arabaSanzimanTuru { get; set; }
        public YakitTuru arabaYakitTuru { get; set; }
        public ColorDialog aracınRengi { get; set; }
        public Image arabaResim { get; set; }
        public bool Garanti { get; set; }

        private short modelYili;

        public short ModelYili
        {
            get { return modelYili; }
            set
            {
                modelYili = value;
                if (modelYili < 2005) { MessageBox.Show("2005 yılından küçük modellere işlem yapılamamaktadır."); }
                else
                {
                    modelYili = value;
                }
            }
        }

        private short motorGucu;

        public short MotorGucu
        {
            get { return motorGucu; }
            set
            {
                motorGucu = value;
                if (motorGucu < 1000) { MessageBox.Show("Motor Gücü en az 1000 olabilir."); }
                else
                {
                    motorGucu = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{arabaTuru} - {arabaMarka} - {arabaModel} ";
        }
    }
}
