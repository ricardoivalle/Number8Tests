using System;

namespace N8Tests
{
    enum Operations {
    ADD,
    SUBSTRACT,
    MULTIPLY,
    DIVIDE
    }
    class Program
    {
        private const int DEFAULT_VALUE = 32;
        static void Main(string[] args)
        {
            int defaultValue = DEFAULT_VALUE;
            Console.WriteLine("The default value is: " + defaultValue.ToString());
            
            var calculatedValue = CalculateOp(Operations.ADD,1,2);
            Console.WriteLine("The calculated value is: " + calculatedValue);
        
        }
        
        private void CalculateOp(int operationId,int firstVal, int secondVal)
        {
            switch(operationId)
            {
                case (int)Operations.ADD: 
                return firstVal + secondVal;                    
                
                case (int)Operations.SUBSTRACT: 
                return firstVal - secondVal;                    

                case (int)Operations.MULTIPLY:
                return firstVal * secondVal;

                case (int)Operations.DIVIDE:
                if (secondVal == 0){return null;}
                return (firstVal / secondVal);

            }
            
        }
    }
}
