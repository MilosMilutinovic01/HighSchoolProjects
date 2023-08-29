#include <iostream>
#include<math.h>
using namespace std;
class Tacka
{
	private:
	float x,y;
	public:
	void unesi(double a,double b); 
	friend double rastojanje(Tacka a,Tacka b);
	};
void Tacka::unesi(double a,double b) 
	{
		x=a;
		y=b;
	}
	double rastojanje(Tacka a,Tacka b)
	{
		return sqrt((a.x-b.x)*(a.x-b.x)+(a.y-b.y)*(a.y-b.y));
	}
class Trougao
{
private:
Tacka A,B,C; 

public:
bool moze()
{
return(rastojanje(A,B)>0&&rastojanje(A,C)>0&&rastojanje(B,C)>0&&(rastojanje(A,B)+rastojanje(A,C))>rastojanje(B,C)&&(rastojanje(A,B)+rastojanje(B,C))>rastojanje(A,C)&&(rastojanje(A,C)+rastojanje(B,C))>rastojanje(A,B));
}

Trougao(Tacka a,Tacka b,Tacka c)
{

A=a;
B=b;
C=c;
}

void ispis()
{
cout<<"\nUneli ste a= "<<rastojanje(A,B)<<"\nUneli ste b= "<<rastojanje(A,C)<<"\nUneli ste c= " <<rastojanje(B,C)<<endl;   
}
float povrs()
{
float s,P;
s=(rastojanje(A,B)+rastojanje(A,C)+rastojanje(B,C))/2;
P=sqrt(s*(s-rastojanje(A,B))*(s-rastojanje(A,C))*(s-rastojanje(B,C)));
return P;    
}
};
int main()
{

Tacka A,B,C;
float x,y,a,b,c;
cout<<"Unesi x za tacku A ";
cin>>x;
cout<<"Unesi y za tacku A ";
cin>>y;
A.unesi(x,y);
cout<<"Unesi x za tacku B ";
cin>>x;
cout<<"Unesi y za tacku B ";
cin>>y;
B.unesi(x,y);
cout<<"Unesi x za tacku C ";
cin>>x;
cout<<"Unesi y za tacku C ";
cin>>y;
C.unesi(x,y);
Trougao t(A,B,C);
if(t.moze())
{
cout<<"\nTrougao je moguce konstruisati"<<endl;
cout<<"Povrsina trougla je "<<t.povrs()<<endl;
t.povrs();
}
else
cout<<"Trougao je nemoguce konstruisati"<<endl; 
t.ispis();
system("PAUSE");
return(0);
}
