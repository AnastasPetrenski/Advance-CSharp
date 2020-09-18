using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorRPNShuntingYardAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 + ( 3 * ( 3 - 5 ) - 6 ) * 2

            ReversePolishNotationCalculator ( ShuntingYardAlgorithm( Console.ReadLine()) );
        }

        public static void ReversePolishNotationCalculator ( Queue<string> shuntingYardExpression )
        {
            Stack<string> stack = new Stack<string>(shuntingYardExpression.Reverse());
            Stack<string> elements = new Stack<string>();
            //PrintStack(stack);

            while (stack.Count > 0)
            {
                var element = stack.Pop();

                while (!IsOperator(element))
                {
                    elements.Push(element);
                    element = stack.Pop();
                }

                if (elements.Count > 1)
                {
                    int first = 0;
                    int second = 0;
                    if (elements.TryPop(out string x)) { second = int.Parse(x); }
                    if (elements.TryPop(out string z)) { first = int.Parse(z); }

                    int result = PerformOperation(element, first, second);

                    elements.Push(result.ToString());
                }
            }
            Console.WriteLine(elements.Pop());
        }

        public static Queue<string> ShuntingYardAlgorithm(string input)
        {
            string[] expression = input.Split();

            Stack<string> operators = new Stack<string>();
            Queue<string> output = new Queue<string>();


            for (int i = 0; i < expression.Length; i++)
            {
                if (IsOperator(expression[i]))
                {
                    if (operators.TryPeek(out string result))
                    { 
                        var precisionLastElement = OperatorPrecision(result);
                        var precisionCurrElement = OperatorPrecision(expression[i]);
                        if (precisionCurrElement <= precisionLastElement)
                        {
                            output.Enqueue(operators.Pop());
                            operators.Push(expression[i]);
                        }
                        else
                        {
                            operators.Push(expression[i]);
                        }
                    }
                    else
                    {
                        operators.Push(expression[i]);
                    }

                }
                else if (expression[i] == "(")
                {
                    operators.Push(expression[i]);
                }
                else if (expression[i] == ")")
                {
                    while (operators.Peek() != "(")
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Pop();
                }
                else
                {
                    output.Enqueue(expression[i]);
                }
            }

            while (operators.Count > 0)
            {
                output.Enqueue(operators.Pop());
            }

            return output;
        }

        public static int OperatorPrecision(string input)
        {
            var result = input switch
            {
                "(" => 0,
                "+" => 1,
                "-" => 1,
                "*" => 2,
                "/" => 2,
                _ => throw new ArgumentException(),
            };

            return result;
        }

        public static bool IsOperator(string input)
        {
            var result = input switch
            {
                "+" => true,
                "-" => true,
                "*" => true,
                "/" => true,
                _ => false,
            };

            return result;
        }

        public static void PrintStack(Queue<string> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        private static int PerformOperation(string element, int first, int second)
        {
            var result = element switch
            {
                "+" => first + second,
                "-" => first - second,
                "*" => first * second,
                "/" => first / second,
                _ => throw new ArgumentException(),
            };

            return result;
        }

        public static void PrintStack(Stack<string> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
