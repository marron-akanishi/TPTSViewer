﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TPTSViewer {
    public partial class Form1 : Form {
        public String OpenDBFile = "";
        String FilePath = "";
        bool is_NewDB = false;
        int FileCount = 0;
        int MaxFileCount = 0;
        SQLiteConnection database;
        bool is_DispFrame = false;
        Color FrameColor = Color.Lime;

        public Form1() {
            InitializeComponent();
        }

        private void Form_Maker() {
            string FileName;
            string[] FileList;
            List<string> x = new List<string>();
            List<string> y = new List<string>();
            List<string> width = new List<string>();
            List<string> height = new List<string>();
            // ファイル検索
            try {
                FileList = Directory.GetFiles(FilePath, FileCount.ToString("D5") + ".*");
                FileName = Path.GetFileName(FileList[0]);
                // DB読み込み
                SQLiteCommand cmd = database.CreateCommand();
                cmd.CommandText = "select * from list where filename = '" + FileName + "'";
                using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                    reader.Read();
                    URL.Text = "URL : " + reader["url"].ToString();
                    ID.Text = "ID : @" + reader["username"].ToString();
                    Fav_Count.Text = "Fav_Count : " + reader["fav"].ToString();
                    RT_Count.Text = "RT_Count : " + reader["retweet"].ToString();
                    HashTag.Text = "HashTag : " + reader["tags"].ToString();
                    if (is_NewDB) {
                        Time.Text = "Time : " + reader["time"].ToString();
                        x.AddRange(reader["facex"].ToString().TrimStart('[').TrimEnd(']').Split(','));
                        y.AddRange(reader["facey"].ToString().TrimStart('[').TrimEnd(']').Split(','));
                        width.AddRange(reader["facew"].ToString().TrimStart('[').TrimEnd(']').Split(','));
                        height.AddRange(reader["faceh"].ToString().TrimStart('[').TrimEnd(']').Split(','));
                    } else {
                        Time.Text = "Time : " + reader["time"].ToString();
                    }
                }
            }
            catch {
                StatusLabel.Text = "ファイルが存在しません : " + FileCount.ToString("D5");
                return;
            }
            // 画像描画
            Image temp = Image.FromFile(FileList[0]);
            //サイズ取得
            if (temp.Width >= pictureBox.Width || temp.Height >= pictureBox.Height) pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            else pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            StatusLabel.Text = temp.Width.ToString() + "x" + temp.Height.ToString();
            //枠描画
            Bitmap canvas = new Bitmap(temp.Width, temp.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.DrawImage(temp, 0, 0);
            temp.Dispose(); //書いたらすぐ開放
            if (is_DispFrame) {
                Pen p = new Pen(FrameColor, 2);
                for(int i = 0;i < height.Count; i++) {
                    g.DrawRectangle(p, Convert.ToInt32(x[i]), Convert.ToInt32(y[i]), 
                                        Convert.ToInt32(width[i]), Convert.ToInt32(height[i]));
                }
                p.Dispose(); //書いたらすぐ開放
            }
            g.Dispose(); //書いたらすぐ開放
            if (pictureBox.Image != null) pictureBox.Image.Dispose();
            pictureBox.Image = canvas;
            JumpTextBox.Text = FileCount.ToString("D5");
            this.Text = FileList[0] + " - TPTS Viewer";
        }

        private void SetMenuMode(bool mode) {
            ReLoadMenu.Enabled = mode;
            OpenFolderMenu.Enabled = mode;
            JumpMenu.Enabled = mode;
            JumpTextBox.Enabled = mode;
            GotoEndMenu.Enabled = mode;
            GotoStartMenu.Enabled = mode;
            PrevMenu.Enabled = mode;
            NextMenu.Enabled = mode;
            SearchMenu.Enabled = mode;
            FaceModeMenu.Enabled = mode;
            if(mode == false) {
                is_DispFrame = false;
                FaceModeMenu.Text = "顔枠表示";
            }
        }

        private void OpenMenu_Click(object sender, EventArgs e) {
            OpenFileDialog dbfile = new OpenFileDialog();
            dbfile.Filter = "SQLite3 DB|*.db";
            dbfile.Title = "データベースファイルを選択してください。";
            if (dbfile.ShowDialog() == DialogResult.OK) {
                if (database != null) database.Close();
                FilePath = Path.GetDirectoryName(dbfile.FileName);
                database = new SQLiteConnection("Data Source=" + dbfile.FileName);
                try {
                    database.Open();
                    StatusLabel.Text = "データベースをロードしました : " + dbfile.FileName;
                    OpenDBFile = dbfile.FileName;
                    FileCount = 0;
                    SetMenuMode(true);
                    if (((ToolStripMenuItem)sender).Text == "旧Version") is_NewDB = false;
                    else is_NewDB = true;
                    Form_Maker();
                }
                catch {
                    StatusLabel.Text = "データベースをロードできませんでした : " + dbfile.FileName;
                    SetMenuMode(false);
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

        private void ExitMenu_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Left || e.KeyData == Keys.J) {
                FileCount--;
                if(FileCount < 0) {
                    StatusLabel.Text = "最後のファイルに移動します";
                    FileCount = MaxFileCount - 1;
                }
                Form_Maker();
            }
            if (e.KeyData == Keys.Right || e.KeyData == Keys.K) {
                FileCount++;
                if (FileCount >= MaxFileCount) {
                    StatusLabel.Text = "最初のファイルに移動します";
                    FileCount = 0;
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

        private void pictureBox_DoubleClick(object sender, EventArgs e) {
            if (pictureBox.Image != null) System.Diagnostics.Process.Start(this.Text.Split(' ')[0]);
            return;
        }

        private void OpenFolderMenu_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(FilePath);
        }

        public void JumpMenu_Click(object sender, EventArgs e) {
            try {
                FileCount = Convert.ToInt32(JumpTextBox.Text);
                Form_Maker();
            }
            catch {
                StatusLabel.Text = "無効なファイル名です : " + JumpTextBox.Text;
                return;
            }
        }

        private void GotoStartMenu_Click(object sender, EventArgs e) {
            FileCount = 0;
            Form_Maker();
        }

        private void GotoEndMenu_Click(object sender, EventArgs e) {
            FileCount = MaxFileCount - 1;
            Form_Maker();
        }

        private void PrevMenu_Click(object sender, EventArgs e) {
            FileCount--;
            if (FileCount < 0) {
                StatusLabel.Text = "最後のファイルに移動します";
                FileCount = MaxFileCount - 1;
            }
            Form_Maker();
        }

        private void NextMenu_Click(object sender, EventArgs e) {
            FileCount++;
            if (FileCount >= MaxFileCount) {
                StatusLabel.Text = "最初のファイルに移動します";
                FileCount = 0;
            }
            Form_Maker();
        }

        private void ReLoadMenu_Click(object sender, EventArgs e) {
            database.Close();
            database = new SQLiteConnection("Data Source=" + OpenDBFile);
            try {
                database.Open();
                StatusLabel.Text = "データベースをリロードしました";
                FileCount = 0;
                SetMenuMode(true);
                Form_Maker();
            }
            catch {
                StatusLabel.Text = "データベースをリロードできませんでした";
                SetMenuMode(false);
                return;
            }
            SQLiteCommand cmd = database.CreateCommand();
            cmd.CommandText = "select count(filename) from list";
            using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                reader.Read();
                MaxFileCount = Convert.ToInt32(reader["count(filename)"].ToString());
            }
        }

        private void SearchMenu_Click(object sender, EventArgs e) {
            Form2 f = new Form2();
            f.Show(this);
        }

        private void ColorSelMenu_Click(object sender, EventArgs e) {
            ColorDialog cd = new ColorDialog();
            cd.Color = FrameColor;
            if(cd.ShowDialog() == DialogResult.OK) {
                FrameColor = cd.Color;
                if (is_DispFrame) Form_Maker();
            }
        }

        private void FaceModeMenu_Click(object sender, EventArgs e) {
            if (is_DispFrame) {
                is_DispFrame = false;
                FaceModeMenu.Text = "顔枠表示";
                Form_Maker();
            } else {
                is_DispFrame = true;
                FaceModeMenu.Text = "顔枠非表示";
                Form_Maker();
            }
        }
    }
}
