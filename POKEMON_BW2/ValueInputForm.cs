namespace POKEMON_BW2
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class ValueInputForm : Form
    {
        private Button cancelButton;
        private bool myAdjust;
        private Button okButton;
        private NumericUpDown valueNUD;

        public ValueInputForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
            valueNUD = new NumericUpDown();
            okButton = new Button();
            cancelButton = new Button();
            valueNUD.BeginInit();
            SuspendLayout();
            valueNUD.Location = new Point(12, 12);
            int[] bits = new int[4];
            bits[0] = 0xffff;
            valueNUD.Maximum = new decimal(bits);
            valueNUD.Name = "valueNUD";
            valueNUD.Size = new Size(0x4b, 0x13);
            valueNUD.TabIndex = 0;
            okButton.Location = new Point(0x5d, 9);
            okButton.Name = "okButton";
            okButton.Size = new Size(0x4b, 0x17);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(0xae, 9);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(0x4b, 0x17);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(6f, 12f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(0x103, 0x2b);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(valueNUD);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ValueInputForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Please Input...";
            Activated += ValueInputForm_Activated;
            valueNUD.EndInit();
            ResumeLayout(false);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ValueInputForm_Activated(object sender, EventArgs e)
        {
            valueNUD.Focus();
            valueNUD.Select(0, valueNUD.ToString().Length);
        }

        public bool Adjust
        {
            set
            {
                myAdjust = value;
            }
        }

        public int Maximum
        {
            get
            {
                return (int) valueNUD.Maximum;
            }
            set
            {
                valueNUD.Maximum = value;
            }
        }

        public int Minimum
        {
            get
            {
                return (int) valueNUD.Minimum;
            }
            set
            {
                valueNUD.Minimum = value;
            }
        }

        public int Value
        {
            get
            {
                return (int) valueNUD.Value;
            }
            set
            {
                if (myAdjust)
                {
                    if (Maximum < value)
                    {
                        valueNUD.Value = Maximum;
                        return;
                    }
                    if (Minimum > value)
                    {
                        valueNUD.Value = Minimum;
                        return;
                    }
                }
                valueNUD.Value = value;
            }
        }
    }
}

