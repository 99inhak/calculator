#include <stdio.h>
#include <math.h>

// 버퍼 날리기
void clearInputBuffer() {
    while (getchar() != '\n');
}

int main() {
    double calcNum1, calcNum2, result;
    char calcOperator;
    char choice;

    do {
        printf("사칙연산 계산기 프로그램입니다.\n");

        printf("첫 번째 수를 입력해주세요: ");

        // scanf는 성공적으로 값을 읽어오면 1을 반환함. (true 반환)
        while (scanf_s("%lf", &calcNum1) != 1) {
            printf("잘못된 입력입니다. 숫자를 입력해주세요: ");

            // 전 버전에서 썼던 while문에 getchar()로 개행문자 다 날리던거 함수(메서드)로 만들어 사용
            clearInputBuffer(); 
        }

        printf("연산자를 입력해주세요 (+, -, *, /, ^, %%): ");
        clearInputBuffer();
        scanf_s("%c", &calcOperator);

        printf("두 번째 수를 입력해주세요: ");
        while (scanf_s("%lf", &calcNum2) != 1) {
            printf("잘못된 입력입니다. 숫자를 입력해주세요: ");
            clearInputBuffer();
        }

        switch (calcOperator) {
        case '+':
            result = calcNum1 + calcNum2;
            break;
        case '-':
            result = calcNum1 - calcNum2;
            break;
        case '*':
            result = calcNum1 * calcNum2;
            break;
        case '/':
            if (calcNum2 != 0) {
                result = calcNum1 / calcNum2;
            }
            else {
                printf("0으로 나눌 수 없습니다.\n");
                continue;
            }
            break;
        case '^':
            result = pow(calcNum1, calcNum2); // 재곱근 함수 math 라이브러리
            break;
        case '%':
            if ((int)calcNum2 != 0) {
                result = (int)calcNum1 % (int)calcNum2;
            }
            else {
                printf("0으로 나눌 수 없습니다.\n");
                continue;
            }
            break;
        default:
            printf("잘못된 연산자입니다.\n");
            continue;
        }

        printf("결과: %lf\n", result);

        printf("계속하려면 y를 입력하세요. 종료하려면 다른 키를 입력하세요: ");
        clearInputBuffer();
        choice = getchar();

    } while (choice == 'y' || choice == 'Y');

    printf("프로그램을 종료합니다.\n");
    return 0;
}
