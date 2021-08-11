using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerArc.Business
{
    public class DuplicatedProductException:Exception
    {
        public DuplicatedProductException(String message):base(message)
        {

        }
    }
}
