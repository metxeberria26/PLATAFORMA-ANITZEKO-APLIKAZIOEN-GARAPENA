Algoritmo Futbol
	
	total <- 0
	maximo <- 0
	
	Para i <- 1 Hasta 11 Hacer
		Escribir "Zenbat gol sartu ditu ", i, ". jokalariak?"
		Leer golak
		
		total <- total + golak
		
		Si golak > maximo Entonces
			maximo <- golak
		FinSi
	FinPara
	
	batazbestekoa <- total / 11
	
	Escribir "Guztira: ", total
	Escribir "Bataz bestekoa: ", batazbestekoa
	Escribir "Gol gehien: ", maximo
	
FinAlgoritmo