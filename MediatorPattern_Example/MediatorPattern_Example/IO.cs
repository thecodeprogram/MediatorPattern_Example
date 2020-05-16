/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 17.05.2020
*/
namespace MediatorPattern_Example
{
    //We are going to derive same types classes from this interface.
    //We define the classes which are delegate inputs and outputs inside a computer.
    //All IO units will be initialized and return the initialization status.
    interface IO
    {
        void initialize();
        bool getStatus();
    }
}
