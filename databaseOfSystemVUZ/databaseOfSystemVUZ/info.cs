using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseOfSystemVUZ
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        public Font FontHeaderText;
        public Font FontText;
        public Color ColorHeaderText;
        public Color BackColorHeaderText;
        public Color ColorText;
        public Color BackColorText;
        public bool boldHeaderText = false, italicHeaderText = false, PodHeaderText = false,bolitalicHeadersText= false;
        public bool boldText= false, italicText=false, PodText=false, bolitalicText=false;

        string[] names = { "Размер шрифта заголовков: ",
            "Размер шрифта текста: ",
        "Цвет текста заголовков: ",
        "Фон текста заголовков: ",
        "Шрифт заголовков: ",
        "Шрифт текста: ",
        "Цвет текста: ",
        "Фон текста"};
        void update_form()
        {
            string l;
            if(FontHeaderText != null)
            {
                 //Выводим размер
               
                lblsizeHeders.Text = names[0] + FontHeaderText.Size.ToString();
                lblfornheaders.Text = names[4] + FontHeaderText.Name.ToString();


                boldHeaderText = FontHeaderText.Bold;
                italicHeaderText = FontHeaderText.Italic;
                PodHeaderText = FontHeaderText.Underline;
                bolitalicHeadersText = FontHeaderText.Bold && FontHeaderText.Italic;
            }
          
           if(!ColorText.IsEmpty)
            {
                //Выводим на форму цвет текста 
               
                lblTextColor.Text = names[6] + ColorText.ToString();
               
            }
           if(!ColorHeaderText.IsEmpty)
            {
                //Выводим на форму цвет текста заголовков
               
                lblColorHeaderfont.Text = names[2] + ColorHeaderText.ToString();
            }
           if(!BackColorHeaderText.IsEmpty)
            {
               
                lblBackCOlorHeders.Text = names[3] + BackColorHeaderText.ToString();
            }
           if(!BackColorText.IsEmpty)
            {
               
                lblBackColorText.Text =names[7] + BackColorText.ToString();
            }
            if (FontText != null)
            {
               
                lblTextfont.Text =names[5] + FontText.Name.ToString();
                lblTextSize.Text = names[1]+ FontText.Size.ToString();

                boldText = FontText.Bold;
                italicText = FontText.Italic;
                PodText = FontText.Underline;
                bolitalicText = FontText.Bold && FontText.Italic;
            }

            chbxHeadersBold.Checked = boldHeaderText;
            chbxItalicHeaders.Checked = italicHeaderText;
            chbxpodHeaders.Checked = PodHeaderText;
            cbxBoldItalicHeaderText.Checked = bolitalicHeadersText;

            chbxBold.Checked = boldText;
            chbxItalic.Checked = italicText;
            chbxPod.Checked = PodText;
            cbxBoldItalicText.Checked = bolitalicText;
        }
        private void ckCOlorHeaders_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            BackColorHeaderText = colorDialog1.Color;
            update_form();
        }

        private void btnColorText_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            ColorText = colorDialog1.Color;
            update_form();
        }

        private void btnBackColorText_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            BackColorText = colorDialog1.Color;
            update_form();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCOlorHeaders_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            ColorHeaderText = colorDialog1.Color;
            update_form();
        }

        private void btnFOntText_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FontText = fontDialog1.Font;
            update_form();
        }

        private void btnFonrHeaders_Click(object sender, EventArgs e)
        {
           
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            FontHeaderText = fontDialog1.Font;
            update_form();

        }

        private void info_Load(object sender, EventArgs e)
        {

            update_form();
        }

       
        private void lblfornheaders_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
