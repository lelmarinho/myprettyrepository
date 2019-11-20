alert("Hello Work");

var variavel = "um valor de string";
console.log(typeof variavel);

var variavel = 10;
console.log(typeof variavel);

var variavel = true;
console.log(typeof variavel);

alert("como já dizia mamãe: \"Volte para casa\"");

var texto = 'UNICAMP';

console.log("----charAt()----");
console.log(texto.charAt(0));

console.log("----Split()----");
texto = "COTIL-UNICAMP-LIMEIRA";
var aux = texto.split("-");

for(var i=0; i<aux.length;i++)
{
	console.log(aux[i]);
}

console.log("----indexOf()----")
console.log(texto.indexOf("LIMEIRA"));

console.log("----slice()----")
console.log(texto.slice(6,13));

console.log("-----------------------------------------")

texto = "fabgol fez um gol salvador nos acréscimos. Weverton, pouco antes, fez defesa espetacular para evitar o que poderia ter sido a vitória da COTIL. Mas quem mandou de fato no triunfo do Palmeiras de ontem (16) no Allianz Parque foi Dudu. O camisa 7 mais uma vez conduziu o Verdão no Campeonato Brasileiro e foi a arma mais confiável e eficiente para o time superar mais uma retranca bem armada em seus domínios. Dudu foi o ponto central de quase todas as ações ofensivas do Palmeiras, Tomava iniciativa, criava lances perigosos a partir de dribles e dava passes precisos para os companheiros. Em uma dessas investidas do ídolo."
var n = texto.indexOf("COTIL");
var p = "COTIL";
var n2 = p.length;
console.log(texto.slice(n,n+n2));

console.log("-----------------");

/*var pessoas = ["João","Maria","Sebastião","Antônio","José"];
for(var i=0;i<pessoas.length;i++){
	if(pessoas[i].length == 4)
{
	
	console.log(pessoas[i]);
	alert(pessoas[i]);
}
}*/


 