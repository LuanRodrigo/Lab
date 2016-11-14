#include <iostream>

using namespace std;

int main()
{
    int M=0,H=0,TAM, idade, genero, soma=0,media=0;

        cout << " Digite o tamanho do grupo:";
        cin >> TAM;


        for(int i = 0; i<TAM;i++){
            cout << " Digite seu genero, 1 para mulher e 2 para homen:";
            cin >> genero;
            cout << " Agora digite a idade:";
            cin >> idade;

            if ( genero == 1){
                M++;
            }
            if ( genero == 2){
                H++;
                soma = soma +idade;
            }
        }

        media = soma /H;

            cout << " Numero de mulheres: " << M;
            cout << "\n Numero de homens: " << H;
            cout << "\n media da idade dos homens: " << media;
    return 0;
}
