class Galleta:
    def __init__(self, sabor):
        self.sabor = sabor
    
 
    def mostrar(self):
        return f"El sabor de la galleta es de {self.sabor}"
 
p = Galleta("Chocolate")
print(p.mostrar())
