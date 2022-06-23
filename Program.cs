using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Collections;
using System;
using System.Collections.Generic;


 
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
            stack.Push("abc");
            Console.WriteLine(stack.Pop());
            stack.Clear();
            stack.Push("4");
            stack.Push("5");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }

    }

public class Stack
{
        private int _size;
        private int _top;

        private  List<Object> _stack; 

        public Stack()
        {
            _stack = new List<Object>();
            
        }

        //push the element to the top of the stack
        public void Push(object obj)
        {
            if(obj is null )
                throw new InvalidOperationException("Object is null. Can not push into the stack.");
            
            if (_size == 0)
            {//if the stack is empty
                _stack.Insert(0,obj);
                _top = 0;
            }
            else
            {
                _stack.Insert(_top+1, obj);
                _top += 1;
            }
            _size += 1;
        }
        //pops the top element in the stack
        public Object Pop()
        {
            if(_size == 0 )
                throw new InvalidOperationException("Stack is empty. Pop() function can not be used.");
           
            if(_size == 1)
            {
                _size = _top = 0;
                _top = 0;
                var PoppedObject = _stack[_top];
                return PoppedObject;
            }
            else
            {
                var PoppedObject1 = _stack[_top];
                _top += -1;
                _size += -1;
                return PoppedObject1;
            }
            
        
        }
        //clears the stack
        public void Clear()
        {
            _size = 0; 
            _top = 0;
        }
        

}  
