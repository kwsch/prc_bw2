namespace POKEMON_BW2
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView dgv;
        private Button evoCode_BT;
        private ListBoxDialog evolLBD = new ListBoxDialog();
        private EvolveData[] evolve;
        public static int EVOLVE_B2 = 0xa78525c;
        public static int EVOLVE_W2 = 0xa78525c;
        private Button evoPokemon_BT;
        private Button evoValue_BT;
        private ToolStripMenuItem exitToolStripMenuItem;
        public static int FAMILY_B2 = 0xa769664;
        public static int FAMILY_W2 = 0xa769664;
        private ToolStripMenuItem fileToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private int[] item = new int[3];
        private ListBoxDialog itemLBD = new ListBoxDialog();
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newSaveToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem openToolStripMenuItem;
        private PlaceData[] place;
        public static int PLACE_B2 = 0xc876a6c;
        public static int PLACE_W2 = 0xc87686c;
        private ToolStripMenuItem placeToolStripMenuItem;
        private PokemonData[] poke;
        private ListBoxDialog pokeLBD = new ListBoxDialog();
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button searchButton;
        private ComboBox searchComboBox;
        private TextBox searchTextBox;
        private EvolveData selectedEvolve;
        private int selectedValue;
        private SkillData[] skill;
        public static int SKILL_B2 = 0xa7901b4;
        public static int SKILL_W2 = 0xa7901b4;
        private ListBoxDialog skilLBD = new ListBoxDialog();
        private ToolStripMenuItem skillToolStripMenuItem;
        private TextBox sourceTextBox;
        private int[] spec = new int[3];
        private ListBoxDialog specLBD = new ListBoxDialog();
        private SplitContainer splitContainer1;
        private StatusStrip statusStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripMenuItem toolToolStripMenuItem;
        private NumericUpDown x00_NUD;
        private NumericUpDown x01_NUD;
        private NumericUpDown x02_NUD;
        private NumericUpDown x03_NUD;
        private NumericUpDown x04_NUD;
        private NumericUpDown x05_NUD;
        private ComboBox x06_CoB;
        private ComboBox x07_CoB;
        private NumericUpDown x08_NUD;
        private NumericUpDown x09_NUD;
        private NumericUpDown x0A_0_NUD;
        private NumericUpDown x0A_1_NUD;
        private NumericUpDown x0A_2_NUD;
        private NumericUpDown x0A_3_NUD;
        private NumericUpDown x0B_0_NUD;
        private NumericUpDown x0B_1_NUD;
        private Button x0C_BT;
        private Button x0E_BT;
        private Button x10_BT;
        private ComboBox x12_CoB;
        private NumericUpDown x13_NUD;
        private NumericUpDown x14_NUD;
        private ComboBox x15_CoB;
        private ComboBox x16_CoB;
        private ComboBox x17_CoB;
        private Button x18_BT;
        private Button x19_BT;
        private Button x1A_BT;
        private NumericUpDown x1B_NUD;
        private CheckBox x21_0_ChB;
        private CheckBox x21_1_ChB;
        private ComboBox x21_CoB;
        private NumericUpDown x22_NUD;
        private CheckedListBox x28_CLB;

        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource = (ArrayList) Program.PokeList.GetArrayList().Clone();
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Value";
            x12_CoB.DataSource = (ArrayList) Program.SexList.GetArrayList().Clone();
            x12_CoB.DisplayMember = "Name";
            x12_CoB.ValueMember = "Value";
            x15_CoB.DataSource = (ArrayList) Program.LevelList.GetArrayList().Clone();
            x15_CoB.DisplayMember = "Name";
            x15_CoB.ValueMember = "Value";
            x06_CoB.DataSource = (ArrayList) Program.TypeList.GetArrayList().Clone();
            x06_CoB.DisplayMember = "Name";
            x06_CoB.ValueMember = "Value";
            x07_CoB.DataSource = (ArrayList) Program.TypeList.GetArrayList().Clone();
            x07_CoB.DisplayMember = "Name";
            x07_CoB.ValueMember = "Value";
            x16_CoB.DataSource = (ArrayList) Program.GroupList.GetArrayList().Clone();
            x16_CoB.DisplayMember = "Name";
            x16_CoB.ValueMember = "Value";
            x17_CoB.DataSource = (ArrayList) Program.GroupList.GetArrayList().Clone();
            x17_CoB.DisplayMember = "Name";
            x17_CoB.ValueMember = "Value";
            x21_CoB.DataSource = (ArrayList) Program.LookList.GetArrayList().Clone();
            x21_CoB.DisplayMember = "Name";
            x21_CoB.ValueMember = "Value";
            dgv.Rows.Add(7);
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv[0, i].Value = (i + 1).ToString();
            }
            itemLBD.InitializeArrayList((ArrayList) Program.ItemList.GetArrayList().Clone());
            specLBD.InitializeArrayList((ArrayList) Program.SpecList.GetArrayList().Clone());
            evolLBD.InitializeArrayList((ArrayList) Program.EvolveList.GetArrayList().Clone());
            pokeLBD.InitializeArrayList((ArrayList) Program.PokeList.GetArrayList().Clone());
            skilLBD.InitializeArrayList((ArrayList) Program.SkillList.GetArrayList().Clone());
            searchComboBox.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
            selectedValue = (int) listBox1.SelectedValue;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < x28_CLB.Items.Count; i++)
            {
                x28_CLB.SetItemChecked(i, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < x28_CLB.Items.Count; i++)
            {
                x28_CLB.SetItemChecked(i, false);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        private void evoCode_BT_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv.SelectedRows[0].Cells[0].RowIndex;
            evolLBD.SelectedValue = selectedEvolve.GetCode(rowIndex);
            if (evolLBD.ShowDialog() == DialogResult.OK)
            {
                selectedEvolve.SetCode(rowIndex, evolLBD.SelectedValue);
            }
            ReadEvolveData(selectedValue);
        }

        private void evoPokemon_BT_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv.SelectedRows[0].Cells[0].RowIndex;
            pokeLBD.SelectedValue = selectedEvolve.GetPokemon(rowIndex);
            if (pokeLBD.ShowDialog() == DialogResult.OK)
            {
                selectedEvolve.SetPokemon(rowIndex, pokeLBD.SelectedValue);
            }
            ReadEvolveData(selectedValue);
        }

        private void evoValue_BT_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv.SelectedRows[0].Cells[0].RowIndex;
            switch (selectedEvolve.GetCode(rowIndex))
            {
                case 4:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 0x10:
                case 0x17:
                case 0x18:
                {
                    ValueInputForm form = new ValueInputForm {
                        Adjust = true,
                        Maximum = 100,
                        Minimum = 0,
                        Value = selectedEvolve.GetValue(rowIndex)
                    };
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        selectedEvolve.SetValue(rowIndex, form.Value);
                    }
                    break;
                }
                case 6:
                case 8:
                case 0x11:
                case 0x12:
                case 0x13:
                case 20:
                    itemLBD.SelectedValue = selectedEvolve.GetValue(rowIndex);
                    if (itemLBD.ShowDialog() == DialogResult.OK)
                    {
                        selectedEvolve.SetValue(rowIndex, itemLBD.SelectedValue);
                    }
                    break;

                case 0x15:
                    skilLBD.SelectedValue = selectedEvolve.GetValue(rowIndex);
                    if (skilLBD.ShowDialog() == DialogResult.OK)
                    {
                        selectedEvolve.SetValue(rowIndex, skilLBD.SelectedValue);
                    }
                    break;

                case 0x16:
                    pokeLBD.SelectedValue = selectedEvolve.GetValue(rowIndex);
                    if (pokeLBD.ShowDialog() == DialogResult.OK)
                    {
                        selectedEvolve.SetValue(rowIndex, pokeLBD.SelectedValue);
                    }
                    break;

                default:
                    MessageBox.Show("You cannot change the number scalar for this method of evolution.", "Evolution Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
            }
            ReadEvolveData(selectedValue);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void File_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            if (data.Length > 0)
            {
                OpenFile(data[0]);
            }
        }

        private void File_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private Version GetVersion(byte[] internalName)
        {
            byte[] buffer = new byte[] { 80, 0x4f, 0x4b, 0x45, 0x4d, 0x4f, 0x4e, 0x20, 0x42, 50, 0, 0 };
            bool flag = true;
            for (int i = 0; i < 12; i++)
            {
                if (buffer[i] != internalName[i])
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                return Version.Black;
            }
            byte[] buffer2 = new byte[] { 80, 0x4f, 0x4b, 0x45, 0x4d, 0x4f, 0x4e, 0x20, 0x57, 50, 0, 0 };
            bool flag2 = true;
            for (int j = 0; j < 12; j++)
            {
                if (buffer2[j] != internalName[j])
                {
                    flag2 = false;
                    break;
                }
            }
            if (flag2)
            {
                return Version.White;
            }
            VersionSelectForm form = new VersionSelectForm();
            form.ShowDialog();
            return form.Version;
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            newSaveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolToolStripMenuItem = new ToolStripMenuItem();
            placeToolStripMenuItem = new ToolStripMenuItem();
            skillToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            groupBox4 = new GroupBox();
            searchButton = new Button();
            searchComboBox = new ComboBox();
            searchTextBox = new TextBox();
            listBox1 = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            x28_CLB = new CheckedListBox();
            x21_1_ChB = new CheckBox();
            x21_0_ChB = new CheckBox();
            x21_CoB = new ComboBox();
            label25 = new Label();
            x17_CoB = new ComboBox();
            x16_CoB = new ComboBox();
            label24 = new Label();
            x07_CoB = new ComboBox();
            x06_CoB = new ComboBox();
            label23 = new Label();
            x15_CoB = new ComboBox();
            label22 = new Label();
            x12_CoB = new ComboBox();
            label21 = new Label();
            x1A_BT = new Button();
            x19_BT = new Button();
            x18_BT = new Button();
            label20 = new Label();
            x10_BT = new Button();
            x0E_BT = new Button();
            x0C_BT = new Button();
            label19 = new Label();
            x22_NUD = new NumericUpDown();
            label18 = new Label();
            x1B_NUD = new NumericUpDown();
            label17 = new Label();
            x14_NUD = new NumericUpDown();
            label16 = new Label();
            x13_NUD = new NumericUpDown();
            label15 = new Label();
            x09_NUD = new NumericUpDown();
            label14 = new Label();
            x08_NUD = new NumericUpDown();
            label13 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            x0A_0_NUD = new NumericUpDown();
            label9 = new Label();
            x0A_1_NUD = new NumericUpDown();
            label10 = new Label();
            x0A_2_NUD = new NumericUpDown();
            label11 = new Label();
            x0A_3_NUD = new NumericUpDown();
            label12 = new Label();
            x0B_0_NUD = new NumericUpDown();
            x0B_1_NUD = new NumericUpDown();
            groupBox1 = new GroupBox();
            label1 = new Label();
            x00_NUD = new NumericUpDown();
            label2 = new Label();
            x02_NUD = new NumericUpDown();
            label3 = new Label();
            x01_NUD = new NumericUpDown();
            label4 = new Label();
            x04_NUD = new NumericUpDown();
            label5 = new Label();
            x05_NUD = new NumericUpDown();
            label6 = new Label();
            x03_NUD = new NumericUpDown();
            tabPage2 = new TabPage();
            evoPokemon_BT = new Button();
            evoValue_BT = new Button();
            evoCode_BT = new Button();
            dgv = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            sourceTextBox = new TextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            x22_NUD.BeginInit();
            x1B_NUD.BeginInit();
            x14_NUD.BeginInit();
            x13_NUD.BeginInit();
            x09_NUD.BeginInit();
            x08_NUD.BeginInit();
            groupBox2.SuspendLayout();
            x0A_0_NUD.BeginInit();
            x0A_1_NUD.BeginInit();
            x0A_2_NUD.BeginInit();
            x0A_3_NUD.BeginInit();
            x0B_0_NUD.BeginInit();
            x0B_1_NUD.BeginInit();
            groupBox1.SuspendLayout();
            x00_NUD.BeginInit();
            x02_NUD.BeginInit();
            x01_NUD.BeginInit();
            x04_NUD.BeginInit();
            x05_NUD.BeginInit();
            x03_NUD.BeginInit();
            tabPage2.SuspendLayout();
            ((ISupportInitialize) dgv).BeginInit();
            SuspendLayout();
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(0x31a, 0x1a);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripMenuItem1, saveToolStripMenuItem, newSaveToolStripMenuItem, toolStripMenuItem2, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(0x55, 0x16);
            fileToolStripMenuItem.Text = "File (&F)";
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(0xc2, 0x16);
            openToolStripMenuItem.Text = "Open ROM (&O)";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(0xbf, 6);
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(0xc2, 0x16);
            saveToolStripMenuItem.Text = "Save ROM (&S)";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            newSaveToolStripMenuItem.Enabled = false;
            newSaveToolStripMenuItem.Name = "newSaveToolStripMenuItem";
            newSaveToolStripMenuItem.Size = new Size(0xc2, 0x16);
            newSaveToolStripMenuItem.Text = "Save ROM As (&W)";
            newSaveToolStripMenuItem.Click += newSaveToolStripMenuItem_Click;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(0xbf, 6);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(0xc2, 0x16);
            exitToolStripMenuItem.Text = "Exit Program (&X)";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            toolToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { placeToolStripMenuItem, skillToolStripMenuItem });
            toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            toolToolStripMenuItem.Size = new Size(0x4a, 0x16);
            toolToolStripMenuItem.Text = "Tools (&T)";
            placeToolStripMenuItem.Enabled = false;
            placeToolStripMenuItem.Name = "placeToolStripMenuItem";
            placeToolStripMenuItem.Size = new Size(0x88, 0x16);
            placeToolStripMenuItem.Text = "Encounter Slot Editor";
            placeToolStripMenuItem.Click += placeToolStripMenuItem_Click;
            skillToolStripMenuItem.Enabled = false;
            skillToolStripMenuItem.Name = "skillToolStripMenuItem";
            skillToolStripMenuItem.Size = new Size(0x88, 0x16);
            skillToolStripMenuItem.Text = "Move Editor";
            skillToolStripMenuItem.Click += skillToolStripMenuItem_Click;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 550);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(0x31a, 0x17);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0x28c, 0x12);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel2.ForeColor = SystemColors.Control;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(80, 0x12);
            toolStripStatusLabel2.Text = "READ ONLY";
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(0x2f, 0x12);
            toolStripStatusLabel3.Text = "No ROM Loaded";
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Enabled = false;
            splitContainer1.Location = new Point(0, 0x1a);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Panel1.Controls.Add(groupBox4);
            splitContainer1.Panel1.Controls.Add(listBox1);
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(0x31a, 0x20c);
            splitContainer1.SplitterDistance = 180;
            splitContainer1.TabIndex = 1;
            groupBox4.Controls.Add(searchButton);
            groupBox4.Controls.Add(searchComboBox);
            groupBox4.Controls.Add(searchTextBox);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(0, 0x1bd);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(180, 0x4f);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filter";
            searchButton.Location = new Point(6, 0x2c);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(0xa8, 0x17);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            searchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "Begins with", "Includes", "Ends with" });
            searchComboBox.Location = new Point(0x63, 0x12);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(0x4b, 20);
            searchComboBox.TabIndex = 1;
            searchTextBox.Location = new Point(6, 0x12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(0x57, 0x13);
            searchTextBox.TabIndex = 0;
            listBox1.Dock = DockStyle.Top;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 12;
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 0x1b4);
            listBox1.TabIndex = 0;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(610, 0x20c);
            tabControl1.TabIndex = 0;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(x28_CLB);
            tabPage1.Controls.Add(x21_1_ChB);
            tabPage1.Controls.Add(x21_0_ChB);
            tabPage1.Controls.Add(x21_CoB);
            tabPage1.Controls.Add(label25);
            tabPage1.Controls.Add(x17_CoB);
            tabPage1.Controls.Add(x16_CoB);
            tabPage1.Controls.Add(label24);
            tabPage1.Controls.Add(x07_CoB);
            tabPage1.Controls.Add(x06_CoB);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(x15_CoB);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(x12_CoB);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(x1A_BT);
            tabPage1.Controls.Add(x19_BT);
            tabPage1.Controls.Add(x18_BT);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(x10_BT);
            tabPage1.Controls.Add(x0E_BT);
            tabPage1.Controls.Add(x0C_BT);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(x22_NUD);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(x1B_NUD);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(x14_NUD);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(x13_NUD);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(x09_NUD);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(x08_NUD);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 0x16);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(0x25a, 0x1f2);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Species Data";
            tabPage1.UseVisualStyleBackColor = true;
            button2.Location = new Point(0x209, 0x1d0);
            button2.Name = "button2";
            button2.Size = new Size(0x4b, 0x17);
            button2.TabIndex = 0x48;
            button2.Text = "No TMs";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button1.Location = new Point(440, 0x1d0);
            button1.Name = "button1";
            button1.Size = new Size(0x4b, 0x17);
            button1.TabIndex = 0x47;
            button1.Text = "All TMs";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            groupBox3.Controls.Add(sourceTextBox);
            groupBox3.Location = new Point(6, 0x173);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(0x17f, 0x79);
            groupBox3.TabIndex = 70;
            groupBox3.TabStop = false;
            groupBox3.Text = "Raw Hex";
            x28_CLB.FormattingEnabled = true;
            x28_CLB.Items.AddRange(new object[] { 
                "TM01 Hone Claws", "TM02 Dragon Claw", "TM03 Psyshock", "TM04 Calm Mind", "TM05 Roar", "TM06 Toxic", "TM07 Hail", "TM08 Bulk Up", "TM09 Venoshock", "TM10 Hidden Power", "TM11 Sunny Day", "TM12 Taunt", "TM13 Ice Beam", "TM14 Blizzard", "TM15 Hyper Beam", "TM16 Light Screen", 
                "TM17 Protect", "TM18 Rain Dance", "TM19 Telekinesis", "TM20 Safeguard", "TM21 Frustration", "TM22 SolarBeam", "TM23 Smack Down", "TM24 Thunderbolt", "TM25 Thunder", "TM26 Earthquake", "TM27 Return", "TM28 Dig", "TM29 Psychic", "TM30 Shadow Ball", "TM31 Brick Break", "TM32 Double Team", 
                "TM33 Reflect", "TM34 Sludge Wave", "TM35 Flamethrower", "TM36 Sludge Bomb", "TM37 Sandstorm", "TM38 Fire Blast", "TM39 Rock Tomb", "TM40 Aerial Ace", "TM41 Torment", "TM42 Facade", "TM43 Flame Charge", "TM44 Rest", "TM45 Attract", "TM46 Thief", "TM47 Low Sweep", "TM48 Round", 
                "TM49 Echoed Voice", "TM50 Overheat", "TM51 Ally Switch", "TM52 Focus Blast", "TM53 Energy Ball", "TM54 False Swipe", "TM55 Scald", "TM56 Fling", "TM57 Charge Beam", "TM58 Sky Drop", "TM59 Incinerate", "TM60 Quash", "TM61 Will-O-Wisp", "TM62 Acrobatics", "TM63 Embargo", "TM64 Explosion", 
                "TM65 Shadow Claw", "TM66 Payback", "TM67 Retaliate", "TM68 Giga Impact", "TM69 Rock Polish", "TM70 Flash", "TM71 Stone Edge", "TM72 Volt Switch", "TM73 Thunder Wave", "TM74 Gyro Ball", "TM75 Swords Danceい", "TM76 Struggle Bug", "TM77 Psych Up", "TM78 Bulldoze", "TM79 Frost Breath", "TM80 Rock Slide", 
                "TM81 X-Scissor", "TM82 Dragon Tail", "TM83 Work Up", "TM84 Poison Jab", "TM85 Dream Eater", "TM86 Grass Knot", "TM87 Swagger", "TM88 Pluck", "TM89 U-Turn", "TM90 Substitute", "TM91 Flash Cannon", "TM92 Trick Room", "TM93 Wild Charge", "TM94 Rock Smash", "TM95 Snarl", "HM01 Cut", 
                "HM02 Fly", "HM03 Surf", "HM04 Strength", "HM05 Waterfall", "HM06 Dive"
             });
            x28_CLB.Location = new Point(0x18b, 6);
            x28_CLB.Name = "x28_CLB";
            x28_CLB.Size = new Size(0xc9, 0x1c4);
            x28_CLB.TabIndex = 0x45;
            x21_1_ChB.AutoSize = true;
            x21_1_ChB.Location = new Point(0x11b, 0x15b);
            x21_1_ChB.Name = "x21_1_ChB";
            x21_1_ChB.Size = new Size(0x24, 0x10);
            x21_1_ChB.TabIndex = 0x23;
            x21_1_ChB.Text = "Multitype: Arceus";
            x21_1_ChB.UseVisualStyleBackColor = true;
            x21_0_ChB.AutoSize = true;
            x21_0_ChB.Location = new Point(0xcc, 0x15b);
            x21_0_ChB.Name = "x21_0_ChB";
            x21_0_ChB.Size = new Size(0x54, 0x10);
            x21_0_ChB.TabIndex = 0x22;
            x21_0_ChB.Text = "Asymmetric";
            x21_0_ChB.UseVisualStyleBackColor = true;
            x21_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x21_CoB.FormattingEnabled = true;
            x21_CoB.Location = new Point(0x4d, 0x159);
            x21_CoB.Name = "x21_CoB";
            x21_CoB.Size = new Size(0x79, 20);
            x21_CoB.TabIndex = 0x21;
            label25.AutoSize = true;
            label25.Location = new Point(12, 0x15c);
            label25.Name = "label25";
            label25.Size = new Size(0x26, 12);
            label25.TabIndex = 0x20;
            label25.Text = "Color";
            x17_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x17_CoB.FormattingEnabled = true;
            x17_CoB.Location = new Point(0xcc, 0x13f);
            x17_CoB.Name = "x17_CoB";
            x17_CoB.Size = new Size(0x79, 20);
            x17_CoB.TabIndex = 0x1f;
            x16_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x16_CoB.FormattingEnabled = true;
            x16_CoB.Location = new Point(0x4d, 0x13f);
            x16_CoB.Name = "x16_CoB";
            x16_CoB.Size = new Size(0x79, 20);
            x16_CoB.TabIndex = 30;
            label24.AutoSize = true;
            label24.Location = new Point(12, 0x142);
            label24.Name = "label24";
            label24.Size = new Size(0x2b, 12);
            label24.TabIndex = 0x1d;
            label24.Text = "Egg Group";
            x07_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x07_CoB.FormattingEnabled = true;
            x07_CoB.Location = new Point(0xcc, 0x125);
            x07_CoB.Name = "x07_CoB";
            x07_CoB.Size = new Size(0x79, 20);
            x07_CoB.TabIndex = 0x1c;
            x06_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x06_CoB.FormattingEnabled = true;
            x06_CoB.Location = new Point(0x4d, 0x125);
            x06_CoB.Name = "x06_CoB";
            x06_CoB.Size = new Size(0x79, 20);
            x06_CoB.TabIndex = 0x1b;
            label23.AutoSize = true;
            label23.Location = new Point(12, 0x128);
            label23.Name = "label23";
            label23.Size = new Size(0x1f, 12);
            label23.TabIndex = 0x1a;
            label23.Text = "Type";
            x15_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x15_CoB.FormattingEnabled = true;
            x15_CoB.Location = new Point(0x58, 0x10b);
            x15_CoB.Name = "x15_CoB";
            x15_CoB.Size = new Size(0xA8, 20);
            x15_CoB.TabIndex = 0x19;
            label22.AutoSize = true;
            label22.Location = new Point(12, 270);
            label22.Name = "label22";
            label22.Size = new Size(0x3b, 12);
            label22.TabIndex = 0x18;
            label22.Text = "EXP Growth";
            x12_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x12_CoB.FormattingEnabled = true;
            x12_CoB.Location = new Point(0x58, 0xf1);
            x12_CoB.Name = "x12_CoB";
            x12_CoB.Size = new Size(0xA8, 20);
            x12_CoB.TabIndex = 0x17;
            label21.AutoSize = true;
            label21.Location = new Point(12, 0xf4);
            label21.Name = "label21";
            label21.Size = new Size(0x2c, 12);
            label21.TabIndex = 0x16;
            label21.Text = "Gender Ratio";
            x1A_BT.Location = new Point(0x121, 0xd4);
            x1A_BT.Name = "x1A_BT";
            x1A_BT.Size = new Size(100, 0x17);
            x1A_BT.TabIndex = 0x15;
            x1A_BT.Text = "-";
            x1A_BT.UseVisualStyleBackColor = true;
            x1A_BT.Click += x1A_BT_Click;
            x19_BT.Location = new Point(0xb7, 0xd3);
            x19_BT.Name = "x19_BT";
            x19_BT.Size = new Size(100, 0x17);
            x19_BT.TabIndex = 20;
            x19_BT.Text = "-";
            x19_BT.UseVisualStyleBackColor = true;
            x19_BT.Click += x19_BT_Click;
            x18_BT.Location = new Point(0x4d, 0xd4);
            x18_BT.Name = "x18_BT";
            x18_BT.Size = new Size(100, 0x17);
            x18_BT.TabIndex = 0x13;
            x18_BT.Text = "-";
            x18_BT.UseVisualStyleBackColor = true;
            x18_BT.Click += x18_BT_Click;
            label20.AutoSize = true;
            label20.Location = new Point(12, 0xd9);
            label20.Name = "label20";
            label20.Size = new Size(0x27, 12);
            label20.TabIndex = 0x12;
            label20.Text = "Ability";
            x10_BT.Location = new Point(0x121, 0xb7);
            x10_BT.Name = "x10_BT";
            x10_BT.Size = new Size(100, 0x17);
            x10_BT.TabIndex = 0x11;
            x10_BT.Text = "-";
            x10_BT.UseVisualStyleBackColor = true;
            x10_BT.Click += x10_BT_Click;
            x0E_BT.Location = new Point(0xb7, 0xb7);
            x0E_BT.Name = "x0E_BT";
            x0E_BT.Size = new Size(100, 0x17);
            x0E_BT.TabIndex = 0x10;
            x0E_BT.Text = "-";
            x0E_BT.UseVisualStyleBackColor = true;
            x0E_BT.Click += x0E_BT_Click;
            x0C_BT.Location = new Point(0x4d, 0xb7);
            x0C_BT.Name = "x0C_BT";
            x0C_BT.Size = new Size(100, 0x17);
            x0C_BT.TabIndex = 15;
            x0C_BT.Text = "-";
            x0C_BT.UseVisualStyleBackColor = true;
            x0C_BT.Click += x0C_BT_Click;
            label19.AutoSize = true;
            label19.Location = new Point(12, 0xbc);
            label19.Name = "label19";
            label19.Size = new Size(0x2a, 12);
            label19.TabIndex = 14;
            label19.Text = "Held Item";
            x22_NUD.Location = new Point(0x138, 0x95);
            int[] bits = new int[4];
            bits[0] = 0xffff;
            x22_NUD.Maximum = new decimal(bits);
            x22_NUD.Name = "x22_NUD";
            x22_NUD.Size = new Size(60, 0x13);
            x22_NUD.TabIndex = 13;
            label18.AutoSize = true;
            label18.Location = new Point(0xe2, 0x97);
            label18.Name = "label18";
            label18.Size = new Size(0x41, 12);
            label18.TabIndex = 12;
            label18.Text = "Base EXP";
            x1B_NUD.Location = new Point(0x138, 0x7c);
            int[] numArray2 = new int[4];
            numArray2[0] = 0xff;
            x1B_NUD.Maximum = new decimal(numArray2);
            x1B_NUD.Name = "x1B_NUD";
            x1B_NUD.Size = new Size(40, 0x13);
            x1B_NUD.TabIndex = 11;
            label17.AutoSize = true;
            label17.Location = new Point(0xe2, 0x7e);
            label17.Name = "label17";
            label17.Size = new Size(0x29, 12);
            label17.TabIndex = 10;
            label17.Text = "Escape Rate";
            x14_NUD.Location = new Point(0x138, 0x63);
            int[] numArray3 = new int[4];
            numArray3[0] = 0xff;
            x14_NUD.Maximum = new decimal(numArray3);
            x14_NUD.Name = "x14_NUD";
            x14_NUD.Size = new Size(40, 0x13);
            x14_NUD.TabIndex = 9;
            label16.AutoSize = true;
            label16.Location = new Point(0xe2, 0x65);
            label16.Name = "label16";
            label16.Size = new Size(0x45, 12);
            label16.TabIndex = 8;
            label16.Text = "Base Happiness";
            x13_NUD.Location = new Point(0x138, 0x4a);
            int[] numArray4 = new int[4];
            numArray4[0] = 0xff;
            x13_NUD.Maximum = new decimal(numArray4);
            x13_NUD.Name = "x13_NUD";
            x13_NUD.Size = new Size(40, 0x13);
            x13_NUD.TabIndex = 7;
            label15.AutoSize = true;
            label15.Location = new Point(0xe2, 0x4c);
            label15.Name = "label15";
            label15.Size = new Size(0x33, 12);
            label15.TabIndex = 6;
            label15.Text = "Hatch Counter";
            x09_NUD.Location = new Point(0x138, 0x31);
            int[] numArray5 = new int[4];
            numArray5[0] = 0xff;
            x09_NUD.Maximum = new decimal(numArray5);
            x09_NUD.Name = "x09_NUD";
            x09_NUD.Size = new Size(40, 0x13);
            x09_NUD.TabIndex = 5;
            label14.AutoSize = true;
            label14.Location = new Point(0xe2, 0x33);
            label14.Name = "label14";
            label14.Size = new Size(0x35, 12);
            label14.TabIndex = 4;
            label14.Text = "Evo Stage";
            x08_NUD.Location = new Point(0x138, 0x18);
            int[] numArray6 = new int[4];
            numArray6[0] = 0xff;
            x08_NUD.Maximum = new decimal(numArray6);
            x08_NUD.Name = "x08_NUD";
            x08_NUD.Size = new Size(40, 0x13);
            x08_NUD.TabIndex = 3;
            label13.AutoSize = true;
            label13.Location = new Point(0xe2, 0x1a);
            label13.Name = "label13";
            label13.Size = new Size(0x35, 12);
            label13.TabIndex = 2;
            label13.Text = "Catch Rate";
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(x0A_0_NUD);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(x0A_1_NUD);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(x0A_2_NUD);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(x0A_3_NUD);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(x0B_0_NUD);
            groupBox2.Controls.Add(x0B_1_NUD);
            groupBox2.Location = new Point(0x74, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(0x68, 0xab);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "EVs Given";
            label7.AutoSize = true;
            label7.Location = new Point(6, 20);
            label7.Name = "label7";
            label7.Size = new Size(0x17, 12);
            label7.TabIndex = 0;
            label7.Text = "HP";
            label8.AutoSize = true;
            label8.Location = new Point(6, 0x2d);
            label8.Name = "label8";
            label8.Size = new Size(0x27, 12);
            label8.TabIndex = 2;
            label8.Text = "Atk";
            x0A_0_NUD.Location = new Point(0x37, 0x12);
            int[] numArray7 = new int[4];
            numArray7[0] = 3;
            x0A_0_NUD.Maximum = new decimal(numArray7);
            x0A_0_NUD.Name = "x0A_0_NUD";
            x0A_0_NUD.Size = new Size(40, 0x13);
            x0A_0_NUD.TabIndex = 1;
            label9.AutoSize = true;
            label9.Location = new Point(6, 70);
            label9.Name = "label9";
            label9.Size = new Size(0x27, 12);
            label9.TabIndex = 4;
            label9.Text = "Def";
            x0A_1_NUD.Location = new Point(0x37, 0x2b);
            int[] numArray8 = new int[4];
            numArray8[0] = 3;
            x0A_1_NUD.Maximum = new decimal(numArray8);
            x0A_1_NUD.Name = "x0A_1_NUD";
            x0A_1_NUD.Size = new Size(40, 0x13);
            x0A_1_NUD.TabIndex = 3;
            label10.AutoSize = true;
            label10.Location = new Point(6, 0x5f);
            label10.Name = "label10";
            label10.Size = new Size(0x22, 12);
            label10.TabIndex = 6;
            label10.Text = "SpA";
            x0A_2_NUD.Location = new Point(0x37, 0x44);
            int[] numArray9 = new int[4];
            numArray9[0] = 3;
            x0A_2_NUD.Maximum = new decimal(numArray9);
            x0A_2_NUD.Name = "x0A_2_NUD";
            x0A_2_NUD.Size = new Size(40, 0x13);
            x0A_2_NUD.TabIndex = 5;
            label11.AutoSize = true;
            label11.Location = new Point(6, 120);
            label11.Name = "label11";
            label11.Size = new Size(0x24, 12);
            label11.TabIndex = 8;
            label11.Text = "SpD";
            x0A_3_NUD.Location = new Point(0x37, 0x5d);
            int[] numArray10 = new int[4];
            numArray10[0] = 3;
            x0A_3_NUD.Maximum = new decimal(numArray10);
            x0A_3_NUD.Name = "x0A_3_NUD";
            x0A_3_NUD.Size = new Size(40, 0x13);
            x0A_3_NUD.TabIndex = 7;
            label12.AutoSize = true;
            label12.Location = new Point(6, 0x91);
            label12.Name = "label12";
            label12.Size = new Size(0x2b, 12);
            label12.TabIndex = 10;
            label12.Text = "Speed";
            x0B_0_NUD.Location = new Point(0x37, 0x76);
            int[] numArray11 = new int[4];
            numArray11[0] = 3;
            x0B_0_NUD.Maximum = new decimal(numArray11);
            x0B_0_NUD.Name = "x0B_0_NUD";
            x0B_0_NUD.Size = new Size(40, 0x13);
            x0B_0_NUD.TabIndex = 9;
            x0B_1_NUD.Location = new Point(0x37, 0x8f);
            int[] numArray12 = new int[4];
            numArray12[0] = 3;
            x0B_1_NUD.Maximum = new decimal(numArray12);
            x0B_1_NUD.Name = "x0B_1_NUD";
            x0B_1_NUD.Size = new Size(40, 0x13);
            x0B_1_NUD.TabIndex = 11;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(x00_NUD);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(x02_NUD);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(x01_NUD);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(x04_NUD);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(x05_NUD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(x03_NUD);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(0x68, 0xab);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Base Stats";
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(0x17, 12);
            label1.TabIndex = 0;
            label1.Text = "HP";
            x00_NUD.Location = new Point(0x37, 0x12);
            int[] numArray13 = new int[4];
            numArray13[0] = 0xff;
            x00_NUD.Maximum = new decimal(numArray13);
            x00_NUD.Name = "x00_NUD";
            x00_NUD.Size = new Size(40, 0x13);
            x00_NUD.TabIndex = 1;
            label2.AutoSize = true;
            label2.Location = new Point(6, 0x2d);
            label2.Name = "label2";
            label2.Size = new Size(0x27, 12);
            label2.TabIndex = 2;
            label2.Text = "Atk";
            x02_NUD.Location = new Point(0x37, 0x44);
            int[] numArray14 = new int[4];
            numArray14[0] = 0xff;
            x02_NUD.Maximum = new decimal(numArray14);
            x02_NUD.Name = "x02_NUD";
            x02_NUD.Size = new Size(40, 0x13);
            x02_NUD.TabIndex = 5;
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(0x27, 12);
            label3.TabIndex = 4;
            label3.Text = "Def";
            x01_NUD.Location = new Point(0x37, 0x2b);
            int[] numArray15 = new int[4];
            numArray15[0] = 0xff;
            x01_NUD.Maximum = new decimal(numArray15);
            x01_NUD.Name = "x01_NUD";
            x01_NUD.Size = new Size(40, 0x13);
            x01_NUD.TabIndex = 3;
            label4.AutoSize = true;
            label4.Location = new Point(6, 0x5f);
            label4.Name = "label4";
            label4.Size = new Size(0x22, 12);
            label4.TabIndex = 6;
            label4.Text = "SpA";
            x04_NUD.Location = new Point(0x37, 0x5d);
            int[] numArray16 = new int[4];
            numArray16[0] = 0xff;
            x04_NUD.Maximum = new decimal(numArray16);
            x04_NUD.Name = "x04_NUD";
            x04_NUD.Size = new Size(40, 0x13);
            x04_NUD.TabIndex = 7;
            label5.AutoSize = true;
            label5.Location = new Point(6, 120);
            label5.Name = "label5";
            label5.Size = new Size(0x24, 12);
            label5.TabIndex = 8;
            label5.Text = "SpD";
            x05_NUD.Location = new Point(0x37, 0x76);
            int[] numArray17 = new int[4];
            numArray17[0] = 0xff;
            x05_NUD.Maximum = new decimal(numArray17);
            x05_NUD.Name = "x05_NUD";
            x05_NUD.Size = new Size(40, 0x13);
            x05_NUD.TabIndex = 9;
            label6.AutoSize = true;
            label6.Location = new Point(6, 0x91);
            label6.Name = "label6";
            label6.Size = new Size(0x2b, 12);
            label6.TabIndex = 10;
            label6.Text = "Speed";
            x03_NUD.Location = new Point(0x37, 0x8f);
            int[] numArray18 = new int[4];
            numArray18[0] = 0xff;
            x03_NUD.Maximum = new decimal(numArray18);
            x03_NUD.Name = "x03_NUD";
            x03_NUD.Size = new Size(40, 0x13);
            x03_NUD.TabIndex = 11;
            tabPage2.Controls.Add(evoPokemon_BT);
            tabPage2.Controls.Add(evoValue_BT);
            tabPage2.Controls.Add(evoCode_BT);
            tabPage2.Controls.Add(dgv);
            tabPage2.Location = new Point(4, 0x16);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(0x25a, 0x1f2);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Evolution Editor";
            tabPage2.UseVisualStyleBackColor = true;
            evoPokemon_BT.Location = new Point(0x1f8, 0xae);
            evoPokemon_BT.Name = "evoPokemon_BT";
            evoPokemon_BT.Size = new Size(90, 0x17);
            evoPokemon_BT.TabIndex = 3;
            evoPokemon_BT.Text = "To Pokemon";
            evoPokemon_BT.UseVisualStyleBackColor = true;
            evoPokemon_BT.Click += evoPokemon_BT_Click;
            evoValue_BT.Location = new Point(0x198, 0xae);
            evoValue_BT.Name = "evoValue_BT";
            evoValue_BT.Size = new Size(90, 0x17);
            evoValue_BT.TabIndex = 2;
            evoValue_BT.Text = "Condition";
            evoValue_BT.UseVisualStyleBackColor = true;
            evoValue_BT.Click += evoValue_BT_Click;
            evoCode_BT.Location = new Point(0x138, 0xae);
            evoCode_BT.Name = "evoCode_BT";
            evoCode_BT.Size = new Size(90, 0x17);
            evoCode_BT.TabIndex = 1;
            evoCode_BT.Text = "Method";
            evoCode_BT.UseVisualStyleBackColor = true;
            evoCode_BT.Click += evoCode_BT_Click;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(Column1, Column2);
            dgv.Dock = DockStyle.Top;
            dgv.Location = new Point(0, 0);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 0x15;
            dgv.ScrollBars = ScrollBars.None;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(0x25a, 0xa8);
            dgv.TabIndex = 0;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Evolution Data";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            sourceTextBox.Dock = DockStyle.Fill;
            sourceTextBox.Font = new Font("ＭＳ ゴシック", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0x80);
            sourceTextBox.Location = new Point(3, 15);
            sourceTextBox.Multiline = true;
            sourceTextBox.Name = "sourceTextBox";
            sourceTextBox.ReadOnly = true;
            sourceTextBox.Size = new Size(0x179, 0x67);
            sourceTextBox.TabIndex = 0;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(6f, 12f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(0x31a, 0x23d);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Pokemon ROM Changer for B2/W2 (U) - v1.02";
            DragDrop += File_DragDrop;
            DragEnter += File_DragEnter;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            x22_NUD.EndInit();
            x1B_NUD.EndInit();
            x14_NUD.EndInit();
            x13_NUD.EndInit();
            x09_NUD.EndInit();
            x08_NUD.EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            x0A_0_NUD.EndInit();
            x0A_1_NUD.EndInit();
            x0A_2_NUD.EndInit();
            x0A_3_NUD.EndInit();
            x0B_0_NUD.EndInit();
            x0B_1_NUD.EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            x00_NUD.EndInit();
            x02_NUD.EndInit();
            x01_NUD.EndInit();
            x04_NUD.EndInit();
            x05_NUD.EndInit();
            x03_NUD.EndInit();
            tabPage2.ResumeLayout(false);
            ((ISupportInitialize) dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void InputFile(FileStream fs)
        {
            fs.Seek(0L, SeekOrigin.Begin);
            byte[] buffer = new byte[12];
            fs.Read(buffer, 0, 12);
            switch (GetVersion(buffer))
            {
                case Version.Black:
                    toolStripStatusLabel3.Text = "BLACK2";
                    break;

                case Version.White:
                    toolStripStatusLabel3.Text = "WHITE2";
                    break;
            }
            skill = new SkillData[Program.SkillList.Count];
            switch (toolStripStatusLabel3.Text)
            {
                case "BLACK2":
                    fs.Seek(SKILL_B2, SeekOrigin.Begin);
                    break;
                case "WHITE2":
                    fs.Seek(SKILL_W2, SeekOrigin.Begin);
                    break;
            }
            for (int i = 0; i < skill.Length; i++)
            {
                skill[i] = new SkillData();
                fs.Read(skill[i].Data, 0, 0x24);
            }
            place = new PlaceData[Program.PlaceList.Count];
            switch (toolStripStatusLabel3.Text)
            {
                case "BLACK2":
                    fs.Seek(PLACE_B2, SeekOrigin.Begin);
                    break;
                case "WHITE2":
                    fs.Seek(PLACE_W2, SeekOrigin.Begin);
                    break;
            }
            for (int j = 0; j < place.Length; j++)
            {
                place[j] = new PlaceData();
                fs.Read(place[j].Data, 0, 0xe8);
            }
            poke = new PokemonData[Program.PokeList.Count + 1];
            switch (toolStripStatusLabel3.Text)
            {
                case "BLACK2":
                    fs.Seek(FAMILY_B2, SeekOrigin.Begin);
                    break;
                case "WHITE2":
                    fs.Seek(FAMILY_W2, SeekOrigin.Begin);
                    break;
            }
            for (int k = 0; k < poke.Length; k++)
            {
                poke[k] = new PokemonData();
                fs.Read(poke[k].Data, 0, 0x4c);
            }
            evolve = new EvolveData[Program.PokeList.Count + 1];
            switch (toolStripStatusLabel3.Text)
            {
                case "BLACK2":
                    fs.Seek(EVOLVE_B2, SeekOrigin.Begin);
                    break;
                case "WHITE2":
                    fs.Seek(EVOLVE_W2, SeekOrigin.Begin);
                    break;
            }
            for (int m = 0; m < evolve.Length; m++)
            {
                evolve[m] = new EvolveData();
                fs.Read(evolve[m].Data, 0, 0x2c);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                listBox1.SelectedIndex = 0;
            }
            else if (listBox1.SelectedIndex >= listBox1.Items.Count)
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            WriteData(selectedValue);
            ReadData((int) listBox1.SelectedValue);
            selectedValue = (int) listBox1.SelectedValue;
        }

        private void newSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void OpenFile(string fileName)
        {
            Cursor = Cursors.WaitCursor;
            splitContainer1.Enabled = false;
            toolStripStatusLabel1.Text = fileName;
            FileInfo info = new FileInfo(fileName);
            saveToolStripMenuItem.Enabled = !info.IsReadOnly;
            newSaveToolStripMenuItem.Enabled = false;
            placeToolStripMenuItem.Enabled = true;
            skillToolStripMenuItem.Enabled = true;
            toolStripStatusLabel2.ForeColor = info.IsReadOnly ? Color.FromKnownColor(KnownColor.ControlText) : BackColor;
            InputFile(info.OpenRead());
            ReadData(selectedValue);
            splitContainer1.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog1.FileName);
            }
        }

        private void OutputData(string filename)
        {
            using (FileStream stream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite))
            {
                if (toolStripStatusLabel3.Text == "BLACK2")
                {
                    stream.Seek(SKILL_B2, SeekOrigin.Begin);
                }
                else if (toolStripStatusLabel3.Text == "WHITE2")
                {
                    stream.Seek(SKILL_W2, SeekOrigin.Begin);
                }
                for (int i = 0; i < skill.Length; i++)
                {
                    stream.Write(skill[i].Data, 0, 0x24);
                }
                stream.Flush();
                if (toolStripStatusLabel3.Text == "BLACK2")
                {
                    stream.Seek(PLACE_B2, SeekOrigin.Begin);
                }
                else if (toolStripStatusLabel3.Text == "WHITE2")
                {
                    stream.Seek(PLACE_W2, SeekOrigin.Begin);
                }
                for (int j = 0; j < place.Length; j++)
                {
                    stream.Write(place[j].Data, 0, 0xe8);
                }
                stream.Flush();
                if (toolStripStatusLabel3.Text == "BLACK2")
                {
                    stream.Seek(FAMILY_B2, SeekOrigin.Begin);
                }
                else if (toolStripStatusLabel3.Text == "WHITE2")
                {
                    stream.Seek(FAMILY_W2, SeekOrigin.Begin);
                }
                for (int k = 0; k < poke.Length; k++)
                {
                    stream.Write(poke[k].Data, 0, 0x4c);
                }
                stream.Flush();
                if (toolStripStatusLabel3.Text == "BLACK2")
                {
                    stream.Seek(EVOLVE_B2, SeekOrigin.Begin);
                }
                else if (toolStripStatusLabel3.Text == "WHITE2")
                {
                    stream.Seek(EVOLVE_W2, SeekOrigin.Begin);
                }
                for (int m = 0; m < evolve.Length; m++)
                {
                    stream.Write(evolve[m].Data, 0, 0x2c);
                }
                stream.Flush();
                stream.Close();
            }
        }

        private void placeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceForm form = new PlaceForm(place);
            if (form.ShowDialog() == DialogResult.OK)
            {
                place = form.Place;
            }
        }

        private void ReadData(int index)
        {
            x00_NUD.Value = poke[index].FamilyHp;
            x01_NUD.Value = poke[index].FamilyAtk;
            x02_NUD.Value = poke[index].FamilyDef;
            x03_NUD.Value = poke[index].FamilySpd;
            x04_NUD.Value = poke[index].FamilySatk;
            x05_NUD.Value = poke[index].FamilySdef;
            x06_CoB.SelectedValue = poke[index].Type1;
            x07_CoB.SelectedValue = poke[index].Type2;
            x08_NUD.Value = poke[index].Capture;
            x09_NUD.Value = poke[index].Rank;
            x0A_0_NUD.Value = poke[index].EffortHp;
            x0A_1_NUD.Value = poke[index].EffortAtk;
            x0A_2_NUD.Value = poke[index].EffortDef;
            x0A_3_NUD.Value = poke[index].EffortSpd;
            x0B_0_NUD.Value = poke[index].EffortSatk;
            x0B_1_NUD.Value = poke[index].EffortSdef;
            item[0] = poke[index].Item1;
            x0C_BT.Text = Program.ItemList.SearchByValue(item[0]);
            item[1] = poke[index].Item2;
            x0E_BT.Text = Program.ItemList.SearchByValue(item[1]);
            item[2] = poke[index].Item3;
            x10_BT.Text = Program.ItemList.SearchByValue(item[2]);
            x12_CoB.SelectedValue = poke[index].Sex;
            x13_NUD.Value = poke[index].EggStep;
            x14_NUD.Value = poke[index].Feel;
            x15_CoB.SelectedValue = poke[index].ExpType;
            x16_CoB.SelectedValue = poke[index].Group1;
            x17_CoB.SelectedValue = poke[index].Group2;
            spec[0] = poke[index].Specific1;
            x18_BT.Text = Program.SpecList.SearchByValue(spec[0]);
            spec[1] = poke[index].Specific2;
            x19_BT.Text = Program.SpecList.SearchByValue(spec[1]);
            spec[2] = poke[index].Specific3;
            x1A_BT.Text = Program.SpecList.SearchByValue(spec[2]);
            x21_0_ChB.Checked = (poke[index].Look & 0x40) == 0x40;
            x21_1_ChB.Checked = (poke[index].Look & 0x80) == 0x80;
            x21_CoB.SelectedValue = poke[index].Look & 0x3f;
            x22_NUD.Value = poke[index].BaseExp;
            for (int i = 0; i < x28_CLB.Items.Count; i++)
            {
                x28_CLB.SetItemChecked(i, poke[index].IsMachineUsable(i));
            }
            ReadSourceData(index);
            selectedEvolve = new EvolveData();
            for (int j = 0; j < 0x2c; j++)
            {
                selectedEvolve.Data[j] = evolve[index].Data[j];
            }
            ReadEvolveData(index);
        }

        private void ReadEvolveData(int index)
        {
            for (int i = 0; i < 7; i++)
            {
                int code = selectedEvolve.GetCode(i);
                int num3 = selectedEvolve.GetValue(i);
                string str = Program.PokeList.SearchByValue(selectedEvolve.GetPokemon(i));
                switch (code)
                {
                    case 1:
                        dgv[1, i].Value =  "Evolves into " + str + " after leveling up with 220 or more Happiness.";
                        break;

                    case 2:
                        dgv[1, i].Value = "Evolves into " + str + " after leveling up in the Day/Morning with 220 or more Happiness.";
                        break;

                    case 3:
                        dgv[1, i].Value = "Evolves into " + str + " after leveling up at Night with 220 or more Happiness.";
                        break;

                    case 4:
                        dgv[1, i].Value = string.Concat(new object[] { "Evolves into " + str + " at level ", num3, " or greater."});
                        break;

                    case 5:
                        dgv[1, i].Value = "Evolves into " + str + " after being traded.";
                        break;

                    case 6:
                        dgv[1, i].Value = "Evolves into " + str + " after being traded while holding " + Program.ItemList.SearchByValue(num3) +".";
                        break;

                    case 7:
                        dgv[1, i].Value = "Evolves into " + str + " after being traded for opposite Shelmet/Karrablast";
                        break;

                    case 8:
                        dgv[1, i].Value = "Evolves into " + str + " after using " + Program.ItemList.SearchByValue(num3) + " on this Pokémon.";
                        break;

                    case 9:
                        dgv[1, i].Value = string.Concat("Evolves into ", str, "at level ", num3, " when its Attack Stat is higher than its Defense stat.");
                        break;

                    case 10:
                        dgv[1, i].Value = string.Concat("Evolves into ", str, "at level ", num3, " when its Attack Stat is equal to its Defense stat.");
                        break;

                    case 11:
                        dgv[1, i].Value = string.Concat("Evolves into ", str, "at level ", num3, " when its Attack Stat is less than its Defense stat.");
                        break;

                    case 12:
                        dgv[1, i].Value = string.Concat("Evolves into ", str, "at level ", num3, " if the upper half of the PID % 0xA is less than 5.");
                        break;

                    case 13:
                        dgv[1, i].Value = string.Concat("Evolves into ", str, "at level ", num3, " if the upper half of the PID % 0xA is greater than or equal to 5.");
                        break;

                    case 14:
                        dgv[1, i].Value = string.Concat("Evolves into ", str, " at level ", num3, " and attepts to add another party member (Ninjask).");
                        break;

                    case 15:
                        dgv[1, i].Value = string.Concat("A ", str, " is added to the party (of the same level) if this Pokémon is evolved at or above level ", num3, ".");
                        break;

                    case 0x10:
                        dgv[1, i].Value = string.Concat("Evolves into ", str, " after leveling up with a beauty stat at or above ", num3, ".");
                        break;

                    case 0x11:
                        dgv[1, i].Value = "Evolves into " + str + " if Male and a "+ Program.ItemList.SearchByValue(num3)+ " is used.";
                        break;

                    case 0x12:
                        dgv[1, i].Value = "Evolves into " + str + " if Female and a "+ Program.ItemList.SearchByValue(num3)+ " is used.";
                        break;

                    case 0x13:
                        dgv[1, i].Value = "Evolves into " + str + " DURING THE DAY after leveling up with " + Program.ItemList.SearchByValue(num3) + " as the current held item.";
                        break;

                    case 20:
                        dgv[1, i].Value = "Evolves into " + str + " AT NIGHT after leveling up with " + Program.ItemList.SearchByValue(num3) + " as the current held item.";
                        break;

                    case 0x15:
                        dgv[1, i].Value = "Evolves into " + str + " after leveling up with " + Program.SkillList.SearchByValue(num3) + " as a currently known move.";
                        break;

                    case 0x16:
                        dgv[1, i].Value = "Evolves into " + str + " after leveling up with " + Program.PokeList.SearchByValue(num3) + "in your party.";
                        break;

                    case 0x17:
                        dgv[1, i].Value = string.Concat(new object[] { "Evolves into " + str + " by evolving Male of this species at or above level ", num3 });
                        break;

                    case 0x18:
                        dgv[1, i].Value = string.Concat(new object[] { "Evolves into " + str + " by evolving Female of this species at or above level ", num3});
                        break;

                    case 0x19:
                        dgv[1, i].Value = "Evolves into " + str + " by leveling up in Chargestone Cave.";
                        break;

                    case 0x1a:
                        dgv[1, i].Value = "Evolves into " + str + " by leveling up near a Moss Rock (Pinwheel Forest).";
                        break;

                    case 0x1b:
                        dgv[1, i].Value = "Evolves into " + str + " by leveling up near an Ice Rock (Twist Mountain Basement).";
                        break;

                    default:
                        dgv[1, i].Value = "- No Data -";
                        break;
                }
            }
        }

        private void ReadSourceData(int index)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 0x4c; i++)
            {
                string str = Convert.ToString(poke[index][i], 0x10).ToUpper();
                if (str.Length == 1)
                {
                    str = "0" + str;
                }
                builder.Append(str + " ");
                if (i % 0x10 == 15)
                {
                    builder.Append(Environment.NewLine);
                }
            }
            sourceTextBox.Text = builder.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            splitContainer1.Enabled = false;
            WriteData((int) listBox1.SelectedValue);
            OutputData(toolStripStatusLabel1.Text);
            splitContainer1.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ArrayList list = (ArrayList) Program.PokeList.GetArrayList().Clone();
            if (searchTextBox.Text == string.Empty)
            {
                listBox1.DataSource = list;
            }
            else
            {
                ArrayList list2 = new ArrayList();
                switch (searchComboBox.SelectedIndex)
                {
                    case 0:
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (((SelectBoxItem) list[i]).Name.StartsWith(searchTextBox.Text))
                            {
                                list2.Add(list[i]);
                            }
                        }
                        break;
                    case 1:
                        for (int j = 0; j < list.Count; j++)
                        {
                            if (((SelectBoxItem) list[j]).Name.IndexOf(searchTextBox.Text, StringComparison.Ordinal) != -1)
                            {
                                list2.Add(list[j]);
                            }
                        }
                        break;
                    default:
                        for (int k = 0; k < list.Count; k++)
                        {
                            if (((SelectBoxItem) list[k]).Name.EndsWith(searchTextBox.Text))
                            {
                                list2.Add(list[k]);
                            }
                        }
                        break;
                }
                listBox1.DataSource = list2;
                listBox1.Select();
            }
        }

        private void skillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkillForm form = new SkillForm(skill);
            if (form.ShowDialog() == DialogResult.OK)
            {
                skill = form.Skill;
            }
        }

        private void WriteData(int index)
        {
            poke[index].FamilyHp = (int) x00_NUD.Value;
            poke[index].FamilyAtk = (int) x01_NUD.Value;
            poke[index].FamilyDef = (int) x02_NUD.Value;
            poke[index].FamilySpd = (int) x03_NUD.Value;
            poke[index].FamilySatk = (int) x04_NUD.Value;
            poke[index].FamilySdef = (int) x05_NUD.Value;
            poke[index].Type1 = (int) x06_CoB.SelectedValue;
            poke[index].Type2 = (int) x07_CoB.SelectedValue;
            poke[index].Capture = (int) x08_NUD.Value;
            poke[index].Rank = (int) x09_NUD.Value;
            poke[index].EffortHp = (int) x0A_0_NUD.Value;
            poke[index].EffortAtk = (int) x0A_1_NUD.Value;
            poke[index].EffortDef = (int) x0A_2_NUD.Value;
            poke[index].EffortSpd = (int) x0A_3_NUD.Value;
            poke[index].EffortSatk = (int) x0B_0_NUD.Value;
            poke[index].EffortSdef = (int) x0B_1_NUD.Value;
            poke[index].Item1 = item[0];
            poke[index].Item2 = item[1];
            poke[index].Item3 = item[2];
            poke[index].Sex = (int) x12_CoB.SelectedValue;
            poke[index].EggStep = (int) x13_NUD.Value;
            poke[index].Feel = (int) x14_NUD.Value;
            poke[index].ExpType = (int) x15_CoB.SelectedValue;
            poke[index].Group1 = (int) x16_CoB.SelectedValue;
            poke[index].Group2 = (int) x17_CoB.SelectedValue;
            poke[index].Specific1 = spec[0];
            poke[index].Specific2 = spec[1];
            poke[index].Specific3 = spec[2];
            int sv = (int) x21_CoB.SelectedValue;
            sv += x21_0_ChB.Checked ? 0x40 : 0;
            sv += x21_1_ChB.Checked ? 0x80 : 0;
            poke[index].Look = sv;
            poke[index].BaseExp = (int) x22_NUD.Value;
            for (int i = 0; i < x28_CLB.Items.Count; i++)
            {
                poke[index].SetMachineUsable(i, x28_CLB.GetItemChecked(i));
            }
            WriteEvolveData(index);
        }

        private void WriteEvolveData(int index)
        {
            for (int i = 0; i < 0x2c; i++)
            {
                evolve[index].Data[i] = selectedEvolve.Data[i];
            }
        }

        private void x0C_BT_Click(object sender, EventArgs e)
        {
            itemLBD.SelectedValue = item[0];
            if (itemLBD.ShowDialog() == DialogResult.OK)
            {
                item[0] = itemLBD.SelectedValue;
                x0C_BT.Text = itemLBD.SelectedName;
            }
        }

        private void x0E_BT_Click(object sender, EventArgs e)
        {
            itemLBD.SelectedValue = item[1];
            if (itemLBD.ShowDialog() == DialogResult.OK)
            {
                item[1] = itemLBD.SelectedValue;
                x0E_BT.Text = itemLBD.SelectedName;
            }
        }

        private void x10_BT_Click(object sender, EventArgs e)
        {
            itemLBD.SelectedValue = item[2];
            if (itemLBD.ShowDialog() == DialogResult.OK)
            {
                item[2] = itemLBD.SelectedValue;
                x10_BT.Text = itemLBD.SelectedName;
            }
        }

        private void x18_BT_Click(object sender, EventArgs e)
        {
            specLBD.SelectedValue = spec[0];
            if (specLBD.ShowDialog() == DialogResult.OK)
            {
                spec[0] = specLBD.SelectedValue;
                x18_BT.Text = specLBD.SelectedName;
            }
        }

        private void x19_BT_Click(object sender, EventArgs e)
        {
            specLBD.SelectedValue = spec[1];
            if (specLBD.ShowDialog() == DialogResult.OK)
            {
                spec[1] = specLBD.SelectedValue;
                x19_BT.Text = specLBD.SelectedName;
            }
        }

        private void x1A_BT_Click(object sender, EventArgs e)
        {
            specLBD.SelectedValue = spec[2];
            if (specLBD.ShowDialog() == DialogResult.OK)
            {
                spec[2] = specLBD.SelectedValue;
                x1A_BT.Text = specLBD.SelectedName;
            }
        }

        public enum Version
        {
            Black,
            White
        }
    }
}

