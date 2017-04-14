namespace POKEMON_BW2
{
    using System;
    using System.Collections;
    using System.Drawing;
    using System.Windows.Forms;

    public class ListBoxDialog : Form
    {
        private Button cancelButton;
        private GroupBox groupBox1;
        protected ArrayList list;
        private ListBox listBox;
        private int max;
        private int min;
        private Button okButton;
        private Button searchButton;
        private ComboBox searchComboBox;
        private TextBox textBox1;

        public ListBoxDialog()
        {
            InitializeComponent();
            searchComboBox.SelectedIndex = 0;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            int selectedValue = SelectedValue;
            listBox.DataSource = list;
            listBox.SelectedValue = selectedValue;
            DialogResult = DialogResult.Cancel;
        }

        private void Decide()
        {
            if (listBox.SelectedIndex != -1)
            {
                int selectedValue = SelectedValue;
                listBox.DataSource = list;
                listBox.SelectedValue = selectedValue;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("No items selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        public void InitializeArrayList(ArrayList list)
        {
            if ((list == null) || (list.Count < 1))
            {
                throw new Exception("List not Initialized.");
            }
            this.list = list;
            listBox.DataSource = list;
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "Value";
            max = -2147483648;
            min = 0x7fffffff;
            for (int i = 0; i < list.Count; i++)
            {
                SelectBoxItem item = (SelectBoxItem) list[i];
                int num2 = item.Value;
                if (max < num2)
                {
                    max = num2;
                }
                if (min > num2)
                {
                    min = num2;
                }
            }
        }

        private void InitializeComponent()
        {
            listBox = new ListBox();
            okButton = new Button();
            cancelButton = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            searchComboBox = new ComboBox();
            searchButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            listBox.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 12;
            listBox.Location = new Point(0, 0);
            listBox.Name = "listBox";
            listBox.Size = new Size(0x11c, 0x100);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listBox.DoubleClick += listBox_DoubleClick;
            listBox.KeyPress += listBox_KeyPress;
            okButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            okButton.Location = new Point(0x74, 0x148);
            okButton.Name = "okButton";
            okButton.Size = new Size(0x4b, 0x17);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            cancelButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(0xc5, 0x148);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(0x4b, 0x17);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            groupBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(searchComboBox);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 0x10d);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 0x35);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            textBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
            textBox1.Location = new Point(6, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0x56, 0x13);
            textBox1.TabIndex = 0;
            searchComboBox.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            searchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "Begins with", "Includes", "Ends with" });
            searchComboBox.Location = new Point(0x62, 20);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(0x4b, 20);
            searchComboBox.TabIndex = 1;
            searchButton.Anchor = AnchorStyles.Right | AnchorStyles.Top;
            searchButton.Location = new Point(0xb3, 0x12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(0x4b, 0x17);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            AutoScaleDimensions = new SizeF(6f, 12f);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelButton;
            ClientSize = new Size(0x11c, 0x16b);
            Controls.Add(groupBox1);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(listBox);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ListBoxDialog";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Please Select...";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            Decide();
        }

        private void listBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '\r') || (e.KeyChar == '\r') || (e.KeyChar == '+'))
            {
                Decide();
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Decide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                listBox.DataSource = list;
            }
            else
            {
                ArrayList list = new ArrayList();
                switch (searchComboBox.SelectedIndex)
                {
                    case 0:
                        for (int i = 0; i < this.list.Count; i++)
                        {
                            if (((SelectBoxItem) this.list[i]).Name.StartsWith(textBox1.Text))
                            {
                                list.Add(this.list[i]);
                            }
                        }
                        break;
                    case 1:
                        for (int j = 0; j < this.list.Count; j++)
                        {
                            if (((SelectBoxItem) this.list[j]).Name.IndexOf(textBox1.Text, StringComparison.Ordinal) != -1)
                            {
                                list.Add(this.list[j]);
                            }
                        }
                        break;
                    default:
                        for (int k = 0; k < this.list.Count; k++)
                        {
                            if (((SelectBoxItem) this.list[k]).Name.EndsWith(textBox1.Text))
                            {
                                list.Add(this.list[k]);
                            }
                        }
                        break;
                }
                listBox.DataSource = list;
            }
        }

        public int Count => listBox.Items.Count;

        public int MaxValue => max;

        public int MinValue => min;

        public int SelectedIndex
        {
            get
            {
                return listBox.SelectedIndex;
            }
            set
            {
                if (value >= listBox.Items.Count)
                {
                    listBox.SelectedIndex = listBox.Items.Count - 1;
                }
                else if (value < 0)
                {
                    listBox.SelectedIndex = 0;
                }
                else
                {
                    listBox.SelectedIndex = value;
                }
            }
        }

        public string SelectedName
        {
            get
            {
                if ((listBox.SelectedIndex < 0) || (listBox.SelectedIndex >= listBox.Items.Count))
                    return string.Empty;

                SelectBoxItem selectedItem = (SelectBoxItem) listBox.SelectedItem;
                return selectedItem.Name;
            }
            set
            {
                if ((listBox.SelectedIndex < 0) || (listBox.SelectedIndex >= listBox.Items.Count))
                    return;

                SelectBoxItem selectedItem = (SelectBoxItem) listBox.SelectedItem;
                selectedItem.Name = value;
            }
        }

        public int SelectedValue
        {
            get
            {
                if ((listBox.SelectedIndex >= 0) && (listBox.SelectedIndex < listBox.Items.Count))
                {
                    return (int) listBox.SelectedValue;
                }
                return 0;
            }
            set
            {
                try
                {
                    listBox.SelectedValue = value;
                }
                catch
                {
                    listBox.SelectedIndex = 0;
                }
            }
        }
    }
}

