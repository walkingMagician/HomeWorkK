#include<iostream>
#include<fstream>
using std::cout;
using std::cin;
using std::endl;


void main()
{
	std::string filePath = "C:\\Users\\ёрий\\source\\repos\\HomeWork\\FileCPP";

	std::ofstream inputFile(filePath);
	if (!inputFile.eof())
	{
		cout << "Error";
	}
	char line =  char();
	std::ifstream fin;
	
}

