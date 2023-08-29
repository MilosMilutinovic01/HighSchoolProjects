function promeni(rec)
{
	document.getElementById("glavna").src=rec.src;
	var index1=rec.src.lastIndexOf("/")+1;
	var index2=rec.src.lastIndexOf(".");
	var pos=rec.src.substring(index1,index2);
	document.getElementById("ime").innerHTML=pos;
}