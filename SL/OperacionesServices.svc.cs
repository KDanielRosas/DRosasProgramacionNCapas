﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OperacionesServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OperacionesServices.svc or OperacionesServices.svc.cs at the Solution Explorer and start debugging.
    public class OperacionesServices : IOperacionesServices
    {
        public int Suma(int a, int b) 
        {
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public double Division(int a, int b) 
        {
            return a / b;
        }

    }
}
