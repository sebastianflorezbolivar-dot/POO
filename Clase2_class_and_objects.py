class Persona:
    def __init__(self, nombre, edad):
        self.nombre = nombre
        self.edad = edad
 
    def saludar(self):
        return f"Hola, soy {self.nombre}"
 
p = Persona("Sebastian" , 20)
print(p.saludar())
