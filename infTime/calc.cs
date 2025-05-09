#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    while(true){
    cout << "\nPodaj dwie liczby\n";
    int a, b;
    cin >> a >> b;
    
    cout << "Menu główne"; 
    cout << "\n1. Dodawanie";
    cout << "\n2. Odejmowanie";
    cout << "\n3. Mnożenie";
    cout << "\n4. Dzielenie";
    cout << "\n5. Mod";
    cout << "\n6. pow";
    cout << "\n7. exit\n";
    int choice;
    
    cin >> choice;
    switch(choice){
        case 1:
            cout << a + b;
            break;
        case 2:
            cout << a - b;
            break;
        case 3:
            cout << a * b;
            break;
        case 4:
            if(b != 0){
                cout << a/b;
            }
            else{
                cout << "Nie można dzielić przez 0";
            }
            break;
        case 5:
            if(b != 0){
                cout << a%b;
            }
            else{
                cout << "Nie można dzielić przez 0";
            }
        case 6:
            cout << pow(a, b);
            break;
        case 7:
            exit(0);
        default:
            cout << "Wybierz poprawną opcję";
    }
    }
}
