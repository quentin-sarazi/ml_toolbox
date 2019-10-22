// test.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

int main()
{
    std::cout << "Hello World!\n"; 

	std::cout << "begin" << std::endl;
	double *model = linear_create_model(5);
	std::cout << "toto" << std::endl;
	auto *input = new double[5];
	for (int i = 0; i < 5; i++) {
		input[i] = 1;
	}
	double res = linear_classify(model, input, 5);
	std::cout << res << std::endl;
	linear_remove_model(model);
	std::cout << "end" << std::endl;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file