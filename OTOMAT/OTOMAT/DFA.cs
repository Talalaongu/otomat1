using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class DFA : FA
    {
        public State[,] DTrans;
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

        public void Output()
        {
            // bảng chữ
            Console.Write("A: ");
            for(int i = 0; i < Alphabet.Length; i++)
            {
                Console.Write(Alphabet[i]+" ");
            }

            // trạng thái
            Console.WriteLine("Q: ");
            for(int i = 0; i < Q.Length; i ++)
            {
                Console.Write("Q{0} : ", i);
                ShowQ(Q[i]);
            }

            // Hàm chuyển
            //for (int i = 0; i < DTrans.GetLength(0); i++)
            //{
            //    Console.Write("Q{0} : ", i);
            //    for (int j = 0; j < DTrans.GetLength(1); j++)
            //    {
                    
            //    }
            //}
        }

        public void ShowQ(State Q)
        {
            for (int j = 0; j < Q.value.Length; j++)
            {
                if (Q.value[j] == true)
                {
                    Console.Write("q{0}  ", j);
                }
            }
        }
    }
}
