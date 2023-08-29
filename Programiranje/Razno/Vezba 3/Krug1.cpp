#include<iostream>
#include<math.h>
using namespace std;
class Tacka
{
float x,y;
public:
Tacka()
{
	x=0;
	y=0;
}
Tacka(float a,float b);
void ispis()
{
cout<<"Koordinate tacke su ("<< x<<","<<y<<")"<<endl; 	
}
};
Tacka::Tacka(float a,float b):x(a),y(b){}
class Krug
{
private:
Tacka centar;
float r;
public:
Krug(){}
Krug(Tacka t,  float x);
float kPovrsina();
float kObim();
};
Krug::Krug(Tacka t, float x):centar(t),r(x){}
float Krug::kPovrsina()
{
const float pi=3.14159;
return pow(r,2)*pi;
}
float Krug::kObim()
{
const float pi=3.14159;
return 2*pi*r;
}
int main()
{
cout<<"Unesite koordinate centra kruga i poluprecnik "<<'\n';
float x, y, r;
cout<<"Unesi x koordinatu: ";
cin>>x;
cout<<"Unesi y koordinatu: ";
cin>>y;
cout<<"Unesi poluprecnik r: ";
cin>>r;
Tacka t(x,y);
Krug k1(t,r);
t.ispis();
cout<<"Povrsina kruga je: "<<k1.kPovrsina()<<endl;
cout<<"Obim kruga je: "<<k1.kObim();
system("PAUSE");
}
