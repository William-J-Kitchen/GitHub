// Practice1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using std::string;
using std::cout;
using std::cin;
using std::max;

class Functions
{
public:
    void basicFunction() {
        cout << "Function Executed.";
    }

    void multiFunction(string basic = "Default", int num = 1) {
        cout << basic << "\n" << num << "\n";
    }

    int returnFunction(int x, int y) {
        return x + y;
    }

    int referenceFunction(int& x, int& y) {
        int z = x;
        x = y;
        y = z;
    }

    void referenceFunction(string x, string y) {
        string z = x;
        x = y;
        y = z;
    }
    void outsideFunction();
private:
    int c = 3;
protected:
    int d = 5;
};

class Child : public Functions {
    public:
        void nonsenseFunction() {
            cout << "Nonsense. \n";
        }
};

class GrandChild : public Child, public Functions {
    public:
        void nonsenseFunction() {
            cout << "GrandChild nonsense. \n";
        }
};



void Functions::outsideFunction() {
    cout << "Outside Function.";
}

class Game {
public:
    string name;
    string genre;
    int year;
    Game(string x, string y, int z) {
        name = x;
        genre = y;
        year = z;
    }
};

int main()
{
    int Integer = 15;
    int Integer2 = 10;
    int Integer3 = 0;
    char Character = 't';
    double Double = 25.0;
    bool Boolean = true;
    string String = "Text";
    string String2 = "Extra text";
    const int Months = 12;
    float Float = 5.75;

    string fullName;

    cout << "Type a number, between 1 & 5: \n";
    cin >> Integer;
    Integer3 = Integer;
    cout << "Your number plus 10 is: " << Integer + 10 << "\n";
    cout << "Your number minus 6 is: " << Integer - 6 << "\n";
    cout << "Your number times 5 is: " << Integer * 5 << "\n";
    cout << "Your number divided by 3 is: " << Integer / 3 << "\n";
    cout << "Your number incremented is: " << Integer++ << "\n";

    cout << "Is your number greater than 5? " << (Integer > 5) << "\n";
    cout << "Is your number equal to 7? " << (Integer == 7) << "\n";
    cout << "Does your number NOT equal 3? " << (Integer != 3) << "\n";
    cout << "Is your number less than or equal to 4? " << (Integer <= 4) << "\n";

    cout << (Integer += 3) << "\n";
    cout << (Integer &= 3) << "\n";
    cout << (Integer <<= 1) << "\n";

    cout << (Integer > 5 && Integer < 15) << "\n";
    cout << (Integer > 1 || Integer < 10) << "\n";
    cout << !(Integer > 1 || Integer < 10) << "\n";

    /* This is a comment
    * that spans multiple lines
    */

    cout << max(Integer, Integer2) << "\n";
    cout << sqrt(Integer) << "\n";
    cout << round(7.6) << "\n";
    cout << pow(Integer, Integer2) << "\n";

    cout << Integer3 << "\n";
    switch (Integer3)
    {
    case 1:
        cout << "First \n";
        break;

    case 2:
        cout << "Second \n";
        break;
    case 3:
        cout << "Third \n";
        break;
    case 4:
        cout << "Fourth \n";
        break;
    case 5:
        cout << "Fifth \n";
        break;
    }

    int test = 20;
    string result = (test > 10) ? "Test > 10 \n" : "Test < 10 \n";
    cout << result;


    cout << String + " " + String2 << "\n";
    cout << "The length of String is: " << String.length() << "\n";
    cout << "The third character of String2 is: " << String2[2] << "\n";
    String[3] = 'i';
    cout << "Changing the text of String: " << String << "\n";

    cout << "Please input your full name. \n";
    getline(cin, fullName);

    if (fullName.length() > 5)
    {
        cout << "Your name is more than 5 characters long. \n";
    }
    else if (fullName.length() < 5) 
    {
        cout << "Your name is less than 5 characters long. \n";
    }
    else
    {
        cout << "Your name is not less than or more than 5 characters long. \n";
    }

    int i = 0;
    while (i < 5)
    {
        cout << i << "\n";
        i++;
    }

    i = 0;
    do
    {
        cout << i << "\n";
        i++;
    } 
    while (i < 5);

    for (int i = 0; i < 5; i++) {
        if (i == 4) {
            break;
        }
        cout << i << "\n";
    }
    i = 0;
    string enemies[4] = { "Golem", "Displacer", "Rasp", "Train" };
    for (int i = 0; i < 4; i++) {
        cout << enemies[i] << "\n";
    }
    
    string food = "Pizza";
    string& meal = food;

    cout << food << "\n";  // Outputs Pizza
    cout << meal << "\n";  // Outputs Pizza
    
    string* ptr = &food;
    cout << &food << "\n";
    cout << ptr << "\n";
    cout << *ptr << "\n";


    //Functions myObj;
    //myObj.basicFunction();
    //myObj.multiFunction("Parameter", 3);
    //myObj.returnFunction(7, 3);
    //myObj.referenceFunction(Integer, Integer2);
    //myObj.outsideFunction();

    //Game gameObj1("Morrowind", "RPG", 2002);
    //Game gameObj2("Crono Trigger", "RPG", 1990);
    //cout << gameObj1.name << " " << gameObj1.genre << " " << gameObj1.year << "\n";

    Child myChild;
    GrandChild myGrandChild;
    myChild.nonsenseFunction();
    myGrandChild.nonsenseFunction();

    try {
        int level = 7;
        if (level >= 10) {
            cout << "You are eligible for the next quest.";
        }
        else {
            throw (level);
        }
    }
    catch (int myNum) {
        cout << "You aren't high enough level for the next quest.\n";
        cout << "Level is: " << myNum;
    }
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
