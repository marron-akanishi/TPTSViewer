using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TPTSViewer {
    public partial class Form1 : Form {
        String FilePath = "";
        int FileCount = 0;
        int MaxFileCount = 0;
        SQLiteConnection database;

        public Form1() {
            InitializeComponent();
        }

        private void ExitMenu_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void OpenMenu_Click(object sender, EventArgs e) {
            if(database != null) database.Close();
            OpenFileDialog dbfile = new OpenFileDialog();
            dbfile.Filter = "SQLite3 DB|*.db";
            dbfile.Title = "データベースファイルを選択してください。";
            if (dbfile.ShowDialog() == DialogResult.OK) {
                FilePath = Path.GetDirectoryName(dbfile.FileName);
                database = new SQLiteConnection("Data Source=" + dbfile.FileName);
                try {
                    database.Open();
                    StatusLabel.Text = "データベースをロードしました : " + dbfile.FileName;
                    Form_Maker();
                }
                catch {
                    StatusLabel.Text = "データベースをロードできませんでした : " + dbfile.FileName;
                    return;
                }
                SQLiteCommand cmd = database.CreateCommand();
                cmd.CommandText = "select count(filename) from list";
                using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                    reader.Read();
                    MaxFileCount = Convert.ToInt32(reader["count(filename)"].ToString());
                }
            }
        }

        private void Form_Maker() {
            string FileName;
            try {
                string[] FileList = Directory.GetFiles(FilePath, FileCount.ToString("D5") + ".*");
                FileName = Path.GetFileName(FileList[0]);
                if (pictureBox.Image != null) pictureBox.Image.Dispose();
                Image temp = Image.FromFile(FileList[0]);
                if (temp.Width >= pictureBox.Width || temp.Height >= pictureBox.Height) pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                else pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                temp.Dispose();
                pictureBox.Image = Image.FromFile(FileList[0]);
                this.Text = FileList[0] + " - TPTS Viewer";
                StatusLabel.Text = (FileCount + 1).ToString() + "個目のファイルです。";
            }
            catch {
                StatusLabel.Text = "ファイルが存在しません : " + FileCount.ToString("D5");
                return;
            }
            SQLiteCommand cmd = database.CreateCommand();
            cmd.CommandText = "select * from list where filename = '" + FileName + "'";
            using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                reader.Read();
                URL.Text = "URL : " + reader["url"].ToString();
                ID.Text = "ID : @" + reader["username"].ToString();
                Fav_Count.Text = "Fav_Count : " + reader["fav"].ToString();
                RT_Count.Text = "RT_Count : " + reader["retweet"].ToString();
                HashTag.Text = "HashTag : " + reader["tags"].ToString();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Left) {
                FileCount--;
                if(FileCount < 0) {
                    StatusLabel.Text = "これ以上前にファイルが存在しません";
                    FileCount = 0;
                    return;
                }
                Form_Maker();
            }
            if (e.KeyData == Keys.Right) {
                FileCount++;
                if (FileCount >= MaxFileCount) {
                    StatusLabel.Text = "これ以上先にファイルが存在しません";
                    FileCount = MaxFileCount - 1;
                    return;
                }
                Form_Maker();
            }
        }

        private void URL_DoubleClick(object sender, EventArgs e) {
            if(URL.Text != "URL") System.Diagnostics.Process.Start(URL.Text.Remove(0, 6));
            return;
        }

        private void ID_DoubleClick(object sender, EventArgs e) {
            if(ID.Text != "ID") System.Diagnostics.Process.Start("https://twitter.com/" + ID.Text.Remove(0, 6));
            return;
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e) {
            if(pictureBox.Image != null) Form_Maker();
        }
    }
}
