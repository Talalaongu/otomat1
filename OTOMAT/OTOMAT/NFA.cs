using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class NFA : FA
    {
        State[,] NTrans;
        public NFA()
        { }
        public NFA(int _state,int _alphabet): base(_state,_alphabet)
        {                        
            NumAlpabet = _alphabet;
            NumState = _state;
            this.NTrans = new State[NumState, NumAlpabet];
            Alphabet = new string[_alphabet];
            Q = new State[_state];
            _FirstQ = 0;
        }

        public void Input()
        {
            
            for(int i = 0; i < NumState; i++)
            {
                Q[i].value[i] = true;
            }
           
            Console.WriteLine("Nhap cac ky tu trong bang chu: ");            
            Alphabet = Console.ReadLine().Split(',');
            //this.NTrans = new State[NumState, NumAlpabet];
            for(int i =0; i < NumState; i++)
            {
                for(int j = 0; j < NumAlpabet; j++)
                {
                    State tmp = new State(NumState);
                    Console.WriteLine("(q{0},{1}) = ", i, Alphabet[j]);
                    tmp.value[Convert.ToInt32(Console.ReadLine().Substring(1))] = true;
                    NTrans[i, j] = tmp;
                }
            }
        }
    }
}
