﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Exeptions;
using TestApp.Model;

namespace TestApp.Utils
{
    internal static class CompileTime<TItem>
    {
        public static double GetInCompleTime(TItem item)
        {
            switch (item)
            {
                case Tringle value:
                    return value.GetAreaFigure();
                case Circle value:
                    return value.GetAreaFigure();
                default: throw new NotFoundompileTime("Cannot cast");
            }
        }
    }
}
