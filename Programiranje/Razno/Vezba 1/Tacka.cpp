#include<iostream>
#include<math.h>
using namespace std;
class Tacka
{
	private:
	float x,y;
	public:
	void unos(double a,double b) 
	{
		x=a;
		y=b;
	}
	Tacka()
	{
	x=0;
	y=0;
	}
	Tacka(float a, float b);
	void ispis();
	double rastojanje1(Tacka a)
	{
		return sqrt((x-a.x)*(x-a.x)+(y-a.y)*(y-a.y));
	}
	double rastojanje2(Tacka a,Tacka b);
	};
	void Tacka::ispis()
	{
		cout<<"Koordinate tacke su("<<x<<","<<y<<")"<<endl;
	}
	double Tacka::rastojanje2(Tacka a,Tacka b)
	{
		return sqrt(pow(b.x-a.x,2)+pow(b.y-a.y,2));
	}
	Tacka::Tacka(float a, float b)
	{
	x=a;
	y=b;
	}
main()
{
Tacka A,B,C(0,0);
float x1,y1,a,b,c;
cout<<"Unesi x za tacku A ";
cin>>x1;
cout<<"Unesi y za tacku A ";
cin>>y1;
A.unos(x1,y1);
cout<<"Unesi x za tacku B ";
cin>>x1;
cout<<"Unesi y za tacku B ";
cin>>y1;
B.unos(x1,y1);
a=B.rastojanje1(C);
b=rastojanje2(C,A);
c=A.rastojanje1(B);
if((a+b>c)&&(a+c>b)&&(c+b>a)&&(a>0)&&(b>0)&&(c>0))
cout<<"Stranice trougla su a="<<a<<" b="<<b<<" c="<<c<<endl;
else
cout<<"Ne moze se konstruisati trougao"<<endl;
}
