﻿namespace knockknock.readify.net
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Error = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Equilateral = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Isosceles = 2,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scalene = 3,
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace = "http://KnockKnock.readify.net",
    ConfigurationName = "IRedPill")]
public interface IRedPill
{
    [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken",ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
    System.Guid WhatIsYourToken();

    [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber",ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException),
        Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +"Fault", Name = "ArgumentOutOfRangeException",
        Namespace = "http://schemas.datacontract.org/2004/07/System")]
    long FibonacciNumber(long n);

    [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis",ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
    knockknock.readify.net.TriangleType WhatShapeIsThis(int a, int b, int c);

    [System.ServiceModel.OperationContractAttribute(Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords",ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException),Action = "http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault",Name = "ArgumentNullException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
    string ReverseWords(string s);
}
