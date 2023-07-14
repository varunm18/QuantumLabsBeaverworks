//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MITRE.QSD.L04\",\"Name\":\"E01_SuperdenseEncode\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/varun/do-not-modify/L04/L04.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"buffer\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pairA\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you will take on the role of the \\\"sender\\\" in the\",\" superdense coding protocol. You will encode a classical message into a\",\" pair of entangled qubits. The system has already entangled the two\",\" qubits together into the 1/√2(|00> + |11>) state and sent one of the\",\" qubits to the remote receiver. You are given a classical buffer with\",\" two bits in it, and the other remaining qubit. Your goal is to encode\",\" both of the classical bits into the entangled qubit pair using only\",\" single-qubit gates on the provided \\\"sender\\\" qubit.\",\"\",\" # Input\",\" ## buffer\",\" An array of two classical bits, where false represents 0, and true\",\" represents 1.\",\"\",\" ## pairA\",\" A qubit that is entangled with another qubit in the state\",\" 1/√2(|00> + |11>).\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MITRE.QSD.L04\",\"Name\":\"E01_SuperdenseEncode\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/varun/do-not-modify/L04/L04.qs\",\"Position\":{\"Item1\":29,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MITRE.QSD.L04\",\"Name\":\"E02_SuperdenseDecode\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Transparent\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/varun/do-not-modify/L04/L04.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pairA\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pairB\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you will take on the role of the \\\"receiver\\\" in the\",\" superdense coding protocol. The sender has sent a pair of entangled\",\" qubits to you and encoded two bits of classical data in them. The\",\" system has received the two qubits, and has presented them here for\",\" you to process. The state of the qubits is unknown, but it should be\",\" in one of the states that you created with your encoding operation\",\" above. Your goal is to recover the two classical bits that are encoded\",\" in the qubits, and return them in a classical buffer.\",\"\",\" # Input\",\" ## pairA\",\" One of the qubits in the entangled pair.\",\"\",\" ## pairB\",\" The other qubit in the entangled pair.\",\"\",\" # Output\",\" A classical bit array containing the two bits that were encoded in the\",\" entangled pair. Use false for 0 and true for 1.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MITRE.QSD.L04\",\"Name\":\"E02_SuperdenseDecode\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/varun/do-not-modify/L04/L04.qs\",\"Position\":{\"Item1\":61,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":31}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MITRE.QSD.L04\",\"Name\":\"E03_BB84PartyA\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/varun/do-not-modify/L04/L04.qs\",\"Position\":{\"Item1\":102,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aPublic\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aSecret\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bPublic\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":9},\"Item2\":{\"Line\":4,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":5,\"Column\":9},\"Item2\":{\"Line\":5,\"Column\":14}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"Bool\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you will take on the role of the first party in the\",\" BB84 protocol. (This is the QKD scheme discussed in lecture.) To make\",\" the operation easier to test, the random bits used in the protocol are\",\" given. Your goal is to encode A's public and secret bits into a qubit\",\" and determine whether the secret bit can be used or must be thrown away\",\" based on B's public bit.\",\"\",\" # Input\",\" ## aPublic\",\" The random bit you generated that will be shared with the other party.\",\"\",\" ## aSecret\",\" The random bit you generated that will not be shared directly with the\",\" other party, but may or may not be used as a shared secret based on the\",\" value of bPublic.\",\"\",\" ## bPublic\",\" The random bit generated by the other party and shared with you.\",\"\",\" ## qubit\",\" The qubit used to encode aPublic and aSecret.\",\"\",\" # Output\",\" A Boolean value that is true if the secret bit can be used and false if\",\" it must be thrown away.\",\"\",\" # Remarks\",\" In a real implementation of the protocol, bPublic would not be shared\",\" until after the qubit is measured.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MITRE.QSD.L04\",\"Name\":\"E03_BB84PartyA\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/varun/do-not-modify/L04/L04.qs\",\"Position\":{\"Item1\":102,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MITRE.QSD.L04\",\"Name\":\"E04_BB84PartyB\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Transparent\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ubuntu/varun/do-not-modify/L04/L04.qs\",\"Position\":{\"Item1\":140,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"aPublic\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bPublic\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubit\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":4,\"Column\":9},\"Item2\":{\"Line\":4,\"Column\":14}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you will take on the role of the second party in the\",\" BB84 protocol. Your goal is to attempt to decode A's secret bit and\",\" determine whether the it can be used or must be thrown away based on\",\" A's public bit.\",\"\",\" # Input\",\" ## aPublic\",\" The random bit generated by the other party and shared with you.\",\"\",\" ## bPublic\",\" The random bit you generated that will be shared with the other party.\",\"\",\" ## qubit\",\" The qubit you will attempt to decode.\",\"\",\" # Output\",\" A tuple of two Boolean values. The first value is true or false based\",\" on whether the secret bit you decoded is a 1 or 0. The second value is\",\" true if the secret bit can be used and false if it must be thrown away.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MITRE.QSD.L04\",\"Name\":\"E04_BB84PartyB\"},\"Attributes\":[],\"SourceFile\":\"/home/ubuntu/varun/do-not-modify/L04/L04.qs\",\"Position\":{\"Item1\":140,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace MITRE.QSD.L04
{
    [SourceLocation("/home/ubuntu/varun/do-not-modify/L04/L04.qs", OperationFunctor.Body, 30, 62)]
    public partial class E01_SuperdenseEncode : Operation<(IQArray<Boolean>,Qubit), QVoid>, ICallable
    {
        public E01_SuperdenseEncode(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Boolean>,Qubit)>, IApplyData
        {
            public In((IQArray<Boolean>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "E01_SuperdenseEncode";
        String ICallable.FullName => "MITRE.QSD.L04.E01_SuperdenseEncode";
        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__Z
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<(IQArray<Boolean>,Qubit), QVoid> __Body__ => (__in__) =>
        {
            var (buffer,pairA) = __in__;
#line 32 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            if (buffer[0L])
            {
#line 33 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
                Microsoft__Quantum__Intrinsic__Z.Apply(pairA);
            }

#line 36 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            if (buffer[1L])
            {
#line 37 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(pairA);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__Z = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.Z));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__((IQArray<Boolean>,Qubit) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Boolean> buffer, Qubit pairA)
        {
            return __m__.Run<E01_SuperdenseEncode, (IQArray<Boolean>,Qubit), QVoid>((buffer, pairA));
        }
    }

    [SourceLocation("/home/ubuntu/varun/do-not-modify/L04/L04.qs", OperationFunctor.Body, 62, 103)]
    public partial class E02_SuperdenseDecode : Operation<(Qubit,Qubit), IQArray<Boolean>>, ICallable
    {
        public E02_SuperdenseDecode(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "E02_SuperdenseDecode";
        String ICallable.FullName => "MITRE.QSD.L04.E02_SuperdenseDecode";
        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, IQArray<Boolean>> Microsoft__Quantum__Convert__ResultArrayAsBoolArray
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit), IQArray<Boolean>> __Body__ => (__in__) =>
        {
            var (pairA,pairB) = __in__;
#line 64 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            Microsoft__Quantum__Intrinsic__CNOT.Apply((pairA, pairB));
#line 65 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            Microsoft__Quantum__Intrinsic__H.Apply(pairA);
#line 67 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            var res = (IQArray<Result>)new QArray<Result>(Microsoft__Quantum__Intrinsic__M.Apply(pairA), Microsoft__Quantum__Intrinsic__M.Apply(pairB));
#line 68 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            var buffer = (IQArray<Boolean>)Microsoft__Quantum__Convert__ResultArrayAsBoolArray.Apply(res);
#line 69 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            return buffer;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Microsoft__Quantum__Convert__ResultArrayAsBoolArray = this.__Factory__.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(global::Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
        }

        public override IApplyData __DataIn__((Qubit,Qubit) data) => new In(data);
        public override IApplyData __DataOut__(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, Qubit pairA, Qubit pairB)
        {
            return __m__.Run<E02_SuperdenseDecode, (Qubit,Qubit), IQArray<Boolean>>((pairA, pairB));
        }
    }

    [SourceLocation("/home/ubuntu/varun/do-not-modify/L04/L04.qs", OperationFunctor.Body, 103, 141)]
    public partial class E03_BB84PartyA : Operation<(Boolean,Boolean,Boolean,Qubit), Boolean>, ICallable
    {
        public E03_BB84PartyA(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Boolean,Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Boolean,Boolean,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item4;
                }
            }
        }

        String ICallable.Name => "E03_BB84PartyA";
        String ICallable.FullName => "MITRE.QSD.L04.E03_BB84PartyA";
        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        public override Func<(Boolean,Boolean,Boolean,Qubit), Boolean> __Body__ => (__in__) =>
        {
            var (aPublic,aSecret,bPublic,qubit) = __in__;
#line 109 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            if (aSecret)
            {
#line 110 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
                Microsoft__Quantum__Intrinsic__X.Apply(qubit);
            }

#line 113 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            if (aPublic)
            {
#line 114 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
                Microsoft__Quantum__Intrinsic__H.Apply(qubit);
            }

#line 117 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            return (aPublic == bPublic);
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __DataIn__((Boolean,Boolean,Boolean,Qubit) data) => new In(data);
        public override IApplyData __DataOut__(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Boolean aPublic, Boolean aSecret, Boolean bPublic, Qubit qubit)
        {
            return __m__.Run<E03_BB84PartyA, (Boolean,Boolean,Boolean,Qubit), Boolean>((aPublic, aSecret, bPublic, qubit));
        }
    }

    [SourceLocation("/home/ubuntu/varun/do-not-modify/L04/L04.qs", OperationFunctor.Body, 141, -1)]
    public partial class E04_BB84PartyB : Operation<(Boolean,Boolean,Qubit), (Boolean,Boolean)>, ICallable
    {
        public E04_BB84PartyB(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Boolean,Boolean,Qubit)>, IApplyData
        {
            public In((Boolean,Boolean,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item3;
                }
            }
        }

        public class Out : QTuple<(Boolean,Boolean)>, IApplyData
        {
            public Out((Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "E04_BB84PartyB";
        String ICallable.FullName => "MITRE.QSD.L04.E04_BB84PartyB";
        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> Microsoft__Quantum__Convert__ResultAsBool
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        public override Func<(Boolean,Boolean,Qubit), (Boolean,Boolean)> __Body__ => (__in__) =>
        {
            var (aPublic,bPublic,qubit) = __in__;
#line 146 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            if (bPublic)
            {
#line 147 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
                Microsoft__Quantum__Intrinsic__H.Apply(qubit);
            }

#line 150 "/home/ubuntu/varun/do-not-modify/L04/L04.qs"
            return (Microsoft__Quantum__Convert__ResultAsBool.Apply(Microsoft__Quantum__Intrinsic__M.Apply(qubit)), (aPublic == bPublic));
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Convert__ResultAsBool = this.__Factory__.Get<ICallable<Result, Boolean>>(typeof(global::Microsoft.Quantum.Convert.ResultAsBool));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __DataIn__((Boolean,Boolean,Qubit) data) => new In(data);
        public override IApplyData __DataOut__((Boolean,Boolean) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Boolean,Boolean)> Run(IOperationFactory __m__, Boolean aPublic, Boolean bPublic, Qubit qubit)
        {
            return __m__.Run<E04_BB84PartyB, (Boolean,Boolean,Qubit), (Boolean,Boolean)>((aPublic, bPublic, qubit));
        }
    }
}