﻿using System;

public class Stack
{
    private int capacity;
    private int[] data;
    private int top = -1;

    public Stack(int size = 1000)
    {
        data = new int[size];
        capacity = size;
    }
    /* Other methods */

    public int Size()
    {
        return (top + 1);
    }

    public bool IsEmpty()
    {
        return (top == -1);
    }

    public void Push(int value)
    {
        if (Size() == capacity)
        {
            throw new System.InvalidOperationException("StackOverflowException");
        }
        top++;
        data[top] = value;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            throw new System.InvalidOperationException("StackEmptyException");
        }
        return data[top];
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new System.InvalidOperationException("StackEmptyException");
        }
        int topVal = data[top];
        top--;
        return topVal;
    }

    public void Print()
    {
        for (int i = top; i > -1; i--)
        {
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
    }

    // Testing code.
    public static void Main(string[] args)
    {
        Stack s = new Stack();
        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Print();
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
}
}
/*
3 2 1 
3
2
1
*/