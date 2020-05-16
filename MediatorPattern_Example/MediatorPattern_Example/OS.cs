/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 17.05.2020
*/
using System;

namespace MediatorPattern_Example
{
    class OS : IO
    {
        private bool isReady = false;

        public bool getStatus() => this.isReady;

        public void initialize()
        {
            Console.WriteLine("Operating System is starting...");
            this.isReady = true;
        }
    }
}
