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
        static void Main(string[] args)
        {
            
            var calculatedValue = CalculateOp(Operations.ADD,1,2);
            Console.WriteLine(calculatedValue);
        
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
