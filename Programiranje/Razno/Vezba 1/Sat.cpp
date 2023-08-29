#include<iostream>
using namespace std;
class Sat
{
private:
int sat,minut,sekund;
public:
Sat(int s,int m, int sek)
{
sat=s;
minut=m;
sekund=sek;
}
bool proveri();
};
bool Sat :: proveri()
{
if((0<=sat&&sat<24)&&(0<=minut&&minut<60)&&(0<=sekund&&sekund<60))
return true;
else
return false;
}
main()
{
int st,min,sek;
cout<<"Unesi sate ";
cin>>st;
cout<<"Unesi minute ";
cin>>min;
cout<<"Unesi sekunde ";
cin>>sek;
Sat cas(st,min,sek);
if(cas.proveri())
cout<<"Ispravno uneto vreme";
else
cout<<"Pogresno uneto vreme";


}

