using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMAT
{
    class Algorithm
    {
        public void NFAToDFA()
        {
            Console.Write("Nhap so trang thai: ");
            int numstate = Convert.ToInt32(Console.ReadLine());
            Console.Write("So ky tu trong bang chu: ");
            int numalpabet = Convert.ToInt32(Console.ReadLine());
            NFA nfa = new NFA(numstate,numalpabet);
            nfa.Input();
            DFA dfa = new DFA();
            dfa.Alphabet = nfa.Alphabet;
            List<State> Q1 = new List<State>();
            Queue<State> tmp = new Queue<State>();
            tmp.Enqueue(nfa.Q[0]);
            Q1.Add(nfa.Q[0]);
            int index = 0;
            List<State[]> dtrans = new List<State[]>();
            while(tmp.Count != 0)
            {
                State a = tmp.Dequeue();
                State[] temp = new State[nfa.NumAlpabet];
                for (int j = 0; j < nfa.NumAlpabet; j++)
                {                    
                    State b = new State(nfa.NumState);
                    for (int i = 0; i < a.value.Length; i++)
                    {
                        if(a.value[i]==true && nfa.NTrans[i, j] != null)
                        {
                            b = b + nfa.NTrans[i, j];
                        }
                    }
                    int count = 0;
                    for (int i = 0; i < Q1.Count; i++)
                    {
                        if (Equals(b, Q1[i]))
                        {
                            count++;
                            break;
                        }
                    }
                    if(count != 1&& !b.Empty())
                    {
                        Q1.Add(b);
                        tmp.Enqueue(b);
                    }
                    temp[j] = b;                    
                }
                dtrans.Add(temp);
            }

            dfa.Output();
        }
    }
}
