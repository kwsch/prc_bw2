namespace POKEMON_BW2
{
    using System;
    using System.Collections;

    public class SelectBoxItemArrayList
    {
        private ArrayList list = new ArrayList();

        public void Add(string myName, int myValue)
        {
            list.Add(new SelectBoxItem(myName, myValue));
        }

        public ArrayList GetArrayList() => list;

        public int SearchByName(string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                SelectBoxItem item = (SelectBoxItem) list[i];
                if (name.Equals(item.Name))
                {
                    return item.Value;
                }
            }
            return -1;
        }

        public string SearchByValue(int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                SelectBoxItem item = (SelectBoxItem) list[i];
                if (value == item.Value)
                {
                    return item.Name;
                }
            }
            return string.Empty;
        }

        public void SetArrayList(ArrayList arrayList) => list = arrayList;

        public int Count => list.Count;
    }
}

