using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class DFA : FA
    {
        State[,] DTrans;
        public DFA()
        {

        }
        public DFA(int _state, int _alphabet) : base(_state, _alphabet)
        {
            NumAlpabet = _alphabet;
            NumState = _state;
            this.DTrans = new State[NumState, NumAlpabet];
            Alphabet = new string[_alphabet];
            Q = new State[_state];
            _FirstQ = 0;
        }
    }
}
