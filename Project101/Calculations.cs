using System;

namespace Project101
{
    public class Calculations
    {
        readonly ILogger logger;
        readonly IStaticClassWrapper staticClassWrapper;
        public Calculations()
        {

        }
        public Calculations(ILogger logger)
        {
            this.logger = logger;
        }

        public Calculations(IStaticClassWrapper staticClassWrapper)
        {
            this.staticClassWrapper = staticClassWrapper;
        }

        public int Add(int val1, int val2)
        {
            return val1 + val2;
        }

        public int Divide(int val1, int val2)
        {
            if (val2.Equals(0))
            {
                throw new DivideByZeroException("Divide By Zero ExceptionMessage");
            }
            return val1 / val2;
        }

        //mocklama örneği
        public int Multiply(int val1, int val2)
        {
            if (val2.Equals(0))
            {
                logger.Info("Returns 0");
            }

            if(val2< 0 || val1 <0)
            {
                logger.Warn("Return a negative result");
            }

            return val1 * val2;
        }


        //statik class wrapleme örneği
        public int Minus(int val1, int val2)
        {
            string message = string.Empty;
           
            if (val1 == 0)
            {
                //wrapper kullanılmadan önceki hali (orjinal)
                // message = StaticClass.WriteMessage("Static class message");

                //wrapper (ara katman) eklendikten sonraki hali(wrapped)
                message = staticClassWrapper.WriteMessage("stubbed class message");
            }

            var result = val1 - val2;  

            return result;
        }
    }
}
