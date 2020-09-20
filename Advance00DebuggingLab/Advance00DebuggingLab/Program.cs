﻿using System;

namespace Advance00DebuggingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();


            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = ((long)operandOne * (long)operandTwo);
                            break;
                        }
                }
                Console.WriteLine(result);
                opCode = Console.ReadLine();

            }
        }
    }
}
