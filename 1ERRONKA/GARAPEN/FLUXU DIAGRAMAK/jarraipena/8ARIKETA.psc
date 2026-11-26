Algoritmo Menu
	
	Repetir
		Escribir "1. Futbola"
		Escribir "2. Saskibaloia"
		Escribir "3. Ping-pongea"
		Escribir "0. Irten"
		Escribir "Aukeratu:"
		Leer aukera
		
		Si aukera = 1 Entonces
			Escribir "Futbola aukeratu duzu"
		SiNo
			Si aukera = 2 Entonces
				Escribir "Saskibaloia aukeratu duzu"
			SiNo
				Si aukera = 3 Entonces
					Escribir "Ping-pongea aukeratu duzu"
				SiNo
					Si aukera = 0 Entonces
						Escribir "Agur!"
					SiNo
						Escribir "Aukera okerra"
					FinSi
				FinSi
			FinSi
		FinSi
		
	Hasta Que aukera = 0
	
FinAlgoritmo