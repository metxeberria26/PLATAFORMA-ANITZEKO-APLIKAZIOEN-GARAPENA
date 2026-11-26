Algoritmo Ekuazioa
	Definir a, b, c, x, x1, x2 Como Real
	Escribir 'Sartu a-ren balioa:'
	Leer a
	Escribir 'Sartu b-ren balioa:'
	Leer b
	Escribir 'Sartu c-ren balioa:'
	Leer c
	Escribir 'Hona hemen askatutako ekuazioa: y=', a, 'x^2 + ', b, 'x + ', c
	x <- b^2-4*a*c
	Si x<0 Entonces
		Escribir 'Ekuazioak EZ DU soluzio errealik'
	SiNo
		Si x=0 Entonces
			x1 <- -b/(2*a)
			Escribir 'x1=', x1
		SiNo
			x1 <- (-b+(x1/2))/(2*a)
			x2 <- (-b-(x1/2))/(2*a)
			Escribir '1-> x1=', x1
			Escribir '2-> x2=', x2
		FinSi
	FinSi
FinAlgoritmo
