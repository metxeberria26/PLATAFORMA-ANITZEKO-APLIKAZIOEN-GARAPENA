Algoritmo sin_titulo
	Definir a Como Entero
	Definir b Como Entero
	astekoa = 0
	kontadorea = 0
	Escribir 'sartu zenbat zareten klasean'
	Leer a
	Repetir
		kontadorea <- kontadorea +1
		Escribir "gaur zenbat zarete klasean?"
		Leer b
		batazbestekoa <- (b/a)*100
		Escribir batazbestekoa
		astekoa <- astekoa + b
	Hasta Que kontadorea=5
	Escribir "asteko batazbestekoa"
	astea <- (astekoa/(5*a)*100)
	Escribir astea
FinAlgoritmo
