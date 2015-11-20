namespace MD5
{
    using MD5.Properties;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public class About : Form
    {
        private Button btnCaiFuTong;
        private Button btnZhiFuBao;
        private IContainer components;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private ToolStripMenuItem 复制ToolStripMenuItem;
        private ToolStripMenuItem 复制ToolStripMenuItem1;

        public About()
        {
            this.InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            /*
            DateTime time2 = DateTime.Now.AddMonths(-2);
            string str = string.Format("{0:Y}", time2) + " 写于杭州";
            this.pictureBox1.Image = Resources.haiou;
            this.richTextBox1.Text = "本软件为个人开发，最终解释权归软件作者所有。\r\n为了能够继续开发更多免费易用的软件，同时也为了生存和发展，\r\n该软件在使用过程中可能会出现广告页面，敬请谅解。\r\n若软件对您有帮助，您可以通过捐助方式支持我，谢谢！\r\n支付宝账号：bandariz@163.com\r\n财付通账号：252505845\r\n捐助的朋友可以获得该软件的个性化定制的多功能版本！\r\n(注：个性化定制包括定制软件名称、标题、界面皮肤、增加新功能等。)";
            this.richTextBox2.Text = "如果您有任何意见（建议）或者您需要定制软件，欢迎与我联系！\r\n  QQ：252505845\r\n邮箱：252505845@qq.com";
            this.richTextBox3.Text = "感谢家人，是你们在背后默默地支持我的工作，\r\n让我能够自由地开发更多的免费软件供广大网友使用。\r\n感谢使用我的软件并给予支持的人，是你们肯定了我的工作。";
            this.richTextBox4.Text = str;
             * */
        }

        private void btnCaiFuTong_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("252505845");
            MessageBox.Show("252505845复制成功，请打开财付通页面！", "感谢您的支持", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Process.Start("www.tenpay.com");
        }

        private void btnZhiFuBao_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("bandariz@163.com");
            MessageBox.Show("bandariz@163.com复制成功，请打开支付宝页面！", "感谢您的支持", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Process.Start("www.alipay.com");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            ComponentResourceManager resource = new ComponentResourceManager(typeof(About));
            this.richTextBox1 = new RichTextBox();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem = new ToolStripMenuItem();
            this.label1 = new Label();
            this.richTextBox2 = new RichTextBox();
            this.contextMenuStrip2 = new ContextMenuStrip(this.components);
            this.复制ToolStripMenuItem1 = new ToolStripMenuItem();
            this.richTextBox3 = new RichTextBox();
            this.label2 = new Label();
            this.btnZhiFuBao = new Button();
            this.btnCaiFuTong = new Button();
            this.pictureBox1 = new PictureBox();
            this.richTextBox4 = new RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            base.SuspendLayout();
            this.richTextBox1.BackColor = SystemColors.ActiveCaptionText;
            this.richTextBox1.BorderStyle = BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.richTextBox1.Location = new Point(12, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new Size(0x18d, 0x85);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] { this.复制ToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new Size(0x5f, 0x1a);
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new Size(0x98, 0x16);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new EventHandler(this.复制ToolStripMenuItem_Click);
            this.label1.AutoSize = true;
            this.label1.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 0x86);
            this.label1.ForeColor = Color.Teal;
            this.label1.Location = new Point(10, 0xcd);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x191, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "                                                                  ";
            this.richTextBox2.BackColor = SystemColors.ActiveCaptionText;
            this.richTextBox2.BorderStyle = BorderStyle.None;
            this.richTextBox2.ContextMenuStrip = this.contextMenuStrip2;
            this.richTextBox2.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.richTextBox2.Location = new Point(12, 230);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new Size(0x18d, 0x36);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            this.contextMenuStrip2.Items.AddRange(new ToolStripItem[] { this.复制ToolStripMenuItem1 });
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new Size(0x99, 0x30);
            this.复制ToolStripMenuItem1.Name = "复制ToolStripMenuItem1";
            this.复制ToolStripMenuItem1.Size = new Size(0x98, 0x16);
            this.复制ToolStripMenuItem1.Text = "复制";
            this.复制ToolStripMenuItem1.Click += new EventHandler(this.复制ToolStripMenuItem1_Click);
            this.richTextBox3.BackColor = SystemColors.ActiveCaptionText;
            this.richTextBox3.BorderStyle = BorderStyle.None;
            this.richTextBox3.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.richTextBox3.Location = new Point(12, 300);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new Size(0x18d, 0x36);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("宋体", 9f, FontStyle.Underline, GraphicsUnit.Point, 0x86);
            this.label2.ForeColor = Color.Teal;
            this.label2.Location = new Point(10, 0x114);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x191, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "                                                                  ";
            this.btnZhiFuBao.Location = new Point(0xcc, 0x8e);
            this.btnZhiFuBao.Name = "btnZhiFuBao";
            this.btnZhiFuBao.Size = new Size(0x33, 0x13);
            this.btnZhiFuBao.TabIndex = 6;
            this.btnZhiFuBao.Text = "复制";
            this.btnZhiFuBao.UseVisualStyleBackColor = true;
            this.btnZhiFuBao.Click += new EventHandler(this.btnZhiFuBao_Click);
            this.btnCaiFuTong.Location = new Point(0xcc, 0x9f);
            this.btnCaiFuTong.Name = "btnCaiFuTong";
            this.btnCaiFuTong.Size = new Size(0x33, 0x13);
            this.btnCaiFuTong.TabIndex = 7;
            this.btnCaiFuTong.Text = "复制";
            this.btnCaiFuTong.UseVisualStyleBackColor = true;
            this.btnCaiFuTong.Click += new EventHandler(this.btnCaiFuTong_Click);
            this.pictureBox1.InitialImage = (Image) resource.GetObject("pictureBox1.InitialImage");
            this.pictureBox1.Location = new Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x18d, 0x49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.richTextBox4.BackColor = SystemColors.ActiveCaptionText;
            this.richTextBox4.BorderStyle = BorderStyle.None;
            this.richTextBox4.Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.richTextBox4.Location = new Point(0x11c, 350);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new Size(120, 20);
            this.richTextBox4.TabIndex = 8;
            this.richTextBox4.Text = "";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.ActiveCaptionText;
            base.ClientSize = new Size(0x1a3, 0x174);
            base.Controls.Add(this.richTextBox4);
            base.Controls.Add(this.btnCaiFuTong);
            base.Controls.Add(this.btnZhiFuBao);
            base.Controls.Add(this.richTextBox3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.richTextBox2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.richTextBox1);
            base.Controls.Add(this.pictureBox1);
            base.Icon = (Icon) resource.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "About";
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "关于";
            base.Load += new EventHandler(this.About_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((ISupportInitialize) this.pictureBox1).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.richTextBox1.SelectedText);
            MessageBox.Show("复制成功！", "感谢您的支持", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.richTextBox2.SelectedText);
            MessageBox.Show("复制成功！", "感谢您的支持", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}

