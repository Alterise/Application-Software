//         Structure:
//         
//			 Client
//		    /	   \
//	Depositor	 Organization
//				    |
//				 Creditor

#include <iostream>
#include <time.h>	
#include <random>
using namespace std;

class Client
{
public:
	double resourse;
	int available_operations;
	bool is_operation_in_progress;
	Client()
	{
		resourse = 0;
		available_operations = 1;
		is_operation_in_progress = 0;
	}

	virtual double calculate_profit(double money, int time)
	{
		if (money < 0 || time < 0) return NAN;
		else return money * 0 * time;
	}

	void show_profit(double money, int time)
	{
		if (isnan(calculate_profit(money, time))) cout << "Wrong input";
		else cout << "Profit: " << calculate_profit(money, time) << endl;
	}

	double get_resourse()
	{
		return resourse;
	}

	bool get_operation()
	{
		if (available_operations <= 0 && !is_operation_in_progress) return 0;
		else
		{
			available_operations--;
			is_operation_in_progress = 1;
			return 1;
		}
	}

	bool stop_operation()
	{
		if (!is_operation_in_progress) return 0;
		is_operation_in_progress = 0;
		return 1;
	}

	bool add_operation()
	{
		available_operations++;
		return 1;
	}
};

class Depositor : public Client
{
private:
	long long last_deposit_time;
	double on_deposit;
	double deposit_percent;
public:
	Depositor()
	{	
		resourse = 0;
		available_operations = 1;
		last_deposit_time = -1;
		is_operation_in_progress = 0;
		on_deposit = 0;
		deposit_percent = 0.001 * (rand() % 10 + 6);
	}

	Depositor(double resourse_tmp, int available_operations_tmp)
	{
		resourse = resourse_tmp;
		available_operations = available_operations_tmp;
		last_deposit_time = -1;
		is_operation_in_progress = 0;
		on_deposit = 0;
		deposit_percent = 0.001 * (rand() % 10 + 6);
	}

	bool do_deposit(double resourse_tmp)
	{
		if (resourse - resourse_tmp < 0) return 0;
		if (!get_operation()) return 0;
		on_deposit = resourse_tmp;
		resourse -= on_deposit;
		last_deposit_time = time(0);
		return 1;
	}

	bool get_deposit()
	{
		if (last_deposit_time == -1) return 0;
		if (!stop_operation()) return 0;
		resourse += on_deposit * (1 + deposit_percent * (time(0) - last_deposit_time));
		on_deposit = 0;
		last_deposit_time = -1;
		return 1;
	}

	double calculate_profit(double money, int time)
	{
		if (money < 0 || time < 0) return NAN;
		else return money * deposit_percent * time;
	}
};

class Organization : public Client
{
protected:
	long long last_dismissal_time;
	int employee_count;
	double employee_price;
public:
	Organization()
	{
		resourse = 0;
		available_operations = 1;
		employee_count = 1;
		last_dismissal_time = -1;
		employee_price = 100;
	}

	Organization(double resourse_tmp, int available_operations_tmp, int employee_tmp, int employee_price_tmp)
	{
		resourse = resourse_tmp;
		available_operations = available_operations_tmp;
		last_dismissal_time = -1;
		employee_count = employee_tmp;
		employee_price = employee_price_tmp;
	}

	bool dismiss_employee()
	{
		if (employee_count <= 0) return 0;
		else
		{
			employee_count--;
			return 1;
		}
	}

	bool hire_employee()
	{
		if (resourse - employee_price < 0) return 0;
		employee_count++;
		resourse -= employee_price;
		return 1;
	}

	int get_employee_count()
	{
		return employee_count;
	}
};

class Creditor : public Organization
{
private:
	long long last_credit_issuance_time;
	double on_credit; 
	double credit_percent;
public:
	Creditor()
	{
		resourse = 0;
		available_operations = 1;
		employee_count = 1;
		last_dismissal_time = -1;
		last_credit_issuance_time = -1;
		on_credit = 0;
		employee_price = 100;
		credit_percent = 0.001 * (rand() % 10 + 16);
	}

	Creditor(double resourse_tmp, int available_operations_tmp, int employee_tmp, int employee_price_tmp)
	{
		resourse = resourse_tmp;
		available_operations = available_operations_tmp;
		last_dismissal_time = -1;
		employee_count = employee_tmp;
		last_credit_issuance_time = -1;
		on_credit = 0;
		employee_price = employee_price_tmp;
		credit_percent = 0.001 * (rand() % 10 + 16);
	}

	bool give_credit(double resourse_tmp)
	{
		if (resourse - resourse_tmp < 0) return 0;
		if (!get_operation()) return 0;
		on_credit = resourse_tmp;
		resourse -= on_credit;
		last_credit_issuance_time = time(0);
		return 1;
	}

