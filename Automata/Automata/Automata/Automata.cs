using System;
using System.Drawing;

namespace Automata
{
    class Automata
    {
        int Cont;
        char [] Car;
        string PaEvaluar;
        static void Main(string[] args)
        
        {
            Automata aut = new Automata();
            Console.WriteLine("Escribe la palabra a evaluar separando cada caracter por espacios");
            aut.PaEvaluar = Console.ReadLine();

            aut.Car = aut.PaEvaluar.ToCharArray(0, aut.PaEvaluar.Length);
            aut.Inicio();
        }

        public void Inicio()
        {
            Cont = 0;
            q0();
        }
        public void palabraRechazada()
        {
            Console.WriteLine("No puedo aceptar esta palabra en el lenguaje");
        }
        public void q0()
        {
            
            if (Cont < Car.Length)
            {
                switch (Car[Cont])
                {
                    case 'a':
                        Cont++;
                        q1();
                        break;
                    case 'c':
                        Cont++;
                        q2();
                        break;

                    default:
                        palabraRechazada();
                        break;

                }
            }
        }
        public void q1()
        {
            switch (Car[Cont])
            {
                case 'b':
                    Cont++;
                    if (Car[Cont] == 'c')
                    {
                        Cont++;
                        q3();
                    }
                    break;
                default:
                    palabraRechazada();
                    break;
            }
        }
        public void q2()
        {
            if (Car[Cont] == 'd')
            {
                Cont++;
                if (Car[Cont] == 'a')
                {
                    Cont++;
                    q3();
                }
            }
            else
            {
                palabraRechazada();
            }
        }
        public void q3()
        {
            if (Car[Cont] == 'a')
            {
                Cont++;
                q4();
            }
            if (Car[Cont] == 'b')
            {
                Cont++;
                q3();
            }
            if (Car[Cont] == 'c')
            {
                Cont++;
                q4();
            }
            if (Car[Cont] == 'd')
            {
                Cont++;
                q3();
            }
            else
            {
                palabraRechazada();
            }
        }
        public void q4()
        {
            if (Car[Cont] == 'a')
            {
                Cont++;
                if (Car[Cont] == 'a')
                {
                    q5();
                }
                else
                {
                    q3();
                }
            }
            if (Car[Cont] == 'c')
            {
                Cont++;
                if (Car[Cont] == 'c')
                {
                    q5();
                }
                else
                {
                    q3();
                }
            }

        }
        public void q5()
        {

            if (Car[Cont] == 'a')
            {
                Cont++;
                q5();
            }
            if (Car[Cont] == 'b')
            {
                Cont++;
                q6();
            }
            if (Car[Cont] == 'c')
            {
                Cont++;
                q5();
            }
            if (Car[Cont] == 'd')
            {
                Cont++;
                q5();
            }
            else
            {
                palabraRechazada();
            }
        }
        public void q6()
        {
            if (Car[Cont] == 'b')
            {
                Cont++;
                q7();
            }
            else
            {
                q5();
            }
        }
        public void q7()
        {
            if (Car[Cont] == 'a')
            {
                Console.WriteLine("La palabra fue aceptada correctamente" + PaEvaluar);
            }
            else
            {
                palabraRechazada();
            }
        }
    }
}
