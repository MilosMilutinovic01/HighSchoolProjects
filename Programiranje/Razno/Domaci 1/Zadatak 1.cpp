#include<iostream>
using namespace std;
class Trougao
{
	private:
		float a,b,c;
	public:
		void unos(float x,float y,float z)
		{
			a=x;
			b=y;
			c=z;
		}
		int provera(float x,float y,float z)
		{
			if(a>0 && b>0 && c>0 && a+b>c && a+c>b && b+c>a)
			return 1;
			else
			return 0;
		}
		float ispis_a()
		{
			return a;
		}
		float ispis_b()
		{
			return b;
		}
		float ispis_c()
		{
			return c;
		}
};

main()
{
float a,b,c;
Trougao t1;
cout<<"Unesi stranicu a: ";
cin>>a; 
cout<<"Unesi stranicu b: ";
cin>>b;
cout<<"Unesi stranicu c: ";
cin>>c;
t1.unos(a,b,c);
cout<<"uneli ste a="<<t1.ispis_a()<<" b="<<t1.ispis_b()<<" c="<<t1.ispis_c()<<endl;	
if(t1.provera(a,b,c)>0)
cout<<"Moguce je konstruisati trougao";
else
cout<<"Nemoguce je konstruisati trougao";
return 0;
}
