var audio1 = document.getElementById("klavir");
var audio2 = document.getElementById("bubnjevi");
var audio3 = document.getElementById("saksofon");
var audio4 = document.getElementById("gitara");
var audio5 = document.getElementById("ksilofon");
var audio6 = document.getElementById("pikolo");
var audio7 = document.getElementById("violina");

function playAudio(t)
{
  t=parseInt(t);
  switch (t)
  {
    case 1 : audio1.play();break;
    case 2 : audio2.play();break;
    case 3 : audio3.play();break;
    case 4 : audio4.play();break;
    case 5 : audio5.play();break;
    case 6 : audio6.play();break;
    case 7 : audio7.play();break;
    default : audio1.play();
  }
}

function pauseAudio(t)
{
  t=parseInt(t);
  switch (t)
  {
    case 1 : audio1.pause();break;
    case 2 : audio2.pause();break;
    case 3 : audio3.pause();break;
    case 4 : audio4.pause();break;
    case 5 : audio5.pause();break;
    case 6 : audio6.pause();break;
    case 7 : audio7.pause();break;
    default : audio1.pause();
  }
}