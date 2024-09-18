#include<iostream>
#include<fstream>
#include <sstream>
using std::cout;
using std::cin;
using std::endl;

void swapIpAndMac(const std::string& fileName) {

    std::ifstream inFile(fileName);
    std::string outputFileName = "output.txt"; // ���� ��� ������ �����������
    std::ofstream outFile(outputFileName);

    if (!inFile.is_open()) {
        std::cerr << "�� ������� ������� ���� ��� ������." << std::endl;
        return;
    }
    if (!outFile.is_open()) {
        std::cerr << "�� ������� ������� ���� ��� ������." << std::endl;
        return;
    }

    std::string line;
    while (std::getline(inFile, line)) {
        std::istringstream stream(line);
        std::string ip, mac;

        // ������ ip � mac �������
        if (std::getline(stream, ip, '\t') && std::getline(stream, mac)) {
            // ���������� �� ������� �������
            outFile << mac << '\t' << ip << std::endl;
        }
        else {
            std::cerr << "������ ��� ������ ������: " << line << std::endl;
        }
    }

    inFile.close();
    outFile.close();

    std::cout << "������ ������� ���������. ���������� �������� � " << outputFileName << std::endl;
}

void main() {
    
    setlocale(LC_ALL, "");

    std::string fileName = "C:\\Users\\����\\source\\repos\\HomeWork\\FileCPP\\201 RAW.txt"; // ������� ����
    swapIpAndMac(fileName);
    
}

/*
192.168.100.21        00-19-99-b4-c2-ae
192.168.100.22        00-19-99-ae-a8-8e
192.168.100.23        00-19-99-b5-e9-9b
192.168.100.24        00-19-99-b4-a2-ed
192.168.100.25        00-19-99-ad-4f-51

192.168.100.26        00-19-99-dc-52-80
192.168.100.27        00-19-99-b4-a2-fb
192.168.100.28        00-19-99-b2-b3-e6

192.168.100.29        00-19-99-ae-a5-59
192.168.100.30        00-19-99-dc-52-77
192.168.100.31        00-19-99-ac-b8-11
192.168.100.32        00-19-99-b5-e9-4d
*/