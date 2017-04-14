namespace POKEMON_BW2
{
    using System;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    internal static class Program
    {
        public static SelectBoxItemArrayList AssortList;
        public static SelectBoxItemArrayList CategoryList;
        public static SelectBoxItemArrayList ConditionList;
        public static SelectBoxItemArrayList EvolveList;
        public static SelectBoxItemArrayList GroupList;
        public static SelectBoxItemArrayList ItemList;
        public static SelectBoxItemArrayList LevelList;
        public static SelectBoxItemArrayList LookList;
        public static SelectBoxItemArrayList PlaceList;
        public static SelectBoxItemArrayList Poke2List;
        public static SelectBoxItemArrayList PokeList;
        public static SelectBoxItemArrayList SexList;
        public static SelectBoxItemArrayList SkillList;
        public static SelectBoxItemArrayList SpecList;
        public static SelectBoxItemArrayList StatusList;
        public static SelectBoxItemArrayList TargetList;
        public static SelectBoxItemArrayList TypeList;

        public static void LoadList()
        {
            EvolveList = OpenCsv("evolve.csv");
            GroupList = OpenCsv("group.csv");
            ItemList = OpenCsv("item.csv");
            LevelList = OpenCsv("level.csv");
            LookList = OpenCsv("look.csv");
            PlaceList = OpenCsv("place.csv");
            PokeList = OpenCsv("poke.csv");
            Poke2List = OpenCsv("poke2.csv");
            SexList = OpenCsv("sex.csv");
            SpecList = OpenCsv("spec.csv");
            SkillList = OpenCsv("skill.csv");
            TypeList = OpenCsv("type.csv");
            AssortList = OpenCsv("s_assort.csv");
            CategoryList = OpenCsv("s_category.csv");
            ConditionList = OpenCsv("s_condition.csv");
            StatusList = OpenCsv("s_status.csv");
            TargetList = OpenCsv("s_target.csv");
        }

        [STAThread]
        private static void Main()
        {
            LoadList();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static SelectBoxItemArrayList OpenCsv(string fileName)
        {
            SelectBoxItemArrayList list = new SelectBoxItemArrayList();
            string[] strArray = File.ReadAllLines(DataDirectory + fileName, Encoding.GetEncoding("shift_jis"));
            for (int i = 0; i < strArray.Length; i++)
            {
                string[] strArray2 = strArray[i].Split(';');
                if (!string.IsNullOrEmpty(strArray2[0]))
                {
                    string[] strArray3 = strArray2[0].Split(',', '\t');
                    list.Add(strArray3[1], int.Parse(strArray3[0]));
                }
            }
            return list;
        }

        public static string DataDirectory => StartupPath + @"data\";
        public static string TempDirectory => StartupPath + @"tmp\";

        public static string StartupPath
        {
            get
            {
                string startupPath = Application.StartupPath;
                if (!startupPath.EndsWith(@"\"))
                {
                    startupPath = startupPath + @"\";
                }
                return startupPath;
            }
        }

    }
}

