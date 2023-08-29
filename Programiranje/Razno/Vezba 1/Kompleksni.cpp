#include<iostream>
#include<math.h>
using namespace std;
class Kompleksni
{
	private:
		float re,im;
	public:
	Kompleksni();
	Kompleksni(float Re,float Im);
	void unos_re(float Re);
	void unos_im(float Im);
	friend float vrat_re(Kompleksni c);
	friend float vrat_im(Kompleksni c);
		
};
		Kompleksni::Kompleksni()
		{
			re=0;
			im=0;
		}
		Kompleksni::Kompleksni(float Re,float Im)
		{
		re=Re;
		im=Im;
		}
		void Kompleksni::unos_re(float Re)
		{
			this->re=Re;
		}
		void Kompleksni::unos_im(float Im)
		{
			im=Im;
		}
		float vrat_re(Kompleksni c)
		{
			return c.re;
		}
		float vrat_im(Kompleksni c)
		{
			return c.im;
		}
main()
{
	float r,i;
	cout<<"Unesi realni deo ";
	cin>>r;
	cout<<"Unesi imaginarni deo ";
	cin>>i;
	Kompleksni k(r,i);
	//k.unos_re(r);
	//k.unos_im(i);
	cout<<"Realni deo je "<<vrat_re(k)<<" imaginarni deo je "<<vrat_im(k)<<endl;
	return 0;
}
