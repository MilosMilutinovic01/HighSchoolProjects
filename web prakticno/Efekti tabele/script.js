function sortTable() {
  var table, rows, switching, i, x, y, shouldSwitch;
  table = document.getElementById("Tabela");
  switching = true;
  while (switching) {
    switching = false;
    rows = table.rows;
    for (i = 1; i < (rows.length); i++) {
      shouldSwitch = false;
      x = rows[i].getElementsByTagName("TD")[4];
      y = rows[i + 1].getElementsByTagName("TD")[4];
      if (Number(x.innerHTML) < Number(y.innerHTML)) {
        shouldSwitch = true;
        break;
      }
    }
    if (shouldSwitch) {
      rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
      switching = true;
    }
  }
}
function oboji()
{
	var	table = document.getElementById("Tabela");
	table.setAttribute("class", "table-striped");
}
function prosli()
{
	var rows, i, x;
  var table = document.getElementById("Tabela");
  rows = table.rows;
    //alert(rows.length - 1);
	for (i = 1; i < (rows.length); i++)
	{
	   x = rows[i].getElementsByTagName("TD")[4];
	   if (Number(x.innerHTML)>50)
		   rows[i].setAttribute("style", "background-color: green;")
	}  
}
function nisuProsli()
{
	var rows, i, x;
  var table = document.getElementById("Tabela");
  rows = table.rows;
	for (i = 1; i < (rows.length); i++)
	{
	   x = rows[i].getElementsByTagName("TD")[4];
	   if (Number(x.innerHTML)<50)
		   rows[i].setAttribute("style", "background-color: red;")
	}  
}
function izbaci()
{
	var rows, i, x;
  var table = document.getElementById("Tabela");
  rows = table.rows;
const n=rows.length;
	for (i = 1; i < n; i++)
	{
	   x = rows[i].getElementsByTagName("TD")[4];
	   console.log(n)
	   console.log(Number(x.innerHTML));
	   if (Number(x.innerHTML)<50)
	   {
		   rows[i].remove();
		   i=i-1;
	   }
	}  
	sortTable();
}