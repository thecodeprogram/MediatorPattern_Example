/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 17.05.2020
*/
using System;

//Main program have no idea what is under the hood.
//It just instructs the mediator class which is BIOS class in this example to start the system.
//All of the tasks will be performed via BIOS class.
namespace MediatorPattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mediator Design Pattern Example - TheCodeProgram";

            //All we need to do from our main program to press the power button
            BIOS _bios = new BIOS();
            _bios.pressPowerButton();

            Console.ReadLine();
        }
    }
}
