using System;
using System.Collections.Generic;
using System.Text;

namespace kopi
{
    class CoffePowder
    {
        private int netto = 0;
        private int oneCupCoffe = 25;

            public CoffePowder(int netto)
        {
            this.netto = netto;
        }

        public Boolean isAvailable()
        {
            return this.netto >= this.oneCupCoffe;
        }

        public int makeOneCup()
        {

            this.netto = this.netto - oneCupCoffe;
            return this.netto;
        }

        internal object getNetto() => throw new NotImplementedException();
    }
}
