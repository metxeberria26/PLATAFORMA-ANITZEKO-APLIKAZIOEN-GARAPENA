Algoritmo Asistentzia
	Definir etorri Como Caracter
    Definir astea, eguna,guztira, etorritakoak Como Entero
    Definir portzentaia Como Real
	
    guztira <- 0
    etorritakoak <- 0
	
    Para astea <- 1 Hasta 5 Hacer
		
        Escribir "===== ", astea, ". ASTEA ====="
		
        Para eguna <- 1 Hasta 5 Hacer
			
            Segun eguna Hacer
                1:
                    Escribir "Astelehena"
                2:
                    Escribir "Asteartea"
                3:
                    Escribir "Asteazkena"
                4:
                    Escribir "Osteguna"
                5:
                    Escribir "Ostirala"
            FinSegun
			
            Escribir "Etorri zara? (bai, ez)"
            Leer etorri
			
          
			
            Si etorri = "bai" Entonces
                etorritakoak <- etorritakoak + 1
            FinSi
			
        FinPara
		
        portzentaia <- (etorritakoak / 5) * 100
		
        Escribir "Asteko asistentzia: ", portzentaia, "%"
		hilekoa <- hilekoa + portzentaia
    FinPara
	
 
    Escribir "Hileko asistentzia: ", (hilekoa / 5) , "%"
	
FinAlgoritmo