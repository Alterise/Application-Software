#include <iostream>
#include <string>
#include <algorithm>
#include <fstream>
using namespace std;

int main()
{
	string surnames_file_name, birthdates_file_name, final_file_name;
	cout << "Input name of file with surnames: ";
	cin >> surnames_file_name;
	cout << "Input name of file with birth dates: ";
	cin >> birthdates_file_name;
	cout << "Input name of output file: ";
	cin >> final_file_name;

	ifstream File_surnames(surnames_file_name);
	ifstream File_birthdates(birthdates_file_name);
	ofstream File_final(final_file_name);

	try
	{
		if (!File_surnames.is_open())
		{
			throw surnames_file_name;
		}
	}
	catch (string surnames_file_name)
	{
		cout << "File opening error: " << surnames_file_name;
		exit(1);
	}

	try
	{
		if (!File_birthdates.is_open())
		{
			throw birthdates_file_name;
		}
	}
	catch (string birthdates_file_name)
	{
		cout << "File opening error: " << birthdates_file_name;
		exit(2);
	}

	try
	{
		if (!File_final.is_open())
		{
			throw final_file_name;
		}
	}
	catch (string final_file_name)
	{
		cout << "File opening error: " << final_file_name;
		exit(3);
	}

	string str_tmp1, str_tmp2;

	while (File_surnames >> str_tmp1 && File_birthdates >> str_tmp2)
	{
		str_tmp1.erase(remove(str_tmp1.begin(), str_tmp1.end(), '.'), str_tmp1.end());
		str_tmp1.erase(remove(str_tmp1.begin(), str_tmp1.end(), ','), str_tmp1.end());
		str_tmp1.erase(remove(str_tmp1.begin(), str_tmp1.end(), ':'), str_tmp1.end());

		// Ôîğìàò ââîäà äàòû: ÄÄ/ÌÌ/ÃÃÃÃ
		str_tmp2.erase(remove(str_tmp2.begin(), str_tmp2.end(), '.'), str_tmp2.end());
		str_tmp2.erase(remove(str_tmp2.begin(), str_tmp2.end(), ','), str_tmp2.end());
		str_tmp2.erase(remove(str_tmp2.begin(), str_tmp2.end(), ':'), str_tmp2.end());
		File_final << str_tmp1 << " " << str_tmp2 << endl;
		cout << str_tmp1 << " " << str_tmp2 << endl;
	}

	File_surnames.close();
	File_birthdates.close();
	File_final.close();
	return 0;
}