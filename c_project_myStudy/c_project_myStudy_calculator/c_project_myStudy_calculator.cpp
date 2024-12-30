
// C 언어에서 #include <stdio.h>는 표준 입출력 라이브러리를 포함하는 헤더 파일 
// 이 헤더 파일은 다양한 입출력 함수를 포함하는데 함수란 c언어 표준 라이브러리에 포함된 코드 블록
// 표준 라이브러리에 printf, scanf 등의 함수가 포함되어 있음
// 표준 라이브러리는 코드 재사용성, 일관성, 효율성, 유지보수 용이성, 교육 및 학습에 좋음
// 덕분에 나는 편안하게 입력 및 출력 함수를 가져다 사용
#include <stdio.h>

// 메인 함수는 프로그램의 시작 지점
// 보통 프로그램 시작 시 필요한 초기화 작업 수행
// 프로그램 주요 로직 실행 및 필요 함수 호출하며 흐름 제어
// 프로그램 종료 시 종료 상태 반환하여 최종적으로 동작
int main()
{

	double calcNum1;
	double calcNum2; // 첫번째 숫자와 두번째 숫자. 사용자에게 입력받는 계산할 두 수.

	char calcOperator; // 연산자 정보를 담을 변수. 사용자에게 입력받을 문자.
	double result; // 계산 결과를 담을 변수. 내 코드에서 결과를 담아두고 출력하는데 쓰이는 변수.

	printf("사칙연산 계산기 프로그램입니다.\n");


	// scanf의 보안 강화버전인 scanf_s를 사용
	// 버퍼 오버플로우와 같은 보안 취약점을 방지하기 위해 사용
	// scanf 함수는 입력 버퍼의 크기를 확인하지 않기 때문에, 잘못된 입력이 들어올 경우
	// 버퍼 오버플로우가 발생할 수 있음
	// 프로그램의 예기치 않은 동작이나 보안 문제를 일으킬 수 있음
	// 고정된 크기에 버퍼의 데이터보다 더 많은 데이터를 사용하려고 할 때 발생 

	// 지금은 char 변수 1바이트 크기이므로 문제가 없지만, 만약 문자열을 입력받아서
	// char 자료형으로 calcOperator[10] 배열 선언할 시 버퍼 오버플로우가 가능함
	printf("첫 번째 수를 입력해주세요\n");
	scanf_s("%lf", &calcNum1);

	// 사용자가 숫자를 입력하고 Enter 키를 누르면 숫자를 읽고, 개행 문자는 입력 버퍼에 남김
	// 입력 버퍼 비우기. scanf_s 함수는 입력 버퍼에 남아있는 개행문자 처리를 못함
	// getchar()는 입력 버퍼에서 한 문자를 반환하는데 while문으로 모든 입력 버퍼를 대상으로 하나씩 꺼내옴
	// \n을 찾을때까지. 그리고 그 과정에서 입력 버퍼에 있던 값은 제거됨
	while (getchar() != '\n');
	printf("calcNum1 INPUT value : %lf", calcNum1); // 로그출력

	printf("\n연산자를 입력해주세요\n");
	scanf_s("%c", &calcOperator);

	while (getchar() != '\n'); // 입력 버퍼 비우기
	printf("calcOperator INPUT value : %c", calcOperator); // 로그출력

	printf("\n두 번째 수를 입력해주세요\n");
	scanf_s("%lf", &calcNum2);

	while (getchar() != '\n'); // 입력 버퍼 비우기
	printf("calcNum2 INPUT value : %lf", calcNum2); // 로그출력


	switch (calcOperator)
	{
	case '+': result = calcNum1 + calcNum2;
		break;
	case '-': result = calcNum1 - calcNum2;
		break;
	case '*': result = calcNum1 * calcNum2;
		break;
	; case '/': if (calcNum2 != 0) { result = calcNum1 / calcNum2; }
			  else { printf("0으로 나눌 수 없습니다.\n"); return 1; }
			  break;
	default:
		break;
	}

	printf("\n계산결과 : %1f", result);

	return(0);
}

