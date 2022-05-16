#include "Pytanie.h"
#include <iostream>
#include <fstream>
using namespace std;

void Pytanie::wczytajPytanie(){
    fstream plik;
    plik.open("quiz.txt",ios::in);
    if(plik.good()==0) cout << "ERROR - Brak pliku" << endl;

    string linia;
    int nrLinii = (nrPytania-1)*5+1;
    int licznik = 1;

    while(getline(plik,linia)){
        if(licznik == nrLinii)
        {
            trescPytania = linia;
        }
        else if(licznik == nrLinii+1)
        {
            a = linia;
        }
        else if(licznik == nrLinii+2)
        {
            b = linia;
        }
        else if(licznik == nrLinii+3)
        {
            c = linia;
        }
        else if(licznik == nrLinii+4)
        {
            poprawna = linia;
        }
        licznik++;
    }
    plik.close();
}

void Pytanie::zadajPytanie(){
    cout << trescPytania <<endl;
    cout << a << endl;
    cout << b << endl;
    cout << c << endl;
}

void Pytanie::sprawdz(){
    cout << "Podaj odpowiedz: ";
    cin >> odpowiedz;

    if(odpowiedz == poprawna)
    {
        cout << "Poprawna odpowiedz\n" << endl;

    }
    else
    {
        cout << "Bledna odpowiedz\n" << endl;
    }
}
