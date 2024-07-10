
// Initialise with the first two element in sequence
// uint is used here instead of int to avoid overflow for the 100th element (b.c. it is a large number)
List<uint> fibonacciSequence = new List<uint>{0,1};

// Looking for the 100th element, hence we should iterate the loop 98th time more
for (int i = 2; i < 100; i++)
{
    // To add a new element to the sequence we use the formula Fn = Fn-1 + Fn-2
    uint fn = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
    // We need to also store the new element into the array,
    // so that we can keep referencing the last 2 elements   
    fibonacciSequence.Add(fn);
}

Console.WriteLine(fibonacciSequence.Last());