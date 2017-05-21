namespace TPTSViewer {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReLoadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFolderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.JumpTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.JumpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoStartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PrevMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GotoEndMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FaceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FaceModeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FaceInfoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorSelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SizeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.URL = new System.Windows.Forms.Label();
            this.Fav_Count = new System.Windows.Forms.Label();
            this.RT_Count = new System.Windows.Forms.Label();
            this.HashTag = new System.Windows.Forms.Label();
            this.HashTagMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ID = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.OpenFolderMenu,
            this.JumpTextBox,
            this.JumpMenu,
            this.GotoStartMenu,
            this.PrevMenu,
            this.NextMenu,
            this.GotoEndMenu,
            this.SearchMenu,
            this.FaceMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu,
            this.ReLoadMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(67, 23);
            this.FileMenu.Text = "ファイル(&F)";
            // 
            // OpenMenu
            // 
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.Size = new System.Drawing.Size(122, 22);
            this.OpenMenu.Text = "開く(&O)";
            this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // ReLoadMenu
            // 
            this.ReLoadMenu.Enabled = false;
            this.ReLoadMenu.Name = "ReLoadMenu";
            this.ReLoadMenu.Size = new System.Drawing.Size(122, 22);
            this.ReLoadMenu.Text = "リロード(&R)";
            this.ReLoadMenu.Click += new System.EventHandler(this.ReLoadMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(122, 22);
            this.ExitMenu.Text = "終了(&X)";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // OpenFolderMenu
            // 
            this.OpenFolderMenu.Enabled = false;
            this.OpenFolderMenu.Name = "OpenFolderMenu";
            this.OpenFolderMenu.Size = new System.Drawing.Size(90, 23);
            this.OpenFolderMenu.Text = "フォルダーを開く";
            this.OpenFolderMenu.Click += new System.EventHandler(this.OpenFolderMenu_Click);
            // 
            // JumpTextBox
            // 
            this.JumpTextBox.CausesValidation = false;
            this.JumpTextBox.Enabled = false;
            this.JumpTextBox.MaxLength = 5;
            this.JumpTextBox.Name = "JumpTextBox";
            this.JumpTextBox.Size = new System.Drawing.Size(100, 23);
            this.JumpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JumpTextBox_KeyPress);
            // 
            // JumpMenu
            // 
            this.JumpMenu.Enabled = false;
            this.JumpMenu.Name = "JumpMenu";
            this.JumpMenu.Size = new System.Drawing.Size(55, 23);
            this.JumpMenu.Text = "ジャンプ";
            this.JumpMenu.Click += new System.EventHandler(this.JumpMenu_Click);
            // 
            // GotoStartMenu
            // 
            this.GotoStartMenu.Enabled = false;
            this.GotoStartMenu.Name = "GotoStartMenu";
            this.GotoStartMenu.Size = new System.Drawing.Size(35, 23);
            this.GotoStartMenu.Text = "<<";
            this.GotoStartMenu.Click += new System.EventHandler(this.GotoStartMenu_Click);
            // 
            // PrevMenu
            // 
            this.PrevMenu.Enabled = false;
            this.PrevMenu.Name = "PrevMenu";
            this.PrevMenu.Size = new System.Drawing.Size(27, 23);
            this.PrevMenu.Text = "<";
            this.PrevMenu.Click += new System.EventHandler(this.PrevMenu_Click);
            // 
            // NextMenu
            // 
            this.NextMenu.Enabled = false;
            this.NextMenu.Name = "NextMenu";
            this.NextMenu.Size = new System.Drawing.Size(27, 23);
            this.NextMenu.Text = ">";
            this.NextMenu.Click += new System.EventHandler(this.NextMenu_Click);
            // 
            // GotoEndMenu
            // 
            this.GotoEndMenu.Enabled = false;
            this.GotoEndMenu.Name = "GotoEndMenu";
            this.GotoEndMenu.Size = new System.Drawing.Size(35, 23);
            this.GotoEndMenu.Text = ">>";
            this.GotoEndMenu.Click += new System.EventHandler(this.GotoEndMenu_Click);
            // 
            // SearchMenu
            // 
            this.SearchMenu.Enabled = false;
            this.SearchMenu.Name = "SearchMenu";
            this.SearchMenu.Size = new System.Drawing.Size(57, 23);
            this.SearchMenu.Text = "検索(&S)";
            this.SearchMenu.Click += new System.EventHandler(this.SearchMenu_Click);
            // 
            // FaceMenu
            // 
            this.FaceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FaceModeMenu,
            this.FaceInfoMenu,
            this.ColorSelMenu});
            this.FaceMenu.Enabled = false;
            this.FaceMenu.Name = "FaceMenu";
            this.FaceMenu.Size = new System.Drawing.Size(43, 23);
            this.FaceMenu.Text = "顔枠";
            // 
            // FaceModeMenu
            // 
            this.FaceModeMenu.Name = "FaceModeMenu";
            this.FaceModeMenu.Size = new System.Drawing.Size(122, 22);
            this.FaceModeMenu.Text = "顔枠表示";
            this.FaceModeMenu.Click += new System.EventHandler(this.FaceModeMenu_Click);
            // 
            // FaceInfoMenu
            // 
            this.FaceInfoMenu.Name = "FaceInfoMenu";
            this.FaceInfoMenu.Size = new System.Drawing.Size(122, 22);
            this.FaceInfoMenu.Text = "情報表示";
            this.FaceInfoMenu.Click += new System.EventHandler(this.FaceInfoMenu_Click);
            // 
            // ColorSelMenu
            // 
            this.ColorSelMenu.Name = "ColorSelMenu";
            this.ColorSelMenu.Size = new System.Drawing.Size(122, 22);
            this.ColorSelMenu.Text = "枠色設定";
            this.ColorSelMenu.Click += new System.EventHandler(this.ColorSelMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.SizeStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(55, 17);
            this.StatusLabel.Text = "準備完了";
            // 
            // SizeStatusLabel
            // 
            this.SizeStatusLabel.Name = "SizeStatusLabel";
            this.SizeStatusLabel.Size = new System.Drawing.Size(714, 17);
            this.SizeStatusLabel.Spring = true;
            this.SizeStatusLabel.Text = "0x0";
            this.SizeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 512);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.URL, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Fav_Count, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.RT_Count, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.HashTag, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.ID, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Time, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // URL
            // 
            this.URL.AutoEllipsis = true;
            this.URL.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.URL, 2);
            this.URL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URL.Location = new System.Drawing.Point(3, 0);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(512, 14);
            this.URL.TabIndex = 0;
            this.URL.Text = "URL";
            this.URL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.URL.DoubleClick += new System.EventHandler(this.URL_DoubleClick);
            // 
            // Fav_Count
            // 
            this.Fav_Count.AutoSize = true;
            this.Fav_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fav_Count.Location = new System.Drawing.Point(3, 14);
            this.Fav_Count.Name = "Fav_Count";
            this.Fav_Count.Size = new System.Drawing.Size(253, 14);
            this.Fav_Count.TabIndex = 2;
            this.Fav_Count.Text = "Fav_Count";
            this.Fav_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RT_Count
            // 
            this.RT_Count.AutoSize = true;
            this.RT_Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RT_Count.Location = new System.Drawing.Point(262, 14);
            this.RT_Count.Name = "RT_Count";
            this.RT_Count.Size = new System.Drawing.Size(253, 14);
            this.RT_Count.TabIndex = 3;
            this.RT_Count.Text = "RT_Count";
            this.RT_Count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HashTag
            // 
            this.HashTag.AutoSize = true;
            this.HashTag.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.SetColumnSpan(this.HashTag, 3);
            this.HashTag.ContextMenuStrip = this.HashTagMenu;
            this.HashTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HashTag.Location = new System.Drawing.Point(3, 28);
            this.HashTag.Name = "HashTag";
            this.HashTag.Size = new System.Drawing.Size(772, 16);
            this.HashTag.TabIndex = 4;
            this.HashTag.Text = "HashTag";
            this.HashTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HashTagMenu
            // 
            this.HashTagMenu.Name = "HashTagMenu";
            this.HashTagMenu.Size = new System.Drawing.Size(61, 4);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ID.Location = new System.Drawing.Point(521, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(254, 14);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Time.Location = new System.Drawing.Point(521, 14);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(254, 14);
            this.Time.TabIndex = 5;
            this.Time.Text = "Time";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(778, 456);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(799, 596);
            this.Name = "Form1";
            this.Text = "TPTS Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Fav_Count;
        private System.Windows.Forms.Label RT_Count;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label HashTag;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ToolStripMenuItem OpenFolderMenu;
        public System.Windows.Forms.ToolStripTextBox JumpTextBox;
        private System.Windows.Forms.ToolStripMenuItem JumpMenu;
        private System.Windows.Forms.ToolStripMenuItem GotoStartMenu;
        private System.Windows.Forms.ToolStripMenuItem GotoEndMenu;
        private System.Windows.Forms.ToolStripMenuItem PrevMenu;
        private System.Windows.Forms.ToolStripMenuItem NextMenu;
        private System.Windows.Forms.ToolStripMenuItem ReLoadMenu;
        public System.Windows.Forms.ToolStripMenuItem SearchMenu;
        private System.Windows.Forms.ToolStripMenuItem FaceMenu;
        private System.Windows.Forms.ToolStripStatusLabel SizeStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem FaceModeMenu;
        private System.Windows.Forms.ToolStripMenuItem FaceInfoMenu;
        private System.Windows.Forms.ToolStripMenuItem ColorSelMenu;
        private System.Windows.Forms.ContextMenuStrip HashTagMenu;
    }
}

