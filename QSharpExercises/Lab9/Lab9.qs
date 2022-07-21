// Lab 9: Shor's Algorithm
// Copyright 2021 The MITRE Corporation. All Rights Reserved.

namespace Lab9 {

    open Microsoft.Quantum.Arithmetic;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Measurement;


    /// # Summary
    /// In this exercise, you must implement the quantum modular
    /// exponentiation function: |o> = a^|x> mod b.
    /// |x> and |o> are input and output registers respectively, and a and b
    /// are classical integers.
    /// 
    /// # Input
    /// ## a
    /// The base power of the term being exponentiated.
    /// 
    /// ## b
    /// The modulus for the function.
    /// 
    /// ## input
    /// The register containing a superposition of all of the exponent values
    /// that the user wants to calculate; this superposition is arbitrary.
    /// 
    /// ## output
    /// This register must contain the output |o> of the modular
    /// exponentiation function. It will start in the |0...0> state.
    operation Exercise1 (
        a : Int,
        b : Int,
        input : Qubit[],
        output : Qubit[]
    ) : Unit {
        // Note: For convenience, you can use the
        // Microsoft.Quantum.Math.ExpModI() function to calculate a modular
        // exponent classically. You can use the
        // Microsoft.Quantum.Arithmetic.MultiplyByModularInteger() function to
        // do an in-place quantum modular multiplication.

        // TODO
        // fail "Not implemented.";
        X(output[Length(output) - 1]);
        for i in 0 .. Length(input) - 1 {
            let power = Length(input) - i - 1;
            let constantA = 2 ^ power;
            let constantB = ExpModI(a, constantA, b);

            Controlled MultiplyByModularInteger([input[i]], (constantB, b, LittleEndian(output)));
        }
        
    }


    /// # Summary
    /// In this exercise, you must implement the quantum subroutine of Shor's
    /// algorithm. You will be given a number to factor and some guess to a
    /// possible factor - both of which are integers.
    /// You must set up, execute, and measure the quantum circuit.
    /// You should return the fraction that was produced by measuring the
    /// result at the end of the subroutine, in the form of a tuple:
    /// the first value should be the number you measured, and the second
    /// value should be 2^n, where n is the number of qubits you use in your
    /// input register.
    /// 
    /// # Input
    /// ## numberToFactor
    /// The number that the user wants to factor. This will become the modulus
    /// for the modular arithmetic used in the subroutine.
    /// 
    /// ## guess
    /// The number that's being guessed as a possible factor. This will become
    /// the base of exponentiation for the modular arithmetic used in the 
    /// subroutine.
    /// 
    /// # Output
    /// A tuple representing the continued fraction approximation that the
    /// subroutine measured. The first value should be the numerator (the
    /// value that was measured from the qubits), and the second value should
    /// be the denominator (the total size of the input space, which is 2^n
    /// where n is the size of your input register).
    operation QFT (register : Qubit[]) : Unit is Adj + Ctl {
        // Hint: there are two functions you may want to use here:
        // the first is your implementation of register reversal in Lab 2,
        // Exercise 2.
        // The second is the Microsoft.Quantum.Intrinsic.R1Frac() gate.

        // TODO
        // fail "Not implemented.";

        for i in 0 .. Length(register) - 1 {
            H(register[i]);
            for j in i + 1 .. Length(register) - 1 {
                Controlled R1Frac([register[j]], (2, (j - i) + 1, register[i]));
            }
        }

        let length = Length(register);
        let halfLength = length / 2;
        for i in 0 .. halfLength - 1 {
            SWAP(register[i], register[length - 1 - i]);
        }

    }

    operation Exercise2 (
        numberToFactor : Int,
        guess : Int
    ) : (Int, Int) {
        // Hint: you can use the Microsoft.Quantum.Arithmetic.MeasureInteger()
        // function to measure a whole set of qubits and transform them into
        // their integer representation.

        // NOTE: This is a *probablistic* test. There is a chance that the
        // unit test fails, even if you have the correct answer. If you think
        // you do, run the test again. Also, look at the output of the test to
        // see what values you came up with versus what the system expects.

        // TODO
        // fail "Not implemented.";

        let outputLength = Ceiling(Log(IntAsDouble(numberToFactor) + 1.0) / Log(2.0));
        let inputLength = 2 * outputLength;

        use output = Qubit[outputLength];
        use input = Qubit[inputLength];

        ApplyToEach(H, input);

        Exercise1(guess, numberToFactor, input, output);

        Adjoint QFT(input);

        mutable results = new Result[Length(input)];

        for i in 0 .. Length(input) - 1 {
            set results w/= i <- M(input[i]);
        }

        mutable num = 0;
        
        for i in 0 .. Length(input) - 1 {
            if (ResultAsBool(results[i])) {
                set num += 2 ^ (Length(input) - 1 - i);
            }
        }

        if (num > 2^(inputLength - 1)) {
            set num = 2^inputLength - num;
        }
        
        ResetAll(output + input);
        
        
        return (num, 2 ^ (inputLength));

    }


