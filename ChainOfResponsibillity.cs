using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibillity {
    abstract class AbsLogger {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int level;

        protected AbsLogger nextLogger;


        public AbsLogger(int level) {
            this.level = level;
        }

        public void setNextLogger(AbsLogger nextLogger) {
            this.nextLogger = nextLogger;
        }

        public void log(int level, string message) {
            if(this.level <= level) {
                this.write(message);
            }

            if (nextLogger != null) {
                nextLogger.log(level, message);
            }
        }

        public abstract void write(string message);
    }


    class ConsoleLogger : AbsLogger {

        public ConsoleLogger(int level) : base(level){
        }
        public override void write(string message) {
            Console.WriteLine("Console: " + message);
        }
    }

    class ErrorLogger : AbsLogger {
        public ErrorLogger(int level) : base(level) {
        }

        public override void write(string message) {
            Console.WriteLine("Error: " + message);
        }
    }

    class FileLogger : AbsLogger {
        public FileLogger(int level) : base(level) {
        }

        public override void write(string message) {
            Console.WriteLine("FILE: " + message);
        }
    }
}
