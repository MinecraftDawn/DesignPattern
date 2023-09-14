namespace Iterator {
    public interface IIterator<T> {
        bool hasNext();
        T next();
    }

    public class MyList<T>{
        private int index = 0;
        internal int size = 0;

        internal T[] datas = new T[100];

        public void add(T data) {
            datas[size++] = data;
        }

        public IIterator<T> getIterator() {
            return new MyIterator<T>(this);
        }


        internal class MyIterator<T> : IIterator<T> {

            private MyList<T> myList;
            private int index = 0;
            private readonly T[] datas;

            public MyIterator(MyList<T> mylist) {
                this.myList = mylist;
            }


            public bool hasNext() {
                if (index >= myList.size) {
                    return false;
                } else {
                    return true;
                }
            }

            public T next() {
                if (this.hasNext()) {
                    return myList.datas[index++];
                }
                throw new IndexOutOfRangeException();
            }
        }
    }

}
