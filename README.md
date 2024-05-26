# tl1-tp6-2024-agos4567
# ¿String es un tipo por valor o un tipo por referencia?
# En C#, string es un tipo por referencia. Aunque string se comporta como si fuera inmutable (no se puede cambiar una vez creado), internamente es una referencia a una instancia de un objeto en el heap.
# Qué secuencias de escape tiene el tipo string?
# En C#, el tipo string admite varias secuencias de escape, que son caracteres especiales usados para representar caracteres que no se pueden escribir directamente. Aquí están algunas de las secuencias de escape más comunes:

# \ : Barra invertida \
#    \' : Comilla simple (')
#   \" : Comilla doble (")
#    \0 : Carácter nulo
#   \a : Alerta (bell)
#    \b : Retroceso
#    \f : Avance de página
#    \n : Nueva línea
#    \r : Retorno de carro
#    \t : Tabulación horizontal
#    \v : Tabulación vertical
#    \uxxxx : Carácter Unicode (donde xxxx es un número hexadecimal de cuatro dígitos)
#    ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
#    En C#, los caracteres @ y $ se usan antes de una cadena de texto para proporcionar funcionalidad adicional: