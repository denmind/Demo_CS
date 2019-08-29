using System;
using System.Collections.Generic;
using System.Text;

//Abstraction demo
//See https://is.gd/PkpnbG
namespace BasicCS
{
    //Interface is used if you need to define ALL methods
    //in the inheriting class
    interface IVehicle
    {
        void DisplayOperation();
    }

    //Abstract class is used if you want to defined ONLY a specific
    //method or group of methods in the heriting class

    public abstract class VehicleOp
    {
        public abstract void DisplayOperation();
    }

}
