#include "MyForm.h"
using namespace std;

string myText::get_text()
{
	return body;
}

string myText::get_name()
{
	return name;
}

void myText::change_name(string name_tmp)
{
	name = name_tmp;
}

void myText::change_text(string text_tmp)
{
	body.clear();
	body = text_tmp;
}

void myText::change_symbols(char to_change, char change_to)
{
	for (size_t i = 0; i < body.size(); i++)
	{
		if (body[i] == to_change) body[i] = change_to;
	}
}

int myText::stat_symbols(char sym)
{
	int counter = 0;
	for (size_t i = 0; i < body.size(); i++)
	{
		if (body[i] == sym) counter++;
	}
	
	return counter;
}