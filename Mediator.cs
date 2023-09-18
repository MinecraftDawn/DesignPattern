namespace Mediator {
    interface Mediator {
        void send(Messager from, Messager to, string message);

        void sendAll(Messager from, string message);
    }


    class MessageMediator : Mediator {

        private List<Messager> users = new List<Messager>();


        public void joinChat(Messager messager) {
            if (!users.Contains(messager)) {
                users.Add(messager);
            }
        }

        public void send(Messager from, Messager to, string message) {
            foreach(Messager msger in users){
                if (msger == to) {
                    Console.WriteLine(from.Name + " to " + to.Name + " : " + message);
                }
            }
        }

        public void sendAll(Messager from, string message) {
            foreach (Messager msger in users) {
                 Console.WriteLine(from.Name + " to " + "everyone" + " : " + message);
            }
        }
    }

    abstract class Messager {
        public string Name { set; get; }
        private Mediator mediator;

        public Messager(Mediator mediator, string name) {
            this.mediator = mediator;
            Name = name; 
        }

        public void send(Messager to, string message) {
            this.mediator.send(this, to, message);
        }

        public void sendAll(string message) {
            this.mediator.sendAll(this, message);
        }


    }

    class User : Messager {
        public User(Mediator mediator, string name) : base(mediator, name) {
        }
    }

}
