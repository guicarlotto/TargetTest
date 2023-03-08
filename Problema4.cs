using System;

class Problema4 {
    static void Main() {

        double d = 100; // km
        double vCarro = 110; // km/h
        double vCaminhao = 80; // km/h
        double dPontoEncontro = d / 2; // km
        double tCarro = dPontoEncontro / vCarro * 60; // min
        double tCaminhao = (dPontoEncontro / vCaminhao + 2 * 5) * 60; // min, esse 2 são o número de pedágios e o 5 o tempo que demora em cada um.

        if (tCaminhao < tCarro) {
            Console.WriteLine("O caminhão está mais próximo de Ribeirão Preto.");
        } else {
            Console.WriteLine("O carro está mais próximo de Ribeirão Preto.");
        }
    }
}


/* 

    Primeiro calculei o tempo que cada um chegaria ao seu objetivo, depois disso comparei o tempo de chegada entre os dois. Se o carro chega mais rápido que o caminhão(tCarro < tCaminhnao) então ele está mais próximo de Ribeirão Preto e mais distânte de sua origem pois se comparado ao tempo do caminho ele cobriu uma distância muito maior.

 */