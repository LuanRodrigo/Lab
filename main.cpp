#include <iostream>

using namespace std;

int main()
{
    float A[4][3],B[4][3],C[4][3],T[4][3], menor;


    for (int i=0;i<4;i++){
        for(int j=0;j<3;j++){
            cout << "Digite a matriz A:";
            cin >> A[i][j];
        }
    }

    for (int i=0;i<4;i++){
        for(int j=0;j<3;j++){
            cout << "Digite a matriz B;";
            cin >> B[i][j];
        }
    }

    for (int i=0;i<4;i++){
        for(int j=0;j<3;j++){
            C[i][j] = A[i][j] + B[i][j];

        }
    }

    menor = C[0][0];

    for (int i=0;i<4;i++){
        for(int j=0;j<3;j++){
            T[i][j] = A[j][i];

        }
    }


    for (int i=0;i<4;i++){
        for(int j=0;j<3;j++){
            if(C[i][j] < menor){
                menor = C[i][j];
            }
        }
    }

    for (int i=0;i<4;i++){
        for(int j=0;j<3;j++){
          cout << C[i][j];
        }
    }
    for (int i=0;i<4;i++){
            cout << endl;
        for(int j=0;j<3;j++){
          cout << T[i][j] << " " ;
        }
    }

        cout << " A menor elemento de C eh: " << menor;





    return 0;
}
