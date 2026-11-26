
	
	Algoritmo El_Juego_Del_Calamar
		
		Definir erantzuna, puntuak Como Entero
		
		puntuak <- 0
		
		Escribir "=================================="
		Escribir "     EL JUEGO DEL CALAMAR"
		Escribir "=================================="
		Escribir "Erantzun galdera hauei!"
		Escribir " "
		
		Escribir "1. Zein da protagonista nagusiaren izena?"
		Escribir "1. Seong Gi-hun"
		Escribir "2. Cho Sang-woo"
		Escribir "3. Hwang Jun-ho"
		Leer erantzuna
		
		Si erantzuna = 1 Entonces
			Escribir "Ondo! Erantzun zuzena da."
			puntuak <- puntuak + 1
		SiNo
			Escribir "Oker! Seong Gi-hun da protagonista."
		FinSi
		
		Escribir " "
		Escribir "2. Zein zen lehenengo joko ospetsua?"
		Escribir "1. Sokatik salto egitea"
		Escribir "2. Argi gorria, argi berdea"
		Escribir "3. Ezkutaketan aritzea"
		Leer erantzuna
		
		Si erantzuna = 2 Entonces
			Escribir "Ondo! Erantzun zuzena da."
			puntuak <- puntuak + 1
		SiNo
			Escribir "Oker! Lehenengo jokoa Argi gorria, argi berdea da."
		FinSi
		
		Escribir " "
		Escribir "3. Zein zen jokalarien zenbakia duen protagonista?"
		Escribir "1. 001"
		Escribir "2. 456"
		Escribir "3. 218"
		Leer erantzuna
		
		Si erantzuna = 2 Entonces
			Escribir "Ondo! Gi-hun 456 zenbakidun jokalaria da."
			puntuak <- puntuak + 1
		SiNo
			Escribir "Oker! Gi-hun 456 zenbakidun jokalaria da."
		FinSi
		
		Escribir " "
		Escribir "4. Zer janzten dute jokalariek?"
		Escribir "1. Arropa urdina"
		Escribir "2. Arropa beltza"
		Escribir "3. Txandal berdeak"
		Leer erantzuna
		
		Si erantzuna = 3 Entonces
			Escribir "Ondo! Txandal berdeak eramaten dituzte."
			puntuak <- puntuak + 1
		SiNo
			Escribir "Oker! Txandal berdeak eramaten dituzte."
		FinSi
		
		Escribir " "
		Escribir "5. Zer forma agertzen dira zaindarien maskaretan?"
		Escribir "1. Zirkulua, triangelua eta karratua"
		Escribir "2. Izarra, bihotza eta ilargia"
		Escribir "3. Laukizuzena, erronboa eta pentagonoa"
		Leer erantzuna
		
		Si erantzuna = 1 Entonces
			Escribir "Ondo! Hiru forma horiek agertzen dira."
			puntuak <- puntuak + 1
		SiNo
			Escribir "Oker! Zirkulua, triangelua eta karratua dira."
		FinSi
		
		Escribir " "
		Escribir "6. Zein herrialdetan gertatzen da telesaila?"
		Escribir "1. Japonian"
		Escribir "2. Hego Korean"
		Escribir "3. Txinan"
		Leer erantzuna
		
		Si erantzuna = 2 Entonces
			Escribir "Ondo! Telesaila Hego Korean gertatzen da."
			puntuak <- puntuak + 1
		SiNo
			Escribir "Oker! Hego Korean gertatzen da."
		FinSi
		
		Escribir " "
		Escribir "7. Zergatik parte hartzen dute jokalariek jokoetan?"
		Escribir "1. Oporrak irabazteko"
		Escribir "2. Dirua irabazteko"
		Escribir "3. Ospetsu bihurtzeko"
		Leer erantzuna
		
		Si erantzuna = 2 Entonces
			Escribir "Ondo! Diru sari handi bat lortzeko parte hartzen dute."
			puntuak <- puntuak + 1
		SiNo
			Escribir "Oker! Dirua irabazteko parte hartzen dute."
		FinSi
		
		Escribir " "
		Escribir "8. Zein koloretakoak dira zaindarien uniformeak?"
		Escribir "1. Arrosa edo gorrixkak"
		Escribir "2. Horiak"
		Escribir "3. Urdin argiak"
		Leer erantzuna
		
		Si erantzuna = 1 Entonces
			Escribir "Ondo! Uniforme arrosa edo gorrixkak dituzte."
			puntuak <- puntuak + 1
		SiNo
			Escribir "Oker! Uniforme arrosa edo gorrixkak dituzte."
		FinSi
		
		Escribir " "
		Escribir "=================================="
		Escribir "             EMAITZA"
		Escribir "=================================="
		Escribir "Lortutako puntuak: ", puntuak, " / 8"
		
		Si puntuak = 8 Entonces
			Escribir "Bikain! Telesaila oso ondo ezagutzen duzu!"
		SiNo
			Si puntuak >= 5 Entonces
				Escribir "Oso ondo! Nahiko ondo ezagutzen duzu telesaila."
			SiNo
				Escribir "Saiatu berriro! Telesaila gehiago ezagutu behar duzu."
			FinSi
		FinSi
		
FinAlgoritmo


