﻿namespace TPTSViewer {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.URL = new System.Windows.Forms.Label();
            this.Fav_Count = new System.Windows.Forms.Label();
            this.RT_Count = new System.Windows.Forms.Label();
            this.HashTag = new System.Windows.Forms.Label();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu,
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(66, 20);
            this.FileMenu.Text = "ファイル(&F)";
            // 
            // OpenMenu
            // 
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.Size = new System.Drawing.Size(113, 22);
            this.OpenMenu.Text = "開く(&O)";
            this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(113, 22);
            this.ExitMenu.Text = "終了(&X)";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 515);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 468);
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
            this.tableLayoutPanel2.SetColumnSpan(this.HashTag, 3);
            this.HashTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HashTag.Location = new System.Drawing.Point(3, 28);
            this.HashTag.Name = "HashTag";
            this.HashTag.Size = new System.Drawing.Size(772, 16);
            this.HashTag.TabIndex = 4;
            this.HashTag.Text = "HashTag";
            this.HashTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ID.DoubleClick += new System.EventHandler(this.ID_DoubleClick);
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
            this.pictureBox.Size = new System.Drawing.Size(778, 459);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPTS Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

