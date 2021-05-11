﻿//-----------------------------------------------------------------------
//
// THE SOFTWARE IS PROVIDED "AS IS" WITHOUT ANY WARRANTIES OF ANY KIND, EXPRESS, IMPLIED, STATUTORY, 
// OR OTHERWISE. EXPECT TO THE EXTENT PROHIBITED BY APPLICABLE LAW, DIGI-KEY DISCLAIMS ALL WARRANTIES, 
// INCLUDING, WITHOUT LIMITATION, ANY IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE, 
// SATISFACTORY QUALITY, TITLE, NON-INFRINGEMENT, QUIET ENJOYMENT, 
// AND WARRANTIES ARISING OUT OF ANY COURSE OF DEALING OR USAGE OF TRADE. 
// 
// DIGI-KEY DOES NOT WARRANT THAT THE SOFTWARE WILL FUNCTION AS DESCRIBED, 
// WILL BE UNINTERRUPTED OR ERROR-FREE, OR FREE OF HARMFUL COMPONENTS.
// 
//-----------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace ApiClient.ConsoleApp
{
    [Serializable]
    internal class MyApplicationIsNotAuthorizedException : System.Exception
    {
        public MyApplicationIsNotAuthorizedException()
        {
        }

        public MyApplicationIsNotAuthorizedException(string message) : base(message)
        {
        }

        public MyApplicationIsNotAuthorizedException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected MyApplicationIsNotAuthorizedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}