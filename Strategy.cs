namespace Strategy {
    class Item {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";

        public Item() {

        }

        public Item(int id, string name) {
            Id = id;
            Name = name;
        }
    }
    class SortById : Comparer<Item> {
        public override int Compare(Item x, Item y) {
            if (x.Id < y.Id) return -1;
            if (x.Id > y.Id) return 1;
            return 0;
        }
    }

    class SortByName : Comparer<Item> {
        public override int Compare(Item x, Item y) {
            return String.Compare(x.Name, y.Name);
        }
    }
}
