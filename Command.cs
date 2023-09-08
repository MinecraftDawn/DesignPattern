namespace Command {
    interface Receiver {
        public void finish();
    }

    class MealReceiver : Receiver {
        public void finish() {
            Console.WriteLine("餐點已完成");
        }
    }

    class DrinkReceiver : Receiver {
        public void finish() {
            Console.WriteLine("飲料已完成");
        }
    }

    abstract class Order {
        protected Receiver receiver;
        public Order(Receiver receiver) { 
            this.receiver = receiver;
        }

        public void sendOrder() {
            this.receiver.finish();
        }
    }

    class MealOrder : Order {


        public MealOrder(Receiver receiver) : base(receiver) {
        }
    }

    class DrinkOrder : Order {
        public DrinkOrder(Receiver receiver) : base(receiver) {
        }
    }

    class Invoker {
        private Queue<Order> queue = new Queue<Order>();

        public void addOrder(Order order) {
            queue.Enqueue(order);
        }

        public void sendAllOrder() {
            foreach (Order order in queue) {
                order.sendOrder();
            }
        }
    }

}
