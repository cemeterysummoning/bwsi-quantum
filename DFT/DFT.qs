// Lab 8 Extra Problem: DFT
// Copyright 2021 The MITRE Corporation. All Rights Reserved.

namespace DFT {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Arithmetic;


    /// # Summary
    /// In this extra problem, you will implement the Discrete Fourier Transform (DFT)
    /// This function should accept an array of N complex numbers, x, and return the transformed array of N complex numbers, X.
    ///Each element of the new array is the sum from n=0 to N-1 of xn*e^-i*2*pi*k*n/N
    ///
    /// # Input
    /// ## x
    /// An array of N complex numbers to be transformed
    ///
    /// # Output
    /// ## An array of N transformed complex numbers
    operation DFT (x: ComplexPolar[]) : ComplexPolar[] {
        //TODO
        // fail ("Not implemented");
        let length = Length(x);
        mutable transformed = new ComplexPolar[Length(x)];

        for i in 0 .. length - 1 {
            for j in 0 .. length - 1 {
                mutable x_n = x[j];
                mutable phase = -2.0 * PI() / IntAsDouble(length) * IntAsDouble(i) * IntAsDouble(j);
                mutable tempPolar = ComplexPolar(1.0, phase);

                let temp = TimesCP(x_n, tempPolar);
                set transformed w/= i <- PlusCP(transformed[i], temp);
            }
        }

        return transformed;
    }

}