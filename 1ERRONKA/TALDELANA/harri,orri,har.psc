

Algoritmo Harri_Paper_Guraizeak
	
	Definir jokalaria, IA Como Entero
	Definir puntuakJokalaria, puntuakIA Como Entero
	Definir aukeraJokalaria, aukeraIA Como Caracter
	
	puntuakJokalaria <- 0
	puntuakIA <- 0
	
	Escribir "HARRI, PAPER EDO GURAIZEAK"
	Escribir "Lehenengo 3 puntura iristen denak irabaziko du!"
	
	Mientras puntuakJokalaria < 3 Y puntuakIA < 3 Hacer
		
		Escribir " "
		Escribir "------ MARKAGAILUA ------"
		Escribir "Zure puntuak: ", puntuakJokalaria
		Escribir "IAren puntuak: ", puntuakIA
		
		Escribir " "
		Escribir "Aukeratu:"
		Escribir "1. Harri"
		Escribir "2. Paper"
		Escribir "3. Guraizeak"
		Leer jokalaria
		
		Si jokalaria >= 1 Y jokalaria <= 3 Entonces
			
			IA <- Aleatorio(1,3)
			
			Segun jokalaria Hacer
				1:
					aukeraJokalaria <- "Harri"
				2:
					aukeraJokalaria <- "Paper"
				3:
					aukeraJokalaria <- "Guraizeak"
			FinSegun
			
			Segun IA Hacer
				1:
					aukeraIA <- "Harri"
				2:
					aukeraIA <- "Paper"
				3:
					aukeraIA <- "Guraizeak"
			FinSegun
			
			Escribir " "
			Escribir "ZURE AUKERA: ", aukeraJokalaria
			Escribir "IA-REN AUKERA: ", aukeraIA
			
			Si jokalaria = IA Entonces
				Escribir "BERDINKETA!"
			SiNo
				Si (jokalaria = 1 Y IA = 3) O (jokalaria = 2 Y IA = 1) O (jokalaria = 3 Y IA = 2) Entonces
					Escribir "TXANDA ZUK IRABAZI DUZU!"
					puntuakJokalaria <- puntuakJokalaria + 1
				SiNo
					Escribir "TXANDA IAK IRABAZI DU!"
					puntuakIA <- puntuakIA + 1
				FinSi
			FinSi
			
			Escribir " "
			Escribir "------ MARKAGAILUA ------"
			Escribir "Zure puntuak: ", puntuakJokalaria
			Escribir "IAren puntuak: ", puntuakIA
			Escribir "-------------------------"
			
		SiNo
			Escribir "Aukera okerra! 1, 2 edo 3 aukeratu."
		FinSi
		
	FinMientras
	
	Escribir " "
	Escribir "===== PARTIDA AMAITU DA ====="
	Escribir "Azken markagailua:"
	Escribir "Zuk: ", puntuakJokalaria
	Escribir "IAk: ", puntuakIA
	
	Si puntuakJokalaria = 3 Entonces
		Escribir "ZORIONAK! PARTIDA IRABAZI DUZU!"
	SiNo
		Escribir "IAK IRABAZI DU PARTIDA!"
	FinSi
	
FinAlgoritmo
