/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 17.05.2020
*/
using System;
using System.Threading;

namespace MediatorPattern_Example
{
    class CPU : IO
    {
        private bool isReady = false;

        public bool getStatus() => this.isReady;
        
        public void initialize()
        {
            Console.WriteLine("Checking CPU...");
            Thread.Sleep(100);
            this.isReady = true;
            Console.WriteLine("CPU is ready...");
            Console.WriteLine("--------------------------");
        }
    }
}
