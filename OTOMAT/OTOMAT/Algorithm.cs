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
            Console.Write("Nhap so trang thai");
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
        }
    }
}
