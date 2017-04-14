namespace POKEMON_BW2
{
    using System;
    using System.Collections;
    using System.Drawing;
    using System.Windows.Forms;

    public class SkillForm : Form
    {
        private Button cancelButton;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
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
        private SkillData[] mySkill;
        private Button okButton;
        private Button searchButton;
        private ComboBox searchComboBox;
        private TextBox searchTextBox;
        private int selectedValue;
        private ListBox skillListBox;
        private SplitContainer splitContainer1;
        private ComboBox x00_CoB;
        private ComboBox x01_CoB;
        private ComboBox x02_CoB;
        private NumericUpDown x03_NUD;
        private NumericUpDown x04_NUD;
        private NumericUpDown x05_NUD;
        private NumericUpDown x06_NUD;
        private NumericUpDown x07_MAX_NUD;
        private NumericUpDown x07_MIN_NUD;
        private ComboBox x08_CoB;
        private NumericUpDown x0A_NUD;
        private NumericUpDown x0B_NUD;
        private NumericUpDown x0C_NUD;
        private NumericUpDown x0D_NUD;
        private NumericUpDown x0E_NUD;
        private NumericUpDown x0F_NUD;
        private NumericUpDown x10_NUD;
        private NumericUpDown x12_NUD;
        private NumericUpDown x13_NUD;
        private ComboBox x14_CoB;
        private ComboBox x15_CoB;
        private ComboBox x16_CoB;
        private ComboBox x17_CoB;
        private NumericUpDown x18_NUD;
        private NumericUpDown x19_NUD;
        private NumericUpDown x1A_NUD;
        private NumericUpDown x1B_NUD;
        private NumericUpDown x1C_NUD;
        private NumericUpDown x1D_NUD;
        private NumericUpDown x1E_NUD;
        private NumericUpDown x1F_NUD;
        private NumericUpDown x20_NUD;
        private NumericUpDown x21_NUD;

        public SkillForm(SkillData[] skill)
        {
            InitializeComponent();
            skillListBox.DataSource = (ArrayList) Program.SkillList.GetArrayList().Clone();
            skillListBox.DisplayMember = "Name";
            skillListBox.ValueMember = "Value";
            x00_CoB.DataSource = (ArrayList) Program.TypeList.GetArrayList().Clone();
            x00_CoB.DisplayMember = "Name";
            x00_CoB.ValueMember = "Value";
            x01_CoB.DataSource = (ArrayList) Program.CategoryList.GetArrayList().Clone();
            x01_CoB.DisplayMember = "Name";
            x01_CoB.ValueMember = "Value";
            x02_CoB.DataSource = (ArrayList) Program.AssortList.GetArrayList().Clone();
            x02_CoB.DisplayMember = "Name";
            x02_CoB.ValueMember = "Value";
            x08_CoB.DataSource = (ArrayList) Program.ConditionList.GetArrayList().Clone();
            x08_CoB.DisplayMember = "Name";
            x08_CoB.ValueMember = "Value";
            x14_CoB.DataSource = (ArrayList) Program.TargetList.GetArrayList().Clone();
            x14_CoB.DisplayMember = "Name";
            x14_CoB.ValueMember = "Value";
            x15_CoB.DataSource = (ArrayList) Program.StatusList.GetArrayList().Clone();
            x15_CoB.DisplayMember = "Name";
            x15_CoB.ValueMember = "Value";
            x16_CoB.DataSource = (ArrayList) Program.StatusList.GetArrayList().Clone();
            x16_CoB.DisplayMember = "Name";
            x16_CoB.ValueMember = "Value";
            x17_CoB.DataSource = (ArrayList) Program.StatusList.GetArrayList().Clone();
            x17_CoB.DisplayMember = "Name";
            x17_CoB.ValueMember = "Value";
            mySkill = new SkillData[skill.Length];
            for (int i = 0; i < mySkill.Length; i++)
            {
                mySkill[i] = new SkillData();
                for (int j = 0; j < 0x24; j++)
                {
                    mySkill[i][j] = skill[i][j];
                }
            }
            searchComboBox.SelectedIndex = 0;
            skillListBox.SelectedIndex = 0;
            skillListBox.SelectedIndexChanged += skillListBox_SelectedIndexChanged;
            ReadData((int) skillListBox.SelectedValue);
            selectedValue = (int) skillListBox.SelectedValue;
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
            splitContainer1 = new SplitContainer();
            skillListBox = new ListBox();
            groupBox1 = new GroupBox();
            x0B_NUD = new NumericUpDown();
            label11 = new Label();
            label22 = new Label();
            x21_NUD = new NumericUpDown();
            x1E_NUD = new NumericUpDown();
            label25 = new Label();
            label23 = new Label();
            x20_NUD = new NumericUpDown();
            x1F_NUD = new NumericUpDown();
            label24 = new Label();
            x1D_NUD = new NumericUpDown();
            x1A_NUD = new NumericUpDown();
            x17_CoB = new ComboBox();
            x1C_NUD = new NumericUpDown();
            x19_NUD = new NumericUpDown();
            x16_CoB = new ComboBox();
            x1B_NUD = new NumericUpDown();
            x18_NUD = new NumericUpDown();
            x15_CoB = new ComboBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            x14_CoB = new ComboBox();
            label18 = new Label();
            x13_NUD = new NumericUpDown();
            label17 = new Label();
            x12_NUD = new NumericUpDown();
            label16 = new Label();
            x10_NUD = new NumericUpDown();
            label15 = new Label();
            x0F_NUD = new NumericUpDown();
            label14 = new Label();
            x0E_NUD = new NumericUpDown();
            label13 = new Label();
            x0D_NUD = new NumericUpDown();
            x0C_NUD = new NumericUpDown();
            label12 = new Label();
            x0A_NUD = new NumericUpDown();
            label10 = new Label();
            x08_CoB = new ComboBox();
            label9 = new Label();
            x07_MAX_NUD = new NumericUpDown();
            x07_MIN_NUD = new NumericUpDown();
            label8 = new Label();
            x06_NUD = new NumericUpDown();
            label7 = new Label();
            x05_NUD = new NumericUpDown();
            label6 = new Label();
            x04_NUD = new NumericUpDown();
            label5 = new Label();
            x03_NUD = new NumericUpDown();
            label4 = new Label();
            x02_CoB = new ComboBox();
            label3 = new Label();
            x01_CoB = new ComboBox();
            label2 = new Label();
            x00_CoB = new ComboBox();
            label1 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            groupBox4 = new GroupBox();
            searchButton = new Button();
            searchComboBox = new ComboBox();
            searchTextBox = new TextBox();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            x0B_NUD.BeginInit();
            x21_NUD.BeginInit();
            x1E_NUD.BeginInit();
            x20_NUD.BeginInit();
            x1F_NUD.BeginInit();
            x1D_NUD.BeginInit();
            x1A_NUD.BeginInit();
            x1C_NUD.BeginInit();
            x19_NUD.BeginInit();
            x1B_NUD.BeginInit();
            x18_NUD.BeginInit();
            x13_NUD.BeginInit();
            x12_NUD.BeginInit();
            x10_NUD.BeginInit();
            x0F_NUD.BeginInit();
            x0E_NUD.BeginInit();
            x0D_NUD.BeginInit();
            x0C_NUD.BeginInit();
            x0A_NUD.BeginInit();
            x07_MAX_NUD.BeginInit();
            x07_MIN_NUD.BeginInit();
            x06_NUD.BeginInit();
            x05_NUD.BeginInit();
            x04_NUD.BeginInit();
            x03_NUD.BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Panel1.Controls.Add(groupBox4);
            splitContainer1.Panel1.Controls.Add(skillListBox);
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Panel2.Controls.Add(x1D_NUD);
            splitContainer1.Panel2.Controls.Add(x1A_NUD);
            splitContainer1.Panel2.Controls.Add(x17_CoB);
            splitContainer1.Panel2.Controls.Add(x1C_NUD);
            splitContainer1.Panel2.Controls.Add(x19_NUD);
            splitContainer1.Panel2.Controls.Add(x16_CoB);
            splitContainer1.Panel2.Controls.Add(x1B_NUD);
            splitContainer1.Panel2.Controls.Add(x18_NUD);
            splitContainer1.Panel2.Controls.Add(x15_CoB);
            splitContainer1.Panel2.Controls.Add(label21);
            splitContainer1.Panel2.Controls.Add(label20);
            splitContainer1.Panel2.Controls.Add(label19);
            splitContainer1.Panel2.Controls.Add(x14_CoB);
            splitContainer1.Panel2.Controls.Add(label18);
            splitContainer1.Panel2.Controls.Add(x13_NUD);
            splitContainer1.Panel2.Controls.Add(label17);
            splitContainer1.Panel2.Controls.Add(x12_NUD);
            splitContainer1.Panel2.Controls.Add(label16);
            splitContainer1.Panel2.Controls.Add(x10_NUD);
            splitContainer1.Panel2.Controls.Add(label15);
            splitContainer1.Panel2.Controls.Add(x0F_NUD);
            splitContainer1.Panel2.Controls.Add(label14);
            splitContainer1.Panel2.Controls.Add(x0E_NUD);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(x0D_NUD);
            splitContainer1.Panel2.Controls.Add(x0C_NUD);
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(x0A_NUD);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(x08_CoB);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(x07_MAX_NUD);
            splitContainer1.Panel2.Controls.Add(x07_MIN_NUD);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(x06_NUD);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(x05_NUD);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(x04_NUD);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(x03_NUD);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(x02_CoB);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(x01_CoB);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(x00_CoB);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(0x224, 0x15f);
            splitContainer1.SplitterDistance = 0x85;
            splitContainer1.TabIndex = 0;
            skillListBox.Dock = DockStyle.Top;
            skillListBox.FormattingEnabled = true;
            skillListBox.ItemHeight = 12;
            skillListBox.Location = new Point(0, 0);
            skillListBox.Name = "skillListBox";
            skillListBox.Size = new Size(0x85, 0x10c);
            skillListBox.TabIndex = 0;
            groupBox1.Controls.Add(x0B_NUD);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(x21_NUD);
            groupBox1.Controls.Add(x1E_NUD);
            groupBox1.Controls.Add(label25);
            groupBox1.Controls.Add(label23);
            groupBox1.Controls.Add(x20_NUD);
            groupBox1.Controls.Add(x1F_NUD);
            groupBox1.Controls.Add(label24);
            groupBox1.Location = new Point(5, 0x11f);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(0xf2, 0x38);
            groupBox1.TabIndex = 0x30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unknown Bytes";
            x0B_NUD.Location = new Point(8, 30);
            int[] bits = new int[4];
            bits[0] = 0xff;
            x0B_NUD.Maximum = new decimal(bits);
            x0B_NUD.Name = "x0B_NUD";
            x0B_NUD.Size = new Size(40, 0x13);
            x0B_NUD.TabIndex = 1;
            label11.AutoSize = true;
            label11.Location = new Point(6, 15);
            label11.Name = "label11";
            label11.Size = new Size(0x19, 12);
            label11.TabIndex = 0;
            label11.Text = "$0B";
            label22.AutoSize = true;
            label22.Location = new Point(0x34, 15);
            label22.Name = "label22";
            label22.Size = new Size(0x18, 12);
            label22.TabIndex = 2;
            label22.Text = "$1E";
            x21_NUD.Location = new Point(0xc0, 30);
            int[] numArray2 = new int[4];
            numArray2[0] = 0xff;
            x21_NUD.Maximum = new decimal(numArray2);
            x21_NUD.Name = "x21_NUD";
            x21_NUD.Size = new Size(40, 0x13);
            x21_NUD.TabIndex = 9;
            x1E_NUD.Location = new Point(0x36, 30);
            int[] numArray3 = new int[4];
            numArray3[0] = 0xff;
            x1E_NUD.Maximum = new decimal(numArray3);
            x1E_NUD.Name = "x1E_NUD";
            x1E_NUD.Size = new Size(40, 0x13);
            x1E_NUD.TabIndex = 3;
            label25.AutoSize = true;
            label25.Location = new Point(190, 15);
            label25.Name = "label25";
            label25.Size = new Size(0x17, 12);
            label25.TabIndex = 8;
            label25.Text = "$21";
            label23.AutoSize = true;
            label23.Location = new Point(0x62, 15);
            label23.Name = "label23";
            label23.Size = new Size(0x18, 12);
            label23.TabIndex = 4;
            label23.Text = "$1F";
            x20_NUD.Location = new Point(0x92, 30);
            int[] numArray4 = new int[4];
            numArray4[0] = 0xff;
            x20_NUD.Maximum = new decimal(numArray4);
            x20_NUD.Name = "x20_NUD";
            x20_NUD.Size = new Size(40, 0x13);
            x20_NUD.TabIndex = 7;
            x1F_NUD.Location = new Point(100, 30);
            int[] numArray5 = new int[4];
            numArray5[0] = 0xff;
            x1F_NUD.Maximum = new decimal(numArray5);
            x1F_NUD.Name = "x1F_NUD";
            x1F_NUD.Size = new Size(40, 0x13);
            x1F_NUD.TabIndex = 5;
            label24.AutoSize = true;
            label24.Location = new Point(0x90, 15);
            label24.Name = "label24";
            label24.Size = new Size(0x17, 12);
            label24.TabIndex = 6;
            label24.Text = "$20";
            x1D_NUD.Location = new Point(0x13c, 0xe8);
            x1D_NUD.Name = "x1D_NUD";
            x1D_NUD.Size = new Size(40, 0x13);
            x1D_NUD.TabIndex = 0x2f;
            x1A_NUD.Location = new Point(270, 0xe8);
            int[] numArray6 = new int[4];
            numArray6[0] = 6;
            x1A_NUD.Maximum = new decimal(numArray6);
            int[] numArray7 = new int[4];
            numArray7[0] = 6;
            numArray7[3] = -2147483648;
            x1A_NUD.Minimum = new decimal(numArray7);
            x1A_NUD.Name = "x1A_NUD";
            x1A_NUD.Size = new Size(40, 0x13);
            x1A_NUD.TabIndex = 0x2e;
            x17_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x17_CoB.FormattingEnabled = true;
            x17_CoB.Location = new Point(0xb8, 0xe7);
            x17_CoB.Name = "x17_CoB";
            x17_CoB.Size = new Size(80, 20);
            x17_CoB.TabIndex = 0x2d;
            x1C_NUD.Location = new Point(0x13c, 0xce);
            x1C_NUD.Name = "x1C_NUD";
            x1C_NUD.Size = new Size(40, 0x13);
            x1C_NUD.TabIndex = 0x2c;
            x19_NUD.Location = new Point(270, 0xce);
            int[] numArray8 = new int[4];
            numArray8[0] = 6;
            x19_NUD.Maximum = new decimal(numArray8);
            int[] numArray9 = new int[4];
            numArray9[0] = 6;
            numArray9[3] = -2147483648;
            x19_NUD.Minimum = new decimal(numArray9);
            x19_NUD.Name = "x19_NUD";
            x19_NUD.Size = new Size(40, 0x13);
            x19_NUD.TabIndex = 0x2b;
            x16_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x16_CoB.FormattingEnabled = true;
            x16_CoB.Location = new Point(0xb8, 0xcd);
            x16_CoB.Name = "x16_CoB";
            x16_CoB.Size = new Size(80, 20);
            x16_CoB.TabIndex = 0x2a;
            x1B_NUD.Location = new Point(0x13c, 180);
            x1B_NUD.Name = "x1B_NUD";
            x1B_NUD.Size = new Size(40, 0x13);
            x1B_NUD.TabIndex = 0x29;
            x18_NUD.Location = new Point(270, 180);
            int[] numArray10 = new int[4];
            numArray10[0] = 6;
            x18_NUD.Maximum = new decimal(numArray10);
            int[] numArray11 = new int[4];
            numArray11[0] = 6;
            numArray11[3] = -2147483648;
            x18_NUD.Minimum = new decimal(numArray11);
            x18_NUD.Name = "x18_NUD";
            x18_NUD.Size = new Size(40, 0x13);
            x18_NUD.TabIndex = 40;
            x15_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x15_CoB.FormattingEnabled = true;
            x15_CoB.Location = new Point(0xb8, 0xb3);
            x15_CoB.Name = "x15_CoB";
            x15_CoB.Size = new Size(80, 20);
            x15_CoB.TabIndex = 0x27;
            label21.AutoSize = true;
            label21.Location = new Point(0x13a, 0xa4);
            label21.Name = "label21";
            label21.Size = new Size(0x1d, 12);
            label21.TabIndex = 0x26;
            label21.Text = "% Chance";
            label20.AutoSize = true;
            label20.Location = new Point(0x10c, 0xa4);
            label20.Name = "label20";
            label20.Size = new Size(0x29, 12);
            label20.TabIndex = 0x25;
            label20.Text = "Stages";
            label19.AutoSize = true;
            label19.Location = new Point(0xb6, 0xa4);
            label19.Name = "label19";
            label19.Size = new Size(0x1d, 12);
            label19.TabIndex = 0x24;
            label19.Text = "Stat";
            x14_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x14_CoB.FormattingEnabled = true;
            x14_CoB.Location = new Point(0xf1, 0x56);
            x14_CoB.Name = "x14_CoB";
            x14_CoB.Size = new Size(0x9e, 20);
            x14_CoB.TabIndex = 0x1f;
            label18.AutoSize = true;
            label18.Location = new Point(0xb6, 0x59);
            label18.Name = "label18";
            label18.Size = new Size(0x1d, 12);
            label18.TabIndex = 30;
            label18.Text = "Targeting";
            x13_NUD.Location = new Point(90, 0x106);
            int[] numArray12 = new int[4];
            numArray12[0] = 100;
            numArray12[3] = -2147483648;
            x13_NUD.Minimum = new decimal(numArray12);
            x13_NUD.Name = "x13_NUD";
            x13_NUD.Size = new Size(50, 0x13);
            x13_NUD.TabIndex = 0x17;
            label17.AutoSize = true;
            label17.Location = new Point(3, 0x108);
            label17.Name = "label17";
            label17.Size = new Size(0x4f, 12);
            label17.TabIndex = 0x16;
            label17.Text = "Quantity";
            x12_NUD.Location = new Point(90, 0xed);
            int[] numArray13 = new int[4];
            numArray13[0] = 100;
            numArray13[3] = -2147483648;
            x12_NUD.Minimum = new decimal(numArray13);
            x12_NUD.Name = "x12_NUD";
            x12_NUD.Size = new Size(50, 0x13);
            x12_NUD.TabIndex = 0x15;
            label16.AutoSize = true;
            label16.Location = new Point(3, 0xef);
            label16.Name = "label16";
            label16.Size = new Size(0x51, 12);
            label16.TabIndex = 20;
            label16.Text = "DMG Heal %";
            x10_NUD.Location = new Point(90, 0xd4);
            int[] numArray14 = new int[4];
            numArray14[0] = 0x181;
            x10_NUD.Maximum = new decimal(numArray14);
            x10_NUD.Name = "x10_NUD";
            x10_NUD.Size = new Size(40, 0x13);
            x10_NUD.TabIndex = 0x13;
            label15.AutoSize = true;
            label15.Location = new Point(3, 0xd6);
            label15.Name = "label15";
            label15.Size = new Size(0x38, 12);
            label15.TabIndex = 0x12;
            label15.Text = "Effect Code";
            x0F_NUD.Location = new Point(90, 0xbb);
            x0F_NUD.Name = "x0F_NUD";
            x0F_NUD.Size = new Size(40, 0x13);
            x0F_NUD.TabIndex = 0x11;
            label14.AutoSize = true;
            label14.Location = new Point(3, 0xbd);
            label14.Name = "label14";
            label14.Size = new Size(0x2f, 12);
            label14.TabIndex = 0x10;
            label14.Text = "Flinch %";
            x0E_NUD.Location = new Point(90, 0xa2);
            int[] numArray15 = new int[4];
            numArray15[0] = 6;
            x0E_NUD.Maximum = new decimal(numArray15);
            x0E_NUD.Name = "x0E_NUD";
            x0E_NUD.Size = new Size(40, 0x13);
            x0E_NUD.TabIndex = 15;
            label13.AutoSize = true;
            label13.Location = new Point(3, 0xa4);
            label13.Name = "label13";
            label13.Size = new Size(0x29, 12);
            label13.TabIndex = 14;
            label13.Text = "+Crit Stage";
            x0D_NUD.Location = new Point(0x88, 0x89);
            int[] numArray16 = new int[4];
            numArray16[0] = 15;
            x0D_NUD.Maximum = new decimal(numArray16);
            x0D_NUD.Name = "x0D_NUD";
            x0D_NUD.Size = new Size(40, 0x13);
            x0D_NUD.TabIndex = 13;
            x0C_NUD.Location = new Point(90, 0x89);
            int[] numArray17 = new int[4];
            numArray17[0] = 15;
            x0C_NUD.Maximum = new decimal(numArray17);
            x0C_NUD.Name = "x0C_NUD";
            x0C_NUD.Size = new Size(40, 0x13);
            x0C_NUD.TabIndex = 12;
            label12.AutoSize = true;
            label12.Location = new Point(3, 0x8b);
            label12.Name = "label12";
            label12.Size = new Size(0x2c, 12);
            label12.TabIndex = 11;
            label12.Text = "Trap Turns";
            x0A_NUD.Location = new Point(0xf1, 0x89);
            x0A_NUD.Name = "x0A_NUD";
            x0A_NUD.Size = new Size(40, 0x13);
            x0A_NUD.TabIndex = 0x23;
            label10.AutoSize = true;
            label10.Location = new Point(0xb6, 0x8b);
            label10.Name = "label10";
            label10.Size = new Size(0x35, 12);
            label10.TabIndex = 0x22;
            label10.Text = "Inflict %";
            x08_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x08_CoB.FormattingEnabled = true;
            x08_CoB.Location = new Point(0xf1, 0x6f);
            x08_CoB.Name = "x08_CoB";
            x08_CoB.Size = new Size(0x79, 20);
            x08_CoB.TabIndex = 0x21;
            label9.AutoSize = true;
            label9.Location = new Point(0xb6, 0x72);
            label9.Name = "label9";
            label9.Size = new Size(0x35, 12);
            label9.TabIndex = 0x20;
            label9.Text = "Inflict";
            x07_MAX_NUD.Location = new Point(0x88, 0x70);
            int[] numArray18 = new int[4];
            numArray18[0] = 15;
            x07_MAX_NUD.Maximum = new decimal(numArray18);
            x07_MAX_NUD.Name = "x07_MAX_NUD";
            x07_MAX_NUD.Size = new Size(40, 0x13);
            x07_MAX_NUD.TabIndex = 10;
            x07_MIN_NUD.Location = new Point(90, 0x70);
            int[] numArray19 = new int[4];
            numArray19[0] = 15;
            x07_MIN_NUD.Maximum = new decimal(numArray19);
            x07_MIN_NUD.Name = "x07_MIN_NUD";
            x07_MIN_NUD.Size = new Size(40, 0x13);
            x07_MIN_NUD.TabIndex = 9;
            label8.AutoSize = true;
            label8.Location = new Point(3, 0x72);
            label8.Name = "label8";
            label8.Size = new Size(0x35, 12);
            label8.TabIndex = 8;
            label8.Text = "Multihit";
            x06_NUD.Location = new Point(90, 0x57);
            int[] numArray20 = new int[4];
            numArray20[0] = 5;
            x06_NUD.Maximum = new decimal(numArray20);
            int[] numArray21 = new int[4];
            numArray21[0] = 7;
            numArray21[3] = -2147483648;
            x06_NUD.Minimum = new decimal(numArray21);
            x06_NUD.Name = "x06_NUD";
            x06_NUD.Size = new Size(40, 0x13);
            x06_NUD.TabIndex = 7;
            label7.AutoSize = true;
            label7.Location = new Point(3, 0x59);
            label7.Name = "label7";
            label7.Size = new Size(0x29, 12);
            label7.TabIndex = 6;
            label7.Text = "Priority";
            x05_NUD.Location = new Point(90, 0x3e);
            int[] numArray22 = new int[4];
            numArray22[0] = 40;
            x05_NUD.Maximum = new decimal(numArray22);
            x05_NUD.Name = "x05_NUD";
            x05_NUD.Size = new Size(40, 0x13);
            x05_NUD.TabIndex = 5;
            label6.AutoSize = true;
            label6.Location = new Point(3, 0x40);
            label6.Name = "label6";
            label6.Size = new Size(0x13, 12);
            label6.TabIndex = 4;
            label6.Text = "PP";
            x04_NUD.Location = new Point(90, 0x25);
            int[] numArray23 = new int[4];
            numArray23[0] = 0x65;
            x04_NUD.Maximum = new decimal(numArray23);
            x04_NUD.Name = "x04_NUD";
            x04_NUD.Size = new Size(40, 0x13);
            x04_NUD.TabIndex = 3;
            label5.AutoSize = true;
            label5.Location = new Point(3, 0x27);
            label5.Name = "label5";
            label5.Size = new Size(0x1d, 12);
            label5.TabIndex = 2;
            label5.Text = "Accuracy";
            x03_NUD.Location = new Point(90, 12);
            int[] numArray24 = new int[4];
            numArray24[0] = 0xff;
            x03_NUD.Maximum = new decimal(numArray24);
            x03_NUD.Name = "x03_NUD";
            x03_NUD.Size = new Size(40, 0x13);
            x03_NUD.TabIndex = 1;
            label4.AutoSize = true;
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(0x1d, 12);
            label4.TabIndex = 0;
            label4.Text = "Base Power";
            x02_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x02_CoB.FormattingEnabled = true;
            x02_CoB.Location = new Point(0xf1, 0x3d);
            x02_CoB.Name = "x02_CoB";
            x02_CoB.Size = new Size(0x9e, 20);
            x02_CoB.TabIndex = 0x1d;
            label3.AutoSize = true;
            label3.Location = new Point(0xb6, 0x40);
            label3.Name = "label3";
            label3.Size = new Size(0x1d, 12);
            label3.TabIndex = 0x1c;
            label3.Text = "Class";
            x01_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x01_CoB.FormattingEnabled = true;
            x01_CoB.Location = new Point(0xf1, 0x24);
            x01_CoB.Name = "x01_CoB";
            x01_CoB.Size = new Size(0x9e, 20);
            x01_CoB.TabIndex = 0x1b;
            label2.AutoSize = true;
            label2.Location = new Point(0xb6, 0x27);
            label2.Name = "label2";
            label2.Size = new Size(0x1d, 12);
            label2.TabIndex = 0x1a;
            label2.Text = "Category";
            x00_CoB.DropDownStyle = ComboBoxStyle.DropDownList;
            x00_CoB.FormattingEnabled = true;
            x00_CoB.Location = new Point(0xf1, 11);
            x00_CoB.Name = "x00_CoB";
            x00_CoB.Size = new Size(0x9e, 20);
            x00_CoB.TabIndex = 0x19;
            label1.AutoSize = true;
            label1.Location = new Point(0xb6, 14);
            label1.Name = "label1";
            label1.Size = new Size(0x9e, 12);
            label1.TabIndex = 0x18;
            label1.Text = "Type";
            okButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            okButton.Location = new Point(380, 0x165);
            okButton.Name = "okButton";
            okButton.Size = new Size(0x4b, 0x17);
            okButton.TabIndex = 1;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            cancelButton.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(0x1cd, 0x165);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(0x4b, 0x17);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            groupBox4.Controls.Add(searchButton);
            groupBox4.Controls.Add(searchComboBox);
            groupBox4.Controls.Add(searchTextBox);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(0, 0x110);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(0x85, 0x4f);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Filter";
            searchButton.Location = new Point(6, 0x2c);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(0x7c, 0x17);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            searchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Items.AddRange(new object[] { "Begins with", "Includes", "Ends with" });
            searchComboBox.Location = new Point(0x37, 0x11);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(0x4b, 20);
            searchComboBox.TabIndex = 1;
            searchTextBox.Location = new Point(6, 0x12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(0x2b, 0x13);
            searchTextBox.TabIndex = 0;
            AutoScaleDimensions = new SizeF(6f, 12f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(0x224, 0x188);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SkillForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Move Editor";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            x0B_NUD.EndInit();
            x21_NUD.EndInit();
            x1E_NUD.EndInit();
            x20_NUD.EndInit();
            x1F_NUD.EndInit();
            x1D_NUD.EndInit();
            x1A_NUD.EndInit();
            x1C_NUD.EndInit();
            x19_NUD.EndInit();
            x1B_NUD.EndInit();
            x18_NUD.EndInit();
            x13_NUD.EndInit();
            x12_NUD.EndInit();
            x10_NUD.EndInit();
            x0F_NUD.EndInit();
            x0E_NUD.EndInit();
            x0D_NUD.EndInit();
            x0C_NUD.EndInit();
            x0A_NUD.EndInit();
            x07_MAX_NUD.EndInit();
            x07_MIN_NUD.EndInit();
            x06_NUD.EndInit();
            x05_NUD.EndInit();
            x04_NUD.EndInit();
            x03_NUD.EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            WriteData(selectedValue);
            DialogResult = DialogResult.OK;
        }

        private void ReadData(int index)
        {
            x00_CoB.SelectedValue = mySkill[index].Type;
            x01_CoB.SelectedValue = mySkill[index].Category;
            x02_CoB.SelectedValue = mySkill[index].Assort;
            x03_NUD.Value = mySkill[index].Power;
            x04_NUD.Value = mySkill[index].Hit;
            x05_NUD.Value = mySkill[index].PP;
            x06_NUD.Value = mySkill[index].Priority;
            x07_MIN_NUD.Value = mySkill[index].MinRepeat;
            x07_MAX_NUD.Value = mySkill[index].MaxRepeat;
            x08_CoB.SelectedValue = mySkill[index].ConditionCode;
            x0A_NUD.Value = mySkill[index].ConditionProbability;
            x0B_NUD.Value = mySkill[index].Unkown0B;
            x0C_NUD.Value = mySkill[index].MinTurn;
            x0D_NUD.Value = mySkill[index].MaxTurn;
            x0E_NUD.Value = mySkill[index].Fatal;
            x0F_NUD.Value = mySkill[index].Wince;
            x10_NUD.Value = mySkill[index].EffectCode;
            x12_NUD.Value = mySkill[index].FluctuationByDamage;
            x13_NUD.Value = mySkill[index].FluctuationByHP;
            x14_CoB.SelectedValue = mySkill[index].Target;
            x15_CoB.SelectedValue = mySkill[index].GetFluctuationStatus(0);
            x16_CoB.SelectedValue = mySkill[index].GetFluctuationStatus(1);
            x17_CoB.SelectedValue = mySkill[index].GetFluctuationStatus(2);
            x18_NUD.Value = mySkill[index].GetFluctuationValue(0);
            x19_NUD.Value = mySkill[index].GetFluctuationValue(1);
            x1A_NUD.Value = mySkill[index].GetFluctuationValue(2);
            x1B_NUD.Value = mySkill[index].GetFluctuationProbability(0);
            x1C_NUD.Value = mySkill[index].GetFluctuationProbability(1);
            x1D_NUD.Value = mySkill[index].GetFluctuationProbability(2);
            x1E_NUD.Value = mySkill[index].Unkown1E;
            x1F_NUD.Value = mySkill[index].Unkown1F;
            x20_NUD.Value = mySkill[index].Unkown20;
            x21_NUD.Value = mySkill[index].Unkown21;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ArrayList list = (ArrayList) Program.SkillList.GetArrayList().Clone();
            if (searchTextBox.Text == string.Empty)
            {
                skillListBox.DataSource = list;
            }
            else
            {
                ArrayList list2 = new ArrayList();
                if (searchComboBox.SelectedIndex == 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (((SelectBoxItem) list[i]).Name.StartsWith(searchTextBox.Text))
                        {
                            list2.Add(list[i]);
                        }
                    }
                }
                else if (searchComboBox.SelectedIndex == 1)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (((SelectBoxItem) list[j]).Name.IndexOf(searchTextBox.Text) != -1)
                        {
                            list2.Add(list[j]);
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (((SelectBoxItem) list[k]).Name.EndsWith(searchTextBox.Text))
                        {
                            list2.Add(list[k]);
                        }
                    }
                }
                skillListBox.DataSource = list2;
                skillListBox.Select();
            }
        }

        private void skillListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skillListBox.SelectedIndex < 0)
            {
                skillListBox.SelectedIndex = 0;
            }
            else if (skillListBox.SelectedIndex >= skillListBox.Items.Count)
            {
                skillListBox.SelectedIndex = skillListBox.Items.Count - 1;
            }
            WriteData(selectedValue);
            ReadData((int) skillListBox.SelectedValue);
            selectedValue = (int) skillListBox.SelectedValue;
        }

        private void WriteData(int index)
        {
            mySkill[index].Type = (int) x00_CoB.SelectedValue;
            mySkill[index].Category = (int) x01_CoB.SelectedValue;
            mySkill[index].Assort = (int) x02_CoB.SelectedValue;
            mySkill[index].Power = (int) x03_NUD.Value;
            mySkill[index].Hit = (int) x04_NUD.Value;
            mySkill[index].PP = (int) x05_NUD.Value;
            mySkill[index].Priority = (int) x06_NUD.Value;
            mySkill[index].MinRepeat = (int) x07_MIN_NUD.Value;
            mySkill[index].MaxRepeat = (int) x07_MAX_NUD.Value;
            mySkill[index].ConditionCode = (int) x08_CoB.SelectedValue;
            mySkill[index].ConditionProbability = (int) x0A_NUD.Value;
            mySkill[index].Unkown0B = (int) x0B_NUD.Value;
            mySkill[index].MinTurn = (int) x0C_NUD.Value;
            mySkill[index].MaxTurn = (int) x0D_NUD.Value;
            mySkill[index].Fatal = (int) x0E_NUD.Value;
            mySkill[index].Wince = (int) x0F_NUD.Value;
            mySkill[index].EffectCode = (int) x10_NUD.Value;
            mySkill[index].FluctuationByDamage = (int) x12_NUD.Value;
            mySkill[index].FluctuationByHP = (int) x13_NUD.Value;
            mySkill[index].Target = (int) x14_CoB.SelectedValue;
            mySkill[index].SetFluctuationStatus(0, (int) x15_CoB.SelectedValue);
            mySkill[index].SetFluctuationStatus(1, (int) x16_CoB.SelectedValue);
            mySkill[index].SetFluctuationStatus(2, (int) x17_CoB.SelectedValue);
            mySkill[index].SetFluctuationValue(0, (int) x18_NUD.Value);
            mySkill[index].SetFluctuationValue(1, (int) x19_NUD.Value);
            mySkill[index].SetFluctuationValue(2, (int) x1A_NUD.Value);
            mySkill[index].SetFluctuationProbability(0, (int) x1B_NUD.Value);
            mySkill[index].SetFluctuationProbability(1, (int) x1C_NUD.Value);
            mySkill[index].SetFluctuationProbability(2, (int) x1D_NUD.Value);
            mySkill[index].Unkown1E = (int) x1E_NUD.Value;
            mySkill[index].Unkown1F = (int) x1F_NUD.Value;
            mySkill[index].Unkown20 = (int) x20_NUD.Value;
            mySkill[index].Unkown21 = (int) x21_NUD.Value;
        }

        public SkillData[] Skill
        {
            get
            {
                return mySkill;
            }
        }
    }
}

