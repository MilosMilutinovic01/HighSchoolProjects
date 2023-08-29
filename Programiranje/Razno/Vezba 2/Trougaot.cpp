#include <iostream>
#include<math.h>
using namespace std;
class Trougao
{
private:
float a,b,c; 
public:
bool moze()
{
return(a>0&&b>0&&c>0&&(a+b)>c&&(a+c)>b&&(b+c)>a);
}
Trougao(float x,float y,float z)
{
a=x;
b=y;
c=z;
}
void ispis()
{
cout<<"Unesli ste trougao sa stranicama\na="<<a<<"\nb="<<b<<"\nc="<<c<<endl;   
}
float povrs()
{
float s;
s=(a+b+c)/2;
return(sqrt(s*(s-a)*(s-b)*(s-c)));
}
float obim()
{
return (a+b+c);    
}
};
int main()
{
float x,y,z;
cout<<"Unesi stranicu a ";
cin>>x;
cout<<"Unesi stranicu b ";
cin>>y;
cout<<"Unesi stranicu c ";
cin>>z;
Trougao t(x,y,z);
if(t.moze())
{
cout<<"Trougao je moguce konstruisati"<<endl;
cout<<"Povrsina trougla je "<<t.povrs()<<endl;
cout<<"Obim trougla je "<<t.obim()<<endl;
t.ispis();
}
else
cout<<"Trougao je nemoguce konstruisati"<<endl; 
system("PAUSE");
return(0);
}
