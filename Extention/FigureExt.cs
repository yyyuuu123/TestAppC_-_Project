using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model;

namespace TestApp.Extention
{
    public static class FigureExt
    {
        public static bool CheckFigure<T>(this T source, Predicate<T> targetInvoke) where T : class
        {
            return targetInvoke.Invoke(source);
        }
    }
}
