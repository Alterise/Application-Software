void trans_matr(double**, int, int, double);
double avg_ar(double**, int, int);
bool val_check(double**, int, double);
void col_division(double**, int, int, double*);
void max_col_check(double, double, int, int*);

void trans_matr(double **matrix, int row_count, int col_count, double val) {
	double max_avg = avg_ar(matrix, 1, row_count);
	int i, max_col = 1;
	
	if (!val_check(matrix, row_count, val))
	{
		return;
	}

	for (i = 2; i < col_count; i++)
	{
		max_col_check(avg_ar(matrix, i, row_count), max_avg, i, &max_col);
	}
	col_division(matrix, max_col, row_count, &max_avg);
}

double avg_ar(double **matrix, int col, int row_count)
{
	double sum;
	sum = 0;
	for (int j = 0; j < row_count; j++)
	{
		sum = sum + matrix[j][col];
	}
	return sum / row_count;
}

bool val_check(double **matrix, int row_count, double val)
{
	for (int i = 0; i < row_count; i++)
	{
		if (matrix[i][0] <= fabs(val)) return 0;
	}
	return 1;
}

void col_division(double **matrix, int col, int row_count, double *max_avg)
{
	for (int i = 0; i < row_count; i++)
	{
		matrix[i][col] /= matrix[i][0];
	}
	*max_avg = avg_ar(matrix, col, row_count);
}

void max_col_check(double tmp_avg, double max_avg, int col, int *max_col)
{
	if (tmp_avg > max_avg) *max_col = col;
}

//double** matrix_init(double ***matrix, int row_count, int col_count)
//{
//	*matrix = new double* [row_count];
//	int i;
//	for (i = 0; i < row_count; i++)
//	{
//		*(matrix[i]) = new double[col_count];
//	}
//	return *matrix;
//}

//void matrix_del(double*** matrix, int row_count)
//{
//	int i;
//	for (i = 0; i < row_count; i++)
//	{
//		delete matrix[i];
//	}
//	delete matrix;
//}