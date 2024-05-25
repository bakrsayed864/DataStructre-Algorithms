// See https://aka.ms/new-console-template for more information
using AlgorithmsAndDataStructures;
using AlgorithmsAndDataStructures.DataStructure;

//Console.WriteLine("Hello, World!");
//List<int> list = new List<int>();
//list.Add(4);
//list.Add(3);
//list.Add(1);
//list.Add(2);
//foreach (var item in list)
//    Console.WriteLine(item);
//list =Algorithm.SelectionSort(list);
//foreach (var item in list)
//    Console.WriteLine(item);

#region Linked Stack
//LinkedStack<int> stack = new LinkedStack<int>();
//stack.Push(0);
//stack.Push(1);  
//stack.Push(2);
//stack.Push(3);
//stack.Push(4);
//Console.WriteLine(stack.getSize());
//stack.Display();
//stack.Pop();
//stack.Pop();
//stack.Pop();
//Console.WriteLine(stack.getSize());
//stack.Display();
//Console.WriteLine(stack.isEmpty());
//stack.Pop();
//stack.Pop();
//Console.WriteLine(stack.isEmpty());
#endregion

#region Custome Queue
//CustomQueue<int> queue=new CustomQueue<int>(10);
//queue.Enqueue(1);//1
//queue.Enqueue(2);//2
//queue.Enqueue(3);//3
//queue.Enqueue(4);
//queue.Enqueue(5);
//queue.Enqueue(6);
//queue.Enqueue(7);
//queue.Enqueue(8);
//queue.Enqueue(9);
//queue.Enqueue(10);
//queue.Enqueue(11);
//queue.Dequeue();
//queue.Display();
#endregion

#region Linked Queue
LinkedQueue<int> Myqueue = new LinkedQueue<int>();
Myqueue.Enqueue(1);
Myqueue.Enqueue(2);
Myqueue.Enqueue(3);
Myqueue.Enqueue(5);
Myqueue.Enqueue(6);
Console.WriteLine(Myqueue.GetFront());
Console.WriteLine(Myqueue.GetBack());
Myqueue.Dequeue();
Myqueue.Dequeue();
Myqueue.Dequeue();
Myqueue.Dequeue();
//Myqueue.Dequeue();
//Myqueue.Dequeue();

Console.WriteLine(Myqueue.GetFront());
Console.WriteLine(Myqueue.GetBack());
Myqueue.Enqueue(7);
Console.WriteLine(Myqueue.GetFront());
Console.WriteLine(Myqueue.GetBack());
Console.WriteLine(Myqueue.GetSize());
#endregion







