namespace POKEMON_BW2
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class PlaceForm : Form
    {
        private Button cancelButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dgv;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ValueInputForm lvVIF = new ValueInputForm();
        private Button maxLvButton;
        private Button minLvButton;
        private PlaceData[] myPlace;
        private OpenFileDialog ofd;
        private Button okButton;
        private Panel panel1;
        private ListBox placeListBox;
        private Button pokeButton;
        private ListBoxDialog pokeLBD = new ListBoxDialog();
        private Button readBinButton;
        private int selectedValue;
        private SaveFileDialog sfd;
        private SplitContainer splitContainer1;
        private Button writeBinButton;
        private NumericUpDown x00_NUD;
        private NumericUpDown x01_NUD;
        private NumericUpDown x02_NUD;
        private NumericUpDown x03_NUD;
        private NumericUpDown x04_NUD;
        private NumericUpDown x05_NUD;
        private NumericUpDown x06_NUD;
        private NumericUpDown x07_NUD;

        public PlaceForm(PlaceData[] place)
        {
            InitializeComponent();
            dgv.Rows.Add(0x38);
            for (int i = 0; i < 12; i++)
            {
                dgv[0, i].Value = "Grass " + i;
            }
            for (int j = 12; j < 0x18; j++)
            {
                dgv[0, j].Value = "Doubles (Dark) Grass " + (j - 12);
            }
            for (int k = 0x18; k < 0x24; k++)
            {
                dgv[0, k].Value = "Shaking Grass " + (k - 0x18);
            }
            for (int m = 0x24; m < 0x29; m++)
            {
                dgv[0, m].Value = "Surfing " + (m - 0x24);
            }
            for (int n = 0x29; n < 0x2e; n++)
            {
                dgv[0, n].Value = "Surfing Spot " + (n - 41);
            }
            for (int num6 = 0x2e; num6 < 0x33; num6++)
            {
                dgv[0, num6].Value = "Fishing " + (num6 - 0x2E);
            }
            for (int num7 = 0x33; num7 < 0x38; num7++)
            {
                dgv[0, num7].Value = "Fishing Spot " + (num7 - 51);
            }
            pokeLBD.InitializeArrayList(Program.Poke2List.GetArrayList());
            placeListBox.DataSource = (ArrayList) Program.PlaceList.GetArrayList().Clone();
            placeListBox.DisplayMember = "Name";
            placeListBox.ValueMember = "Value";
            myPlace = new PlaceData[place.Length];
            for (int num8 = 0; num8 < myPlace.Length; num8++)
            {
                myPlace[num8] = new PlaceData();
                for (int num9 = 0; num9 < 0xe8; num9++)
                {
                    myPlace[num8][num9] = place[num8][num9];
                }
            }
            placeListBox.SelectedIndex = 0;
            placeListBox.SelectedIndexChanged += placeListBox_SelectedIndexChanged;
            ReadData((int) placeListBox.SelectedValue);
            selectedValue = (int) placeListBox.SelectedValue;
            lvVIF.Adjust = true;
            lvVIF.Maximum = 100;
            lvVIF.Minimum = 0;
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
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            placeListBox = new ListBox();
            groupBox3 = new GroupBox();
            readBinButton = new Button();
            writeBinButton = new Button();
            groupBox2 = new GroupBox();
            x07_NUD = new NumericUpDown();
            x06_NUD = new NumericUpDown();
            x03_NUD = new NumericUpDown();
            x05_NUD = new NumericUpDown();
            x02_NUD = new NumericUpDown();
            x04_NUD = new NumericUpDown();
            x01_NUD = new NumericUpDown();
            x00_NUD = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            maxLvButton = new Button();
            minLvButton = new Button();
            pokeButton = new Button();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            okButton = new Button();
            cancelButton = new Button();
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
            panel1.SuspendLayout();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            x07_NUD.BeginInit();
            x06_NUD.BeginInit();
            x03_NUD.BeginInit();
            x05_NUD.BeginInit();
            x02_NUD.BeginInit();
            x04_NUD.BeginInit();
            x01_NUD.BeginInit();
            x00_NUD.BeginInit();
            groupBox1.SuspendLayout();
            ((ISupportInitialize) dgv).BeginInit();
            SuspendLayout();
            panel1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            panel1.Controls.Add(splitContainer1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0x310, 0x206);
            panel1.TabIndex = 0;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Panel1.Controls.Add(placeListBox);
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(0x310, 0x206);
            splitContainer1.SplitterDistance = 0xb6;
            splitContainer1.TabIndex = 0;
            placeListBox.Dock = DockStyle.Fill;
            placeListBox.FormattingEnabled = true;
            placeListBox.ItemHeight = 12;
            placeListBox.Location = new Point(0, 0);
            placeListBox.Name = "placeListBox";
            placeListBox.Size = new Size(0xb6, 0x1fc);
            placeListBox.TabIndex = 0;
            groupBox3.Controls.Add(readBinButton);
            groupBox3.Controls.Add(writeBinButton);
            groupBox3.Location = new Point(400, 0x1c9);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(0xc3, 0x3a);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Encounter Slot Backup (.bin)";
            readBinButton.Location = new Point(100, 0x16);
            readBinButton.Name = "readBinButton";
            readBinButton.Size = new Size(0x4b, 0x17);
            readBinButton.TabIndex = 4;
            readBinButton.Text = "Import";
            readBinButton.UseVisualStyleBackColor = true;
            readBinButton.Click += readBinButton_Click;
            writeBinButton.Location = new Point(0x13, 0x16);
            writeBinButton.Name = "writeBinButton";
            writeBinButton.Size = new Size(0x4b, 0x17);
            writeBinButton.TabIndex = 3;
            writeBinButton.Text = "Export";
            writeBinButton.UseVisualStyleBackColor = true;
            writeBinButton.Click += writeBinButton_Click;
            groupBox2.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            groupBox2.Controls.Add(x07_NUD);
            groupBox2.Controls.Add(x06_NUD);
            groupBox2.Controls.Add(x03_NUD);
            groupBox2.Controls.Add(x05_NUD);
            groupBox2.Controls.Add(x02_NUD);
            groupBox2.Controls.Add(x04_NUD);
            groupBox2.Controls.Add(x01_NUD);
            groupBox2.Controls.Add(x00_NUD);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(3, 0x1c9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(0x187, 0x3a);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Habitat Header";
            x07_NUD.Location = new Point(330, 30);
            int[] bits = new int[4];
            bits[0] = 0xff;
            x07_NUD.Maximum = new decimal(bits);
            x07_NUD.Name = "x07_NUD";
            x07_NUD.Size = new Size(40, 0x13);
            x07_NUD.TabIndex = 8;
            x06_NUD.Location = new Point(0x11c, 30);
            int[] numArray2 = new int[4];
            numArray2[0] = 0xff;
            x06_NUD.Maximum = new decimal(numArray2);
            x06_NUD.Name = "x06_NUD";
            x06_NUD.Size = new Size(40, 0x13);
            x06_NUD.TabIndex = 8;
            x03_NUD.Location = new Point(0x92, 30);
            int[] numArray3 = new int[4];
            numArray3[0] = 0xff;
            x03_NUD.Maximum = new decimal(numArray3);
            x03_NUD.Name = "x03_NUD";
            x03_NUD.Size = new Size(40, 0x13);
            x03_NUD.TabIndex = 8;
            x05_NUD.Location = new Point(0xee, 30);
            int[] numArray4 = new int[4];
            numArray4[0] = 0xff;
            x05_NUD.Maximum = new decimal(numArray4);
            x05_NUD.Name = "x05_NUD";
            x05_NUD.Size = new Size(40, 0x13);
            x05_NUD.TabIndex = 8;
            x02_NUD.Location = new Point(100, 30);
            int[] numArray5 = new int[4];
            numArray5[0] = 0xff;
            x02_NUD.Maximum = new decimal(numArray5);
            x02_NUD.Name = "x02_NUD";
            x02_NUD.Size = new Size(40, 0x13);
            x02_NUD.TabIndex = 8;
            x04_NUD.Location = new Point(0xc0, 30);
            int[] numArray6 = new int[4];
            numArray6[0] = 0xff;
            x04_NUD.Maximum = new decimal(numArray6);
            x04_NUD.Name = "x04_NUD";
            x04_NUD.Size = new Size(40, 0x13);
            x04_NUD.TabIndex = 8;
            x01_NUD.Location = new Point(0x36, 30);
            int[] numArray7 = new int[4];
            numArray7[0] = 0xff;
            x01_NUD.Maximum = new decimal(numArray7);
            x01_NUD.Name = "x01_NUD";
            x01_NUD.Size = new Size(40, 0x13);
            x01_NUD.TabIndex = 8;
            x00_NUD.Location = new Point(8, 30);
            int[] numArray8 = new int[4];
            numArray8[0] = 0xff;
            x00_NUD.Maximum = new decimal(numArray8);
            x00_NUD.Name = "x00_NUD";
            x00_NUD.Size = new Size(40, 0x13);
            x00_NUD.TabIndex = 8;
            label8.AutoSize = true;
            label8.Location = new Point(0x148, 15);
            label8.Name = "label8";
            label8.Size = new Size(0x35, 12);
            label8.TabIndex = 7;
            label8.Text = "Item*";
            label7.AutoSize = true;
            label7.Location = new Point(0x11a, 15);
            label7.Name = "label7";
            label7.Size = new Size(0x25, 12);
            label7.TabIndex = 6;
            label7.Text = "Fish*";
            label6.AutoSize = true;
            label6.Location = new Point(0xec, 15);
            label6.Name = "label6";
            label6.Size = new Size(0x19, 12);
            label6.TabIndex = 5;
            label6.Text = "Fish";
            label5.AutoSize = true;
            label5.Location = new Point(190, 15);
            label5.Name = "label5";
            label5.Size = new Size(0x1d, 12);
            label5.TabIndex = 4;
            label5.Text = "Surf*";
            label4.AutoSize = true;
            label4.Location = new Point(0x90, 15);
            label4.Name = "label4";
            label4.Size = new Size(0x1d, 12);
            label4.TabIndex = 3;
            label4.Text = "Surf";
            label3.AutoSize = true;
            label3.Location = new Point(100, 15);
            label3.Name = "label3";
            label3.Size = new Size(0x1d, 12);
            label3.TabIndex = 2;
            label3.Text = "Shake";
            label2.AutoSize = true;
            label2.Location = new Point(0x34, 15);
            label2.Name = "label2";
            label2.Size = new Size(0x1d, 12);
            label2.TabIndex = 1;
            label2.Text = "Double";
            label1.AutoSize = true;
            label1.Location = new Point(6, 15);
            label1.Name = "label1";
            label1.Size = new Size(0x23, 12);
            label1.TabIndex = 0;
            label1.Text = "Regular";
            groupBox1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            groupBox1.Controls.Add(maxLvButton);
            groupBox1.Controls.Add(minLvButton);
            groupBox1.Controls.Add(pokeButton);
            groupBox1.Controls.Add(dgv);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(0x250, 0x1c0);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encounter Slot Data";
            maxLvButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            maxLvButton.Location = new Point(0x1ed, 0x1a3);
            maxLvButton.Name = "maxLvButton";
            maxLvButton.Size = new Size(90, 0x17);
            maxLvButton.TabIndex = 3;
            maxLvButton.Text = "Edit Max Level";
            maxLvButton.UseVisualStyleBackColor = true;
            maxLvButton.Click += maxLvButton_Click;
            minLvButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            minLvButton.Location = new Point(0x18d, 0x1a3);
            minLvButton.Name = "minLvButton";
            minLvButton.Size = new Size(90, 0x17);
            minLvButton.TabIndex = 2;
            minLvButton.Text = "Edit Min Level";
            minLvButton.UseVisualStyleBackColor = true;
            minLvButton.Click += minLvButton_Click;
            pokeButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            pokeButton.Location = new Point(0x12d, 0x1a3);
            pokeButton.Name = "pokeButton";
            pokeButton.Size = new Size(90, 0x17);
            pokeButton.TabIndex = 1;
            pokeButton.Text = "Edit Pokémon";
            pokeButton.UseVisualStyleBackColor = true;
            pokeButton.Click += pokeButton_Click;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(Column1, Column2, Column3, Column4);
            dgv.Location = new Point(3, 15);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 0x15;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(0x24a, 0x18e);
            dgv.TabIndex = 0;
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Slot";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Pokémon";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.HeaderText = "Min Level";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column3.Width = 80;
            Column4.HeaderText = "Max Level";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            Column4.Width = 80;
            okButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            okButton.Location = new Point(0x268, 0x210);
            okButton.Name = "okButton";
            okButton.Size = new Size(0x4b, 0x17);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            cancelButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            cancelButton.Location = new Point(0x2b9, 0x210);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(0x4b, 0x17);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            ofd.Filter = "Encounter Slot File|*.bin|All Files|*.*";
            sfd.Filter = "Encounter Slot File|*.bin|Slots|*.*";
            AutoScaleDimensions = new SizeF(6f, 12f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(0x310, 0x233);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 600);
            Name = "PlaceForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Encounter Slot Editor";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            x07_NUD.EndInit();
            x06_NUD.EndInit();
            x03_NUD.EndInit();
            x05_NUD.EndInit();
            x02_NUD.EndInit();
            x04_NUD.EndInit();
            x01_NUD.EndInit();
            x00_NUD.EndInit();
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize) dgv).EndInit();
            ResumeLayout(false);
        }

        private void maxLvButton_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int selectedValue = (int) placeListBox.SelectedValue;
                int count = dgv.SelectedRows.Count;
                lvVIF.Value = (int) dgv.SelectedRows[count - 1].Cells[3].Value;
                if (lvVIF.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < count; i++)
                    {
                        int rowIndex = dgv.SelectedRows[i].Cells[0].RowIndex;
                        myPlace[selectedValue].SetMaxLv(rowIndex, lvVIF.Value);
                    }
                    ReadData(selectedValue);
                }
            }
        }

        private void minLvButton_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int selectedValue = (int) placeListBox.SelectedValue;
                int count = dgv.SelectedRows.Count;
                lvVIF.Value = (int) dgv.SelectedRows[count - 1].Cells[2].Value;
                if (lvVIF.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < count; i++)
                    {
                        int rowIndex = dgv.SelectedRows[i].Cells[0].RowIndex;
                        myPlace[selectedValue].SetMinLv(rowIndex, lvVIF.Value);
                    }
                    ReadData(selectedValue);
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            WriteData(selectedValue);
            DialogResult = DialogResult.OK;
        }

        private void placeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (placeListBox.SelectedIndex < 0)
            {
                placeListBox.SelectedIndex = 0;
            }
            else if (placeListBox.SelectedIndex >= placeListBox.Items.Count)
            {
                placeListBox.SelectedIndex = placeListBox.Items.Count - 1;
            }
            WriteData(selectedValue);
            ReadData((int) placeListBox.SelectedValue);
            selectedValue = (int) placeListBox.SelectedValue;
        }

        private void pokeButton_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                int selectedValue = (int) placeListBox.SelectedValue;
                int count = dgv.SelectedRows.Count;
                pokeLBD.SelectedValue = Program.Poke2List.SearchByName((string) dgv.SelectedRows[count - 1].Cells[1].Value);
                if (pokeLBD.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < count; i++)
                    {
                        int rowIndex = dgv.SelectedRows[i].Cells[0].RowIndex;
                        myPlace[selectedValue].SetPokemon(rowIndex, pokeLBD.SelectedValue);
                    }
                    ReadData(selectedValue);
                }
            }
        }

        private void readBinButton_Click(object sender, EventArgs e)
        {
            ofd.FileName = ((SelectBoxItem) placeListBox.SelectedItem).Name + ".bin";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int selectedValue = (int) placeListBox.SelectedValue;
                byte[] buffer = File.ReadAllBytes(ofd.FileName);
                for (int i = 0; i < 0xe8; i++)
                {
                    myPlace[selectedValue][i] = buffer[i];
                }
                ReadData(selectedValue);
            }
        }

        private void ReadData(int index)
        {
            for (int i = 0; i < 0x38; i++)
            {
                dgv[1, i].Value = Program.Poke2List.SearchByValue(myPlace[index].GetPokemon(i));
                dgv[2, i].Value = myPlace[index].GetMinLv(i);
                dgv[3, i].Value = myPlace[index].GetMaxLv(i);
            }
            x00_NUD.Value = myPlace[index][0];
            x01_NUD.Value = myPlace[index][1];
            x02_NUD.Value = myPlace[index][2];
            x03_NUD.Value = myPlace[index][3];
            x04_NUD.Value = myPlace[index][4];
            x05_NUD.Value = myPlace[index][5];
            x06_NUD.Value = myPlace[index][6];
            x07_NUD.Value = myPlace[index][7];
        }

        private void writeBinButton_Click(object sender, EventArgs e)
        {
            sfd.FileName = ((SelectBoxItem) placeListBox.SelectedItem).Name + ".bin";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int selectedValue = (int) placeListBox.SelectedValue;
                byte[] bytes = new byte[0xe8];
                for (int i = 0; i < 0xe8; i++)
                {
                    bytes[i] = myPlace[selectedValue][i];
                }
                File.WriteAllBytes(sfd.FileName, bytes);
            }
        }

        private void WriteData(int index)
        {
            myPlace[index][0] = (byte) x00_NUD.Value;
            myPlace[index][1] = (byte) x01_NUD.Value;
            myPlace[index][2] = (byte) x02_NUD.Value;
            myPlace[index][3] = (byte) x03_NUD.Value;
            myPlace[index][4] = (byte) x04_NUD.Value;
            myPlace[index][5] = (byte) x05_NUD.Value;
            myPlace[index][6] = (byte) x06_NUD.Value;
            myPlace[index][7] = (byte) x07_NUD.Value;
        }

        public PlaceData[] Place
        {
            get
            {
                return myPlace;
            }
        }
    }
}

