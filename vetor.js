
//nome = prompt("Digite seu nome:");
var vetor = new Array(5);

for (var i = 0; i<vetor.length; i++){
     vetor[i] = prompt("Valor da posição ["+i+"]:");
}

atualizaTela();

function addPrimeiraPos(){
	var valor = document.getElementById("txtValor").value;
	if (valor.trim() ==""){
		alert("Informe um valor");
	} else {
	vetor.unshift(valor);
	atualizaTela();
}
}

function addUltimaPos(){
	var valor = document.getElementById("txtValor").value;
	if (valor.trim()==""){
		alert("Informe um valor");
	}else {
	vetor.push(valor);
	atualizaTela();
}
}

function removePrimeiro(){
	if (vetor.length <= 0){
		alert("O vetor está vazio");
	} else {
	var valor = document.getElementById("txtValor").value;
	vetor.shift(valor);
	atualizaTela();
}
}
function removeUltimo(){
	var valor = document.getElementById("txtValor").value;
	if (valor.length <= 0){
		alert("O vetor está vazio");
			} else {
	vetor.pop(valor);
	atualizaTela();
}
}
function atualizaTela(){
	var dadosVetor = "<b>Dados do Vetor:</b><br><br>";
for (var i = 0; i < vetor.length; i++){
	dadosVetor = dadosVetor + vetor[i] + "<br>";
}

var exibeVetorHTML = document.getElementById("exibeVetor");
exibeVetorHTML.innerHTML = dadosVetor;
}