#pragma once
#include <iostream>
#include <vector>
#include <string>
using namespace std;

class myText
{
	string name;
	string body;
public:
	myText()
	{
		name = "<Doesn't named yet>";
		body = "<No text yet>";
	}

	~myText()
	{
		name.clear();
		body.clear();
	}

	string get_text();
	string get_name();
	void change_name(string);
	void change_text(string);
	void change_symbols(char, char);
	int stat_symbols(char);
};