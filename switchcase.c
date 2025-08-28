#include <stdio.h>
#include <stdlib.h> 

void main() {
    int ch, no, i, flag = 0, fact = 1, number, n, t1 = 0, t2 = 1, nextTerm;
    char* days[] = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

    do {
        printf("\n----- 	Menu	-----\n");
        printf("\n1. Even & Odd numbers");
        printf("\n2. Prime Numbers");
        printf("\n3. Factorial of number");
        printf("\n4. Fibonacci Series");
        printf("\n5. Print Day Name");
        printf("\n6. Exit");
        printf("\n--------------------------------------\n");
        printf("\n\nEnter your choice: ");
        scanf("%d", &ch);

        switch (ch) {
            case 1:
                printf("Enter a number: ");
                scanf("%d", &no);
                if (no % 2 == 0)
                    printf("Number is Even\n");
                else
                    printf("Number is Odd\n");
                break;

            case 2:
                printf("Enter a positive integer: ");
                scanf("%d", &no);
                if (no == 0 || no == 1) {
                    flag = 1;
                } else {
                    flag = 0;  // Reset flag for each new number
                }

                for (i = 2; i <= no / 2; ++i) {
                    if (no % i == 0) {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0) {
                    printf("%d is a prime number.\n", no);
                } else {
                    printf("%d is not a prime number.\n", no);
                }
                break;

            case 3:
                printf("Enter a number: ");
                scanf("%d", &number);
                fact = 1;  // Reset fact for each new number
                for (i = 1; i <= number; i++) {
                    fact = fact * i;
                }
                printf("Factorial of %d is: %d\n", number, fact);
                break;

            case 4:
                nextTerm = t1 + t2;
                printf("Enter the number of terms: ");
                scanf("%d", &n);
                printf("Fibonacci Series: %d, %d, ", t1, t2);

                for (i = 3; i <= n; ++i) {
                    printf("%d, ", nextTerm);
                    t1 = t2;
                    t2 = nextTerm;
                    nextTerm = t1 + t2;
                }
                printf("\n");
                break;

            case 5:
                printf("Enter a day number (1 for Sunday, 2 for Monday, etc.): ");
                scanf("%d", &no);
                if (no >= 1 && no <= 7) {
                    printf("Day: %s\n", days[no - 1]);
                } else {
                    printf("Invalid day number\n");
                }
                break;

            case 6:
                exit(0);
                break;

            default:
                printf("\nInvalid Choice!!!\n");
                break;
        }
    } while (ch != 6);
}
