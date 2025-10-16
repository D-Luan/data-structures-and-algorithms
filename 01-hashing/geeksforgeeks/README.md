## GeeksforGeeks Problems: Hashing

This directory contains my solutions to GeeksforGeeks problems that are effectively solved using hash tables (`Dictionary` in C#).

Each solution demonstrates a practical application of hashing concepts, such as frequency counting or finding complements, to achieve optimal performance.

### Solved Problems

| Problem | Solution | Key Concept Used | Time Complexity |
| --- | --- | --- | --- |
| [Check For Subset](https://www.geeksforgeeks.org/dsa/find-whether-an-array-is-subset-of-another-array-set-1/) | [Code](./CheckForSubset/Program.cs) | Using a HashSet for efficient O(1) lookups| **O(m + n)**
| [Check For Disjoint](https://www.geeksforgeeks.org/dsa/check-two-given-sets-disjoint/) | [Code](./CheckForDisjoint/Program.cs) | Using a HashSet for efficient O(1) lookups| **O(m + n)**
| [Check For Disjoint (Memory Optimized)](https://www.geeksforgeeks.org/dsa/check-two-given-sets-disjoint/) | [Code](./CheckForDisjointMemoryOptimized/Program.cs) | Memory optimization by hashing the smaller array. | **O(m + n)**
| [Check For Equal](https://www.geeksforgeeks.org/dsa/check-if-two-arrays-are-equal-or-not/) | [Code](./CheckForEqual/Program.cs) | Using frequency counter in dictionary | **O(m + n)**
