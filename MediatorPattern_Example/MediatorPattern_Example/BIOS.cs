/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 17.05.2020
*/
using System;

namespace MediatorPattern_Example
{
    //This BIOS class will be our Mediator class.
    //BIOS is going to coordinate everything when we press the power button
    //It will first check the IO Parts and then if there is no problem 
    //call the operating system.
    public class BIOS
    {
        public void pressPowerButton()
        {
            //First start all of IO's
            CPU _cpu = new CPU();
            _cpu.initialize();
            if (_cpu.getStatus() == false)
                Console.WriteLine("Starting CPU is failed...");

            RAM _ram = new RAM();
            _ram.initialize();
            if (_ram.getStatus() == false)
                Console.WriteLine("Starting RAM is failed...");

            HDD _hdd = new HDD();
            _hdd.initialize();
            if (_hdd.getStatus() == false)
                Console.WriteLine("Starting HDD is failed...");

            //if there is no problem with the IO's then we are good to call operating system
            if (_cpu.getStatus() && _ram.getStatus() && _hdd.getStatus())
            {
                OS _os = new OS();
                _os.initialize();
                if (_os.getStatus() == true)
                    Console.WriteLine("Operating System started successfully...");
            }
        }
    }
}
