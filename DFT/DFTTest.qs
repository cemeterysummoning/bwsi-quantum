namespace DFT {
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Arithmetic;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Logical;

    
    @Test("QuantumSimulator")
    operation DFTTest() : Unit {

        let data = [
            ComplexPolar(1.,0.),
            ComplexPolar(2.,0.),
            ComplexPolar(3.,0.),
            ComplexPolar(4.,0.),
            ComplexPolar(5.,0.),
            ComplexPolar(6.,0.),
            ComplexPolar(7.,0.),
            ComplexPolar(8.,0.)
        ];
        let DFTData = DFT(data);
        let checkData = Solution(data);
        for i in 0 .. Length(data)-1 {
            if EqualCP(DFTData[i], checkData[i]) == false {
                fail("DFT not implemented correctly");
            }
        }
    }
    //Don't look at the solution before you've tried it!!
    operation Solution (x: ComplexPolar[]) : ComplexPolar[] {
        let N = Length(x);
        mutable newx = [ComplexPolar(0.,0.), size=N]; // X = {0,0,0,...,0}
        //get k-th element of X
        for k in 0 .. N-1 {
            //for the sum in the equation for Xk
            for n in 0 .. N-1 {
                mutable sum_element = TimesCP(x[n],ComplexPolar(1.,-2.*PI()*IntAsDouble(k)*IntAsDouble(n)/IntAsDouble(N)));
                set newx w/= k <- PlusCP(newx[k], sum_element) ;//Xk = sum(e^-2ipikn/N)
            }
        }
        return newx;
    }
}
