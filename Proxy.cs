namespace Proxy {
    interface Access {
        public string getName();
        public void setName(string name);
    }

    class DB : Access {
        private string _name = "";

        public string getName() {
            return _name;
        }

        public void setName(string name) {
            this._name = name;
        }
    }

    class DBProxy : Access {
        private DB db;
        public DBProxy(DB db) {
            this.db = db;
        }

        public string getName() {
            return db.getName();
        }

        public void setName(string name) {
            if (!name.Contains("=")) {
                db.setName(name);
            }else {
                Console.WriteLine("SQL Injection防範");
            }
        }
    }
}
