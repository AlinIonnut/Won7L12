Console.WriteLine("~List of integers~");
Won7L12.Queue<int>  intQueue = new Won7L12.Queue<int> (6);
intQueue.Enqueue (1);
intQueue.Enqueue (2);
intQueue.Enqueue (3);
intQueue.Enqueue (4);
Console.WriteLine ("Count: " + intQueue.Count);
Console.WriteLine ("Dequeued: " + intQueue.Dequeue ());
Console.WriteLine("Count after dequeue: " + intQueue.Count);


Console.WriteLine("~List of objects~");
Queue<string> stringQueue = new Queue<string>(3);
stringQueue.Enqueue("first");
stringQueue.Enqueue("second");
stringQueue.Enqueue("third");

Console.WriteLine("Count: " + stringQueue.Count);
Console.WriteLine("Dequeued: " + stringQueue.Dequeue());
Console.WriteLine("Dequeued: " + stringQueue.Dequeue());
Console.WriteLine("Dequeued: " + stringQueue.Dequeue());
Console.WriteLine("Dequeued: " + stringQueue.Dequeue());
Console.WriteLine("Count after dequeue: " + stringQueue.Count);