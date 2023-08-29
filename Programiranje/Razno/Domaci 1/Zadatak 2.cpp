#include<iostream>
using namespace std;
class Complex
{
	private:
		float re,im;
	public:
		void unos(float x,float y)
		{
			re=x;
			im=y;	
		}
		void ispis()
		{
			cout<<"Uneli ste kompleksni broj "<<re<<"+"<<im<<"r"<<endl;
		}
		void zbir_razlika(Complex k1)
		{
			cout<<"Zbir kompleksnih brojeva iznosi "<<re+k1.re<<"+"<<im+k1.im<<"r"<<endl;
			cout<<"Razlika kompleksnih brojeva iznosi "<<re-k1.re<<im-k1.im<<endl;
		}
};
main()
{
Complex k1,k2;
float a,b,c,d;
cout<<"Unesi prvi kompleksan broj:"<<endl;
cout<<"Re: ";
cin>>a;
cout<<"Im: ";
cin>>b;
cout<<"Unesi drugi kompleksan broj:"<<endl;
cout<<"Re: ";
cin>>c;
cout<<"Im: ";
cin>>d;
k1.unos(a,b);
k2.unos(c,d);
k1.ispis();
k2.ispis();
k1.zbir_razlika(k2);
}
