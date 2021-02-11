#include <iostream>
#include "text.h"
#include <string>
using namespace std;

int main()
{
	Text mytext;
	int switcher = 0;
	while (1)
	{
		cout << "\nMenu: \n";
		cout << "1 - Create text\n";
		cout << "2 - Print text\n";
		cout << "3 - Change name of text\n";
		cout << "4 - Change text\n";
		cout << "5 - Change symbols in text\n";
		cout << "6 - Get stats of symbols in text\n";
		cout << "0 - To stop\n";
		cout << "Input number: ";
		cin >> switcher;
		cout << endl;
		if (!switcher) return 0;
		else if (switcher == 1) mytext.create();
		else if (switcher == 2) mytext.print();
		else if (switcher == 3) mytext.change_name();
		else if (switcher == 4) mytext.change_text();
		else if (switcher == 5) mytext.change_symbols();
		else if (switcher == 6) mytext.stat_symbols();
		else printf("\nPlease, input correct number\n");
	}
}