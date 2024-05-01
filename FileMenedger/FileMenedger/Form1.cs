using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileMenedger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string LeftPath;
        string RightPath;
        string LeftbackPath;
        string RightbackPath;
        Boolean leftflag;
        List<string> ls = new List<string>();

        void GetLocDir()
        {
           
            this.Text = "Файловый менеджер";
            String[] LogicalDrives = Environment.GetLogicalDrives();
            foreach (string s in LogicalDrives)
            {
                DriveInfo dr = new DriveInfo(s);
                if (dr.IsReady)
                {
                    cmbdrivelistleft.Items.Add(s);
                    cmbdrivelistright.Items.Add(s);
                }
            }
           
                cmbdrivelistleft.SelectedIndex = 0;
                cmbdrivelistright.SelectedIndex = 0;
            
        }

        void GetFiles(ListView pl, string FPath,ref string backPath)
        {
            pl.BeginUpdate();

            try
            {
                string[] dirs = Directory.GetDirectories(FPath);
                ls.Clear();

                try
                {
                    DirectoryInfo dInfo = new DirectoryInfo(FPath);
                    backPath = dInfo.Parent.FullName;
                }
                catch { }

                pl.Items.Clear();

                foreach (string s in dirs)
                {
                    string dirname = System.IO.Path.GetFileName(s);
                    pl.Items.Add(dirname, 1);

                    ls.Add(s);
                }

                
                DateTime dtModifyDate;
                double lFileSize = 0;

                string[] lvData = new string[3];
                string[] files = Directory.GetFiles(FPath);
                foreach (string s in files)
                {
                    string filename = Path.GetFileName(s);
                    FileInfo objFileSize = new FileInfo(s);
                   
                    lFileSize = objFileSize.Length;
                    dtModifyDate = objFileSize.LastWriteTime;

                    lvData[0] = filename;

                    if (lFileSize < 1024) lvData[1] = Math.Round(lFileSize,1).ToString() + " байт";
                    if (lFileSize >= 1024 && lFileSize < 1048576) lvData[1] = Math.Round((lFileSize / 1024),1).ToString() + " Кб";
                    if (lFileSize >= 1048576 && lFileSize < 1073741824) lvData[1] = Math.Round((lFileSize / (1024 * 1024)),1).ToString() + " Мб";
                    if (lFileSize >= 1073741824) lvData[1] = Math.Round((lFileSize / (1024 * 1024 * 1024)),1).ToString() + " Гб";
                   
                    
                    
                    lvData[2] = dtModifyDate.ToShortDateString();

                    ListViewItem lvItem = new ListViewItem(lvData, 0);
                    pl.Items.Add(lvItem);
                   
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            pl.EndUpdate();
        }

      

        private void cmbdrivelistleft_SelectedIndexChanged(object sender, EventArgs e)
        {
            LeftbackPath = cmbdrivelistleft.SelectedItem.ToString();
            label2.Text = LeftbackPath;
            LeftPath = LeftbackPath;
            GetFiles(leftpanal, LeftPath,ref LeftbackPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            GetLocDir();
            
        }

      
        private void leftpanal_ItemActivate(object sender, EventArgs e)
        {
            if (leftpanal.SelectedItems.Count == 0)
                return;

            ListViewItem item = leftpanal.SelectedItems[0];
            if (item.ImageIndex == 1)
            {
                string it = item.Text;
                string title = "";
                foreach (string s in ls)
                {
                    try
                    {
                        if (s.Substring(s.Length - it.Length, it.Length) == it)
                        {
                            LeftPath = s;
                            title = s;
                            
                        }
                    }
                    catch { }
                }
                try
                {
                    string[] dirs = Directory.GetDirectories(LeftPath);
                    label2.Text = title;
                    GetFiles(leftpanal, LeftPath, ref LeftbackPath);
                                      
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            else if (item.ImageIndex == 0)
            {
                string start = label2.Text + "\\" + item.Text;
                try { System.Diagnostics.Process.Start(start); }
                catch (Exception ex) { MessageBox.Show(ex.Message); };
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = LeftbackPath;
            LeftPath = LeftbackPath;
           
            GetFiles(leftpanal, LeftPath,ref  LeftbackPath);
        }

        private void cmbdrivelistright_SelectedIndexChanged(object sender, EventArgs e)
        {
            RightbackPath = cmbdrivelistright.SelectedItem.ToString();
            label1.Text = RightbackPath;
            RightPath = RightbackPath;
            GetFiles(rightpanal, RightPath,ref RightbackPath);
           
           

        }

        private void rightpanal_ItemActivate(object sender, EventArgs e)
        {
            if (rightpanal.SelectedItems.Count == 0)
                return;

            ListViewItem item = rightpanal.SelectedItems[0];
            if (item.ImageIndex == 1)
            {
                string it = item.Text;
                string title = "";
                foreach (string s in ls)
                {
                    try
                    {
                        if (s.Substring(s.Length - it.Length, it.Length) == it)
                        {
                            RightPath = s;
                            title = s;
                        
                        }
                    }
                    catch { }
                }
                try
                {
                    string[] dirs = Directory.GetDirectories(RightPath);
                    label1.Text = title;
                    GetFiles(rightpanal, RightPath,ref RightbackPath);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            else if (item.ImageIndex == 0)
            {
                string start = label1.Text + "\\" + item.Text;
                try { System.Diagnostics.Process.Start(start); }
                catch (Exception ex) { MessageBox.Show(ex.Message); };
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = RightbackPath;
            RightPath = RightbackPath;
            GetFiles(rightpanal, RightPath,ref RightbackPath);
        }

     

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
           splitContainer2.SplitterDistance = splitContainer1.SplitterDistance;
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {
            splitContainer1.SplitterDistance = splitContainer2.SplitterDistance;
        }

        private void delitefiles(ref ListView pl, string path)
        {
            DialogResult rez = MessageBox.Show("Вы действительно хотите удалить файл(ы)", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (rez == DialogResult.Yes)
            {
                foreach (ListViewItem i in pl.SelectedItems)
                {
                    try
                    {
                        try
                        {
                            DirectoryInfo di = new DirectoryInfo(path + "\\" + i.Text);
                            di.Delete(true);
                        }

                        catch { }                        
                        try
                        {
                            if (label2.Text.LastIndexOf("\\") == 1) File.Delete(path + i.Text);
                            else File.Delete(path + "\\" + i.Text);
                            
                        }
                        catch { }
                    }
                    catch { }
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path1 = label2.Text;
            string path2 = label1.Text;
            if (leftflag == true)
            {
                delitefiles(ref leftpanal, path1);
                GetFiles(leftpanal, LeftPath, ref LeftbackPath);
                GetFiles(rightpanal, RightPath, ref RightbackPath);
            }
            else
            {
                delitefiles(ref rightpanal, path2);
                GetFiles(rightpanal, RightPath, ref RightbackPath);
                GetFiles(leftpanal, LeftPath, ref LeftbackPath);
            }
        }

        void movefiles(ref ListView p, string Fpath, string Cpath)
        {
            foreach (ListViewItem i in p.SelectedItems)
            {
                if (i.ImageIndex != 1) File.Move(Path.Combine(Fpath, i.Text), Path.Combine(Cpath, i.Text));
                else
                {
                    if (!Directory.Exists(Path.Combine(Cpath, i.Text)))
                    {
                        Directory.CreateDirectory(Path.Combine(Cpath, i.Text));
                        copefileswithdirectoryes(Path.Combine(Fpath, i.Text), Path.Combine(Cpath, i.Text));
                        Directory.Delete(Path.Combine(Fpath, i.Text), true);
                    }
                    else
                    {
                        DialogResult rez = MessageBox.Show("Заменить файлы?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rez == DialogResult.Yes)
                        {
                            copefileswithdirectoryes(Path.Combine(Fpath, i.Text), Path.Combine(Cpath, i.Text));
                            Directory.Delete(Path.Combine(Fpath, i.Text), true);

                        }
                    }
                }
            }

            GetFiles(leftpanal, LeftPath, ref LeftbackPath);
            GetFiles(rightpanal, RightPath, ref RightbackPath);
        }

        private void Move_Click(object sender, EventArgs e)
        {

            string spath = label1.Text;
            string cpath = label2.Text;
            if (leftflag == true) movefiles(ref leftpanal, cpath, spath);
            else movefiles(ref rightpanal, spath, cpath);
           
        }

        //узнаем количество файлов в выбранной директории
        void length(string Fpath, string Cpath, ref int k)
        {
            DirectoryInfo dir_inf = new DirectoryInfo(Fpath);
            k = dir_inf.GetFiles().Length;
            foreach (DirectoryInfo dir in dir_inf.GetDirectories())
            {
                k += dir.GetFiles().Length;
                copefileswithdirectoryes(dir.FullName, Cpath + "\\" + dir.Name);

            }
        }

        frmcopycs frmcopy = new frmcopycs();
        int filesforcopy = 0;
        int k = 0;
     
        void copefileswithdirectoryes(string Fpath, string Cpath)
        {
            //Берём нашу исходную папку
            DirectoryInfo dir_inf = new DirectoryInfo(Fpath);
          
            //Перебираем все внутренние папки
            foreach (DirectoryInfo dir in dir_inf.GetDirectories())
            {
                //Проверяем - если директории не существует, то создаём;
                if (Directory.Exists(Cpath + "\\" + dir.Name) != true)
                {
                    Directory.CreateDirectory(Cpath + "\\" + dir.Name);
                   
                }
                //Рекурсия (перебираем вложенные папки и делаем для них то-же самое).
                copefileswithdirectoryes(dir.FullName, Cpath + "\\" + dir.Name);
            }
            
                //Перебираем файлики в папке источнике.
                foreach (string file in Directory.GetFiles(Fpath))
                {
                    filesforcopy++;
                    //Определяем (отделяем) имя файла с расширением - без пути (но с слешем "\").
                    string filik = file.Substring(file.LastIndexOf('\\'), file.Length - file.LastIndexOf('\\'));
                    //Копируем файлик с перезаписью из источника в приёмник.
                    frmcopy.label3.Text = "Откуда: "  + file;
                    frmcopy.label4.Text = "Куда: " + Cpath + filik;

                    frmcopy.pbtotal.Value = filesforcopy; 

                    File.Copy(file, Cpath + filik, true);
                    
                }
                GetFiles(leftpanal, LeftPath, ref LeftbackPath);
                GetFiles(rightpanal, RightPath, ref RightbackPath);
          
        }

       
        private void Cope_Click(object sender, EventArgs e)
        {
            string spath = label1.Text;
            string cpath = label2.Text;
            
            //else ;
            if (leftflag == true)
            {
                foreach (ListViewItem i in leftpanal.SelectedItems)
                {

                    if (i.ImageIndex == 1)
                    {
                        length(Path.Combine(cpath, i.Text), Path.Combine(spath, i.Text),ref k);
                        frmcopy.ShowDialog();
                        frmcopy.pbtotal.Maximum = k;
                        frmcopy.pbtotal.Minimum=0;
                        //frmcopy.pbtotal.Step = 1/k;
                        if (!Directory.Exists(Path.Combine(spath, i.Text))) Directory.CreateDirectory(Path.Combine(spath, i.Text));
                        copefileswithdirectoryes(Path.Combine(cpath, i.Text), Path.Combine(spath, i.Text));
                        
                        GetFiles(leftpanal, LeftPath, ref LeftbackPath);
                        GetFiles(rightpanal, RightPath, ref RightbackPath);
                    }
                    else
                    {
                         length(Path.Combine(cpath, i.Text), Path.Combine(spath, i.Text),ref k);
                        frmcopy.ShowDialog();
                        frmcopy.pbtotal.Maximum = k;
                        frmcopy.pbtotal.Minimum=1;
                        frmcopy.pbtotal.Step = 1/k;
                        File.Copy(Path.Combine(cpath, i.Text), Path.Combine(spath, i.Text));
                        GetFiles(leftpanal, LeftPath, ref LeftbackPath);
                        GetFiles(rightpanal, RightPath, ref RightbackPath);
                    }

                }
            }
            else
            {
                foreach (ListViewItem i in rightpanal.SelectedItems)
                {

                    if (i.ImageIndex == 1)
                    {
                        if (!Directory.Exists(Path.Combine(cpath, i.Text))) Directory.CreateDirectory(Path.Combine(cpath, i.Text));
                        copefileswithdirectoryes(Path.Combine(spath, i.Text), Path.Combine(cpath, i.Text));
                        // textBox1.Text = i.Name;
                    }
                    else
                    {
                        File.Copy(Path.Combine(spath, i.Text), Path.Combine(cpath, i.Text));
                        GetFiles(leftpanal, LeftPath, ref LeftbackPath);
                        GetFiles(rightpanal, RightPath, ref RightbackPath);
                    }

                }
            }

        }

        private void leftpanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftflag = true;
            
           
        }

        private void rightpanal_SelectedIndexChanged(object sender, EventArgs e)
        {
            leftflag = false;
         
          
       
        }

        private void Exet_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leftpanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)(Keys.Back)) button1_Click(sender, e);
        }

        private void rightpanal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)(Keys.Back)) button2_Click(sender, e);
        }

     
          
              

       
    
       
    

       
      
    }
}
