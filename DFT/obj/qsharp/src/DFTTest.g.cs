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

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DFT\",\"Name\":\"DFTTest\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Diagnostics\",\"Name\":\"Test\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":6}}]},\"Argument\":{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"QuantumSimulator\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":7},\"Item2\":{\"Line\":1,\"Column\":25}}]}},\"Offset\":{\"Item1\":10,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}},{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ace/scripts/quantum/DFT/DFTTest.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DFT\",\"Name\":\"DFTTest\"},\"Attributes\":[],\"SourceFile\":\"/home/ace/scripts/quantum/DFT/DFTTest.qs\",\"Position\":{\"Item1\":11,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"DFT\",\"Name\":\"Solution\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Targeting\",\"Name\":\"RequiresCapability\",\"Range\":{\"Case\":\"Null\"}}]},\"TypeIdRange\":{\"Case\":\"Null\"},\"Argument\":{\"Item1\":{\"Case\":\"ValueTuple\",\"Fields\":[[{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Opaque\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Full\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},{\"Item1\":{\"Case\":\"StringLiteral\",\"Fields\":[\"Inferred automatically by the compiler.\",[]]},\"Item2\":[],\"Item3\":{\"Case\":\"String\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}}]]},\"Item2\":[],\"Item3\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"String\"},{\"Case\":\"String\"},{\"Case\":\"String\"}]]},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Null\"}},\"Offset\":{\"Item1\":0,\"Item2\":0},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"/home/ace/scripts/quantum/DFT/DFTTest.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Math\",\"Name\":\"ComplexPolar\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":36}}]}}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Math\",\"Name\":\"ComplexPolar\",\"Range\":{\"Case\":\"Null\"}}]}]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"UserDefinedType\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Math\",\"Name\":\"ComplexPolar\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":54}}]}}]}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"DFT\",\"Name\":\"Solution\"},\"Attributes\":[],\"SourceFile\":\"/home/ace/scripts/quantum/DFT/DFTTest.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace DFT
{
    [SourceLocation("/home/ace/scripts/quantum/DFT/DFTTest.qs", OperationFunctor.Body, 12, 33)]
    public partial class DFTTest : Operation<QVoid, QVoid>, ICallable
    {
        public DFTTest(IOperationFactory m) : base(m)
        {
        }

        public class QuantumSimulator
        {
            public QuantumSimulator(Xunit.Abstractions.ITestOutputHelper Output)
            {
                this.Output = Output;
            }

            internal Xunit.Abstractions.ITestOutputHelper Output
            {
                get;
            }

            [Xunit.Fact()]
            [Xunit.Trait("Target", "QuantumSimulator")]
            [Xunit.Trait("Name", "DFTTest")]
            public void DFTTest()
#line 12 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            {
                var sim = new Microsoft.Quantum.Simulation.Simulators.QuantumSimulator();
                if (sim is Microsoft.Quantum.Simulation.Common.SimulatorBase baseSim && this.Output != null)
                {
                    baseSim.OnLog += this.Output.WriteLine;
                }

                try
                {
                    sim.Execute<DFTTest, QVoid, QVoid>(QVoid.Instance);
                }
                catch
                {
#line 12 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
                    Xunit.Assert.True(false, "Q# Test failed. For details see the Standard output below.");
                }
                finally
                {
                    if (sim is IDisposable disposeSim)
                    {
                        disposeSim.Dispose();
                    }
                }
            }
        }

        String ICallable.Name => "DFTTest";
        String ICallable.FullName => "DFT.DFTTest";
        protected ICallable<(Double,Double), Microsoft.Quantum.Math.ComplexPolar> Microsoft__Quantum__Math__ComplexPolar
        {
            get;
            set;
        }

        protected ICallable<IQArray<Microsoft.Quantum.Math.ComplexPolar>, IQArray<Microsoft.Quantum.Math.ComplexPolar>> DFT__
        {
            get;
            set;
        }

        protected ICallable<IQArray<Microsoft.Quantum.Math.ComplexPolar>, IQArray<Microsoft.Quantum.Math.ComplexPolar>> Solution__
        {
            get;
            set;
        }

        protected ICallable Length__
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Math.ComplexPolar,Microsoft.Quantum.Math.ComplexPolar), Boolean> Microsoft__Quantum__Logical__EqualCP
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line 14 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            var data = (IQArray<Microsoft.Quantum.Math.ComplexPolar>)new QArray<Microsoft.Quantum.Math.ComplexPolar>(new Microsoft.Quantum.Math.ComplexPolar((1D, 0D)), new Microsoft.Quantum.Math.ComplexPolar((2D, 0D)), new Microsoft.Quantum.Math.ComplexPolar((3D, 0D)), new Microsoft.Quantum.Math.ComplexPolar((4D, 0D)), new Microsoft.Quantum.Math.ComplexPolar((5D, 0D)), new Microsoft.Quantum.Math.ComplexPolar((6D, 0D)), new Microsoft.Quantum.Math.ComplexPolar((7D, 0D)), new Microsoft.Quantum.Math.ComplexPolar((8D, 0D)));
#line 24 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            var DFTData = (IQArray<Microsoft.Quantum.Math.ComplexPolar>)DFT__.Apply(data);
#line 25 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            var checkData = (IQArray<Microsoft.Quantum.Math.ComplexPolar>)Solution__.Apply(data);
#line 26 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            foreach (var i in new QRange(0L, (data.Length - 1L)))
#line hidden
            {
#line 27 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
                if ((Microsoft__Quantum__Logical__EqualCP.Apply((DFTData[i], checkData[i])) == false))
                {
#line 28 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
                    throw new ExecutionFailException("DFT not implemented correctly");
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Math__ComplexPolar = this.__Factory__.Get<ICallable<(Double,Double), Microsoft.Quantum.Math.ComplexPolar>>(typeof(global::Microsoft.Quantum.Math.ComplexPolar));
            this.DFT__ = this.__Factory__.Get<ICallable<IQArray<Microsoft.Quantum.Math.ComplexPolar>, IQArray<Microsoft.Quantum.Math.ComplexPolar>>>(typeof(DFT));
            this.Solution__ = this.__Factory__.Get<ICallable<IQArray<Microsoft.Quantum.Math.ComplexPolar>, IQArray<Microsoft.Quantum.Math.ComplexPolar>>>(typeof(Solution));
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.Microsoft__Quantum__Logical__EqualCP = this.__Factory__.Get<ICallable<(Microsoft.Quantum.Math.ComplexPolar,Microsoft.Quantum.Math.ComplexPolar), Boolean>>(typeof(global::Microsoft.Quantum.Logical.EqualCP));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<DFTTest, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("/home/ace/scripts/quantum/DFT/DFTTest.qs", OperationFunctor.Body, 33, -1)]
    public partial class Solution : Operation<IQArray<Microsoft.Quantum.Math.ComplexPolar>, IQArray<Microsoft.Quantum.Math.ComplexPolar>>, ICallable
    {
        public Solution(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solution";
        String ICallable.FullName => "DFT.Solution";
        protected ICallable Length__
        {
            get;
            set;
        }

        protected ICallable<(Double,Double), Microsoft.Quantum.Math.ComplexPolar> Microsoft__Quantum__Math__ComplexPolar
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Math.ComplexPolar,Microsoft.Quantum.Math.ComplexPolar), Microsoft.Quantum.Math.ComplexPolar> Microsoft__Quantum__Math__TimesCP
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> Microsoft__Quantum__Math__PI
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> Microsoft__Quantum__Convert__IntAsDouble
        {
            get;
            set;
        }

        protected ICallable<(Microsoft.Quantum.Math.ComplexPolar,Microsoft.Quantum.Math.ComplexPolar), Microsoft.Quantum.Math.ComplexPolar> Microsoft__Quantum__Math__PlusCP
        {
            get;
            set;
        }

        public override Func<IQArray<Microsoft.Quantum.Math.ComplexPolar>, IQArray<Microsoft.Quantum.Math.ComplexPolar>> __Body__ => (__in__) =>
        {
            var x = __in__;
#line 34 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            var N = x.Length;
#line 35 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
#line hidden
            var __arg1__ = new Microsoft.Quantum.Math.ComplexPolar((0D, 0D));
#line 35 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            var newx = new QArray<Microsoft.Quantum.Math.ComplexPolar>(QArray.Filled(() => __arg1__, N));
#line 37 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            foreach (var k in new QRange(0L, (N - 1L)))
#line hidden
            {
#line 39 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
                foreach (var n in new QRange(0L, (N - 1L)))
#line hidden
                {
#line 40 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
                    var sum_element = Microsoft__Quantum__Math__TimesCP.Apply((x[n], new Microsoft.Quantum.Math.ComplexPolar((1D, ((((-(2D) * Microsoft__Quantum__Math__PI.Apply(QVoid.Instance)) * Microsoft__Quantum__Convert__IntAsDouble.Apply(k)) * Microsoft__Quantum__Convert__IntAsDouble.Apply(n)) / Microsoft__Quantum__Convert__IntAsDouble.Apply(N))))));
#line 41 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
                    newx.Modify(k, Microsoft__Quantum__Math__PlusCP.Apply((newx[k], sum_element)));
                }
            }

#line 44 "/home/ace/scripts/quantum/DFT/DFTTest.qs"
            return newx;
        }

        ;
        public override void __Init__()
        {
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.Microsoft__Quantum__Math__ComplexPolar = this.__Factory__.Get<ICallable<(Double,Double), Microsoft.Quantum.Math.ComplexPolar>>(typeof(global::Microsoft.Quantum.Math.ComplexPolar));
            this.Microsoft__Quantum__Math__TimesCP = this.__Factory__.Get<ICallable<(Microsoft.Quantum.Math.ComplexPolar,Microsoft.Quantum.Math.ComplexPolar), Microsoft.Quantum.Math.ComplexPolar>>(typeof(global::Microsoft.Quantum.Math.TimesCP));
            this.Microsoft__Quantum__Math__PI = this.__Factory__.Get<ICallable<QVoid, Double>>(typeof(global::Microsoft.Quantum.Math.PI));
            this.Microsoft__Quantum__Convert__IntAsDouble = this.__Factory__.Get<ICallable<Int64, Double>>(typeof(global::Microsoft.Quantum.Convert.IntAsDouble));
            this.Microsoft__Quantum__Math__PlusCP = this.__Factory__.Get<ICallable<(Microsoft.Quantum.Math.ComplexPolar,Microsoft.Quantum.Math.ComplexPolar), Microsoft.Quantum.Math.ComplexPolar>>(typeof(global::Microsoft.Quantum.Math.PlusCP));
        }

        public override IApplyData __DataIn__(IQArray<Microsoft.Quantum.Math.ComplexPolar> data) => data;
        public override IApplyData __DataOut__(IQArray<Microsoft.Quantum.Math.ComplexPolar> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Microsoft.Quantum.Math.ComplexPolar>> Run(IOperationFactory __m__, IQArray<Microsoft.Quantum.Math.ComplexPolar> x)
        {
            return __m__.Run<Solution, IQArray<Microsoft.Quantum.Math.ComplexPolar>, IQArray<Microsoft.Quantum.Math.ComplexPolar>>(x);
        }
    }
}