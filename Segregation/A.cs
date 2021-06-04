using System;
using System.Collections.Generic;
using System.Text;

namespace Segregation
{
    /*
     * 类A通过interface1依赖于B
     * 
     * 但是只依赖于B的1、2、3方法
     * B里边的4、5方法是多余的
     * 
     * 而类C依赖于D的3、4、5方法
     * D里边的1、2方法是多余的
     * 
     * 问题：接口太大，不同的继承于Interface1的类，用不了接口的所有方法
     * 所以要对接口进行分割，达到继承即用到
     */
    class A
    {
        public void DoA1(Interface1 i)
        {
            i.Do1();
        }

        public void Do2(Interface1 i)
        {
            i.Do2();
        }

        public void Do3(Interface1 i)
        {
            i.Do3();
        }
    }
}
