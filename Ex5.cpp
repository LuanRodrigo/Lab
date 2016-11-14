#include <iostream>

using namespace std;

int main()
{
    int fat,n;

        do{
            cout<< "Digite um numero inteiro e positivo:";
            cin >> n;

        }while(n <=0);

        for(fat = 1; n > 1;n = n -1){
            fat = fat*n;
        }


        cout << fat;
    return 0;
}
