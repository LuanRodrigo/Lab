#include <iostream>

using namespace std;

int main()
{
    int n[20], maior,menor, soma=0, media = 0;
    int X=5;

        for ( int i=0;i<X;i++){
            cout << " Digite um numero:";
            cin >> n[i];
            soma = soma + n[i];
    }
    media = soma/X;
    menor = n[0];
    maior = n[0];

        for( int i=0;i<X;i++){
            if(n[i]> maior){
                maior = n[i];
            }
    }
        for(int i=0;i<X;i++){
            if(n[i]<menor){
                menor = n[i];
            }
        }


            cout <<" Maior numero da serie: " << maior;
            cout <<"\n Menor numeor da serie: " << menor;
            cout << "\n A media da serie: " << media;
        for( int i=0;i<X;i++){
        if(n[i]> media){
            cout << "\n Acima da media: " << n[i];
        }
        }








    return 0;
}
