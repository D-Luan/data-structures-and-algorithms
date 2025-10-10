#include <stdio.h>
#include <stdlib.h>

#define TABLE_SIZE 10

typedef struct Node {
    int key;
    struct Node* next;
} Node;

/* Represents the Hash Table. Contains the array of pointers.
where each pointer is the head of a linked list. */
typedef struct HashTable {
    Node** table;
} HashTable;

int hash(int key);
HashTable* create_hash_table();
void insert(HashTable* ht, int key);
int search(HashTable* ht, int key);
void destroy(HashTable* ht);

int main() {
    HashTable* ht = create_hash_table();

    insert(ht, 22);
    insert(ht, 3);
    insert(ht, 55);

    if(search(ht, 22)) {
        printf("Number %d found!\n", 22);
    } else {
        printf("Number %d not found!\n", 22);
    }

    if(search(ht, 44)) {
        printf("Number %d found!\n", 44);
    } else {
        printf("Number %d not found!\n", 44);
    }

    destroy(ht);

    return 0;
}

int hash(int key) {
    return key % TABLE_SIZE;
}

HashTable* create_hash_table() {
    HashTable* ht = (HashTable*) malloc(sizeof(HashTable));

    ht->table = (Node**) malloc(sizeof(Node*) * TABLE_SIZE);

    for(int i = 0; i < TABLE_SIZE; i++) {
        ht->table[i] = NULL;
    }

    return ht;
}

void insert(HashTable* ht, int key) {
    int index = hash(key);

    Node* new_node = (Node*) malloc(sizeof(Node));
    new_node->key = key;
    
    /* Separate Chaining Collision Handling
    Prepend the new node to the beginning of the linked list at this index.
    This is an O(1) operation and gracefully handles both empty lists (where ht->table[index] is NULL)
    and lists that already have nodes. */
    new_node->next = ht->table[index];
    ht->table[index] = new_node; 

    printf("Inserted %d in index %d\n", key, index);
}

int search(HashTable* ht, int key) {
    int index = hash(key);

    Node* current_node = ht->table[index];

    while(current_node != NULL) {
        if(current_node->key == key) {
            return 1;
        }

        current_node = current_node->next;
    }

    return 0;
}

void destroy(HashTable* ht) {
    if(ht == NULL) {
        return;
    }

    for(int i = 0; i < TABLE_SIZE; i++) {
        Node* current_node = ht->table[i];

        // Traverse the linked list for this bucket and free each node.
        while(current_node != NULL) {
            Node* temp = current_node->next;

            free(current_node);

            current_node = temp;
        }
    }

    free(ht->table);
    free(ht);
}