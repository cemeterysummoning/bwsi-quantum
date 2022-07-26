# Lab 13: Grover's Algorithm
# Copyright 2021 The MITRE Corporation. All Rights Reserved.


from numpy import number
from qiskit import QuantumCircuit, ClassicalRegister, QuantumRegister
from qiskit import execute
from qiskit import Aer
from qiskit import assemble
import math
import random


def exercise_1(circuit, classical_bits, register):
    """
    In this exercise, you are given a circuit, a classical bit array, and a qubit
    register. Both of these are of unknown length, but they have the same length.
    Your goal is to apply the bitwise XOR operation in-place on the
    quantum register, using its own state and the classical bit array as
    the two input arguments, and using the register itself as the output.
    For example, if the classical bit array is 10110 and the qubit
    register is in the state |00101>, then this operation should put the
    qubit register into the state 10110 XOR 00101 = |10011>.

    Parameters:
        circuit (QuantumCircuit): The circuit being constructed.
        classical_bits (bool[]): A classical bit array that contains an unknown
            bit string of unknown length.
        register (QuantumRegister): A qubit array in an unknown state, which has
            the same length as the classical_bits array.
    """
    
    # raise Exception("Not implemented yet.")
    for i in range(len(classical_bits)):
        if classical_bits[i]:
            circuit.x(register[i])


def exercise_2(circuit, register, target):
    """
    In this exercise, you must implement an oracle that checks if all of
    the provided qubits are in the |0> state. You are given a qubit
    register of unknown length in an unknown state, and a target qubit
    that is in the |1> state. Your goal is to phase-flip the target qubit
    if the register is in the state |0...0>.

    Parameters:
        circuit (QuantumCircuit): The circuit being constructed.
        register (QuantumRegister): A register of unknown length in an unknown state.
        target (QuantumRegister): The target qubit that you must phase-flip if the
            register is in the |0...0> state. The target qubit will be provided in
            the |1> state.
    """
    
    # raise Exception("Not implemented yet.")
    circuit.x(register)

    ancillas = QuantumRegister(len(register) - 1)

    circuit.add_register(ancillas)

    

    circuit.ccx(register[0], register[1], ancillas[0])
    if len(register) > 2: 
        for i in range(2, len(register)):
            circuit.ccx(register[i], ancillas[i - 2], ancillas[i - 1])

    circuit.cz(ancillas[len(ancillas) - 1], target)

    if len(register) > 2: 
        for i in range(len(register) - 1, 1, -1):
            circuit.ccx(register[i], ancillas[i - 2], ancillas[i - 1])

    circuit.ccx(register[0], register[1], ancillas[0])

    circuit.x(register)

def exercise_3(circuit, 
               original_message, 
               encrypted_message, 
               candidate_encryption_key, 
               target):
    """
    In this exercise, you must implement an oracle that checks to see if a
    provided encryption key is correct. You are given an original message
    as a classical bit string and the message after it has been encrypted
    with an unknown encryption key. The encryption algorithm is a bitwise
    XOR. You are also given a qubit register which represents the
    encryption key being checked, and a target qubit. Your goal is to
    phase-flip the target qubit if the state of the qubit register
    corresponds to the encryption key that was used to encrypt the
    original message.

    Parameters:
        circuit (QuantumCircuit): The circuit being constructed.
        original_message (bool[]): A classical bitstring containing the
            original message that was encrypted.
        encrypted_message (bool[]): A classical bitstring containing the 
            original message after it was encrypted with a bitwise XOR algorithm.
        candidate_encryption_key (QuantumRegister): A quantum register containing
            the potential encryption key that is being checked by your oracle - 
            think of it like a quantum version of the classical encryption key.
        target (QuantumRegister): The qubit that you should phase-flip if the
            candidate key is the correct key - that is, if encrypting the original
            message with it produces the same bitstring as the encrypted_message
            bitstring.

    Remarks:
        Obviously, bitwise XOR is a trivial example because you can just XOR
        the original message with the encrypted message to recover the
        encryption key. The point of this exercise is to show that this
        process can be done with any algorithm, including ones that are
        nontrivial like modern cryptographic cyphers (SHA256, AES, etc.). XOR
        is just used here because it's easy to implement, think of it as a
        proof-of-concept.
    """
    
    # raise Exception("Not implemented yet.")
    exercise_1(circuit, original_message, candidate_encryption_key)
    exercise_1(circuit, encrypted_message, candidate_encryption_key)
    
    exercise_2(circuit, candidate_encryption_key, target)

    exercise_1(circuit, encrypted_message, candidate_encryption_key)
    exercise_1(circuit, original_message, candidate_encryption_key)


def exercise_4(circuit, oracle, register, target):
    """
    In this exercise, you must implement the repeated quantum iteration in
    Grover's algorithm, which consists of running the oracle and then the
    diffusion operator. You are given an oracle to run, a qubit register
    representing the input to the oracle, and a target qubit that the
    oracle can use for phase-flipping if provided with the correct input.

    Parameters:
        circuit (QuantumCircuit): The circuit being constructed.
        oracle (Function): A function object representing the oracle being
            used during the search to find the "correct" state. Its signature is
            identical to the exercise_2() function.
        register (QuantumRegister): A qubit register of unknown length and
            unknown state. This represents the input you should provide to
            the oracle.
        target (QuantumRegister): A qubit in the |1> state. This represents a
            target you can use for any phase-flipping oracles. 
    """
    
    # raise Exception("Not implemented yet.")
    
    oracle(circuit, register, target)
    circuit.h(register)
    exercise_2(circuit, register, target)
    circuit.h(register)
    


def exercise_5(oracle, number_of_qubits):
    """
    In this exercise, you must implement Grover's quantum search
    algorithm. You have already implemented all of the pieces, so now you
    just need to put them all together. You are given an oracle which can
    correctly identify the "correct" answer to the problem being searched,
    and a number of qubits that it expects for its input register. Your
    goal is to use this information to run Grover's search and find the
    correct state.

    Parameters:
        oracle (Function): A function object representing the oracle being
            used during the search to find the "correct" state. Its signature is
            identical to the exercise_2() function.
        number_of_qubits (int): The number of qubits that the oracle expects
            in its input register.

    Returns:
        You must return a string representing the big-endian binary value of
        the solution that the search algorithm found.
        For example, if Qiskit measured 00111, you must return "11100".
    """
    
    # raise Exception("Not implemented yet.")
    numtimes = math.ceil(math.sqrt(2 ** number_of_qubits))

    register = QuantumRegister(number_of_qubits)
    register_measure = ClassicalRegister(number_of_qubits)

    output = QuantumRegister(1)

    circuit = QuantumCircuit(register, output, register_measure)

    circuit.x(output)
    circuit.h(register)

    for i in range(numtimes):
        exercise_4(circuit, oracle, register, output)

    circuit.measure(register, register_measure)
    simulator = Aer.get_backend('aer_simulator')
    qobj = assemble(circuit, shots=1)
    job = simulator.run(qobj)
    print('here')
    result = job.result()
    counts = result.get_counts(circuit)
    value = ""
    for i in counts.keys():
        value = i;

    return value

if __name__ == '__main__':
    original = [random.randint(0, 1) for i in range(3)]
    key = [random.randint(0, 1) for i in range(3)]
    encrypted = [(original[i] != key[i]) for i in range(3)]
    oracle = lambda circuit_arg, qubit_arg, target_arg : exercise_3(circuit_arg, original, encrypted, qubit_arg, target_arg)
    print(exercise_5(oracle, 3))