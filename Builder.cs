using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    abstract class AbsComputer {
        private CPU cpu;
        private KeyBoard keyBoard;
        private Disk disk;
        private Memory memory;

        public void setCPU(CPU cpu) {
            this.cpu = cpu;
        }

        public void setKeyBoard(KeyBoard keyBoard) {
            this.keyBoard = keyBoard;
        }

        public void setDisk(Disk disk) {
            this.disk = disk;
        }

        public void setMemory(Memory memory) {
            this.memory = memory;
        }

        public void printInfo() {
            if (cpu != null) Console.WriteLine("CPU: " + cpu.getName());
            if (keyBoard != null) Console.WriteLine("KeyBoard: " + keyBoard.getName());
            if (disk != null) Console.WriteLine("Disk size: " + disk.getSize());
            if (memory != null) Console.WriteLine("Mem size: " + memory.getSize());
        }
    }

    class Computer : AbsComputer { }


    class CPU {
        private string name;

        public CPU(string name) { 
            this.name = name;
        }

        public string getName() {
            return name;
        }
    }

    class KeyBoard {
        private string name;

        public KeyBoard(string name) {
            this.name = name;
        }

        public string getName() {
            return name;
        }
    }

    class Disk {
        private int size;

        public Disk(int size) {
            this.size = size;
        }

        public int getSize() {
            return size;
        }
    }

    class Memory {
        private int size;

        public Memory(int size) {
            this.size = size;
        }

        public int getSize() {
            return size;
        }
    }

    abstract class AbsComputerBuilder { 
        public abstract CPU buildCPU();

        public abstract KeyBoard buildKeyBoard();

        public abstract Disk buildDisk();

        public abstract Memory buildMemory();
    }

    class ComputerBuilder : AbsComputerBuilder {
        public override CPU buildCPU() {
            return new CPU("Intel");
        }

        public override KeyBoard buildKeyBoard() {

            return new KeyBoard("CORSAIR");
        }

        public override Disk buildDisk() {
            return new Disk(1024);
        }
        public override Memory buildMemory() {
            return new Memory(32);
        }
    }

    class Director {
        private ComputerBuilder builder;
        public Director(ComputerBuilder builder) {
            this.builder = builder;
        }

        public AbsComputer buildComputer() {
            AbsComputer computer = new Computer();
            computer.setCPU(builder.buildCPU());
            computer.setDisk(builder.buildDisk());
            computer.setKeyBoard(builder.buildKeyBoard());
            computer.setMemory(builder.buildMemory());

            return computer;
        }
    }
}
