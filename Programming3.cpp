// Programming3.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <iostream>
#include <time.h>

using namespace std;


int main()
{
	int i, ship_size = 5, x, y, path, j, t, ii, it, i3;
	/*
	int** m = new int* [20];
	for (i = 0; i < 20; i++)
	{
		m[i] = new int[20];
	}
	*/
	int m[13][13];
	for (i = 1; i < 12; i++) {
		for (j = 1; j < 12; j++) {
			m[i][j] = 0;
		}
	}
	for (; ship_size != 1; ) {
		ship_size = ship_size - 1;
		for (j = 1; j < 6 - ship_size; j++) {
			cout << "\n ship_size " << ship_size;			
			t = 4; x = 0;
			y = 0;
			while (t == 4 || t == 5) {
				t = 4;
				//srand(time(NULL));
				x = rand() % 7+ 1;
				y = rand() % 7 + 1;
				path = rand() % 2 + 1;
				switch (path) {
				case 2:
				{
					for (ii = 0; ii <= ship_size + 1; ii++) {
						if (m[x][y] != 0) { t = 5; }
						if (m[x][y + ii] != 0) { t = 5; }
						if (m[x + 1][y + ii] != 0) { t = 5; }
						if (m[x + 1][y + ii + 1] != 0) { t = 5; }
						if (m[x][y + ii + 1] != 0) { t = 5; }
						if (m[x - 1][y + ii - 1] != 0) { t = 5; }
						if (m[x - 1][y + ii] != 0) { t = 5; }
						if (m[x - 1][y + ii + 1] != 0) { t = 5; }
						if (m[x][y + ii - 1] != 0) { t = 5; }
						if (m[x + 1][y + ii - 1] != 0) { t = 5; }				
					}
					for (i3 = 1; i3 <= ship_size && t != 5; i3++) {
						m[x][y + i3] = 1;
						t = 0;
					}
					break;
			}
				case 1:
				{
					for (ii = 0; ii <= ship_size + 1; ii++) {
						if (m[x][y] != 0) { t = 5; }
						if (m[x + ii][y] != 0) { t = 5; }
						if (m[x + ii + 1][y] != 0) { t = 5; }
						if (m[x + ii + 1][y + 1] != 0) { t = 5; }
						if (m[x + ii][y + 1] != 0) { t = 5; }
						if (m[x + ii - 1][y - 1] != 0) { t = 5; }
						if (m[x + ii - 1][y] != 0) { t = 5; }
						if (m[x + ii - 1][y - 1] != 0) { t = 5; }
						if (m[x + ii][y - 1] != 0) { t = 5; }
						if (m[x + ii + 1][y - 1] != 0) { t = 5; }
					}
					for (i3 = 1; i3 <= ship_size && t != 5; i3++) {
						m[x + i3][y] = 1;
						t = 0;
					}
					break;
				}
				}
			}
		}
	}
	cout << "\n";
	for (it = 1; it < 11; it++) {
		printf("%d %d %d %d %d %d %d %d %d %d", m[it][1], m[it][2], m[it][3], m[it][4], m[it][5], m[it][6], m[it][7], m[it][8], m[it][9], m[it][10]);
		cout << "\n";
	}

	_getchar_nolock();
	return 0;

}