	bool get_credit()
	{
		if (last_credit_issuance_time == -1) return 0;
		if (!stop_operation()) return 0;
		resourse += on_credit * (1 + credit_percent * (time(0) - last_credit_issuance_time));
		on_credit = 0;
		last_credit_issuance_time = -1;
		return 1;
	}

	double calculate_profit(double money, int time)
	{
		if (money < 0 || time < 0) return NAN;
		else return money * credit_percent * time;
	}
};

int main()
{
	srand(time(0));
	int switcher, switcher2;
	double amount;
	int time;
	char arithmetic_operation;

	Depositor client_dep(853.31, 2);
	Organization client_org(15534.28, 5, 15, 120);
	Creditor client_crd(8623.21, 3, 5, 80);

	while (1)
	{
		cout << endl << "    Choose who to operate with:" << endl;
		cout << "1 - Depositor" << endl;
		cout << "2 - Organization" << endl;
		cout << "3 - Creditor" << endl;
		cout << "0 - Exit" << endl;
		cout << endl << "Input: ";
		cin >> switcher;
		if (!switcher) return 0;
		else if (switcher == 1)
		{
			while (1)
			{
				cout << endl << "    Menu:" << endl;
				cout << "1 - Do deposit" << endl;
				cout << "2 - Get deposit back" << endl;
				cout << "3 - Calculate profit from deposit" << endl;
				cout << "4 - Get balance" << endl;
				cout << "0 - Go back" << endl;
				cout << endl << "Input: ";
				cin >> switcher2;
				if (!switcher2) break;
				else if (switcher2 == 1)
				{
					cout << "Input amount: ";
					cin >> amount;
					if (!client_dep.do_deposit(amount)) cout << "Not enough resourse" << endl;
				}
				else if (switcher2 == 2)
				{
					if (!client_dep.get_deposit()) cout << "No deposit to get back" << endl;
				}
				else if (switcher2 == 3)
				{
					cout << "Input deposit amount and time: ";
					cin >> amount >> time;
					client_dep.show_profit(amount, time);
				}
				else if (switcher2 == 4)
				{
					cout << client_dep.get_resourse() << endl;
				}
				else cout << "Wrong Input. Try again" << endl;
			}
		}
		else if (switcher == 2)
		{
			while (1)
			{
				cout << endl << "    Menu:" << endl;
				cout << "1 - Hire employee" << endl;
				cout << "2 - Dismiss employee" << endl;
				cout << "3 - Get employee count" << endl;
				cout << "4 - Get balance" << endl;
				cout << "0 - Go back" << endl;
				cout << endl << "Input: ";
				cin >> switcher2;
				if (!switcher2) break;
				else if (switcher2 == 1)
				{
					if (!client_org.hire_employee()) cout << "Not enough resourse" << endl;
				}
				else if (switcher2 == 2)
				{
					if (!client_org.dismiss_employee()) cout << "No employee to dismiss" << endl;
				}
				else if (switcher2 == 3)
				{
					cout << client_org.get_employee_count() << endl;
				}
				else if (switcher2 == 4)
				{
					cout << client_org.get_resourse() << endl;
				}
				else cout << "Wrong Input. Try again" << endl;
			}
		}
		else if (switcher == 3)
		{
			while (1)
			{
				cout << endl << "    Menu:" << endl;
				cout << "1 - Hire employee" << endl;
				cout << "2 - Dismiss employee" << endl;
				cout << "3 - Get employee count" << endl;
				cout << "4 - Get balance" << endl;
				cout << "5 - Give credit" << endl;
				cout << "6 - Get credit back" << endl;
				cout << "7 - Calculate profit from credit" << endl;
				cout << "0 - Go back" << endl;
				cout << endl << "Input: ";
				cin >> switcher2;
				if (!switcher2) break;
				else if (switcher2 == 1)
				{
					if (!client_crd.hire_employee()) cout << "Not enough resourse" << endl;
				}
				else if (switcher2 == 2)
				{
					if (!client_crd.dismiss_employee()) cout << "No employee to dismiss" << endl;
				}
				else if (switcher2 == 3)
				{
					cout << client_crd.get_employee_count() << endl;
				}
				else if (switcher2 == 4)
				{
					cout << client_crd.get_resourse() << endl;
				}
				else if (switcher2 == 5)
				{
					cout << "Input amount: ";
					cin >> amount;
					if (!client_crd.give_credit(amount)) cout << "Not enough resourse" << endl;
				}
				else if (switcher2 == 6)
				{
					if (!client_crd.get_credit()) cout << "No deposit to get back" << endl;
				}
				else if (switcher2 == 7)
				{	
					cout << "Input credit amount and time: ";
					cin >> amount >> time;
					client_dep.show_profit(amount, time);
				}
				else cout << "Wrong Input. Try again" << endl;
			}
		}
		else cout << "Wrong Input. Try again" << endl;
	}
}
