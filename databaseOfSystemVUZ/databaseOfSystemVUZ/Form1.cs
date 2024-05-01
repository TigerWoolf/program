using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace databaseOfSystemVUZ
{
    public partial class Form1 : Form
    {

        public int cnt = 0;
        public int pecent = 0;
        Stats frmplan = new Stats();

        public Form1()
        {
            InitializeComponent();

        }
      [Serializable]
      
        struct RezMauchIsl
        {
        }
        struct SpisokMerop
        {
           public  string events, dept, head, students,report,owner,type,level;
            public int year;
            //мероприятие, подразделение, руководитель, участники
            //результат, достижение
            public DateTime bdate, edate;//начало, конец выстуления
            public bool is_report; //публикация
            
        }
        struct Tezis
        {
            public string author, title, booktitle, publicher, address, pages;
            public int year;
        }
        struct sbortrud
        {
            public string author, title, publicher, address, num_pages;
            public int year;
        }
        struct jurnalstat
        {
            public Boolean is_wos, is_scorpus, is_rsci, is_humanities, is_hac, is_google;
            public int year;
            public string title, author, jurnal, pages, outside_autors;
        }
        struct grants_ruk
        {
            public string id, ruk, title;
            public int year;
        }

        struct grants
        {
            public string id, ruk, ispol, title;
            public int year;
        }
        struct grantsisp
        {
            public string id, ispol;
        }
        struct disserts
        {
            public string title, author, phdtype;
            public int year;
        }
        struct books
        {
            public string title, authors, coathors, pages, address, type, publisher;
            public int year;
        }
        struct profil
        {
            public string science, dept, last_name, first_name, middle_name, kad_name, deg_name,mail,name;
            public int owner_id;
        }
        struct Articl
        {
           public string athors, title, booktitle, city, izdatelstvo, pages;
           public int year;
        }


        List<Articl> art = new List<Articl>();
        List<SpisokMerop> Spisok_Merop = new List<SpisokMerop>();
        List<Tezis> spisok_Tezis = new List<Tezis>();
        List<sbortrud> spisok_sbortrud = new List<sbortrud>();
        List<jurnalstat> spisok_jurnalstat = new List<jurnalstat>();
        List<grants> spisok_grants = new List<grants>();
        List<grantsisp> view_gr = new List<grantsisp>();
        List<grants_ruk> view_ruc = new List<grants_ruk>();
        List<disserts> list_diserts = new List<disserts>();
        List<books> list_books = new List<books>();
        List<profil> list_profil = new List<profil>();

        

        public  void show_grants(string name = "",string name2="")
        {
         
            frmplan.tsPBAll.Visible = true;
            frmplan.tsPBAll.Maximum = spisok_grants.Count();
            if (name == "") this.pgrCurrent.Maximum = spisok_grants.Count();
            for (int i = 0; i < spisok_grants.Count(); i++)
            {
                if (name!="")
                {
                   
                    if (name == "1" && spisok_grants[i].title.Contains(name2))
                    {
                        frmplan.dataGridView7.Rows.Add();
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[0].Value = spisok_grants[i].title;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[1].Value = spisok_grants[i].ruk;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[2].Value = spisok_grants[i].ispol;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[3].Value = spisok_grants[i].year;
                    }
                   
                    if (name == "2" && spisok_grants[i].year.Equals(Convert.ToInt32(name2)))
                    {
                        frmplan.dataGridView7.Rows.Add();
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count-1].Cells[0].Value = spisok_grants[i].title;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[1].Value = spisok_grants[i].ruk;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[2].Value = spisok_grants[i].ispol;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[3].Value = spisok_grants[i].year;
                    }
                    if(name == "Clear")
                    {
                        frmplan.dataGridView7.Rows.Add();
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[0].Value = spisok_grants[i].title;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[1].Value = spisok_grants[i].ruk;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[2].Value = spisok_grants[i].ispol;
                        frmplan.dataGridView7.Rows[frmplan.dataGridView7.Rows.Count - 1].Cells[3].Value = spisok_grants[i].year;
                    }
                    frmplan.tsPBAll.Value = i;
                   
                }
                else
                {
                    frmplan.dataGridView7.Rows.Add();
                    frmplan.dataGridView7.Rows[i].Cells[0].Value = spisok_grants[i].title;
                    frmplan.dataGridView7.Rows[i].Cells[1].Value = spisok_grants[i].ruk;
                    frmplan.dataGridView7.Rows[i].Cells[2].Value = spisok_grants[i].ispol;
                    frmplan.dataGridView7.Rows[i].Cells[3].Value = spisok_grants[i].year;
                    pecent++;
                    this.pgrTotal.Value = pecent;
                    this.pgrCurrent.Value = i;
                }
                frmplan.tsLabAll.Text = "Количество записей: " + frmplan.dataGridView7.Rows.Count.ToString();
                frmplan.tsPBAll.Visible = false;
            }
        }
        public void show_spisok_merop(string usl = "", string name = "")
        {
            string lvl = "", typ = "";
            if (usl != "")
            {
                frmplan.tsPBAll.Visible = true;
                frmplan.tsPBAll.Maximum = Spisok_Merop.Count();
                for (int i = 0; i < Spisok_Merop.Count(); i++)
                {

                   
                    switch (Spisok_Merop[i].level)
                    {
                        case "М":
                            lvl = "Международное";
                            break;
                        case "В":
                            lvl = "Всероссийское";
                            break;
                        case "Р":
                            lvl = "Региональное";
                            break;
                        case "З":
                            lvl = "Внутривузовское";
                            break;
                    }
                    switch (Spisok_Merop[i].type)
                    {
                        case "К":
                            typ = "Конференция";
                            break;
                        case "С":
                            typ = "Семинар";
                            break;
                        case "Ф":
                            typ = "Форум";
                            break;
                        case "В":
                            typ = "Выставка";
                            break;
                        case "О":
                            typ = "Олимпиада";
                            break;
                        case "Н":
                            typ = "Конкурс";
                            break;
                    }
                    if(usl == "Clear")
                    {
                        frmplan.dataGridView2.Rows.Add();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[0].Value = Spisok_Merop[i].events;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[1].Value = Spisok_Merop[i].head;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[2].Value = typ;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[3].Value = lvl;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[4].Value = Spisok_Merop[i].students;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[5].Value = Spisok_Merop[i].bdate.ToShortDateString() + " - " + Spisok_Merop[i].edate.ToShortDateString();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[6].Value = Spisok_Merop[i].owner;
                    }
                    if (usl == "1" && Spisok_Merop[i].events.Contains(name))
                    {
                        frmplan.dataGridView2.Rows.Add();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[0].Value = Spisok_Merop[i].events;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[1].Value = Spisok_Merop[i].head;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[2].Value = typ;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[3].Value = lvl;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[4].Value = Spisok_Merop[i].students;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[5].Value = Spisok_Merop[i].bdate.ToShortDateString() + " - " + Spisok_Merop[i].edate.ToShortDateString();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[6].Value = Spisok_Merop[i].owner;
                    }
                    if (usl == "2" && Spisok_Merop[i].bdate.ToShortDateString().Contains(name))
                    {
                        frmplan.dataGridView2.Rows.Add();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[0].Value = Spisok_Merop[i].events;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[1].Value = Spisok_Merop[i].head;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[2].Value = typ;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[3].Value = lvl;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[4].Value = Spisok_Merop[i].students;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[5].Value = Spisok_Merop[i].bdate.ToShortDateString() + " - " + Spisok_Merop[i].edate.ToShortDateString();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[6].Value = Spisok_Merop[i].owner;
                    }
                    if (usl == "3" && typ.Contains(name))
                    {
                        frmplan.dataGridView2.Rows.Add();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[0].Value = Spisok_Merop[i].events;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[1].Value = Spisok_Merop[i].head;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[2].Value = typ;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[3].Value = lvl;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[4].Value = Spisok_Merop[i].students;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[5].Value = Spisok_Merop[i].bdate.ToShortDateString() + " - " + Spisok_Merop[i].edate.ToShortDateString();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[6].Value = Spisok_Merop[i].owner;
                    }
                    if (usl == "4" && lvl.Contains(name))
                    {
                        frmplan.dataGridView2.Rows.Add();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[0].Value = Spisok_Merop[i].events;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[1].Value = Spisok_Merop[i].head;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[2].Value = typ;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[3].Value = lvl;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[4].Value = Spisok_Merop[i].students;
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[5].Value = Spisok_Merop[i].bdate.ToShortDateString() + " - " + Spisok_Merop[i].edate.ToShortDateString();
                        frmplan.dataGridView2.Rows[frmplan.dataGridView2.Rows.Count - 1].Cells[6].Value = Spisok_Merop[i].owner;
                    }
                    
                   
                    frmplan.tsPBAll.Value = i;

                }
                frmplan.tsPBAll.Visible = false;
                frmplan.tsLabAll.Text = "Количество записей: " + frmplan.dataGridView2.Rows.Count.ToString();
            }
            else
            {
                this.pgrCurrent.Maximum = Spisok_Merop.Count();
                for (int i = 0; i < Spisok_Merop.Count(); i++)
                {
                  
                   
                    switch (Spisok_Merop[i].level)
                    {
                        case "М":
                            lvl = "Международное";
                            break;
                        case "В":
                            lvl = "Всероссийское";
                            break;
                        case "Р":
                            lvl = "Региональное";
                            break;
                        case "З":
                            lvl = "Внутривузовское";
                            break;
                    }
                    switch (Spisok_Merop[i].type)
                    {
                        case "К":
                            typ = "Конференция";
                            break;
                        case "С":
                            typ = "Семинар";
                            break;
                        case "Ф":
                            typ = "Форум";
                            break;
                        case "В":
                            typ = "Выставка";
                            break;
                        case "О":
                            typ = "Олимпиада";
                            break;
                        case "Н":
                            typ = "Конкурс";
                            break;
                    }
                    frmplan.dataGridView2.Rows.Add();
                    frmplan.dataGridView2.Rows[i].Cells[0].Value = Spisok_Merop[i].events;
                    frmplan.dataGridView2.Rows[i].Cells[1].Value = Spisok_Merop[i].head;
                    frmplan.dataGridView2.Rows[i].Cells[2].Value = typ;
                    frmplan.dataGridView2.Rows[i].Cells[3].Value = lvl;
                    frmplan.dataGridView2.Rows[i].Cells[4].Value = Spisok_Merop[i].students;
                    frmplan.dataGridView2.Rows[i].Cells[5].Value = Spisok_Merop[i].bdate.ToShortDateString() + " - " + Spisok_Merop[i].edate.ToShortDateString();
                    frmplan.dataGridView2.Rows[i].Cells[6].Value = Spisok_Merop[i].owner;
                    pecent++;
                    this.pgrTotal.Value = pecent;
                    this.pgrCurrent.Value = i;
                }
                
            }
            
        }
        public void show_jurnals(string usl = "", string name = "")
        {
            if (usl != "")
            {
                frmplan.tsPBAll.Visible = true;
                frmplan.tsPBAll.Maximum = spisok_jurnalstat.Count();
                

                for (int i = 0; i < spisok_jurnalstat.Count(); i++)
                {
                    string st = "";
                    if (spisok_jurnalstat[i].is_scorpus) st += "SCOPUS ";
                    if (spisok_jurnalstat[i].is_wos) st += "WOS ";
                    if (spisok_jurnalstat[i].is_hac) st += "HAC ";
                    if (spisok_jurnalstat[i].is_humanities) st += "PLUS ";
                    if (spisok_jurnalstat[i].is_rsci) st += "RSCI ";
                    if (spisok_jurnalstat[i].is_google) st += "GOOGLE ";
                   
                    if (usl == "Clear")
                    {
                        frmplan.dataGridView6.Rows.Add();
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[0].Value = spisok_jurnalstat[i].outside_autors != "" ? spisok_jurnalstat[i].author + " соавторство: " + spisok_jurnalstat[i].outside_autors : spisok_jurnalstat[i].author;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[1].Value = spisok_jurnalstat[i].title;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[4].Value = st.Trim();
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[2].Value = spisok_jurnalstat[i].jurnal;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[5].Value = spisok_jurnalstat[i].year;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[3].Value = spisok_jurnalstat[i].pages;
                    }
                    if (usl == "1" && spisok_jurnalstat[i].title.Contains(name))
                    {
                        frmplan.dataGridView6.Rows.Add();
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[0].Value = spisok_jurnalstat[i].outside_autors != "" ? spisok_jurnalstat[i].author + " соавторство: " + spisok_jurnalstat[i].outside_autors : spisok_jurnalstat[i].author;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[1].Value = spisok_jurnalstat[i].title;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[4].Value = st.Trim();
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[2].Value = spisok_jurnalstat[i].jurnal;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[5].Value = spisok_jurnalstat[i].year;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[3].Value = spisok_jurnalstat[i].pages;
                    }
                    if (usl == "2" && spisok_jurnalstat[i].year.ToString().Contains(name))
                    {
                        frmplan.dataGridView6.Rows.Add();
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[0].Value = spisok_jurnalstat[i].outside_autors != "" ? spisok_jurnalstat[i].author + " соавторство: " + spisok_jurnalstat[i].outside_autors : spisok_jurnalstat[i].author;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[1].Value = spisok_jurnalstat[i].title;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[4].Value = st.Trim();
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[2].Value = spisok_jurnalstat[i].jurnal;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[5].Value = spisok_jurnalstat[i].year;
                        frmplan.dataGridView6.Rows[frmplan.dataGridView6.Rows.Count - 1].Cells[3].Value = spisok_jurnalstat[i].pages;
                    }
                    frmplan.tsPBAll.Value = i;
                }

            }
            else
            {
                this.pgrCurrent.Maximum = spisok_jurnalstat.Count();
                for (int i = 0; i < spisok_jurnalstat.Count(); i++)
                {
                    string st = "";
                    if (spisok_jurnalstat[i].is_scorpus) st += "SCOPUS ";
                    if (spisok_jurnalstat[i].is_wos) st += "WOS ";
                    if (spisok_jurnalstat[i].is_hac) st += "HAC ";
                    if (spisok_jurnalstat[i].is_humanities) st += "PLUS ";
                    if (spisok_jurnalstat[i].is_rsci) st += "RSCI ";
                    if (spisok_jurnalstat[i].is_google) st += "GOOGLE ";
                    frmplan.dataGridView6.Rows.Add();
                    frmplan.dataGridView6.Rows[i].Cells[0].Value = spisok_jurnalstat[i].outside_autors != "" ? spisok_jurnalstat[i].author + " соавторство: " + spisok_jurnalstat[i].outside_autors : spisok_jurnalstat[i].author;
                    frmplan.dataGridView6.Rows[i].Cells[1].Value = spisok_jurnalstat[i].title;
                    frmplan.dataGridView6.Rows[i].Cells[4].Value = st.Trim();
                    frmplan.dataGridView6.Rows[i].Cells[2].Value = spisok_jurnalstat[i].jurnal;
                    frmplan.dataGridView6.Rows[i].Cells[5].Value = spisok_jurnalstat[i].year;
                    frmplan.dataGridView6.Rows[i].Cells[3].Value = spisok_jurnalstat[i].pages;
                    pecent++;
                    this.pgrTotal.Value = pecent;
                    this.pgrCurrent.Value = i;
                }

            }
            frmplan.tsPBAll.Visible = false;
        }

        public void show_tezis(string usl = "", string name = "")
        {
            if (usl != "")
            {
                frmplan.tsPBAll.Visible = true;
                frmplan.tsPBAll.Maximum = spisok_Tezis.Count();
                for (int i = 0; i < spisok_Tezis.Count(); i++)
                {
                    if (usl == "Clear")
                    {
                        frmplan.dataGridView3.Rows.Add();
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[0].Value = spisok_Tezis[i].author;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[1].Value = spisok_Tezis[i].title;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[2].Value = spisok_Tezis[i].booktitle;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[3].Value = spisok_Tezis[i].address;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[4].Value = spisok_Tezis[i].publicher;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[5].Value = spisok_Tezis[i].year;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[6].Value = spisok_Tezis[i].pages;
                    }
                    if (usl == "1" && spisok_Tezis[i].booktitle.Contains(name))
                    {
                        frmplan.dataGridView3.Rows.Add();
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[0].Value = spisok_Tezis[i].author;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[1].Value = spisok_Tezis[i].title;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[2].Value = spisok_Tezis[i].booktitle;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[3].Value = spisok_Tezis[i].address;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[4].Value = spisok_Tezis[i].publicher;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[5].Value = spisok_Tezis[i].year;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[6].Value = spisok_Tezis[i].pages;
                    }
                    if (usl == "2" && spisok_Tezis[i].year.ToString().Contains(name))
                    {
                        frmplan.dataGridView3.Rows.Add();
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[0].Value = spisok_Tezis[i].author;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[1].Value = spisok_Tezis[i].title;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[2].Value = spisok_Tezis[i].booktitle;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[3].Value = spisok_Tezis[i].address;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[4].Value = spisok_Tezis[i].publicher;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[5].Value = spisok_Tezis[i].year;
                        frmplan.dataGridView3.Rows[frmplan.dataGridView3.Rows.Count - 1].Cells[6].Value = spisok_Tezis[i].pages;
                    }
                    frmplan.tsPBAll.Value = i;
                }
                frmplan.tsPBAll.Visible = false;

            }
            else
            {
                this.pgrCurrent.Maximum = spisok_Tezis.Count();
                for (int i = 0; i < spisok_Tezis.Count(); i++)
                {
                    frmplan.dataGridView3.Rows.Add();
                    frmplan.dataGridView3.Rows[i].Cells[0].Value = spisok_Tezis[i].author;
                    frmplan.dataGridView3.Rows[i].Cells[1].Value = spisok_Tezis[i].title;
                    frmplan.dataGridView3.Rows[i].Cells[2].Value = spisok_Tezis[i].booktitle;
                    frmplan.dataGridView3.Rows[i].Cells[3].Value = spisok_Tezis[i].address;
                    frmplan.dataGridView3.Rows[i].Cells[4].Value = spisok_Tezis[i].publicher;
                    frmplan.dataGridView3.Rows[i].Cells[5].Value = spisok_Tezis[i].year;
                    frmplan.dataGridView3.Rows[i].Cells[6].Value = spisok_Tezis[i].pages;
                    pecent++;
                    this.pgrTotal.Value = pecent;
                    this.pgrCurrent.Value = i;
                }

            }
            
        }

        public void show_art(string usl = "", string name = "")
        {
            if (usl != "")
            {
                frmplan.tsPBAll.Visible = true;
                frmplan.tsPBAll.Maximum = art.Count();
                for (int i = 0; i < art.Count(); i++)
                {
                    if (usl == "Clear")
                    {
                        frmplan.dataGridView4.Rows.Add();
                        frmplan.dataGridView4.Rows[i].Cells[0].Value = art[i].athors;
                        frmplan.dataGridView4.Rows[i].Cells[1].Value = art[i].title;
                        frmplan.dataGridView4.Rows[i].Cells[2].Value = art[i].city;
                        frmplan.dataGridView4.Rows[i].Cells[3].Value = art[i].izdatelstvo;
                        frmplan.dataGridView4.Rows[i].Cells[4].Value = art[i].year;
                        frmplan.dataGridView4.Rows[i].Cells[5].Value = art[i].pages;
                    }
                    if (usl == "1" && art[i].title.Contains(name))
                    {
                        frmplan.dataGridView4.Rows.Add();
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[0].Value = art[i].athors;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[1].Value = art[i].title;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[2].Value = art[i].city;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[3].Value = art[i].izdatelstvo;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[4].Value = art[i].year;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[5].Value = art[i].pages;
                    }
                        if (usl == "2" && art[i].year.ToString().Contains(name))
                    {
                        frmplan.dataGridView4.Rows.Add();
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[0].Value = art[i].athors;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[1].Value = art[i].title;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[2].Value = art[i].city;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[3].Value = art[i].izdatelstvo;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[4].Value = art[i].year;
                        frmplan.dataGridView4.Rows[frmplan.dataGridView4.Rows.Count - 1].Cells[5].Value = art[i].pages;
                    }
                    frmplan.tsPBAll.Value = i;
                }
                frmplan.tsPBAll.Visible = false;
            }
            else
            {
                this.pgrCurrent.Maximum = art.Count();
                for (int i = 0; i < art.Count(); i++)
                {
                    
                    frmplan.dataGridView4.Rows.Add();
                    frmplan.dataGridView4.Rows[i].Cells[0].Value = art[i].athors;
                    frmplan.dataGridView4.Rows[i].Cells[1].Value = art[i].title;
                    frmplan.dataGridView4.Rows[i].Cells[2].Value = art[i].city;
                    frmplan.dataGridView4.Rows[i].Cells[3].Value = art[i].izdatelstvo;
                    frmplan.dataGridView4.Rows[i].Cells[4].Value = art[i].year;
                    frmplan.dataGridView4.Rows[i].Cells[5].Value = art[i].pages;
                    pecent++;
                    this.pgrTotal.Value = pecent;
                    this.pgrCurrent.Value = i;
                }
            }
        }

        public void show_sbortrud(string usl = "", string name = "")
        {
            if (usl != "")
            {
                frmplan.tsPBAll.Visible = true;
                frmplan.tsPBAll.Maximum = spisok_sbortrud.Count();
                for (int i = 0; i < spisok_sbortrud.Count(); i++)
                {
                    if (usl == "Clear")
                    {
                        frmplan.dataGridView5.Rows.Add();
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[0].Value = spisok_sbortrud[i].author;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[1].Value = spisok_sbortrud[i].title;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[2].Value = spisok_sbortrud[i].address;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[3].Value = spisok_sbortrud[i].publicher;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[4].Value = spisok_sbortrud[i].year;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[5].Value = spisok_sbortrud[i].num_pages;
                    }
                    if (usl == "1" && spisok_sbortrud[i].title.Contains(name))
                    {
                        frmplan.dataGridView5.Rows.Add();
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count -1].Cells[0].Value = spisok_sbortrud[i].author;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[1].Value = spisok_sbortrud[i].title;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[2].Value = spisok_sbortrud[i].address;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[3].Value = spisok_sbortrud[i].publicher;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[4].Value = spisok_sbortrud[i].year;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[5].Value = spisok_sbortrud[i].num_pages;
                    }
                    if(usl == "2" && spisok_sbortrud[i].year.ToString().Contains(name))
                    {
                        frmplan.dataGridView5.Rows.Add();
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[0].Value = spisok_sbortrud[i].author;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[1].Value = spisok_sbortrud[i].title;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[2].Value = spisok_sbortrud[i].address;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[3].Value = spisok_sbortrud[i].publicher;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[4].Value = spisok_sbortrud[i].year;
                        frmplan.dataGridView5.Rows[frmplan.dataGridView5.Rows.Count - 1].Cells[5].Value = spisok_sbortrud[i].num_pages;
                    }

                    frmplan.tsPBAll.Value = i;
                }
                frmplan.tsPBAll.Visible = false;
            }
            else
            {
                this.pgrCurrent.Maximum = spisok_sbortrud.Count();
                for (int i = 0; i < spisok_sbortrud.Count(); i++)
                {
                    frmplan.dataGridView5.Rows.Add();
                    frmplan.dataGridView5.Rows[i].Cells[0].Value = spisok_sbortrud[i].author;
                    frmplan.dataGridView5.Rows[i].Cells[1].Value = spisok_sbortrud[i].title;
                    frmplan.dataGridView5.Rows[i].Cells[2].Value = spisok_sbortrud[i].address;
                    frmplan.dataGridView5.Rows[i].Cells[3].Value = spisok_sbortrud[i].publicher;
                    frmplan.dataGridView5.Rows[i].Cells[4].Value = spisok_sbortrud[i].year;
                    frmplan.dataGridView5.Rows[i].Cells[5].Value = spisok_sbortrud[i].num_pages;
                    pecent++;
                    this.pgrTotal.Value = pecent;
                    this.pgrCurrent.Value = i;
                }
            }
        }

        public void show_desert(string usl = "", string name = "")
        {
            if (usl != "")
            {
                frmplan.tsPBAll.Visible = true;
                frmplan.tsPBAll.Maximum = list_diserts.Count();
                for (int i = 0; i < list_diserts.Count(); i++)
                {
                    if (usl == "Clear")
                    {
                        frmplan.dataGridView8.Rows.Add();
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[0].Value = list_diserts[i].title;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[1].Value = list_diserts[i].author;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[2].Value = list_diserts[i].phdtype;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[3].Value = list_diserts[i].year;
                    }
                    if (usl == "1" && list_diserts[i].title.Contains(name))
                    {
                        frmplan.dataGridView8.Rows.Add();
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[0].Value = list_diserts[i].title;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[1].Value = list_diserts[i].author;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[2].Value = list_diserts[i].phdtype;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[3].Value = list_diserts[i].year;
                    }
                    if (usl == "2" && list_diserts[i].year.ToString().Contains(name))
                    {
                        frmplan.dataGridView8.Rows.Add();
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[0].Value = list_diserts[i].title;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[1].Value = list_diserts[i].author;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[2].Value = list_diserts[i].phdtype;
                        frmplan.dataGridView8.Rows[frmplan.dataGridView8.Rows.Count - 1].Cells[3].Value = list_diserts[i].year;
                    }
                    frmplan.tsPBAll.Value = i;
                }
                frmplan.tsPBAll.Visible = false;
            }
            else
            {
                this.pgrCurrent.Maximum = list_diserts.Count();
                for (int i = 0; i < list_diserts.Count(); i++)
                {
                  
                    frmplan.dataGridView8.Rows.Add();
                    frmplan.dataGridView8.Rows[i].Cells[0].Value = list_diserts[i].title;
                    frmplan.dataGridView8.Rows[i].Cells[1].Value = list_diserts[i].author;
                    frmplan.dataGridView8.Rows[i].Cells[2].Value = list_diserts[i].phdtype;
                    frmplan.dataGridView8.Rows[i].Cells[3].Value = list_diserts[i].year;
                    pecent++;
                    this.pgrTotal.Value = pecent;
                    this.pgrCurrent.Value = i;
                }
            }
        }

        public void show_books(string usl = "", string name = "")
        {
            if (usl != "")
            {
                frmplan.tsPBAll.Visible = true;
                frmplan.tsPBAll.Maximum = list_books.Count();
                for (int i = 0; i < list_books.Count(); i++)
                {
                    if (usl == "Clear")
                    {
                        frmplan.dataGridView9.Rows.Add();
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[0].Value = list_books[i].title;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[1].Value = list_books[i].authors;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[2].Value = list_books[i].publisher;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[3].Value = list_books[i].year;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[4].Value = list_books[i].pages;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[5].Value = list_books[i].type;
                    }
                    if (usl == "1" && list_books[i].title.Contains(name))
                    {
                        frmplan.dataGridView9.Rows.Add();
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count -1].Cells[0].Value = list_books[i].title;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[1].Value = list_books[i].authors;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[2].Value = list_books[i].publisher;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[3].Value = list_books[i].year;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[4].Value = list_books[i].pages;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[5].Value = list_books[i].type;
                    }

                    if(usl == "2" && list_books[i].year.ToString().Contains(name))
                    {
                        frmplan.dataGridView9.Rows.Add();
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[0].Value = list_books[i].title;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[1].Value = list_books[i].authors;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[2].Value = list_books[i].publisher;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[3].Value = list_books[i].year;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[4].Value = list_books[i].pages;
                        frmplan.dataGridView9.Rows[frmplan.dataGridView9.Rows.Count - 1].Cells[5].Value = list_books[i].type;
                    }
                    frmplan.tsPBAll.Value = i;
                }
                frmplan.tsPBAll.Visible = false;
            }
            else
            {
                this.pgrCurrent.Maximum = list_books.Count();
                for (int i = 0; i < list_books.Count(); i++)
                {
                   
                    frmplan.dataGridView9.Rows.Add();
                    frmplan.dataGridView9.Rows[i].Cells[0].Value = list_books[i].title;
                    frmplan.dataGridView9.Rows[i].Cells[1].Value = list_books[i].authors;
                    frmplan.dataGridView9.Rows[i].Cells[2].Value = list_books[i].publisher;
                    frmplan.dataGridView9.Rows[i].Cells[3].Value = list_books[i].year;
                    frmplan.dataGridView9.Rows[i].Cells[4].Value = list_books[i].pages;
                    frmplan.dataGridView9.Rows[i].Cells[5].Value = list_books[i].type;
                    pecent++;
                    this.pgrTotal.Value = pecent;
                    this.pgrCurrent.Value = i;
                }

            }
        }


        string host; // Имя хоста
        string database; // Имя базы данных
        string user; //Имя пользователя
        string password; // Пароль пользователя
        private void Form1_Load(object sender, EventArgs e)
        {         
            login frmlogin = new login();
            this.Hide();
            frmlogin.ShowDialog();
            host = frmlogin.host;
            database = frmlogin.database;
            user = frmlogin.user;
            password = frmlogin.password;
            if (frmlogin.exit) Application.Exit();
            else
            {
                this.Show();
                this.SetTopLevel(true);
                this.Update();
                frmplan.Owner = this;
                int id = frmlogin.id;
                string query_SpisokMerop = "Select sci_userprofile.last_name,sci_userprofile.first_name,sci_userprofile.middle_name,sci_event.type,sci_event.level" +
                    ",students,sci_studentattendanevent.year,is_report,report,bdate,edate,fullname,base,name from sci_studentattendanevent,sci_departament,sci_userprofile,auth_user, sci_event where sci_studentattendanevent.dept_id=sci_departament.id and sci_studentattendanevent.event_id=sci_event.id and sci_studentattendanevent.head_id=sci_userprofile.id and sci_studentattendanevent.owner_id = auth_user.id";
                string query_Tezis = "SELECT sci_userprofile.last_name,sci_userprofile.middle_name,sci_userprofile.first_name,sci_inproceedings.title,sci_inproceedings.booktitle,sci_inproceedings.publisher,sci_inproceedings.address,sci_inproceedings.year,sci_inproceedings.pages FROM sci_userprofile, sci_inproceedings_author, sci_inproceedings where sci_userprofile.id = sci_inproceedings_author.userprofile_id and sci_inproceedings_author.inproceedings_id= sci_inproceedings.id";
                string query_jurnalstat = "Select last_name, middle_name,  first_name,title, year, short_name, outside_coauthors,  pages, sci_article.is_rsci, sci_article.is_wos, sci_article.is_scopus, sci_article.is_humanities, sci_article.is_hac, sci_article.is_google_scholar from sci_userprofile, sci_article_author, sci_journal, sci_article, sci_scitheme where sci_scitheme.id = sci_article.scitheme_id and sci_article.journal_id = sci_journal.id and sci_article.id = sci_article_author.article_id and sci_article_author.userprofile_id = sci_userprofile.id";
                string query_sbortrud = "SELECT sci_userprofile.last_name,sci_userprofile.middle_name,sci_userprofile.first_name,sci_proceeding.title,sci_proceeding.publisher,sci_proceeding.address,sci_proceeding.year,sci_proceeding.num_pages FROM sci_userprofile, sci_proceeding, sci_proceeding_editor where sci_userprofile.id = sci_proceeding_editor.userprofile_id and sci_proceeding_editor.proceeding_id= sci_proceeding.id";
                string query_Aticle = "Select sci_userprofile.last_name, sci_userprofile.middle_name,sci_userprofile.first_name, title, booktitle, publisher,address,sci_incollection.year, pages from sci_incollection, sci_incollection_author, sci_userprofile where sci_userprofile.id = sci_incollection_author.userprofile_id and sci_incollection_author.incollection_id = sci_incollection.id";
                string query_ruc_grant = "SELECT sci_grant.id,sci_grant.title,sci_userprofile.last_name,sci_userprofile.middle_name, sci_userprofile.first_name, sci_grant.year FROM sci_grant,sci_userprofile ,sci_grant_heads where sci_grant.id = sci_grant_heads.grant_id and sci_userprofile.id = sci_grant_heads.userprofile_id";
                string query_isp_grant = "SELECT sci_grant.id,sci_userprofile.last_name,sci_userprofile.middle_name, sci_userprofile.first_name,title FROM sci_grant,sci_userprofile ,sci_grant_performers where sci_grant.id = sci_grant_performers.grant_id and sci_userprofile.id = sci_grant_performers.userprofile_id";
                string query_phdthesis = "select sci_phdthesis.title, sci_userprofile.last_name,sci_userprofile.first_name,sci_userprofile.middle_name,sci_phdthesis.year, sci_phdthesis.phdtype from sci_phdthesis,sci_userprofile where sci_phdthesis.author_id = sci_userprofile.id";
                string query_book = @"SELECT title,publisher,sci_book.year, type, outside_coauthors,numpages,address,GROUP_CONCAT(sci_userprofile.last_name,' ',SUBSTR(sci_userprofile.first_name,1,1),'.',SUBSTR(sci_userprofile.middle_name,1,1),'.') FROM sci_book,sci_book_author,sci_userprofile where sci_book_author.book_id = sci_book.id and sci_book_author.userprofile_id = sci_userprofile.id group by sci_book.id";
                string query_prof = "select science,dept,sci_userprofile.last_name,sci_userprofile.first_name,sci_userprofile.middle_name,owner_id,COALESCE(sci_userprofile.academic_title_id,1),COALESCE(sci_userprofile.degree_id,1),auth_user.username,auth_user.email FROM sci_userprofile,auth_user where sci_userprofile.owner_id = auth_user.id and owner_id = " + id;
               
               
                string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;     
                
                this.label1.Text = "Получаем информацию с базы данных";
                this.label1.Update();
                this.pgrTotal.Visible = false;
                this.pgrCurrent.Visible = false;
                this.label2.Visible = false;             
                MySqlConnection mysql_connection = new MySqlConnection(Connect);
                MySqlCommand mysql_query = null;
                MySqlDataReader mysql_result = null;
                Tezis spTez = new Tezis();
                Articl ar = new Articl(); ;
                SpisokMerop spisok = new SpisokMerop();
                sbortrud spSbtrud = new sbortrud();
                jurnalstat jrstat = new jurnalstat();
                grants grant = new grants();
                grantsisp gr_sip = new grantsisp();
                grants_ruk gr_ruk = new grants_ruk();
                disserts phd_diserts = new disserts();
                books book = new books();
                profil prof = new profil();
                try
                {
                    mysql_connection.Open();
                    mysql_query = new MySqlCommand(query_jurnalstat, mysql_connection);
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        jrstat.author = mysql_result.GetString(0) + " " + mysql_result.GetString(1)[0] + "." + mysql_result.GetString(2)[0];
                        jrstat.title = mysql_result.GetString(3);
                        jrstat.year = Convert.ToInt32(mysql_result.GetString(4));
                        jrstat.jurnal = mysql_result.GetString(5);
                        jrstat.outside_autors = mysql_result.GetString(6);
                        jrstat.pages = mysql_result.GetString(7);
                        jrstat.is_rsci = Convert.ToBoolean(mysql_result.GetString(8));
                        jrstat.is_wos = Convert.ToBoolean(mysql_result.GetString(9));
                        jrstat.is_scorpus = Convert.ToBoolean(mysql_result.GetString(10));
                        jrstat.is_humanities = Convert.ToBoolean(mysql_result.GetString(11));
                        jrstat.is_hac = Convert.ToBoolean(mysql_result.GetString(12));
                        jrstat.is_google = Convert.ToBoolean(mysql_result.GetString(13));
                        spisok_jurnalstat.Add(jrstat);

                    }
                    mysql_connection.Close();
                    mysql_connection.Open();
                    mysql_query = new MySqlCommand(query_SpisokMerop, mysql_connection);
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        spisok.head = mysql_result.GetString(0) + " " + mysql_result.GetString(1)[0] + "." + mysql_result.GetString(2)[0];
                        spisok.type = mysql_result.GetString(3);
                        spisok.level = mysql_result.GetString(4);
                        spisok.students = mysql_result.GetString(5);
                        spisok.year = Convert.ToInt32(mysql_result.GetString(6));
                        spisok.is_report = Convert.ToBoolean(mysql_result.GetString(7));
                        spisok.report = mysql_result.GetString(8);
                        spisok.bdate = Convert.ToDateTime(mysql_result.GetString(9));
                        spisok.edate = Convert.ToDateTime(mysql_result.GetString(10));
                        spisok.events = mysql_result.GetString(11);
                        spisok.dept = mysql_result.GetString(13);
                        spisok.owner = mysql_result.GetString(12);
                        Spisok_Merop.Add(spisok);

                    }
                    mysql_connection.Close();
                    mysql_query = new MySqlCommand(query_Tezis, mysql_connection);
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        spTez.author = mysql_result.GetString(0) + " " + mysql_result.GetString(1)[0] + "." + mysql_result.GetString(2)[0];
                        spTez.title = mysql_result.GetString(3);
                        spTez.booktitle = mysql_result.GetString(4);
                        spTez.publicher = mysql_result.GetString(5);
                        spTez.address = mysql_result.GetString(6);
                        spTez.year = Convert.ToInt32(mysql_result.GetString(7));
                        spTez.pages = mysql_result.GetString(8);
                        spisok_Tezis.Add(spTez);

                    }
                    mysql_connection.Close();
                    mysql_query = new MySqlCommand(query_sbortrud, mysql_connection);
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        spSbtrud.author = mysql_result.GetString(0) + " " + mysql_result.GetString(1)[0] + "." + mysql_result.GetString(2)[0];
                        spSbtrud.title = mysql_result.GetString(3);
                        spSbtrud.publicher = mysql_result.GetString(4);
                        spSbtrud.address = mysql_result.GetString(5);
                        spSbtrud.year = Convert.ToInt32(mysql_result.GetString(6));
                        spSbtrud.num_pages = mysql_result.GetString(7);
                        spisok_sbortrud.Add(spSbtrud);

                    }
                    mysql_connection.Close();
                    mysql_query = new MySqlCommand(query_Aticle, mysql_connection);
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        ar.athors = mysql_result.GetString(0) + " " + mysql_result.GetString(1)[0] + "." + mysql_result.GetString(2)[0];
                        ar.title = mysql_result.GetString(3);
                        ar.booktitle = mysql_result.GetString(4);
                        ar.izdatelstvo = mysql_result.GetString(5);
                        ar.city = mysql_result.GetString(6);
                        ar.year = Convert.ToInt32(mysql_result.GetString(7));
                        ar.pages = mysql_result.GetString(8);
                        art.Add(ar);

                    }
                    mysql_connection.Close();
                    mysql_query = new MySqlCommand(query_phdthesis, mysql_connection);
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        phd_diserts.title = mysql_result.GetString(0);
                        phd_diserts.author = mysql_result.GetString(1) + " " + mysql_result.GetString(2)[0] + "." + mysql_result.GetString(3)[0];
                        switch (mysql_result.GetString(5))
                        {
                            case "Д":
                                phd_diserts.phdtype = "Докторская";
                                break;
                            case "К":
                                phd_diserts.phdtype = "Колективная монография";
                                break;
                            case "М":
                                phd_diserts.phdtype = "Магистерская диссертация";
                                break;
                            case "А":
                                phd_diserts.phdtype = "Автореферат";
                                break;
                        }

                        phd_diserts.year = Convert.ToInt32(mysql_result.GetString(4));

                        list_diserts.Add(phd_diserts);

                    }
                    mysql_connection.Close();
                    mysql_query = new MySqlCommand(query_book, mysql_connection);
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        book.title = mysql_result.GetString(0);
                        book.publisher = mysql_result.GetString(1);
                        book.year = Convert.ToInt32(mysql_result.GetString(2));
                        switch (mysql_result.GetString(3))
                        {
                            case "М":
                                book.type = "Монография";
                                break;
                            case "К":
                                book.type = "Колективная монография";
                                break;
                            case "У":
                                book.type = "Учебник";
                                break;
                            case "П":
                                book.type = "Учебное пособие";
                                break;
                            case "Д":
                                book.type = "Другое";
                                break;
                        }
                        book.coathors = mysql_result.GetString(4);
                        book.pages = mysql_result.GetString(5);
                        book.address = mysql_result.GetString(6);
                        book.authors = mysql_result.GetString(7);


                        list_books.Add(book);

                    }
                    mysql_connection.Close();
                    mysql_query = new MySqlCommand(query_ruc_grant, mysql_connection);
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        gr_ruk.id = mysql_result.GetString(0);
                        gr_ruk.title = mysql_result.GetString(1);
                        gr_ruk.ruk = mysql_result.GetString(2) + " " + mysql_result.GetString(3)[0] + "." + mysql_result.GetString(4)[0];
                        gr_ruk.year = Convert.ToInt32(mysql_result.GetString(5));
                        view_ruc.Add(gr_ruk);

                    }
                    mysql_connection.Close();
                    mysql_query = new MySqlCommand(query_isp_grant, mysql_connection);
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        gr_sip.id = mysql_result.GetString(0);
                        gr_sip.ispol = mysql_result.GetString(1) + " " + mysql_result.GetString(2)[0] + "." + mysql_result.GetString(3)[0];
                        view_gr.Add(gr_sip);

                    }
                    mysql_connection.Close();
                    mysql_query = new MySqlCommand(query_prof, mysql_connection);
                    mysql_connection.Open();
                    mysql_result = mysql_query.ExecuteReader();
                    while (mysql_result.Read())
                    {
                        try
                        {
                            prof.science = mysql_result.GetString(0);
                            prof.dept = mysql_result.GetString(1);
                            prof.last_name = mysql_result.GetString(2);
                            prof.first_name = mysql_result.GetString(3);
                            prof.middle_name = mysql_result.GetString(4);

                            prof.kad_name = mysql_result.GetString(6);
                            prof.deg_name = mysql_result.GetString(7);
                            prof.name = mysql_result.GetString(8);
                            prof.mail = mysql_result.GetString(9);

                            list_profil.Add(prof);
                        }
                        catch { }
                        cnt++;
                    }
                    mysql_connection.Close();
                }
                catch { MessageBox.Show("Ошибка подключения к бд"); }
                for (int i = 0; i < view_ruc.Count(); i++)
                {
                    string ispol = "";
                    for (int j = 0; j < view_gr.Count(); j++)
                    {
                        if (view_gr[j].id == view_ruc[i].id) ispol += view_gr[j].ispol + " ";
                    }
                    grant.id = view_ruc[i].id;
                    grant.title = view_ruc[i].title;
                    grant.ruk = view_ruc[i].ruk;
                    grant.ispol = ispol.Trim();
                    grant.year = view_ruc[i].year;
                    ispol = "";
                    spisok_grants.Add(grant);
                }             
                cnt = art.Count + Spisok_Merop.Count + spisok_Tezis.Count + spisok_sbortrud.Count + spisok_jurnalstat.Count + spisok_grants.Count + list_diserts.Count + list_books.Count + list_profil.Count;
                this.pgrTotal.Maximum = cnt;
                this.pgrTotal.Visible = true;
                this.pgrCurrent.Visible = true;
                this.label2.Visible = true;
                this.label2.Text = "Заполняем журналы";
                this.label2.Update();
                show_jurnals();
                this.label2.Text = "Заполняем мероприятия";
                this.label2.Update();
                show_spisok_merop();
                this.label2.Text = "Заполняем тезисы";
                this.label2.Update();
                show_tezis();
                this.label2.Text = "Заполняем сборники трудов";
                this.label2.Update();
                show_sbortrud();
                this.label2.Text = "Заполняем статьи в трудах (материалах) конференций";
                this.label2.Update();
                show_art();
                this.label2.Text = "Заполняем гранты";
                this.label2.Update();
                show_grants();
                this.label2.Text = "Заполняем диссертации";
                this.label2.Update();
                show_desert();
                this.label2.Text = "Заполняем книги";
                this.label2.Update();
                show_books();
                this.Hide();
                this.MinimizeBox = true;
                frmplan.ShowDialog();
                if (frmplan.close == true)   this.Close();               
            }
        }

        private void pgrTotal_Click(object sender, EventArgs e)
        {

        }

        /** private void btnProf_Click(object sender, EventArgs e)
         {
             Profil frmprof = new Profil();
             this.Hide();
             frmprof.tbxdeg.Text = list_profil[0].deg_name;
             frmprof.tbxdep.Text = list_profil[0].dept;
             frmprof.tbxfam.Text = list_profil[0].last_name;
             frmprof.txtname.Text = list_profil[0].first_name;
             frmprof.tbxotch.Text = list_profil[0].middle_name;
             frmprof.tbxscines.Text = list_profil[0].science;
             frmprof.tbxstep.Text = list_profil[0].kad_name;
             frmprof.tbxname.Text = list_profil[0].name;
             frmprof.tbxmail.Text = list_profil[0].mail;
             frmprof.ShowDialog();
             if (frmprof.close == true) this.Show();
         }*/

        /* private void btnPlan_Click(object sender, EventArgs e)
         {
             Plan frmplan = new Plan();
             this.Hide();
             frmplan.ShowDialog();
             if (frmplan.close == true) this.Show();
         }
        */


    }
}
