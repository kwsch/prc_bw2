namespace POKEMON_BW2
{
    public class SelectBoxItem
    {
        private int myNameIndex;
        private int myValueIndex;

        public SelectBoxItem(string myName, int myValue)
        {
            this.Name = myName;
            this.Value = myValue;
        }

        public SelectBoxItem(string myName, int myValue, int myNameIndex, int myValueIndex)
        {
            this.Name = myName;
            this.Value = myValue;
            this.myNameIndex = myNameIndex;
            this.myValueIndex = myValueIndex;
        }

        public override string ToString() => Name;

        public string Name { get; set; }

        public string NameAndValue => $"{Name} ({Value:000})";
        public int Value { get; set; }
        public string ValueAndName => $"{Value:000}: {Name}";
    }
}

