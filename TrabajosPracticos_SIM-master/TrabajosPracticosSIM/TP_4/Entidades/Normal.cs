﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajosPracticosSIM.TP_1;

namespace TrabajosPracticosSIM.TP_4.Entidades
{
    public class Normal : IDistribucion
    {
        public double Media { get; set; }
        public double DS { get; set; }

        public Normal(double media, double ds)
        {
            Media = media;
            DS = ds;
        }

        public string DevolverParams()
        {
            return "µ: " + Media + ",σ: " + DS;
        }
        public double DevolverUnaVariableAleatoria(Queue<double> random)
        {
            double random1 = random.Dequeue();
            double random2 = random.Dequeue();
            double z = Math.Sqrt(-2 * Math.Log(1 - random1)) * Math.Cos(2 * Math.PI * random2);
            double varAleat = Media + (z * DS);
            varAleat = Utiles.RedondearDecimales(varAleat, 4);
            return varAleat;
        }

        public double DevolverParam1()
        {
            return Media;
        }

        public double DevolverParam2()
        {
            return DS;
        }

        public int CantidadDeRandoms()
        {
            return 2;
        }
    }
}

