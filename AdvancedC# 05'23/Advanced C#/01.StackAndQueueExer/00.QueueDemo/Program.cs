Queue<int> queue = new();
queue.Enqueue(1); // add object to the end of queue
queue.Dequeue(); // remove and return a object at the biginning of queue
queue.Peek(); // return a object at the biginning of queue
int count = queue.Count; // get the number of the queue
bool exists = queue.Contains(2); // determine where an element of the queue
int[] array = queue.ToArray(); // copies elements to a new array
queue.Clear(); // remove all objects
queue.TrimExcess(); // set the capacity to the equal number of elements

