#include <iostream>

using namespace std;

int main()
{
    int memoria,n, soma, maior=0,menor=0;

            cout << " Digite o tamanho do lote:";
            cin >> n;


        for(int i = 0; i<n;i++){
            cout << " Digite a capacidade de memoria do computador: ";
            cin >> memoria;

            if(memoria>maior){
                maior = memoria;
            }
            if(memoria < menor){
                menor = memoria;
            }
        }
            cout << " Maior Memoria verificada: " << maior;
            cout << "\n Menor memoria verificada: " << menor;
    return 0;
}
