using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class ArrayBase
    {
        protected bool user;//способ ввода
        protected int n;

        public ArrayBase(bool user, int n)
        {
            this.user = user;
            this.n = n;
        }


        protected abstract void UserCreate();
        protected abstract void RndCreate();


        public abstract decimal Average();

        public abstract void Print();
    }
}
