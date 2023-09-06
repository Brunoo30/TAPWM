function Media() {
    var nome = prompt("Digite o nome do aluno:");
    var nota1 = parseFloat(prompt("Digite a primeira nota:"));
    var nota2 = parseFloat(prompt("Digite a segunda nota:"));
    var nota3 = parseFloat(prompt("Digite a terceira nota:"));

    if (isNaN(nota1) || isNaN(nota2) || isNaN(nota3)) {
        alert("Por favor, insira notas válidas.");
        return;
    }

    var media = (nota1 + nota2 + nota3) / 3;

    alert("A média do aluno " + nome + " é: " + media.toFixed(2));
}