﻿// Intro to Quantum Software Development
// Lab 2: Working with Qubit Registers
// Copyright 2023 The MITRE Corporation. All Rights Reserved.

namespace MITRE.QSD.L02 {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Math;


    /// # Summary
    /// In this exercise, you have been given an array of qubits. The length
    /// of the array is a secret; you'll have to figure it out using Q#. The
    /// goal is to rotate each qubit around the Y axis by 15° (π/12 radians),
    /// multiplied by its index in the array.
    ///
    /// For example: if the array had 3 qubits, you would need to leave the
    /// first one alone (index 0), rotate the next one by 15° (π/12 radians),
    /// and rotate the last one by 30° (2π/12 = π/6 radians).
    ///
    /// # Input
    /// ## qubits
    /// The array of qubits you need to rotate.
    ///
    /// # Remarks
    /// This investigates how to work with arrays and for loops in Q#, and how
    /// to use the arbitrary rotation gates.
    operation E01_YRotations (qubits : Qubit[]) : Unit {
        // Tip: You can get the value of π with the function PI().
        // Tip: You can use the IntAsDouble() function to cast an integer to
        // a double for floating-point arithmetic. Q# won't let you do
        // arithmetic between Doubles and Ints directly.
        
        for i in 0 .. Length(qubits)-1 {
            Ry(PI()/12.0*IntAsDouble(i), qubits[i]);
        }
    }


    /// # Summary
    /// In this exercise, you have been given an array of qubits, the length of
    /// which is unknown again. Your goal is to measure each of the qubits, and
    /// construct an array of Ints based on the measurement results.
    ///
    /// # Input
    /// ## qubits
    /// The qubits to measure. Each of them is in an unknown state.
    ///
    /// # Output
    /// An array of Ints that has the same length as the input qubit array.
    /// Each element should be the measurement result of the corresponding
    /// qubit in the input array. For example: if you measure the first qubit
    /// to be Zero, then the first element of this array should be 0. If you
    /// measure the third qubit to be One, then the third element of this array
    /// should be 1.
    ///
    /// # Remarks
    /// This investigates how to measure qubits, work with those measurements,
    /// and how to return things in Q# operations. It also involves conditional
    /// statements.
    operation E02_MeasureQubits (qubits : Qubit[]) : Int[] {
        // Tip: You can either create the Int array with the full length
        // directly and update each of its values with the apply-and-replace
        // operator, or append each Int to the array as you go. Use whichever
        // method you prefer.
        
        mutable intArray = [0,size=Length(qubits)];
        for i in 0 .. Length(qubits)-1 {
            // intArray[i] = M(qubits[i]);
            let res = M(qubits[i]);
            if (res == One) {
                set intArray w/= i <- 1;
            }
        }

        return intArray;
    }

    /// # Summary
    /// In this exercise, you are given a register of unknown length, which
    /// will be in the state |0...0>. Your goal is to put it into the |+...+>
    /// state, which is a uniform superposition of all possible measurement
    /// outcomes. For example, if it had three qubits, you would have to put
    /// it into this state:
    ///
    ///     |+++> = 1/√8(|000> + |001> + |010> + |011>
    ///                + |100> + |101> + |110> + |111>)
    ///
    /// # Input
    /// ## register
    /// A register of unknown length. All of its qubits are in the |0> state,
    /// so the register's state is |0...0>.
    ///
    /// # Remarks
    /// This investigates how to construct uniform superpositions, where a
    /// register is in a combination of all possible measurement outcomes, and
    /// each superposition term has an equal amplitude to the others.
    operation E03_PrepareUniform (register : Qubit[]) : Unit {
        // ApplyToEach(H, register);
        for i in 0 .. Length(register) - 1 {
            H(register[i]);
        }
    }

    /// # Summary
    /// In this exercise, you are given a register of unknown length, which
    /// will be in the state |+...+>. (This is the uniform superposition
    /// constructed in the previous exercise.) Your goal is to flip the phase
    /// of every odd-valued term in the superposition, preparing the state:
    ///
    ///     1/√N(|0> - |1> + |2> - |3> + |4> - ... - |N-1>)
    ///
    /// Note that, in the above expression, N = 2^(Length(register))
    ///
    /// # Input
    /// ## register
    /// A register of unknown length. All of its qubits are in the |+> state,
    /// so the register's state is |+...+>.
    ///
    /// # Remarks
    /// This investigates how a single-qubit gate can affect a multi-qubit
    /// state and tests your understanding of using integers for register
    /// values.
    operation E04_PhaseFlipOddTerms (register : Qubit[]) : Unit {
        Z(register[Length(register) - 1]);
        
    }
}
