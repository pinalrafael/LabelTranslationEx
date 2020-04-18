using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabelTranslation;

namespace LabelTranslationEx
{
    public class ConfigLocale
    {
        private static Locale l { get; set; }
        public static string TITLULO { get; set; }
        public static string LABEL { get; set; }

        public static void Load(Locale.Global linguagem)
        {
            // INICIA A LIGUA PADRÃO
            l = new Locale(linguagem);

            // CARREGA OS TEXTOS
            List<Locale.Translations> titulo = new List<Locale.Translations>();
            titulo.Add(new Locale.Translations("Título", Locale.Global.pt_BR));
            titulo.Add(new Locale.Translations("Title", Locale.Global.en_US));
            titulo.Add(new Locale.Translations("_Título", Locale.Global.Others));
            Locale.Text texttitulo = new Locale.Text("titulo", "Título", titulo);
            l.AddText(texttitulo);

            List<Locale.Translations> label = new List<Locale.Translations>();
            label.Add(new Locale.Translations("Selecione a Linguagem", Locale.Global.pt_BR));
            label.Add(new Locale.Translations("Select Language", Locale.Global.en_US));
            label.Add(new Locale.Translations("_Selecione a Linguagem", Locale.Global.Others));
            Locale.Text textlabel = new Locale.Text("label", "Selecione a Linguagem", label);
            l.AddText(textlabel);

            // TRADUZ 
            TITLULO = l.Translate(l.getTextByName("titulo"));
            LABEL = l.Translate(l.getTextByName("label"));

            // UTILIZAR PARA LABELS COM VALORES
            String.Format("{0} Test", 1);
        }

        public static void Troca(Locale.Global newLinguagem)
        {
            l.setGlobal(newLinguagem);

            // TRADUZ 
            TITLULO = l.Translate(l.getTextByName("titulo"));
            LABEL = l.Translate(l.getTextByName("label"));
        }
    }
}
