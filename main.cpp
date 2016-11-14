#include <iostream>

using namespace std;

int main()
{
    float notas[20], soma=0, media = 0;


        for( int i=0;i<20;i++){
            cout << " Digite a nota:";
            cin >> notas[i];
            soma = soma+notas[i];
        }
        media = soma /20;



        cout << " A media das notas eh: " << media;

        for( int i = 0;i<20;i++){
            cout << " Nota do " << i << " aluno: " << notas[i];
        }



    return 0;
}
