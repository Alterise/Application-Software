#include <iostream>
using namespace std;

int max_elem(int** matrix, int um, int lm, int n) {
	int max = matrix[um][0];
	for (int i = um; i < lm; i++)
	{
		for (int j = 0; j < n; j++)
		{
			if (max < matrix[i][j])
			{
				max = matrix[i][j];
			}
		}
	}
	return max;
}


int main()
{
	int n, m;
	cin >> m >> n;
	int** matrix = new int*[m];
	for (int i = 0; i < m; i++) 
	{
		matrix[i] = new int[n];
	}
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			cin >> matrix[i][j];
		}
	}
	int um, lm;
	cin >> um >> lm;
	um--;
	lm--;
	cout << max_elem(matrix, um, lm, n);
	for (int i = 0; i < m; i++)
	{
		delete matrix[i];
	}
	delete [] matrix;
}