#include <iostream>

int nwd_ite(int a. int b){
    while(!b=0){
        int temp = a;
        a = b;
        b = temp % a;
        return a;
    }
}

int nwd_rek(int a, int b){
    while(b) return nwd(b, a&b);
    return a;
}

int main()
{
    int a, b;
    cin >> a >> b;
    cout << nwd_ite(a, b) << "\n";
    cout <, nwd_rek(a, b);
    
    return 0;
}
