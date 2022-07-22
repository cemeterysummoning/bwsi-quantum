// Bonus Lab 12: Bernstein-Vazirani Algorithm

namespace QSharpExercises.BonusLab12 {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Measurement;

    /// # Summary
    /// In this exercise, you are given a secret string, s, a register with an unknown number of
    /// qubits, in an unknown state, and an output qubit.
    /// Your goal is to construct an oracle that will flip the
    /// output qubit if the bitwise dot product of s and the input is register 1
    ///
    /// For example, if the register was in the state |101> and s=[1,1,1],
    ///then you would not filp the output since (1*1)XOR(0*1)XOR(1*1)=0
    /// 
    /// # Input
    /// ## secretArray
    /// A binary string indicating the secret vector to btiwise dot product with.
    /// Given as an integer array of 1s and 0s
    ///
    /// ## input
    /// A register of qubits in an unknown state. It could be in an arbitrary
    /// superposition.
    /// 
    /// ## output
    /// An output qubit that you must flip if the oracle's conditions are met.
    operation Exercise1 (secretArray : Int[] , input : Qubit[], output : Qubit) : Unit {

        // TODO
        // fail "Not implemented.";

        for i in 0 .. Length(secretArray) - 1 {
            if (secretArray[i] == 1) {
                CNOT(input[i], output);
            }
        }
    }

    /// # Summary
    /// In this exercise, you will implement the Bernstein-Vazirani algorithm.
    /// 
    /// # Input
    /// ## inputLength
    /// The number of qubits that the oracle expects the input register to
    /// contain. You must allocate a register with this many qubits to provide
    /// to the oracle.
    /// 
    /// ## oracle
    /// An operation that represents some quantum function. It will take in an
    /// input register (that must be in the |+...+> state) and an output qubit.
    /// 
    /// # Output
    /// You should return the secret string as an integer array
    operation Exercise2 (
        inputLength : Int,
        oracle : ((Qubit[], Qubit) => Unit)
    ) : Int[] {

        // TODO
        // fail "Not implemented.";
        use (inputs, output) = (Qubit[inputLength], Qubit());
        X(output);
        ApplyToEach(H, inputs + [output]);
        oracle(inputs, output);
        ApplyToEach(H, inputs + [output]);

        mutable measurements = [];

        for i in 0 .. inputLength - 1 {
            set measurements += [(M(inputs[i]) == One ? 1 | 0)];
        }
        ResetAll(inputs + [output]);
        return measurements;
    }
}
