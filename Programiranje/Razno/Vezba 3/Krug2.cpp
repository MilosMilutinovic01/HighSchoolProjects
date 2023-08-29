#include<iostream>
#include<math.h>
using namespace std;
class Tacka
{
private:      
float x,y;
public:
Tacka(float a,float b){x=a;y=b;}
float rastojanje(Tacka) const;
};
float Tacka::rastojanje(Tacka a)const
{
return sqrt(pow(x-a.x,2)+pow(y-a.y,2));
} 
class Krug
{
private:
Tacka centar;
Tacka sa_kruga;
public:
Krug(Tacka a,Tacka b)
{
	centar=a;
	sa_kruga=b;
}
float kPovrsina();
float kObim();
};
float Krug::kPovrsina()
{
float r;
const float pi=3.14159;
r=centar.rastojanje(sa_kruga);
return pow(r,2)*pi;
}
float Krug::kObim()
{
float r;
const float pi=3.14159;
r=centar.rastojanje(sa_kruga);
return 2*pi*r;
}
int main()
{
cout<<"Unesite koordinate centra kruga i tacke sa kruga"<<'\n';
float x, y, x1,y1;
cout<<"Unesi x koordinatu centra :";
cin>>x;
cout<<"Unesi y koordinatu centra :";
cin>>y;
cout<<"Unesi x koordinatu na krugu :";
cin>>x1;
cout<<"Unesi y koordinatu na krugu :";
cin>>y1;
Tacka c(x,y),k(x1,y1);
Krug k1(c,k);
cout<<"Povrsina kruga je: "<<k1.kPovrsina()<<endl;
cout<<"Obim kruga je: "<<k1.kObim();
system("PAUSE");
}
