# Tipos de clonagem

1. Shallow Copy - **(Superficial)** : Clona o objeto mas copia os valores somente do tipos de valor, sendo que os tipos de referência a objetos complexos é copiado a referência ao objeto;

2. Deep Copy - **(Profunda)** : Clona o objeto e todos os objetos por ele referenciado. (tudo é copiado)

---

Beneficios :
Evitar criar um objeto utilizando a palavra *new*, o que diminui o custo de memória;
Evitar que as subclasses que criam objetos funcionem como o padrão abstract factory;
É util quando a inicialização do objeto é cara e possui parâmetros de inicialização, Nesse contexto o Protype pode evitar a "criação do zero" que é custosa e suportar a clonagem barata de um protótipo pré-inicializado.
O Prototype é único entre os outros padrões de criação, pois não requer uma classe apenas um objeto.
O Prototype não requer o uso de subclasses mas precisa de uma inicialização
A clonagem de objetos complexos que contenham refências circulares pode ser muito complicado.