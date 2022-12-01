using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Генеральский_практическая_5
{
    internal class Triangle
    {
        private int _a;
        private int _b;
        private int _c;

        public Triangle(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public int Perimetr(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
            return a + b + c;
        }
        public int A
        {
            get => _a;
            set
            {
                _a = value;
            }
        }
        public int B
        {
            get => _b;
            set
            {
                _b = value;
            }
        }
       public int C
        {
            get => _c;
            set
            {
                _c = value;
            }
        }
        public void SetParams(int value)
        {
            A = value;
            B = value;
            C = value;
        }
        public void SetParams(int AValue,int BValue,int CValue)
        {
            A = AValue;
            B = BValue;
            C = CValue;
        }
        public void Doubling(int DoublingA,int DoublingB,int DoublingC)
        {
            A = DoublingA;
            B = DoublingB;
            C = DoublingC;
            A *= 2;
            B *= 2;   
            C *= 2;
        }
    }
}
