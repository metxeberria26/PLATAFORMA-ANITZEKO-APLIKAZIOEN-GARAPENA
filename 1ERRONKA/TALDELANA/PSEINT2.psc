

Algoritmo Ahorcado
	
	Definir hitza, letra, hutsak, ezkutua Como Caracter
	Definir zenbakia, saiakerak, i Como Entero
	Definir aurkitua Como Logico
	
	zenbakia <- Aleatorio(1,5)
	
	Segun zenbakia Hacer
		1:
			hitza <- "ETXEA"
		2:
			hitza <- "KATUA"
		3:
			hitza <- "TXAKURRA"
		4:
			hitza <- "LIBURUA"
		5:
			hitza <- "ESKOLA"
	FinSegun
	
	hutsak <- ""
	ezkutua <- ""
	saiakerak <- 0
	
	Para i <- 1 Hasta Longitud(hitza) Hacer
		ezkutua <- ezkutua + "_"
	FinPara
	
	Mientras saiakerak < 8 Y ezkutua <> hitza Hacer
		
		Escribir "Hitza: ", ezkutua
		Escribir "Okerreko letrak: ", hutsak
		Escribir "Saiakerak geratzen dira: ", 8 - saiakerak
		Escribir "Sartu letra bat:"
		Leer letra
		
		aurkitua <- Falso
		
		Para i <- 1 Hasta Longitud(hitza) Hacer
			Si Subcadena(hitza,i,i) = letra Entonces
				aurkitua <- Verdadero
				ezkutua <- Subcadena(ezkutua,1,i-1) + letra + Subcadena(ezkutua,i+1,Longitud(ezkutua))
			FinSi
		FinPara
		
		Si aurkitua = Falso Entonces
			hutsak <- hutsak + " " + letra
			saiakerak <- saiakerak + 1
			Escribir "Oker! Letra hori ez dago hitzean."
		SiNo
			Escribir "Ondo! Letra hori hitzean dago."
		FinSi
		
	FinMientras
	
	Si ezkutua = hitza Entonces
		Escribir "ZORIONAK! Hitza asmatu duzu!"
		Escribir "Hitza: ", hitza
	SiNo
		Escribir "Saiakerak amaitu dira!"
		Escribir "Hitz zuzena zen: ", hitza
	FinSi
	
FinAlgoritmo




