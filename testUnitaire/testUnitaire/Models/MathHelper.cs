using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testUnitaire.Models
{
    public class MathHelper
    {
        public static double factoriel(int a)
        {
            if (a <= 0) return 1;
            return a * factoriel(a - 1);

        }
    }
}