## Hash Table with Separate Chaining in C

## Description

This is a simple C implementation of a hash table that uses the **separate chaining** method to handle collisions.

### Core Concepts

The implementation is based on the following key components:

1.  **Data Structures:**
    * A `HashTable` struct that holds the array of "buckets" (`Node** table`).
    * A `Node` struct to build the singly linked lists for the chains.

2.  **Hash Function:**
    * A simple modulo hash function (`key % TABLE_SIZE`) is used to map keys to an index in the bucket array.

3.  **Collision Resolution:**
    * When a collision occurs (multiple keys map to the same index), the new node is prepended to the beginning of the linked list at that index. This makes the `insert` operation very fast (O(1)).

4.  **Core Functions:**
    * `create_hash_table()`: Allocates memory and initializes the hash table.
    * `insert()`: Adds a new key to the table, handling collisions via chaining.
    * `search()`: Traverses the linked list at the calculated index to find a key.
    * `destroy()`: Frees all allocated memory for the nodes and the table itself, preventing memory leaks.