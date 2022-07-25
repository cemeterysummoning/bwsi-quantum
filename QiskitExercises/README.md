# Qiskit Exercises

## Environment Setup

1. Install [Anaconda](https://www.anaconda.com/products/distribution).

    > On Linux, you will need to download the install script and run it from the terminal. For example:
    ```sh
    curl -O https://repo.anaconda.com/archive/Anaconda3-2022.05-Linux-x86_64.sh
    bash Anaconda3-2022.05-Linux-x86_64.sh
    ```

2. Open the Anaconda prompt (search the program and click on it).

    > On Linux, simply open a new terminal.

3. Navigate to the `QiskitExercises` directory. For example:

    ```sh
    cd /path/to/repo/exercises/QiskitExercises
    ```

4. Setup a new virtual environment and activate it.

    ```sh
    conda create -n qiskit python=3
    conda activate qiskit
    ```

    > You only need to create the virtual environment once, but you need to activate it each time you open the project.

5. Install Qiskit with pip.

    ```sh
    pip install qiskit
    ```

## VS Code Integration

1. Install the official Python extension by Microsoft.

2. Open the QiskitExercises folder.

3. Use the Command Palette (`F1` or `Ctrl+Shift+P`) to set your Python interpreter to the virtual environment you created. (Search for "Python: Select Interpreter" and click on the one with your virtual environment in the path.)

Now, whenever you open the terminal, the environment will automatically be activated for you.

> There is some additional setup to get `conda` working with PowerShell. Best workaround on Windows is to set the default profile to use Command Prompt instead.

## Running the Tests

1. Open the terminal and make sure the virtual environment is activated.

2. `cd` into the lab folder.

3. Run `python -m unittest` to run all tests. To target individual tests, use `python -m unittest -k <test_name>`.
