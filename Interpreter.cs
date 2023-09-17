namespace Interpreter {
    class Context {
        private string data;

        public Context(string data) {
            this.data = data;
        }

        public string getData() {
            return data;
        }
    }

    interface Expression {
        public bool interpret(Context c1, Context c2);
    }

    class SQLExpression : Expression {
        public bool interpret(Context c1, Context c2) {
            return c1.getData().Contains(c2.getData()); 
        }
    }

}
