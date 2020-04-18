using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTranslationEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ConfigLocale.Load(LabelTranslation.Locale.Global.pt_BR);

            chbLingagens.SelectedIndex = 0;

            this.Text = ConfigLocale.TITLULO;

            this.label1.Text = ConfigLocale.LABEL;
        }

        private void chbLingagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelTranslation.Locale.Global gl = LabelTranslation.Locale.Global.Others;

            switch (chbLingagens.SelectedItem.ToString())
            {
                case "pt_BR":
                    gl = LabelTranslation.Locale.Global.pt_BR;
                    break;
                case "en_US":
                    gl = LabelTranslation.Locale.Global.en_US;
                    break;
            }

            ConfigLocale.Troca(gl);

            this.Text = ConfigLocale.TITLULO;

            this.label1.Text = ConfigLocale.LABEL;
        }
    }
}
