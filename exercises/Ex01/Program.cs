using System;
using System.Collections.Generic;

public class FirstExercise
{
    public static int Precedence(char op)
    {
        switch (op)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            case '^':
                return 3;
            default:
                return 0;
        }
    }

    public static bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
    }

    public static string Convert(string infix)
    {
        Stack<char> stack = new Stack<char>();
        string postfix = "";

        foreach (char c in infix)
        {
            if (char.IsWhiteSpace(c))
                continue;

            if (char.IsLetterOrDigit(c))
            {
                postfix += c;
            }
            else if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    postfix += stack.Pop();
                }

                if (stack.Count > 0 && stack.Peek() != '(')
                {
                    return "Invalid Expression"; // Invalid expression
                }
                else
                {
                    stack.Pop();
                }
            }
            else if (IsOperator(c))
            {
                while (stack.Count > 0 && Precedence(c) <= Precedence(stack.Peek()))
                {
                    postfix += stack.Pop();
                }

                stack.Push(c);
            }
        }

        while (stack.Count > 0)
        {
            postfix += stack.Pop();
        }

        return postfix;
    }

    public static void Main(string[] args)
    {
        string infix = "a+b*c/(m-n)";
        string postfix = Convert(infix);
        Console.WriteLine("Postfix expression: " + postfix);
    }
}