public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: enter a couple of food items with different priorities and remove 1 to see if it takes out the highest number
        // Expected Result: Test case will have ramen be removed since it will be the highest and taco and pho remain
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Taco", 12);
        priorityQueue.Enqueue("Ramen", 48);
        priorityQueue.Enqueue("Pho", 6);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");
        var priorityQueue2 = new PriorityQueue();
        // Test 2
        // Scenario: sports items. Will be adding sports items with different priorities. 4 of them will be added and two removed.
        // Expected Result: Only baseball and tennisball will be showing. I will have 2 dequeues that willl remove glove and basketball
        Console.WriteLine("Test 2");
        priorityQueue2.Enqueue("glove", 78);
        priorityQueue2.Enqueue("Baseball", -3);
        priorityQueue2.Enqueue("Basketball", 90);
        priorityQueue2.Enqueue("Tennisball", 7);
        priorityQueue2.Dequeue();
        priorityQueue2.Dequeue();
        Console.WriteLine(priorityQueue2);

        // Defect(s) Found: 

        Console.WriteLine("---------");
        Console.WriteLine("Test 3");
        var priorityQueue3 = new PriorityQueue();
        Console.WriteLine(priorityQueue3);

        // Add more Test Cases As Needed Below
    }
}