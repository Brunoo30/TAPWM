
function jogar(escolhaDoJogador) {
    var opcoes = ['Pedra', 'Papel', 'Tesoura'];
    var escolhaDoComputador = opcoes[Math.floor(Math.random() * 3)];

    if (escolhaDoJogador === escolhaDoComputador) {
        alert ("Opção do computador:  " + escolhaDoComputador + '\n' + 'Você perdeu!');
    } else if (
        (escolhaDoJogador === 'Pedra' && escolhaDoComputador === 'Tesoura') ||
        (escolhaDoJogador === 'Papel' && escolhaDoComputador === 'Pedra') ||
        (escolhaDoJogador === 'Tesoura' && escolhaDoComputador === 'Papel')
    ) {
        alert ("Opção do computador:  " + escolhaDoComputador + '\n' + 'Você ganhou!');
    } else {
        alert ("Opção do computador:  " + escolhaDoComputador + '\n'+ 'Você perdeu!');
    }
}