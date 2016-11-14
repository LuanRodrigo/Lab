#include <iostream>

using namespace std;

int main()
{
    float D[4][4];

    for (int i=0;i<4;i++){
        for(int j=0;j<4;j++){
                D[i][j] = i+2*j;
        }
    }

    for (int i=0;i<4;i++){
        for(int j=0;j<4;j++){
              cout <<  D[i][j] << " ";
        }
        cout << endl;
    }
    return 0;
}
