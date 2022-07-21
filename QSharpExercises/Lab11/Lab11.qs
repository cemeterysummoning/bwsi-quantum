// Lab 11: Steane's Error Correction Code
// Copyright 2021 The MITRE Corporation. All Rights Reserved.

namespace QSharpExercises.Lab11 {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;


    /// # Summary
    /// In this exercise, you are provided with an original qubit in an
    /// unknown state a|0> + b|1>. You are also provided with 6 blank qubits,
    /// all of which are in the |0> state. Your goal is to construct a
    /// "logical qubit" from these 7 qubits that acts like a single qubit, but
    /// can protect against a single bit-flip error and a single phase-flip
    /// error on any of the actual qubits. The bit-flip and phase-flip may be
    /// on different qubits.
    /// 
    /// # Input
    /// ## original
    /// A qubit that you want to protect from bit flips. It will be in the
    /// state a|0> + b|1>.
    /// 
    /// ## spares
    /// A register of 6 spare qubits that you can use to add error correction
    /// to the original qubit. All of them are in the |0> state.
    operation Exercise1 (original : Qubit, spares : Qubit[]) : Unit
    is Adj {
        // TODO
        // fail "Not implemented.";
        H(spares[3]); 
        H(spares[4]);
        H(spares[5]);

        CNOT(original, spares[0]);
        CNOT(original, spares[1]);

        CNOT(spares[5], spares[2]);
        CNOT(spares[5], spares[0]);
        CNOT(spares[5], original);

        CNOT(spares[4], spares[2]);
        CNOT(spares[4], spares[1]);
        CNOT(spares[4], original);

        CNOT(spares[3], spares[2]);
        CNOT(spares[3], spares[1]);
        CNOT(spares[3], spares[0]);
    }


    /// # Summary
    /// In this exercise, you are provided with a logical qubit, represented
    /// by an error-protected register that was encoded with your Exercise 1
    /// implementation. Your goal is to perform a bit-flip syndrome
    /// measurement on the register, to determine if any of the bits have been
    /// flipped.
    /// 
    /// # Input
    /// ## register
    /// A 7-qubit register representing a single error-protected logical
    /// qubit. Its state  is unknown, and it may have suffered a bit-flip
    /// and/or a phase-flip error.
    /// 
    /// # Output
    /// An array of the 3 syndrome measurement results that the Steane code
    /// produces.
    operation Exercise2 (register : Qubit[]) : Result[] {
        // TODO
        // fail "Not implemented.";

        use ancillas = Qubit[6];
        mutable indexes0 = [0, 2, 4, 6];
        mutable indexes1 = [1, 2, 5, 6];
        mutable indexes2 = [3, 4, 5, 6];
        
        ApplyToEach(H, ancillas[3 .. 5]);

        for i in indexes0 {
            CNOT(register[i], ancillas[0]);
            CNOT(ancillas[3], register[i]);
        }
        for i in indexes1 {
            CNOT(register[i], ancillas[1]);
            CNOT(ancillas[4], register[i]);
        }
        for i in indexes2 {
            CNOT(register[i], ancillas[2]);
            CNOT(ancillas[5], register[i]);
        }

        ApplyToEach(H, ancillas[3 .. 5]);
        

        return [M(ancillas[2]), M(ancillas[1]), M(ancillas[0])];

    }


    /// # Summary
    /// In this exercise, you are provided with a logical qubit, represented
    /// by an error-protected register that was encoded with your Exercise 1
    /// implementation. Your goal is to perform a phase-flip syndrome
    /// measurement on the register, to determine if any of the qubits have
    /// suffered a phase-flip error.
    /// 
    /// # Input
    /// ## register
    /// A 7-qubit register representing a single error-protected logical
    /// qubit. Its state is unknown, and it may have suffered a bit-flip
    /// and/or a phase-flip error.
    /// 
    /// # Output
    /// An array of the 3 syndrome measurement results that the Steane code
    /// produces.
    operation Exercise3 (register : Qubit[]) : Result[] {
        // TODO
        // fail "Not implemented.";
        use ancillas = Qubit[6];
        mutable indexes0 = [0, 2, 4, 6];
        mutable indexes1 = [1, 2, 5, 6];
        mutable indexes2 = [3, 4, 5, 6];
        
        ApplyToEach(H, ancillas[3 .. 5]);

        for i in indexes0 {
            CNOT(register[i], ancillas[0]);
            CNOT(ancillas[3], register[i]);
        }
        for i in indexes1 {
            CNOT(register[i], ancillas[1]);
            CNOT(ancillas[4], register[i]);
        }
        for i in indexes2 {
            CNOT(register[i], ancillas[2]);
            CNOT(ancillas[5], register[i]);
        }

        ApplyToEach(H, ancillas[3 .. 5]);
        

        return [M(ancillas[5]), M(ancillas[4]), M(ancillas[3])];
    }

