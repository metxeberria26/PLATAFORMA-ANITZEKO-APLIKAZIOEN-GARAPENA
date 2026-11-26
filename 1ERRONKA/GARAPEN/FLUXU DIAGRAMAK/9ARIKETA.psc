Algoritmo BederatzigarrenAriketa
	Definir letra1 Como Caracter
	Definir letra2 Como Caracter
	Escribir "Sartu lehenengo letra:"
	Leer letra1
	Escribir "Sartu bigarrengo letra:"
	Leer letra2
	Si letra1 = "letra2" Entonces
		Escribir "Sartu dituzun letrak berdinak dira."
	SiNo
		Si letra1 > letra2 Entonces
			Escribir "Sartutako letrak ez daude"
		SiNo
			Escribir Sartutako letra1 eta letra2 letrak, ordenean daude.
		FinSi
	FinSi
FinAlgoritmo
