var s = $("#myPhpValue")[0].value;
var p = $(".centered");
console.log(s);
var bop = false;
for(var j=0;j<p.length;j++){
	for(var i=0;i<s.split(" ").length-1;i++){
		if(p[j].innerText==s.split(" ")[i]){
			bop=true;
		}
	}
	if(bop){
		p[j].style.color = "red";	
	}
	else{
		p[j].style.color = "green";
		p[j].parentElement.children[0].addEventListener('click',Reserve);
	}
	bop=false;
}
function Reserve(){
	this.parentElement.children[1].style.color = "yellow";
	$("#br")[0].value=this.parentElement.children[1].innerText;
}

/*var Time = setTimeout(function() {
        location.reload();
        clearTimeout(Time);
    },30000)*/



