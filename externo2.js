	  var hoje = new Date();  
      var dia = hoje.getDate();
      var mes = hoje.getMonth(); 
      var ano = hoje.getFullYear();
function escreveData()
{
      var meses = ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"];
      var mesTexto = meses[mes];

      var diaSemana = hoje.getDay();  
      var diasSemana = ["Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sabado"];
      var diaSemanaTexto = diasSemana[diaSemana];

      var textoData = diaSemanaTexto + ", " + dia + " de " + mesTexto + " de " + ano;

      var putInHTML = document.getElementById("dataHoje").innerHTML = textoData;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
}

function comparaDatas()
{
	var aniversarioU = document.getElementById("userDate");
	var aniversario = new Date(aniversarioU);

	if ((dia == aniversario.getDate())&&(mes++ == aniversario.getMonth())) 
	{
		alert("Feliz Aniversário!!!");
	} 

	else
		alert("Hoje não é seu aniversário. Que pena!");

}