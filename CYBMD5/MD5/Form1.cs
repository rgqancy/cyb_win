namespace MD5
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private Button btnAbout;
        private Button btnClearAll;
        private Button btnDelete;
        private Button btnSaveAs;
        private ComputerHash cComputerHash;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip1;
        private ColumnHeader FileName;
        private ColumnHeader FilePath;
        private GroupBox groupBox1;
        private ColumnHeader id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblCmpResult;
        private ListView listViewFiles;
        private ColumnHeader MD5Hash;
        private int nFilesNo;
        private StatusStrip statusStrip1;
        private TextBox tbFileName;
        private TextBox tbMD5Now;
        private TextBox tbMD5Old;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem 清空CToolStripMenuItem;
        private ToolStripMenuItem 删除DToolStripMenuItem;

        public Form1()
        {
            this.InitializeComponent();
        }

        protected void AddFileToListView(string sFile)
        {
            if (Directory.Exists(sFile))
            {
                foreach (string str in Directory.GetFiles(sFile))
                {
                    this.AddFileToListView(str);
                }
            }
            else if (File.Exists(sFile))
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();
                this.nFilesNo = this.listViewFiles.Items.Count;
                this.nFilesNo++;
                item.SubItems[0].Text = this.nFilesNo.ToString();
                item.SubItems.Add(Path.GetFileName(sFile));
                item.SubItems.Add(this.cComputerHash.GetHashString(sFile, "MD5"));
                item.SubItems.Add(sFile);
                this.listViewFiles.Items.Add(item);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Owner = this;
            about.Show();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "txt file(*.txt)|*.txt";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;
            if ((dialog.ShowDialog() == DialogResult.OK) && ((stream = dialog.OpenFile()) != null))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    foreach (ListViewItem item in this.listViewFiles.Items)
                    {
                        writer.WriteLine(item.SubItems[3].Text);
                        writer.WriteLine("MD5: " + item.SubItems[2].Text);
                    }
                }
                stream.Close();
                MessageBox.Show("保存成功！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.StartUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cComputerHash = new ComputerHash();
            this.toolStripStatusLabel1.Text = "创意宝MD5生成器!";
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resource = new ComponentResourceManager(typeof(Form1));
            this.listViewFiles = new ListView();
            this.id = new ColumnHeader();
            this.FileName = new ColumnHeader();
            this.MD5Hash = new ColumnHeader();
            this.FilePath = new ColumnHeader();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.删除DToolStripMenuItem = new ToolStripMenuItem();
            this.清空CToolStripMenuItem = new ToolStripMenuItem();
            this.label1 = new Label();
            this.btnDelete = new Button();
            this.btnClearAll = new Button();
            this.groupBox1 = new GroupBox();
            this.lblCmpResult = new Label();
            this.tbMD5Old = new TextBox();
            this.tbMD5Now = new TextBox();
            this.tbFileName = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.label2 = new Label();
            this.btnSaveAs = new Button();
            this.btnAbout = new Button();
            this.statusStrip1 = new StatusStrip();
            this.toolStripStatusLabel1 = new ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            base.SuspendLayout();
            this.listViewFiles.AllowDrop = true;
            this.listViewFiles.Columns.AddRange(new ColumnHeader[] { this.id, this.FileName, this.MD5Hash, this.FilePath });
            this.listViewFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.Location = new Point(3, 0x18);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new Size(680, 0xdf);
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = View.Details;
            this.listViewFiles.SelectedIndexChanged += new EventHandler(this.listViewFiles_SelectedIndexChanged);
            this.listViewFiles.DragDrop += new DragEventHandler(this.listView1_DragDrop);
            this.listViewFiles.DragEnter += new DragEventHandler(this.listView1_DragEnter);
            this.id.Text = "序号";
            this.id.Width = 40;
            this.FileName.Text = "文件名";
            this.FileName.TextAlign = HorizontalAlignment.Center;
            this.FileName.Width = 200;
            this.MD5Hash.Text = "MD5摘要";
            this.MD5Hash.TextAlign = HorizontalAlignment.Center;
            this.MD5Hash.Width = 230;
            this.FilePath.Text = "文件路径";
            this.FilePath.TextAlign = HorizontalAlignment.Center;
            this.FilePath.Width = 200;
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.删除DToolStripMenuItem, this.清空CToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(0x71, 0x30);
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new Size(0x70, 0x16);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            this.删除DToolStripMenuItem.Click += new EventHandler(this.删除DToolStripMenuItem_Click);
            this.清空CToolStripMenuItem.Name = "清空CToolStripMenuItem";
            this.清空CToolStripMenuItem.Size = new Size(0x70, 0x16);
            this.清空CToolStripMenuItem.Text = "清空(&C)";
            this.清空CToolStripMenuItem.Click += new EventHandler(this.清空CToolStripMenuItem_Click);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x7d, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "请把文件或文件夹拖入";
            this.btnDelete.Location = new Point(0x220, 0x111);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(0x37, 0x17);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new EventHandler(this.删除DToolStripMenuItem_Click);
            this.btnClearAll.Location = new Point(0x220, 0x128);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new Size(0x37, 0x17);
            this.btnClearAll.TabIndex = 5;
            this.btnClearAll.Text = "清空";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new EventHandler(this.清空CToolStripMenuItem_Click);
            this.groupBox1.Controls.Add(this.lblCmpResult);
            this.groupBox1.Controls.Add(this.tbMD5Old);
            this.groupBox1.Controls.Add(this.tbMD5Now);
            this.groupBox1.Controls.Add(this.tbFileName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new Point(3, 0x108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x178, 0x70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MD5摘要";
            this.lblCmpResult.AutoSize = true;
            this.lblCmpResult.Location = new Point(280, 80);
            this.lblCmpResult.Name = "lblCmpResult";
            this.lblCmpResult.Size = new Size(0, 12);
            this.lblCmpResult.TabIndex = 6;
            this.tbMD5Old.Location = new Point(0x40, 0x4c);
            this.tbMD5Old.Name = "tbMD5Old";
            this.tbMD5Old.Size = new Size(0xd0, 0x15);
            this.tbMD5Old.TabIndex = 5;
            this.tbMD5Old.TextChanged += new EventHandler(this.tbMD5Old_TextChanged);
            this.tbMD5Now.Location = new Point(0x40, 50);
            this.tbMD5Now.Name = "tbMD5Now";
            this.tbMD5Now.Size = new Size(0xd0, 0x15);
            this.tbMD5Now.TabIndex = 4;
            this.tbMD5Now.TextChanged += new EventHandler(this.tbMD5Now_TextChanged);
            this.tbFileName.Location = new Point(0x40, 0x18);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new Size(0xd0, 0x15);
            this.tbFileName.TabIndex = 3;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(10, 80);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x35, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "摘要：";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(10, 0x35);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x35, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "现摘要：";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(10, 0x1c);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x35, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件名：";
            this.btnSaveAs.Location = new Point(0x220, 0x13f);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new Size(0x37, 0x17);
            this.btnSaveAs.TabIndex = 7;
            this.btnSaveAs.Text = "导出";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new EventHandler(this.btnSaveAs_Click);
            this.btnAbout.Location = new Point(0x220, 0x156);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new Size(0x37, 0x17);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "关于";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new EventHandler(this.btnAbout_Click);
            this.statusStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripStatusLabel1 });
            this.statusStrip1.Location = new Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new Size(0x2b4, 0x16);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.toolStripStatusLabel1.BackColor = SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new Size(0, 0x11);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            base.ClientSize = new Size(0x2b4, 0x192);
            base.Controls.Add(this.statusStrip1);
            //base.Controls.Add(this.btnAbout);
            base.Controls.Add(this.btnSaveAs);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.btnClearAll);
            base.Controls.Add(this.btnDelete);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.listViewFiles);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Icon = (Icon) resource.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form1";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "创意宝MD5生成器";
            base.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            base.Load += new EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
			
			this.label4.Visible = false;
			this.tbMD5Old.Visible = false;
			this.lblCmpResult.Visible = false;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            this.listViewFiles.Items.Clear();
            string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
            foreach (string str in data)
            {
                this.AddFileToListView(str);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move | DragDropEffects.Copy | DragDropEffects.Scroll;
            }
        }

        private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listViewFiles.SelectedItems)
            {
                this.tbFileName.Text = item.SubItems[1].Text;
                this.tbMD5Now.Text = item.SubItems[2].Text;
            }
        }

        protected void RenameNewFile(string sFileName)
        {
            /*
            string path = sFileName + ".new";
            bool flag = false;
            if (File.Exists(path))
            {
                flag = File.Exists(sFileName);
                string startupPath = Application.StartupPath;
                string destFileName = startupPath + @"\" + sFileName;
                string fileName = startupPath + @"\" + path;
                if (!flag)
                {
                    FileInfo info = new FileInfo(fileName);
                    info.MoveTo(destFileName);
                }
                else
                {
                    File.Delete(destFileName);
                    new FileInfo(fileName).MoveTo(destFileName);
                }
            }
             * */
        }

        protected void StartUpdate()
        {
            /*
            string startupPath = Application.StartupPath;
            string path = startupPath + @"\\update.exe";
            this.RenameNewFile("update.exe");
            if (File.Exists(path))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = path;
                startInfo.Arguments = "电脑自动关机软件:AutoShutdown";
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;
                startInfo.WorkingDirectory = startupPath;
                try
                {
                    Process.Start(startInfo);
                }
                catch (Win32Exception)
                {
                }
            }
             * */
        }

        private void tbMD5Now_TextChanged(object sender, EventArgs e)
        {
            string str = this.tbMD5Now.Text.Trim().ToLower();
            string strB = this.tbMD5Old.Text.Trim().ToLower();
            if (str.CompareTo(strB) == 0)
            {
                this.lblCmpResult.ForeColor = Color.Green;
                this.lblCmpResult.Text = "两摘要相同！";
            }
            else
            {
                this.lblCmpResult.ForeColor = Color.Red;
                this.lblCmpResult.Text = "两摘要不相同！";
            }
        }

        private void tbMD5Old_TextChanged(object sender, EventArgs e)
        {
            string str = this.tbMD5Now.Text.Trim().ToLower();
            string strB = this.tbMD5Old.Text.Trim().ToLower();
            if (str.CompareTo(strB) == 0)
            {
                this.lblCmpResult.ForeColor = Color.Green;
                this.lblCmpResult.Text = "两摘要相同！";
            }
            else
            {
                this.lblCmpResult.ForeColor = Color.Red;
                this.lblCmpResult.Text = "两摘要不相同！";
            }
        }

        private void 清空CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.listViewFiles.Items.Count;
            if (count != 0)
            {
                for (int i = 0; i < count; i++)
                {
                    this.listViewFiles.Items.Remove(this.listViewFiles.Items[0]);
                }
            }
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewFiles.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in this.listViewFiles.SelectedItems)
                {
                    this.listViewFiles.Items.Remove(item);
                }
                int count = this.listViewFiles.Items.Count;
                if (count != 0)
                {
                    this.nFilesNo = 0;
                    for (int i = 0; i < count; i++)
                    {
                        ListViewItem item2 = this.listViewFiles.Items[i];
                        this.nFilesNo = i + 1;
                        item2.SubItems[0].Text = this.nFilesNo.ToString();
                    }
                }
            }
        }
    }
}

