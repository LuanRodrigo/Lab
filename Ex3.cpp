#include <iostream>

using namespace std;

int main()
{
    float num[50],maior,menor,media=0,soma=0;


        for(int i = 0; i<50;i++){
            cout << " Digite um numero:";
            cin >> num[i];
        }


        maior = num[0];
        menor = num[0];

        for(int i = 0; i<50;i++){
            soma = soma + num[i];
        }

        media = soma /50;

        for(int i = 0; i<50;i++){
            if( num[i] > maior){
                maior = num[i];
            }
        }
        for(int i = 0; i<50;i++){
            if( num[i] < menor){
                menor = num[i];
            }
        }


    return 0;
}
