Algoritmo B3_Notak
	
	Definir izena Como Caracter
	Definir nota, batura, batazbestekoa Como Real
	Definir kopuru Como entero
	
	Escribir "Sartu ikaslearen izena:"
	Leer izena
	
	Mientras izena <> "" Hacer
		
		batura <- 0
		kopuru <- 0
		
		Escribir "Sartu nota (0 amaitzeko):"
		Leer nota
		
		Mientras nota <> 0 Hacer
			batura <- batura + nota
			kopuru <- kopuru + 1
			
			Escribir "Sartu beste nota (0 amaitzeko):"
			Leer nota
		FinMientras
		
		Si kopuru > 0 Entonces
			batazbestekoa <- batura / kopuru
			Escribir "Ikaslea: ", izena
			Escribir "Noten batez bestekoa: ", batazbestekoa
		FinSi
		
		Escribir "Sartu beste ikaslearen izena (hutsa amaitzeko):"
		Leer izena
		
	FinMientras
	
FinAlgoritmo