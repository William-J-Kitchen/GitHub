// ClassSubmission.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using std::string;
using std::cout;
using std::cin;

class Shape {
public:
    string Color;

    void getArea() {
    };
};

class Rectangle :Shape {
public:
    string Color;
    float Height;
    float Width;

    void getArea() {
        float Height, Width, Area;
        
        cout << "Please enter the Height and Width.\n";
        cin >> Height, Width;
        Area = Height * Width;
        cout << "The area of the Rectangle is " << Area << ".\n";
    }
};

class Traingle :Shape {
    string Color;
    float Base;
    float Width;

    void getArea() {
        float Height, Base, Area;

        cout << "Please enter the Height and Base.\n";
        cin >> Height, Base;
        Area = (0.5)* Height * Base;
        cout << "The area of the Triangle is " << Area << ".\n";
    }
};

class Circle :Shape {
    string Color;
    float Radius;

    void getArea() {
        float Radius, Area;

        cout << "Please enter the radius.\n";
        cin >> Radius;
        Area = 3.14 * Radius * Radius;
        cout << "The area of the circle is " << Area << ".\n";
    }
};

static void Main()
{
    //Shape Rectangle;
    //Rectangle.Color = "Blue";
    //Rectangle.Height = ""
    //Hound.Height = 24;
    //Hound.Weight = 60;
    //Hound.Shake();
    //Hound.Sit();
    //Hound.LayDown();


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
