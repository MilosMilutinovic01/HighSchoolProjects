function zameni()
{
    var x = document.getElementById("prikaz").src;
    var a = x.lastIndexOf("/")+1;
    var b = x.substring(0,a);
    var grad = document.getElementById("grad").value;
    document.getElementById("prikaz").src=b+grad;
}