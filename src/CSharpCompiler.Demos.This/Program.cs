﻿using System;
using System.Reflection;
using System.Reflection.Emit;

namespace CSharpCompiler.Demos.This
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = null;
            msg.Print();
        }

        private static void DoSomethingWeird()
        {
            Message msg2 = null;
            var printer = (Action<Message>)typeof(Message).GetMethod("Print").CreateDelegate(typeof(Action<Message>));
            printer.Invoke(msg2);
        }
    }

    public class Message
    {
        public void Print()
        {
            var text = this == null ? "I don't know" : this.ToString();
            Console.WriteLine("I am " + text + "!");
        }
    }
}
