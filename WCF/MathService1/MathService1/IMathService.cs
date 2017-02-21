using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathService1
{
    // Leave this here for now
    [ServiceContract]
    public interface IMathService
    {
        //basic operations that I want to provide for my service
        [OperationContract]
        Int32 Add(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Subtract(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Multiply(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Divide(Int32 num1, Int32 num2);

        [OperationContract]
        Int32 Sin(Int32 num1, Int32 num2);


    }
}
