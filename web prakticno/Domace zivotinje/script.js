function PlaySound(soundobj) {
    var thissound=document.getElementById(soundobj);
    thissound.play();
}
var modal;
function StopSound(soundobj) {
    var thissound=document.getElementById(soundobj);
    thissound.pause();
    thissound.currentTime = 0;
}
function otvoriModal(zivotinja)
{
modal = document.getElementById(zivotinja+"Modal");
modal.style.display = "block";
}
 function zatvori(){
  modal.style.display = "none";
}
// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";
  }
}