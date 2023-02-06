using CustomStackStructure;


CustomStack stack = new();

stack.Push(1);
stack.Push(22);
stack.Push(33);
stack.Push(44);
stack.Push(555);

// Pop - removing
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine("-------------------");
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Peek());

stack.ForEach(i => Console.Write(i + " "));