function latcir()
{
	document.getElementById("2").value="";
    tekst=document.getElementById("1").value;
	var tekst1=tekst;
	tekst="";
	for (var i = 0; i < tekst1.length; i++) {
		if(tekst1.charAt(i)=="n" && tekst1.charAt(i+1)=="j")
		{
			tekst+="њ";
			i+=2;
		}
		if(tekst1.charAt(i)=="d" && tekst1.charAt(i+1)=="j")
		{
			tekst+="ђ";
			i+=2;
		}
		if(tekst1.charAt(i)=="l" && tekst1.charAt(i+1)=="j")
		{
			tekst+="љ";
			i+=2;
		}
		if(tekst1.charAt(i)=="d" && tekst1.charAt(i+1)=="ž")
		{
			tekst+="џ";
			i+=2;
		}
		if(tekst1.charAt(i)=="a")tekst+="а";
		if(tekst1.charAt(i)==" ")tekst+=" ";
		if(tekst1.charAt(i)=="b")tekst+="б";
		if(tekst1.charAt(i)=="c")tekst+="ц";
		if(tekst1.charAt(i)=="d")tekst+="д";
		if(tekst1.charAt(i)=="e")tekst+="е";
		if(tekst1.charAt(i)=="f")tekst+="ф";
		if(tekst1.charAt(i)=="g")tekst+="г";
		if(tekst1.charAt(i)=="h")tekst+="х";
		if(tekst1.charAt(i)=="i")tekst+="и";
		if(tekst1.charAt(i)=="j")tekst+="ј";
		if(tekst1.charAt(i)=="k")tekst+="к";
		if(tekst1.charAt(i)=="l")tekst+="л";
		if(tekst1.charAt(i)=="m")tekst+="м";
		if(tekst1.charAt(i)=="n")tekst+="н";
		if(tekst1.charAt(i)=="o")tekst+="о";
		if(tekst1.charAt(i)=="p")tekst+="п";
		if(tekst1.charAt(i)=="r")tekst+="р";
		if(tekst1.charAt(i)=="s")tekst+="с";
		if(tekst1.charAt(i)=="t")tekst+="т";
		if(tekst1.charAt(i)=="u")tekst+="у";
		if(tekst1.charAt(i)=="v")tekst+="в";
		if(tekst1.charAt(i)=="č")tekst+="ч";
		if(tekst1.charAt(i)=="ć")tekst+="ћ";
		if(tekst1.charAt(i)=="š")tekst+="ш";
}
	document.getElementById("1").value=tekst1;
	document.getElementById("2").value=tekst;
}

function cirlat()
{
    tekst=document.getElementById("2").value;
	document.getElementById("1").value="";
	document.getElementById("2").value="";
	var tekst1=tekst;
	tekst="";
	for (var i = 0; i < tekst1.length; i++) {
		
		if(tekst1.charAt(i)=="а"){tekst+="a";continue;}
		if(tekst1.charAt(i)==" "){tekst+=" ";continue;}
		if(tekst1.charAt(i)=="б"){tekst+="b";continue;}
		if(tekst1.charAt(i)=="ц"){tekst+="c";continue;}
		if(tekst1.charAt(i)=="д"){tekst+="d";continue;}
		if(tekst1.charAt(i)=="е"){tekst+="e";continue;}
		if(tekst1.charAt(i)=="ф"){tekst+="f";continue;}
		if(tekst1.charAt(i)=="г"){tekst+="g";continue;}
		if(tekst1.charAt(i)=="х"){tekst+="h";continue;}
		if(tekst1.charAt(i)=="и"){tekst+="i";continue;}
		if(tekst1.charAt(i)=="ј"){tekst+="j";continue;}
		if(tekst1.charAt(i)=="к"){tekst+="k";continue;}
		if(tekst1.charAt(i)=="л"){tekst+="l";continue;}
		if(tekst1.charAt(i)=="м"){tekst+="m";continue;}
		if(tekst1.charAt(i)=="н"){tekst+="n";continue;}
		if(tekst1.charAt(i)=="о"){tekst+="o";continue;}
		if(tekst1.charAt(i)=="п"){tekst+="p";continue;}
		if(tekst1.charAt(i)=="р"){tekst+="r";continue;}
		if(tekst1.charAt(i)=="с"){tekst+="s";continue;}
		if(tekst1.charAt(i)=="т"){tekst+="t";continue;}
		if(tekst1.charAt(i)=="у"){tekst+="u";continue;}
		if(tekst1.charAt(i)=="в"){tekst+="v";continue;}
		if(tekst1.charAt(i)=="ч"){tekst+="č";continue;}
		if(tekst1.charAt(i)=="ћ"){tekst+="ć";continue;}
		if(tekst1.charAt(i)=="њ"){tekst+="nj";continue;}
		if(tekst1.charAt(i)=="ђ"){tekst+="đ";continue;}
		if(tekst1.charAt(i)=="ш"){tekst+="š";continue;}
		if(tekst1.charAt(i)=="џ"){tekst+="dž";continue;}
}
console.log(tekst);
	document.getElementById("2").value=tekst1;
	document.getElementById("1").value=tekst;
}