    operation CorrectionsAll (register : Qubit[]) : Result[] {
        // TODO
        // fail "Not implemented.";
        use ancillas = Qubit[6];
        mutable indexes0 = [0, 2, 4, 6];
        mutable indexes1 = [1, 2, 5, 6];
        mutable indexes2 = [3, 4, 5, 6];
        
        ApplyToEach(H, ancillas[3 .. 5]);

        for i in indexes0 {
            CNOT(register[i], ancillas[0]);
            CNOT(ancillas[3], register[i]);
        }
        for i in indexes1 {
            CNOT(register[i], ancillas[1]);
            CNOT(ancillas[4], register[i]);
        }
        for i in indexes2 {
            CNOT(register[i], ancillas[2]);
            CNOT(ancillas[5], register[i]);
        }

        ApplyToEach(H, ancillas[3 .. 5]);

        return [M(ancillas[5]), M(ancillas[4]), M(ancillas[3]), M(ancillas[2]), M(ancillas[1]), M(ancillas[0])];
    }


    /// # Summary
    /// In this exercise, you are provided with the 3-result array of syndrome
    /// measurements provided by the bit-flip or phase-flip measurement
    /// operations. Your goal is to determine the index of the broken qubit
    /// (if any) based on these measurements.
    /// 
    /// As a reminder, for Steane's code, the following table shows the
    /// relationship between the syndrome measurements and the index of the
    /// broken qubit:
    /// -----------------------
    /// 000 = No error
    /// 001 = Error or qubit 0
    /// 010 = Error on qubit 1
    /// 011 = Error on qubit 2
    /// 100 = Error on qubit 3
    /// 101 = Error on qubit 4
    /// 110 = Error on qubit 5
    /// 111 = Error on qubit 6
    /// -----------------------
    /// 
    /// # Input
    /// ## syndrome
    /// An array of the 3 syndrome measurement results from the bit-flip or
    /// phase-flip measurement operations. These will come from your
    /// implementations of Exercise 2 and Exercise 3.
    /// 
    /// # Output
    /// An Int identifying the index of the broken qubit, based on the
    /// syndrome measurements. If none of the qubits are broken, you should
    /// return -1.
    /// 
    /// # Remarks
    /// This is a "function" instead of an "operation" because it's a purely
    /// classical method. It doesn't have any quantum parts to it, just lots
    /// of regular old classical math and logic.
    function Exercise4 (syndrome : Result[]) : Int {
        // TODO
        // fail "Not implemented.";
        mutable number = 0;
        
        for i in 0 .. Length(syndrome) - 1 {
            if (ResultAsBool(syndrome[i])) {
                set number += 2 ^ (Length(syndrome) - 1 - i);
            }
        }
        return number - 1;

    }


    /// # Summary
    /// In this exercise, you are given a logical qubit represented by an
    /// error-protected register of 7 physical qubits. This register was
    /// produced by your implementation of Exercise 1. It is in an unknown
    /// state, but one of its qubits may or may not have suffered a bit-flip
    /// error, and another qubit may or may not have suffered a phase-flip
    /// error. Your goal is to use your implementations of Exercises 2, 3, and
    /// 4 to detect and correct the bit-flip and/or phase-flip errors in the
    /// register.
    /// 
    /// # Input
    /// ## register
    /// A 7-qubit register representing a single error-protected logical
    /// qubit. Its state is unknown, and it may have suffered a bit-flip
    /// and/or a phase-flip error.
    /// 
    /// # Remarks
    /// This test may take a lot longer to run than you're used to, because it
    /// tests every possible combination of bit and phase flips on a whole
    /// bunch of different original qubit states. Don't worry if it doesn't
    /// immediately finish!
    operation Exercise5 (register : Qubit[]) : Unit {
        // TODO
        // fail "Not implemented.";
        let errors = CorrectionsAll(register);
        let brokenPhase = Exercise4(errors[0 .. 2]);
        let brokenBit = Exercise4(errors[3 .. 5]);

        if (brokenBit != -1) {
            X(register[brokenBit]);
        }
        
        if (brokenPhase != -1) {
            Z(register[brokenPhase]);
        }
        
    }
}
