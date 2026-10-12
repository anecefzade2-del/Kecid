namespace Random_number
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();

            this.yenioyunbtn = new System.Windows.Forms.Button();

            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();

            this.panelCehd = new System.Windows.Forms.Panel();
            this.labelCehd = new System.Windows.Forms.Label();

            this.richTextBox1 = new System.Windows.Forms.RichTextBox();

            this.errorProvider1 =
                new System.Windows.Forms.ErrorProvider(this.components);

            this.panel1.SuspendLayout();
            this.panelCehd.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.errorProvider1)).BeginInit();

            this.SuspendLayout();

            // 
            // panel1
            // 
            this.panel1.BackColor =
                System.Drawing.Color.FromArgb(52, 73, 94);

            this.panel1.Controls.Add(
                this.titleLabel);

            this.panel1.Location =
                new System.Drawing.Point(0, 0);

            this.panel1.Name =
                "panel1";

            this.panel1.Size =
                new System.Drawing.Size(560, 90);

            this.panel1.TabIndex = 0;

            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;

            this.titleLabel.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    22F,
                    System.Drawing.FontStyle.Bold);

            this.titleLabel.ForeColor =
                System.Drawing.Color.White;

            this.titleLabel.Location =
                new System.Drawing.Point(145, 24);

            this.titleLabel.Name =
                "titleLabel";

            this.titleLabel.Size =
                new System.Drawing.Size(275, 41);

            this.titleLabel.TabIndex = 0;

            this.titleLabel.Text =
                "ƏDƏD TAPMA OYUNU";

            // 
            // yenioyunbtn
            // 
            this.yenioyunbtn.BackColor =
                System.Drawing.Color.FromArgb(46, 204, 113);

            this.yenioyunbtn.FlatAppearance.BorderSize = 0;

            this.yenioyunbtn.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.yenioyunbtn.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.yenioyunbtn.ForeColor =
                System.Drawing.Color.White;

            this.yenioyunbtn.Location =
                new System.Drawing.Point(175, 115);

            this.yenioyunbtn.Name =
                "yenioyunbtn";

            this.yenioyunbtn.Size =
                new System.Drawing.Size(210, 45);

            this.yenioyunbtn.TabIndex = 1;

            this.yenioyunbtn.Text =
                "YENİ OYUN";

            this.yenioyunbtn.UseVisualStyleBackColor =
                false;

            this.yenioyunbtn.Click +=
                new System.EventHandler(
                    this.yenioyunbtn_Click);

            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.label1.ForeColor =
                System.Drawing.Color.FromArgb(52, 73, 94);

            this.label1.Location =
                new System.Drawing.Point(55, 190);

            this.label1.Name =
                "label1";

            this.label1.Size =
                new System.Drawing.Size(137, 20);

            this.label1.TabIndex = 2;

            this.label1.Text =
                "Axtarılan ədəd:";

            // 
            // textBox1
            // 
            this.textBox1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F);

            this.textBox1.Location =
                new System.Drawing.Point(55, 220);

            this.textBox1.Name =
                "textBox1";

            this.textBox1.Size =
                new System.Drawing.Size(260, 31);

            this.textBox1.TabIndex = 3;

            this.textBox1.TextAlign =
                System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // button1
            // 
            this.button1.BackColor =
                System.Drawing.Color.FromArgb(52, 152, 219);

            this.button1.FlatAppearance.BorderSize = 0;

            this.button1.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.button1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            this.button1.ForeColor =
                System.Drawing.Color.White;

            this.button1.Location =
                new System.Drawing.Point(330, 218);

            this.button1.Name =
                "button1";

            this.button1.Size =
                new System.Drawing.Size(175, 36);

            this.button1.TabIndex = 4;

            this.button1.Text =
                "YOXLA";

            this.button1.UseVisualStyleBackColor =
                false;

            this.button1.Click +=
                new System.EventHandler(
                    this.button1_Click);

            // 
            // panelCehd
            // 
            this.panelCehd.BackColor =
                System.Drawing.Color.FromArgb(236, 240, 241);

            this.panelCehd.Controls.Add(
                this.labelCehd);

            this.panelCehd.Location =
                new System.Drawing.Point(55, 275);

            this.panelCehd.Name =
                "panelCehd";

            this.panelCehd.Size =
                new System.Drawing.Size(450, 50);

            this.panelCehd.TabIndex = 5;

            // 
            // labelCehd
            // 
            this.labelCehd.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.labelCehd.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    12F,
                    System.Drawing.FontStyle.Bold);

            this.labelCehd.ForeColor =
                System.Drawing.Color.FromArgb(52, 73, 94);

            this.labelCehd.Location =
                new System.Drawing.Point(0, 0);

            this.labelCehd.Name =
                "labelCehd";

            this.labelCehd.Size =
                new System.Drawing.Size(450, 50);

            this.labelCehd.TabIndex = 0;

            this.labelCehd.Text =
                "Cəhd sayı: 0";

            this.labelCehd.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor =
                System.Drawing.Color.White;

            this.richTextBox1.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.richTextBox1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            this.richTextBox1.Location =
                new System.Drawing.Point(55, 345);

            this.richTextBox1.Name =
                "richTextBox1";

            this.richTextBox1.ReadOnly = true;

            this.richTextBox1.Size =
                new System.Drawing.Size(450, 120);

            this.richTextBox1.TabIndex = 6;

            this.richTextBox1.Text = "";

            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl =
                this;

            // 
            // Form1
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    7F,
                    15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    245, 247, 250);

            this.ClientSize =
                new System.Drawing.Size(560, 500);

            this.Controls.Add(
                this.richTextBox1);

            this.Controls.Add(
                this.panelCehd);

            this.Controls.Add(
                this.button1);

            this.Controls.Add(
                this.textBox1);

            this.Controls.Add(
                this.label1);

            this.Controls.Add(
                this.yenioyunbtn);

            this.Controls.Add(
                this.panel1);

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.Name =
                "Form1";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Ədəd Tapma Oyunu";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();

            this.panelCehd.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)
                (this.errorProvider1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.Button yenioyunbtn;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Panel panelCehd;
        private System.Windows.Forms.Label labelCehd;

        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}