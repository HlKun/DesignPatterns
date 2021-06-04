using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    abstract class Pizza
    {
        public abstract void Prepare();

        public  void Bake()
        {

        }

        public void Cut()
        {

        }

        public void Box()
        {

        }
    }
}
