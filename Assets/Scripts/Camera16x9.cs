using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera16x9 : MonoBehaviour {

	// (Camera.aspect) Aspect ou Aspecto é a divisão da largura pela altura da camera, caso você não de um valor a ela ela irá pegar sozinha automaticamente fazendo a operação dita ateriormente.
	// Mas caso sejá atribuido um valor o sistema automatico de atribuição não não irá mudar o aspect mais independente da troca de resolusão ou não.
	// A grande desvantagem desse metodo é que se a diferença entre resoluções for grande a imagem ficará puxada/distorcida.


	// O valor nessita ser chamado uma única vez para que seja atribuido permanentemente.
	void Start () {
		Camera.main.aspect = 1.8f; //A resolução 1.8 é uma aproximação do valor 1.777778 que é resultante da conta 16/9;
	}
}
