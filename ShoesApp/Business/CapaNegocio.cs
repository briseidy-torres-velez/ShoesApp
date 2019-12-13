using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Business
{
    public class CapaNegocio
    {
       public bool Insert(AddProdET AddET)
        {
            CapaDatos cd = new CapaDatos();
            return cd.Insert(AddET);
        }
    }
}
