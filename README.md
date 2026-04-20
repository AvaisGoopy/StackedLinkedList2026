# Stacked Limked]

📦 Stack Implementation Using a Linked List (C#)

This project implements a stack (LIFO – Last In, First Out) using a singly linked list in C#. Instead of relying on arrays, it dynamically allocates memory through nodes, making it flexible and efficient for insertions and deletions.

🔧 Key Components
Node class: Represents each element in the stack, storing:
data (value)
next (reference to the next node)
StackLL class: Implements stack functionality using a linked list with a head pointer representing the top of the stack.
Interface1: Defines the stack operations (Push, Pop, Peek, IsEmpty, Size).
⚙️ Core Operations
Push(int value): Adds a new element to the top of the stack (O(1))
Pop(): Removes the top element (O(1))
Peek(): Returns the top element without removing it
IsEmpty(): Checks if the stack has no elements
printAllNodes(): Traverses and prints all elements from top to bottom
🚀 How It Works

Elements are inserted and removed from the head of the linked list, ensuring constant time complexity for stack operations. The structure grows dynamically as new elements are pushed.

⚠️ Notes
Pop() currently does not return the removed value (can be improved)
Size() is not yet implemented
Uses object for data storage (could be improved with generics for type safety)

