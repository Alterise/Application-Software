#include <iostream>
#include <iomanip>
#include <cmath>
#include <random>
using namespace std;

void matrix_init(double*** matrix, int rows, int cols)
{
    int i;
    *matrix = new double* [rows];
    for (i = 0; i < rows; i++)
    {
        (*matrix)[i] = new double [cols];
    }
}

void matrix_print(double** matrix, int rows, int cols)
{
    cout.precision(2);
    cout << fixed;
    int i, j;
    for (i = 0; i < rows; i++)
    {
        for (j = 0; j < cols; j++)
        {
            cout << setw(6) << matrix[i][j] << " ";
        }
        cout << endl;
    }
}

void matrix_del(double*** matrix, int rows, int cols)
{
    int i, j;
    for (i = 0; i < rows; i++)
    {
        delete((*matrix)[i]);
    }
    delete(*matrix);
}

void matrix_rand_fill(double** matrix, int rows, int cols)
{
    srand(time(0));
    int i, j;
    for (i = 0; i < rows; i++)
    {
        for (j = 0; j < cols; j++)
        {
            matrix[i][j] = (rand() % 1900 - 900) / 100.0;
        }
    }
}

void matrix_fill(double** matrix, int rows, int cols)
{
    int i, j;
    for (i = 0; i < rows; i++)
    {
        for (j = 0; j < cols; j++)
        {
            cin >> matrix[i][j];
        }
    }
}

void matrix_diag_sums(double** matrix, int rows, int cols)
{
    int i, j;
    double sum;
    cout.precision(2);
    cout << fixed;
    for (i = 0; i < rows; i++)
    {
        cout << "   |   ";
    }
    cout << endl;
    for (i = rows - 1; i >= 0; i--)
    {
        j = 0;
        sum = 0;
        while (j + i < rows)
        {
            sum += matrix[i + j][j++];
        }
        cout << setw(6) << sum << " ";
    }
    cout << endl;
}

int main()
{
    int rows, cols;

    cout << "Input size of matrix: ";
    cin >> rows >> cols;
    if (rows <= 0 || cols <= 0)
    {
        perror("Input Error");
        return 0;
    }
    double** matrix;
    matrix_init(&matrix, rows, cols);
    matrix_rand_fill(matrix, rows, cols);
    matrix_print(matrix, rows, cols);
    matrix_diag_sums(matrix, rows, cols);
    matrix_del(&matrix, rows, cols);
}