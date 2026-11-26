Algoritmo FD2_LAUTIK_HANDIENA
	
	Definir num, mayor Como Entero
	
	Escribir "*** Ejecución Iniciada. ***"
	
	Escribir "Sartu 1.go zenbakia:"
	Leer num
	mayor <- num
	
	Escribir "Sartu 2.go zenbakia:"
	Leer num
	Si num > mayor Entonces
		mayor <- num
	FinSi
	
	Escribir "Sartu 3.go zenbakia:"
	Leer num
	Si num > mayor Entonces
		mayor <- num
	FinSi
	
	Escribir "Sartu 4.go zenbakia:"
	Leer num
	Si num > mayor Entonces
		mayor <- num
	FinSi
	
	Escribir "Sartu duzun zenbakirik handiena ", mayor, " da."
	
	Escribir "*** Ejecución Finalizada. ***"
	
FinAlgoritmo