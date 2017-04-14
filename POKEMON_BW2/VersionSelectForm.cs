namespace POKEMON_BW2
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class VersionSelectForm : Form
    {
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        public Form1.Version Version;

        public VersionSelectForm()
        {
            InitializeComponent();
            Version = Form1.Version.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(0x94, 0x10);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "ポケットモンスター　ブラック2";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 0x22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(0x98, 0x10);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "ポケットモンスター　ホワイト2";
            radioButton2.UseVisualStyleBackColor = true;
            button1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            button1.Location = new Point(0xb5, 0x1a);
            button1.Name = "button1";
            button1.Size = new Size(0x4b, 0x17);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            AutoScaleDimensions = new SizeF(6f, 12f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(0x10c, 0x3d);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VersionSelectForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "バージョン選択";
            ResumeLayout(false);
            PerformLayout();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Version = Form1.Version.Black;
            }
            else if (radioButton2.Checked)
            {
                Version = Form1.Version.White;
            }
        }
    }
}

