#include <iostream>
#include <fstream>
#include <time.h>
#include <random>
#include <string>
#include <vector>
using namespace std;

void random_generator(int count, string filename)
{
	ofstream fout(filename);
	vector<string> name = {"Sneakers", "Boots", "Sandals", "Flip-flops"};
	vector<string> type = {"Male", "Female", "Child"};
	vector<string> season = { "Winter", "Fall", "Spring", "Summer" };
	vector<string> color = { "Black", "White", "Brown", "Red", "Yellow", "Orange", "Violet" };
	for (int i = 0; i < count; i++)
	{
		fout << name[rand() % 4] << " " << type[rand() % 3] << " " << season[rand() % 4] << " ";
		fout << color[rand() % 7] << " " << rand() % 30 + 20 << " " << (rand() % 140 + 5) * 100 << endl;
	}
	fout.close();
}

class Shoes
{
private:
	string name, type, season, color;
	double size , price;
public:
	Shoes(string name_tmp, string type_tmp, string season_tmp, string color_tmp, double size_tmp, double price_tmp)
	{
		name = name_tmp;
		type = type_tmp;
		season = season_tmp;
		color = color_tmp;
		size = size_tmp;
		price = price_tmp;
	}

	void set_name(string name_tmp)
	{
		name = name_tmp;
	}

	void set_type(string type_tmp)
	{
		type = type_tmp;
	}

	void set_season(string season_tmp)
	{
		season = season_tmp;
	}

	void set_color(string color_tmp)
	{
		color = color_tmp;
	}

	void set_size(double size_tmp)
	{
		size = size_tmp;
	}

	void set_price(double price_tmp)
	{
		price = price_tmp;
	}

	double get_price()
	{
		return price;
	}

	double get_size()
	{
		return size;
	}

	string get_name()
	{
		return name;
	}

	string get_type()
	{
		return type;
	}

	string get_season()
	{
		return season;
	}

	string get_color()
	{
		return color;
	}

	void print()
	{
		cout << name << " " << type << " " << season << " " << color << " " << size << " " << price << endl;
	}
};

string clear_extra(string str)
{
	str.erase(remove(str.begin(), str.end(), '.'), str.end());
	str.erase(remove(str.begin(), str.end(), ','), str.end());
	str.erase(remove(str.begin(), str.end(), ':'), str.end());
	return str;
}

int main()
{
	double sum_price = 0;
	int counter = 0;
	vector<Shoes> elems;
	
	srand(time(0));
	random_generator(100, "input.txt");
	ifstream fin("input.txt");
	string name, type, season, color;
	double size, price;
	cout << " Name | Type | Season | Color | Size | Price" << endl;
	while (fin >> name >> type >> season >> color >> size >> price)
	{
		try
		{
			Shoes* tmp_class = new Shoes(clear_extra(name), clear_extra(type), clear_extra(season), clear_extra(color), size, price);
			elems.push_back(*tmp_class);
		}
		catch (...)
		{
			perror("Wrong input");
			fin.close();
			exit(1);
		}
	}

	for (int i = 0; i < elems.size(); i++)
	{
		if (elems[i].get_type() == "Child" && elems[i].get_season() == "Summer")
		{
			elems[i].print();
			sum_price += elems[i].get_price();
			counter++;
		}
	}

	try
	{
		cout << endl << "Average price: " << sum_price / counter << endl;
	}
	catch (...)
	{
		perror("No input");
		fin.close();
		exit(2);
	}

	fin.close();
}