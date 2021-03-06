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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QSharpExercises.BonusLab12\",\"Name\":\"Exercise1\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Empty\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"secretArray\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":67}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you are given a secret string, s, a register with an unknown number of\",\" qubits, in an unknown state, and an output qubit.\",\" Your goal is to construct an oracle that will flip the\",\" output qubit if the bitwise dot product of s and the input is register 1\",\"\",\" For example, if the register was in the state |101> and s=[1,1,1],\",\"then you would not filp the output since (1*1)XOR(0*1)XOR(1*1)=0\",\"\",\" # Input\",\" ## secretArray\",\" A binary string indicating the secret vector to btiwise dot product with.\",\" Given as an integer array of 1s and 0s\",\"\",\" ## input\",\" A register of qubits in an unknown state. It could be in an arbitrary\",\" superposition.\",\"\",\" ## output\",\" An output qubit that you must flip if the oracle's conditions are met.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QSharpExercises.BonusLab12\",\"Name\":\"Exercise1\"},\"Attributes\":[],\"SourceFile\":\"/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs\",\"Position\":{\"Item1\":28,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QSharpExercises.BonusLab12\",\"Name\":\"Exercise2\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Transparent\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"inputLength\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":2,\"Column\":9},\"Item2\":{\"Line\":2,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"oracle\"]},\"Type\":{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":3,\"Column\":9},\"Item2\":{\"Line\":3,\"Column\":15}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Operation\",\"Fields\":[{\"Item1\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"}]]},\"Item2\":{\"Case\":\"UnitType\"}},{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" In this exercise, you will implement the Bernstein-Vazirani algorithm.\",\"\",\" # Input\",\" ## inputLength\",\" The number of qubits that the oracle expects the input register to\",\" contain. You must allocate a register with this many qubits to provide\",\" to the oracle.\",\"\",\" ## oracle\",\" An operation that represents some quantum function. It will take in an\",\" input register (that must be in the |+...+> state) and an output qubit.\",\"\",\" # Output\",\" You should return the secret string as an integer array\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QSharpExercises.BonusLab12\",\"Name\":\"Exercise2\"},\"Attributes\":[],\"SourceFile\":\"/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
#line hidden
namespace QSharpExercises.BonusLab12
{
    [SourceLocation("/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs", OperationFunctor.Body, 29, 56)]
    public partial class Exercise1 : Operation<(IQArray<Int64>,IQArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Exercise1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Int64>,IQArray<Qubit>,Qubit)>, IApplyData
        {
            public In((IQArray<Int64>,IQArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return Qubit.Concat(((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
                }
            }
        }

        String ICallable.Name => "Exercise1";
        String ICallable.FullName => "QSharpExercises.BonusLab12.Exercise1";
        protected ICallable Length__
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Int64>,IQArray<Qubit>,Qubit), QVoid> __Body__ => (__in__) =>
        {
            var (secretArray,input,output) = __in__;
#line 34 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
            foreach (var i in new QRange(0L, (secretArray.Length - 1L)))
#line hidden
            {
#line 35 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                if ((secretArray[i] == 1L))
                {
#line 36 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    Microsoft__Quantum__Intrinsic__CNOT.Apply((input[i], output));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __DataIn__((IQArray<Int64>,IQArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Int64> secretArray, IQArray<Qubit> input, Qubit output)
        {
            return __m__.Run<Exercise1, (IQArray<Int64>,IQArray<Qubit>,Qubit), QVoid>((secretArray, input, output));
        }
    }

    [SourceLocation("/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs", OperationFunctor.Body, 56, -1)]
    public partial class Exercise2 : Operation<(Int64,ICallable), IQArray<Int64>>, ICallable
    {
        public Exercise2(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return ((IApplyData)Data.Item2)?.Qubits;
                }
            }
        }

        String ICallable.Name => "Exercise2";
        String ICallable.FullName => "QSharpExercises.BonusLab12.Exercise2";
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected ICallable Microsoft__Quantum__Canon__ApplyToEach
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

        protected ICallable<IQArray<Qubit>, QVoid> ResetAll__
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), IQArray<Int64>> __Body__ => (__in__) =>
        {
            var (inputLength,oracle) = __in__;
#line hidden
            {
#line 63 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                var (inputs,output) = (Allocate__.Apply(inputLength), Allocate__.Apply());
#line hidden
                bool __arg1__ = true;
                try
                {
#line 64 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    Microsoft__Quantum__Intrinsic__X.Apply(output);
#line 65 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, QArray<Qubit>.Add(inputs, new QArray<Qubit>(output))));
#line 66 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    oracle.Apply((inputs, output));
#line 67 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    Microsoft__Quantum__Canon__ApplyToEach.Apply((Microsoft__Quantum__Intrinsic__H, QArray<Qubit>.Add(inputs, new QArray<Qubit>(output))));
#line 69 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    var measurements = new QArray<Int64>();
#line 71 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    foreach (var i in new QRange(0L, (inputLength - 1L)))
#line hidden
                    {
#line 72 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                        measurements = QArray<Int64>.Add(measurements, new QArray<Int64>(((Microsoft__Quantum__Intrinsic__M.Apply(inputs[i]) == Result.One) ? 1L : 0L)));
                    }

#line 74 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    ResetAll__.Apply(QArray<Qubit>.Add(inputs, new QArray<Qubit>(output)));
#line 75 "/home/ace/scripts/quantum/QSharpExercises/Lab12/Lab12.qs"
                    return measurements;
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(inputs);
#line hidden
                        Release__.Apply(output);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Canon__ApplyToEach = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Canon.ApplyToEach<>));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.ResetAll__ = this.__Factory__.Get<ICallable<IQArray<Qubit>, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.ResetAll));
        }

        public override IApplyData __DataIn__((Int64,ICallable) data) => new In(data);
        public override IApplyData __DataOut__(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 inputLength, ICallable oracle)
        {
            return __m__.Run<Exercise2, (Int64,ICallable), IQArray<Int64>>((inputLength, oracle));
        }
    }
}