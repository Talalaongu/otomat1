using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class NFA : FA
    {
        public State[,] NTrans;
        public NFA()
        { }
        public NFA(int _state,int _alphabet): base(_state,_alphabet)
        {                        
            NumAlpabet = _alphabet;
            NumState = _state;
            this.NTrans = new State[NumState, NumAlpabet];
            Alphabet = new string[_alphabet];
            Q = new State[_state];
            for (int i = 0; i < _state; i++)
            {
                Q[i] = new State(_state);
                Q[i].value[i] = true;
            }
            _FirstQ = 0;
        }

        public void Input()
        {                      
            Console.Write("Nhap cac ky tu trong bang chu: ");            
            Alphabet = Console.ReadLine().Split(',');
            //this.NTrans = new State[NumState, NumAlpabet];
            Console.WriteLine("Ham chuyen: ");
            for(int i =0; i < NumState; i++)
            {
                for(int j = 0; j < NumAlpabet; j++)
                {
                    
                    Console.Write("(q{0},{1}) = ", i, Alphabet[j]);
                    string temp = Console.ReadLine();
                    if (temp != "null")
                    {
                        State tmp = new State(NumState);
                        string[] a = temp.Split(',');

                        for (int k = 0; k < a.Length; k++)
                        {
                            for (int n = 0; n < tmp.value.Length; n++)
                            {
                                if (Int32.Parse(a[k]) == n)
                                    tmp.value[n] = true;
                            }
                        }
                        //tmp.value[Convert.ToInt32(Console.ReadLine().Substring(1))] = true;
                        NTrans[i, j] = tmp;
                    }
                    else
                    {
                        NTrans[i, j] = new State(NumState);
                    }
                }
            }
        }
    }
}
