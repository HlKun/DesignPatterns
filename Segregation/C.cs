using System;
using System.Collections.Generic;
using System.Text;

namespace Segregation
{

    /*
     * 类C通过interface1依赖于D
     */
    class C
    {
        public void DoC3(Interface1 i)
        {
            i.Do3();
        }

        public void DoC4(Interface1 i)
        {
            i.Do4();
        }

        public void DoC5(Interface1 i)
        {
            i.Do5();
        }
    }
}
