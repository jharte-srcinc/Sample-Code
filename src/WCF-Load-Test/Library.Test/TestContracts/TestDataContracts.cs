﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     This file is not actually autogenerated, but this header is used to suppress StyleCop errors about multiple classes in a file as
//     there are a lot of small test contracts that are not worth splitting into separate files.
// </auto-generated>
//------------------------------------------------------------------------------

//---------------------------------------------------------------------
// <copyright file="TestDataContracts.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
//     THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
//     OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
//     LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR
//     FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>
// <summary>The test data contract types.</summary>
//---------------------------------------------------------------------

namespace Microsoft.WcfUnit.Library.Test.TestContracts
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data;
    using System.IO;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Xml;
    using System.Xml.Serialization;

    public enum TestEnum
    {
        One,
        Two,
        Three
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1815:OverrideEqualsAndOperatorEqualsOnValueTypes", Justification = "Just testing contracts with structs, don't need to deal with equality here.")]
    [DataContract]
    public struct CustomValueType
    {
        [DataMember]
        public int A;
        [DataMember]
        public int B;
    }

    public class NonDataContractClass
    {
    }

    [DataContract]
    public class ClassWithSerializableMemberOfNonSerializableType
    {
        [DataMember]
        public NonDataContractClass NonSerializableTypeMember;
    }

    [MessageContract]
    public class WithMessageContractButNoneInside
    {
        [MessageBodyMember]
        public NonDataContractClass NoContract;
    }

    [DataContract]
    public class SimpleCompoundTypeDataContract
    {
        [DataMember]
        public decimal Field1;

        [DataMember]
        public string Field2;

        public string Nonmember;

        private string property1;

        private int property2;

        [DataMember]
        public string Property1
        {
            get { return this.property1; }
            set { this.property1 = value; }
        }

        [DataMember]
        public int Property2
        {
            get { return this.property2; }
            set { this.property2 = value; }
        }

        public string Property3
        {
            get
            {
                return string.Empty;
            }
        }
    }

    [MessageContract]
    public class SimpleCompoundTypeMessageContract
    {
        [MessageBodyMember]
        public decimal Field1;

        [MessageBodyMember]
        public string Field2;

        public string Nonmember;

        private string property1;

        private int property2;

        [MessageHeader]
        public string Property1
        {
            get { return this.property1; }
            set { this.property1 = value; }
        }

        [MessageBodyMember]
        public int Property2
        {
            get { return this.property2; }
            set { this.property2 = value; }
        }
    }

    public class SimpleCompoundTypeNoContract
    {
        public string A;
    }

    [DataContract]
    public class NestedCompoundType
    {
        public SimpleCompoundTypeNoContract ShouldIgnore;

        private SimpleCompoundTypeDataContract compound1;

        private SimpleCompoundTypeDataContract compound2;

        [DataMember]
        public SimpleCompoundTypeDataContract Compound1
        {
            get { return this.compound1; }
            set { this.compound1 = value; }
        }

        [DataMember]
        public SimpleCompoundTypeDataContract Compound2
        {
            get { return this.compound2; }
            set { this.compound2 = value; }
        }
    }

    [DataContract]
    public class CompoundWithArrayType
    {
        [DataMember]
        public int[] Arr;
    }

    [DataContract]
    public class CyclicStructure
    {
        [DataMember]
        public CyclicStructure BackRef;
    }

    [DataContract]
    public class CompoundTypeWithXmlElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1059:MembersShouldNotExposeCertainConcreteTypes", MessageId = "System.Xml.XmlNode", Justification = "Test is for XmlElement")]
        [DataMember]
        public XmlElement Element;
    }

    [DataContract]
    public class CompoundTypeWithXmlNodeArray
    {
        [DataMember]
        public XmlNode[] Nodes;
    }

    [DataContract]
    public class CompoundWithGenericSimpleCollection
    {
        [DataMember]
        public Collection<int> Arr;
    }

    [DataContract]
    public class CompoundWithGenericSimpleICollection
    {
        [DataMember]
        public ICollection<int> Arr;
    }

    [DataContract]
    public class CompoundWithGenericCompoundCollection
    {
        [DataMember]
        public Collection<SimpleCompoundTypeDataContract> Arr;
    }

    [DataContract]
    public class CompoundWithGenericCompoundICollection
    {
        [DataMember]
        public ICollection<SimpleCompoundTypeDataContract> Arr;
    }

    [DataContract]
    public class CompoundWithGenericSimpleDictionary
    {
        [DataMember]
        public Dictionary<string, int> D;
    }

    [DataContract]
    public class CompoundWithGenericSimpleIDictionary
    {
        [DataMember]
        public IDictionary<string, int> D;
    }

    [DataContract]
    public class CompoundWithGenericCompoundDictionary
    {
        [DataMember]
        public Dictionary<string, SimpleCompoundTypeDataContract> D;
    }

    [DataContract]
    public class CompoundWithGenericCompoundBothSidesDictionary
    {
        [DataMember]
        public Dictionary<SimpleCompoundTypeDataContract, SimpleCompoundTypeDataContract> D;
    }

    [DataContract]
    public class CompoundWithRecursiveDictionary
    {
        [DataMember]
        public Dictionary<string, CompoundWithRecursiveDictionary> D;
    }

    public class NonGenericEnumerableOnlyCollection : IEnumerable
    {
        private ArrayList array = new ArrayList();

        public void Add(object o)
        {
            this.array.Add(o);
        }
        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return this.array.GetEnumerator();
        }

        #endregion
    }

    [DataContract]
    public class CompoundContainingNonGenericEnumerableOnlyCollection
    {
        [DataMember]
        public NonGenericEnumerableOnlyCollection Arr;
    }

    [DataContract]
    public class CompoundContainingNonGenericDictionary
    {
        [DataMember]
        public Hashtable Arr;
    }

    [DataContract]
    public class CompoundContainingArrayList
    {
        [DataMember]
        public ArrayList Arr;
    }

    [MessageContract]
    public class NestedStreamMessageContract
    {
        [MessageHeader]
        public int Header;

        [MessageBodyMember]
        public Stream Body;
    }

    [MessageContract]
    public class NestedMemoryStreamMessageContract
    {
        [MessageHeader]
        public int Header;

        [MessageBodyMember]
        public MemoryStream Body;
    }

    public class GenericListWrapper : List<SimpleCompoundTypeDataContract>
    {
    }

    public class GenericListWrapperWithOtherMembers : List<SimpleCompoundTypeDataContract>
    {
        private int property;

        [DataMember]
        public int Property
        {
            get { return this.property; }
            set { this.property = value; }
        }
    }

    public class GenericListWrapperWithNestedWrapperThatHasOtherMembers : List<SimpleCompoundTypeDataContract>
    {
        private GenericListWrapperWithOtherMembers nested;

        [DataMember]
        public GenericListWrapperWithOtherMembers Nested
        {
            get { return this.nested; }
            set { this.nested = value; }
        }
    }

    public class GenericDictionaryWrapper : Dictionary<string, SimpleCompoundTypeDataContract>
    {
    }

    public class GenericDictionaryWrapperWithOtherMembers : Dictionary<string, SimpleCompoundTypeDataContract>
    {
        private int property;

        [DataMember]
        public int Property
        {
            get { return this.property; }
            set { this.property = value; }
        }
    }

    public class GenericDictionaryWrapperWithNestedWrapperThatHasOtherMembers : Dictionary<string, SimpleCompoundTypeDataContract>
    {
        private GenericDictionaryWrapperWithOtherMembers nested;

        [DataMember]
        public GenericDictionaryWrapperWithOtherMembers Nested
        {
            get { return this.nested; }
            set { this.nested = value; }
        }
    }

    [DataContract]
    [KnownType(typeof(DerivedClass1Contract))]
    [KnownType(typeof(DerivedClass2Contract))]
    public class BaseClassContract
    {
        [DataMember]
        public int A;
    }

    [DataContract]
    public class DerivedClass1Contract : BaseClassContract
    {
        [DataMember]
        public int A1;
    }

    [DataContract]
    public class DerivedClass2Contract : BaseClassContract
    {
        [DataMember]
        public int A2;
    }

    [DataContract]
    public class DerivedClass3NoContract : BaseClassContract
    {
        [DataMember]
        public int A3;
    }

    [DataContract]
    public class CompoundClassContainingADerivedClass
    {
        [DataMember]
        public BaseClassContract A1;
    }

    public class AsmxIgnoreFields
    {
        public int OptionalField;

        [XmlIgnore]
        public bool OptionalFieldSpecified;

        [XmlIgnore]
        public bool OptionalPropertySpecified;

        [XmlIgnore]
        public bool NonOptionalFieldSpecified;

        [XmlIgnore]
        public string AlwaysIgnored { get; set; }

        public int OptionalProperty { get; set; }

        [XmlIgnore]
        public virtual string IgnoredBase { get; set; }

        [XmlIgnore]
        public virtual string IgnoredBaseOverridden { get; set; }
    }

    public class AsmxIgnoreFieldsDerived : AsmxIgnoreFields
    {
        public override string IgnoredBaseOverridden { get; set; }
    }

    [XmlInclude(typeof(DerivedClass1Asmx))]
    public class BaseClassAsmx
    {
        public int A;
    }

    public class DerivedClass1Asmx : BaseClassAsmx
    {
        public int A1;
    }

    [DataContract]
    public class CompoundContainingDataSet
    {
        [DataMember]
        public DataSet Data { get; set; }
    }

    [DataContract]
    public class CompoundContainingDataSets
    {
        [DataMember]
        public DataSet Data1 { get; set; }

        [DataMember]
        public DataSet Data2 { get; set; }
    }

    [DataContract]
    public class CompoundContainingTypedDataSet
    {
        [DataMember]
        public TypedDataSet Data { get; set; }
    }
}
