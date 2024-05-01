using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;

namespace databaseOfSystemVUZ
{
    public partial class login : Form
    {
        public bool Close = false,exit = false;
        public int id;
        public login()
        {
            InitializeComponent();
        }

        public void enablclic()
        {
            if (tbxlog.Text != "" && tbxpass.Text != "") btnLog.Enabled = true;
            else btnLog.Enabled = false;
        }
        private void login_Load(object sender, EventArgs e)
        {
            enablclic();
            tbxlog.Focus();
           
        }
         public const int SALT_BYTE_SIZE = 9;
            public const int HASH_BYTE_SIZE = 32;
            public const int PBKDF2_ITERATIONS = 12000;

            public const int ITERATION_INDEX = 1;
            public const int SALT_INDEX = 2;
            public const int PBKDF2_INDEX = 3;

            public static bool ValidatePassword(string password, string correctHash)
            {
                // Extract the parameters from the hash
                char[] delimiter = { '$' };
                string[] split = correctHash.Split(delimiter);
                int iterations = Int32.Parse(split[ITERATION_INDEX]);
                byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
                byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

                byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
                return SlowEquals(hash, testHash);
            }
            private static bool SlowEquals(byte[] a, byte[] b)
            {
                uint diff = (uint)a.Length ^ (uint)b.Length;
                for (int i = 0; i < a.Length && i < b.Length; i++)
                    diff |= (uint)(a[i] ^ b[i]);
                return diff == 0;
            }

            private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
            {
                Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
                pbkdf2.IterationCount = iterations;
                return pbkdf2.GetBytes(outputBytes);
            }
            public static string CreateHash(string password)
            {
                // Generate a random salt
                RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
                byte[] salt = new byte[SALT_BYTE_SIZE];
            csprng.GetBytes(salt);
             // Hash the password and encode the parameters
                byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
                return "pbkdf2_sha256$" + PBKDF2_ITERATIONS + "$" +
                    Convert.ToBase64String(salt) + "$" +
                    Convert.ToBase64String(hash);
            }
            public static byte[] PBKDF2Sha256GetBytes(int dklen, byte[] password, byte[] salt, int iterationCount)
            {
                using (var hmac = new System.Security.Cryptography.HMACSHA256(password))
                {
                    int hashLength = hmac.HashSize / 8;
                    if ((hmac.HashSize & 7) != 0)
                        hashLength++;
                    int keyLength = dklen / hashLength;
                    if ((long)dklen > (0xFFFFFFFFL * hashLength) || dklen < 0)
                        throw new ArgumentOutOfRangeException("dklen");
                    if (dklen % hashLength != 0)
                        keyLength++;
                    byte[] extendedkey = new byte[salt.Length + 4];
                    Buffer.BlockCopy(salt, 0, extendedkey, 0, salt.Length);
                    using (var ms = new System.IO.MemoryStream())
                    {
                        for (int i = 0; i < keyLength; i++)
                        {
                            extendedkey[salt.Length] = (byte)(((i + 1) >> 24) & 0xFF);
                            extendedkey[salt.Length + 1] = (byte)(((i + 1) >> 16) & 0xFF);
                            extendedkey[salt.Length + 2] = (byte)(((i + 1) >> 8) & 0xFF);
                            extendedkey[salt.Length + 3] = (byte)(((i + 1)) & 0xFF);
                            byte[] u = hmac.ComputeHash(extendedkey);
                            Array.Clear(extendedkey, salt.Length, 4);
                            byte[] f = u;
                            for (int j = 1; j < iterationCount; j++)
                            {
                                u = hmac.ComputeHash(u);
                                for (int k = 0; k < f.Length; k++)
                                {
                                    f[k] ^= u[k];
                                }
                            }
                            ms.Write(f, 0, f.Length);
                            Array.Clear(u, 0, u.Length);
                            Array.Clear(f, 0, f.Length);
                        }
                        byte[] dk = new byte[dklen];
                        ms.Position = 0;
                        ms.Read(dk, 0, dklen);
                        ms.Position = 0;
                        for (long i = 0; i < ms.Length; i++)
                        {
                            ms.WriteByte(0);
                        }
                        Array.Clear(extendedkey, 0, extendedkey.Length);
                        return dk;
                    }
                }
            }

        public string host = ""; // Имя хоста
        public string database = ""; // Имя базы данных
        public string user = ""; // Имя пользователя
        public string password = ""; // Пароль пользователя
        private void btnLog_Click(object sender, EventArgs e)
        {

            //tbxlog.Text = CreateHash("PrizracK2020");
            using (StreamReader fs = new StreamReader(Application.StartupPath + "\\configure.cfg"))
            {
                string str;
                if (!fs.EndOfStream)
                {
                    host = fs.ReadLine();
                }
                if (!fs.EndOfStream)
                {
                    database = fs.ReadLine();
                }
                if (!fs.EndOfStream)
                {
                    user = fs.ReadLine();
                }
                if (!fs.EndOfStream)
                {
                    password = fs.ReadLine();
                }
            }    
           
            string Connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
            MySqlConnection mysql_connection = new MySqlConnection(Connect);
            string query_auth = " Select id, username, password from auth_user where username like \""+tbxlog.Text+"\"";
            string username = "";
            string passwd = "";
            MySqlCommand mysql_query=null;
            MySqlDataReader mysql_result=null;
            try
            {
                mysql_connection.Open();
                mysql_query = new MySqlCommand(query_auth, mysql_connection);
                mysql_result = mysql_query.ExecuteReader();
           
          
            while (mysql_result.Read())
            {
                id = Convert.ToInt32(mysql_result.GetString(0));
                username = mysql_result.GetString(1);
                passwd = mysql_result.GetString(2);
            }
            mysql_connection.Close();
            if (passwd != "")
            {
                String[] ps = passwd.Split('$');
                byte[] psw = Encoding.UTF8.GetBytes(tbxpass.Text);
                byte[] slt = Encoding.UTF8.GetBytes(ps[2]);
               // MessageBox.Show(Convert.ToBase64String(PBKDF2Sha256GetBytes(32, psw, slt, 12000)), ps[3]);
               // tbxlog.Text = Convert.ToBase64String(PBKDF2Sha256GetBytes(32, psw, slt, 12000));
                if (Convert.ToBase64String(PBKDF2Sha256GetBytes(32, psw, slt, 12000)) == ps[3])
                {
                    Close = true;
                    this.Close();
                }
                else MessageBox.Show("Неправильный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch { MessageBox.Show("Ошибка подключения к бд"); }
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Close == true) return;
            else exit = true; ;
        }

        
        private void tbxlog_TextChanged(object sender, EventArgs e)
        {
            enablclic();
        }

        private void tbxpass_TextChanged(object sender, EventArgs e)
        {
            enablclic();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Close == true) return;
            else exit = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            exit = true;
            this.Close();

        }
    }
}
