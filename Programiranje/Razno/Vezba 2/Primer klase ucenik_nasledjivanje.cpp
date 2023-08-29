#include<iostream>
#include<string>
using namespace std;

class Osoba
{
protected:
string ime, prezime,jmbg;
public:
Osoba()
{
}Osoba(string im,string pr,string JMBG) 
{
	ime=im;
	prezime=pr;
	jmbg=JMBG;
}

void unosIme(string im)
	{
		ime=im;
	}
void unosPrezime(string pr)
	{
		prezime=pr;
	}
void unosJMBG(string JMBG)
	{
		if(JMBG.length()==13)
		jmbg=JMBG;
		else
		jmbg="Pogresno";
	}	
virtual void ispis()
	{ 
		cout<<"Ime :"<<ime<<"  Prezime :"<<prezime<<"  JMBG :"<<jmbg<<endl;
	}
};

class Ucenik:public Osoba
{
private:
	int razred,odeljenje;
	public:
	Ucenik()
{
	}	
	Ucenik(string im,string pr,string JMBG,int raz,int od):Osoba(im,pr,JMBG)
	{
		razred=raz;
		odeljenje=od;
	}
	
void ispis()
	{ 
		cout<<"Ime :"<<ime<<"  Prezime :"<<prezime<<"  Razred :"<<razred<<" Odeljenje "<<odeljenje<<endl;
	}	
};

int main()
{
Osoba *osoba=new Osoba();
string Ime,Prezime,JMBG;
int  Razred,Odeljenje;
cout<<"Unesi ime ";
cin>>Ime;
cout<<"Unesi prezime ";
cin>>Prezime;
cout<<"Unesi jmbg ";
cin>>JMBG;
osoba->unosIme(Ime);
osoba->unosPrezime(Prezime);
osoba->unosJMBG(JMBG);
cout<<"Unesi razred ";
cin>>Razred;
cout<<"Unesi odeljenje ";
cin>>Odeljenje;
Ucenik *ucenik=new Ucenik(Ime,Prezime,JMBG,Razred,Odeljenje);
cout<<"Ispis za objekat klase Osoba"<<endl;
osoba->ispis();
cout<<"Ispis za objekat klase Ucenik"<<endl;
ucenik->ispis();

	
}
