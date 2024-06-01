
Stack<int> stack= new(); // LastInFirstOut
///
stack.Peek(); // Returns the object on the top without remove
///
stack.Pop(); // Remove and return object of the top
///
stack.Push(stack.Count); // Add object on the top
///
int count = stack.Count(); // Returns the number of objects
///
bool exist = stack.Contains(2); // Determines where the object in the stack
///
int[] array = stack.ToArray(); // copies the stack to the new array
///
stack.Clear(); // Remove all object 
///
stack.TrimExcess(); // set the capacity of the actual numbers of elements
