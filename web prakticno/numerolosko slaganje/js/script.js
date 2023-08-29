function ime1(){
	var ime=document.getElementById("osoba1").value;
	var tekst=document.getElementById("ime1");
	tekst.innerHTML=ime;
}
function ime2(){
	var ime=document.getElementById("osoba2").value;
	var tekst=document.getElementById("ime2");
	tekst.innerHTML=ime;
}
function izracunaj(){
	ime1();
	ime2();
	var datum1=new Date(document.getElementById("datum1").value);
	var datum2= new Date(document.getElementById("datum2").value);
	var x;
	x=datum1.getDate().toString(10)+(datum1.getMonth()+1).toString(10)+datum1.getFullYear().toString(10);
	//console.log(x);
	x=zbirCifara(x);
	var y;
	y=datum2.getDate().toString(10)+(datum2.getMonth()+1).toString(10)+datum2.getFullYear().toString(10);
	//console.log(y);
	y=zbirCifara(y);
	var procenat;
	if(Number(x)>=Number(y))
		procenat=parseInt((Number(y)/Number(x))*100);
	else
		procenat=parseInt((Number(x)/Number(y))*100);
	document.getElementById("rezultat").innerHTML=procenat+"%";
}
function zbirCifara(vred){
	var n,sum=0;
	n=parseInt(vred);
	while (n) {
    sum += n % 10;
    n = Math.floor(n / 10);
	}
	//console.log(sum);
	if(sum>9)
	{
		
		sum=zbirCifara(sum);
		console.log(sum);
	}
	return sum;
}