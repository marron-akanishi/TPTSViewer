using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPTSViewer {
    public partial class Form2 : Form {
        Dictionary<string, string> column = new Dictionary<string, string>() {
            {"ユーザーID","username" },
            {"ハッシュタグ","tags" }
        };

        // mode->0:id 1:tag
        public Form2(string data,int mode=0) {
            InitializeComponent();
            textBox1.Text = data;
            comboBox1.DataSource = new BindingSource(column, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            comboBox1.SelectedIndex = mode;
        }

        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            SQLiteConnection database = new SQLiteConnection("Data Source=" + ((Form1)this.Owner).OpenDBFile);
            database.Open();
            SQLiteCommand cmd = database.CreateCommand();
            cmd.CommandText = string.Format("select filename from list where {0} like '%{1}%'",
                comboBox1.SelectedValue,textBox1.Text);
            using (SQLiteDataReader reader = cmd.ExecuteReader()) {
                while (reader.Read()) {
                    string data = (string)reader[0];
                    listBox1.Items.Add(data);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            ((Form1)this.Owner).JumpTextBox.Text = listBox1.Text.Split('.')[0];
            ((Form1)this.Owner).JumpMenu_Click(null, null);
        }

        private void Form2_Shown(object sender, EventArgs e) {
            ((Form1)this.Owner).SearchMenu.Enabled = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            ((Form1)this.Owner).SearchMenu.Enabled = true;
        }
    }
}
