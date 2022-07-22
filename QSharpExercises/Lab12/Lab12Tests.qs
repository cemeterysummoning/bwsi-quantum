// Tests for Lab 7: Bernstein-Vazirani Algorithm

namespace QSharpExercises.Tests.BonusLab12 {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Random;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Logical;

    open QSharpExercises.BonusLab12;


    @Test("QuantumSimulator")
    operation Exercise1Test () : Unit {
        mutable secretArrayArray = [[0,0,0],[0,0,1],[0,1,0],[1,0,0],[1,1,0],[1,1,1]];

        for secretArray in secretArrayArray {
            use (input, output) = (Qubit[3], Qubit());
            ApplyToEach(H, input);
            H(output);

            Exercise1(secretArray, input, output);

            for i in 0..Length(input)-1 {
              if(secretArray[i]==1){CX(input[i], output);}
            }
            H(output);
            ApplyToEach(H, input);

            AssertAllZero(input + [output]);
        }
    }

    @Test("QuantumSimulator")
    operation Exercise2Test () : Unit {
        mutable secretArrayArray = [[0,0,0],[0,0,1],[0,1,0],[1,0,0],[1,1,0],[1,1,1]];
        for secretArray in secretArrayArray{
            let retString = Exercise2(3,Exercise1(secretArray,_,_));
            if not EqualA(EqualI, secretArray,retString){
                fail $"Incorrectly guessed {retString} and not {secretArray}.";
            }
        } 
    }
}
