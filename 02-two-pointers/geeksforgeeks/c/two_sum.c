#include <stdio.h>
#include <stdbool.h>

bool two_sum(int v[], int qtd, int target);

int main() {
    int array[] = {-8, 1, 4, 6, 10, 45};
    int length = sizeof(array) / sizeof(array[0]);
    int target = 16;

    if (two_sum(array, length, target)) {
        printf("True\n");
    } else {
        printf("False\n");
    }

    return 0;
}

bool two_sum(int v[], int qtd, int target) {
    int left = 0, right = qtd - 1, sum;

    while(left < right) {
        sum = v[left] + v[right];

        if(sum == target) {
            return true;
        } else if (sum < target) {
            left++;
        } else {
            right--;
        }
    }

    return false;
}