    /// # Summary
    /// In this exercise, you will be given an arbitrary numerator and
    /// denominator for a fraction, along with some threshold value for the
    /// denominator.
    /// Your goal is to return the largest convergent of the continued
    /// fraction that matches the provided number, with the condition that the
    /// denominator of your convergent must be less than the threshold value.
    /// 
    /// Using the example from the lecture section, if you are given the
    /// number 341 / 512 with a threshold of 21, the most accurate convergent
    /// that respects this threshold is 2 / 3, so that's what you would return.
    /// 
    /// # Input
    /// ## numerator
    /// The numerator of the original fraction
    /// 
    /// ## denominator
    /// The denominator of the original fraction
    /// 
    /// ## denominatorThreshold
    /// A threshold value for the denominator. The continued fraction
    /// convergent that you find must be less than this value. If it's higher,
    /// you must return the previous convergent.
    /// 
    /// # Output
    /// A tuple representing the convergent that you found. The first element
    /// should be the numerator, and the second should be the denominator.
    function Exercise3 (
        numerator : Int,
        denominator : Int,
        denominatorThreshold : Int
    ) : (Int, Int) {
        // TODO
        // fail "Not implemented.";
        Message($"initial numerator: {numerator}, initial denominator: {denominator}");
        
        mutable p = [0, numerator];
        mutable q = [0, denominator];
        mutable a = [0, p[1] / q[1]];
        mutable r = [0, p[1] % q[1]];
        mutable n = [1, a[1] * 1 + 0];
        mutable d = [0, a[1] * 0 + 1];

        set p += [q[1]];
        set q += [r[1]];
        mutable i = 2;
        if (r[1] == 0) {
            return (n[1], d[1]);
        }

        while (r[i - 1] != 0 and d[i - 1] < denominatorThreshold) {
            set a += [p[i] / q[i]];
            set r += [p[i] % q[i]];
            set n += [a[i] * n[i - 1] + n[i - 2]];
            set d += [a[i] * d[i - 1] + d[i - 2]];

            set p += [q[i]];
            set q += [r[i]];
            set i += 1;
        }

        if (d[i - 1] > denominatorThreshold) {
            return (n[i - 2], d[i - 2]);
        }
        return (n[i - 1], d[i - 1]);
    }


    /// # Summary
    /// In this exercise, you are given two integers - a number that you want
    /// to find the factors of, and an arbitrary guess as to one of the
    /// factors of the number. This guess was already checked to see if it was
    /// a factor of the number, so you know that it *isn't* a factor. It is
    /// guaranteed to be co-prime with numberToFactor.
    /// 
    /// Your job is to find the period of the modular exponentation function
    /// using these two values as the arguments. That is, you must find the
    /// period of the equation y = guess^x mod numberToFactor.
    /// 
    /// # Input
    /// ## numberToFactor
    /// The number that the user wants to find the factors for
    /// 
    /// ## guess
    /// Some co-prime integer that is smaller than numberToFactor
    /// 
    /// # Output
    /// The period of y = guess^x mod numberToFactor.
    operation Exercise4Helper (numberToFactor : Int, guess: Int) : Int {
        mutable (numerator, denominator) = Exercise2(numberToFactor, guess);
        if (numerator == 0) {
            repeat {
                set (numerator, denominator) = Exercise2(numberToFactor, guess);
            } until (numerator != 0);
        }

        set (numerator, denominator) = Exercise3(numerator, denominator, numberToFactor);
        return denominator;
    }

    operation Exercise4 (numberToFactor : Int, guess : Int) : Int
    {
        // Note: you can't use while loops in operations in Q#.
        // You'll have to use a repeat loop if you want to run
        // something several times.

        // Hint: you can use the
        // Microsoft.Quantum.Math.GreatestCommonDivisorI()
        // function to calculate the GCD of two numbers.

        // TODO
        // fail "Not implemented.";

        mutable factor = Exercise4Helper(numberToFactor, guess);
        mutable d_old = 0;
        mutable d_new = 0;
        if ((guess ^ factor) % numberToFactor != 1) {
            repeat {
                set d_old = factor;
                repeat {
                    set d_new = Exercise4Helper(numberToFactor, guess);

                } until (d_new != d_old); 
                set factor = d_old * d_new / GreatestCommonDivisorI(d_old, d_new);

            } until ((guess ^ factor) % numberToFactor == 1);
        }
        return factor;
    }


    /// # Summary
    /// In this exercise, you are given a number to find the factors of,
    /// a guess of a factor (which is guaranteed to be co-prime), and the
    /// period of the modular exponentiation function that you found in
    /// Exercise 4.
    /// 
    /// Your goal is to use the period to find a factor of the number if
    /// possible.
    /// 
    /// # Input
    /// ## numberToFactor
    /// The number to find a factor of
    /// 
    /// ## guess
    /// A co-prime number that is *not* a factor
    /// 
    /// ## period
    /// The period of the function y = guess^x mod numberToFactor.
    /// 
    /// # Output
    /// - If you can find a factor, return that factor.
    /// - If the period is odd, return -1.
    /// - If the period doesn't work for factoring, return -2.
    function Exercise5 (
        numberToFactor : Int,
        guess : Int, period : Int
    ) : Int {
        // TODO
        // fail "Not implemented.";
        if (period % 2 == 1) {
            return -1;
        } 
        let constant = guess ^ (period / 2) % numberToFactor;
        if (constant == 1 or constant == -1) {
            return -2;
        }

        let factor1 = GreatestCommonDivisorI(numberToFactor, constant + 1);
        let factor2 = GreatestCommonDivisorI(numberToFactor, constant - 1);
        if (factor1 * factor2 == numberToFactor and factor1 > 2 and factor1 < numberToFactor) {
            return factor1;
        } else {
            return -2;
        }
    }
}
