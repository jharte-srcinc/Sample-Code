﻿// -----------------------------------------------------------------------
// <copyright file="WithMessageContractButNoneInside.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Microsoft.WcfUnit.Library.Test
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data;
    using System.IO;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>Summary description for <see cref="WithMessageContractButNoneInside"/> class.</summary>
    [MessageContract]
    public class WithMessageContractButNoneInside
    {
        /// <summary>Summary description for class level field of type <c>Microsoft.WcfUnit.Library.Test.NonDataContractClass</c>.</summary>
        [MessageBodyMember]
        private NonDataContractClass NoContract;
    }
}
