# OrderSystem
<p>OrderSystem consiste em uma simples aplicação console, utilizando C# e .NET 6, na qual o usuário informa seu nome, e-mail e data de nascimento, e realiza um pedido contendo n items, sendo cada item composto por nome do produto, preço e quantidade. Por fim, é exibido um resumo do pedido do cliente.</p>
<p>Para implementação da solução deste problema, foram criadas 4 classes (Client - {Name, Email, BirthDate}, Product - {Name, Price}, OrderItem - {Quantity, Price, Product} e Order - {Moment, Status, Items, Client}) e 1 enum (OrderStatus) - {PendingPayment, Processing, Shipped, Delivered}. 
  Dessa forma, na classe OrderItem, existe uma composição entre OrderItem e Product, sendo uma relação "tem-um", enquanto que, na classe Order, existem duas composições, uma entre Order e Client, sendo uma relação "tem-um", e a outra entre Order e OrderItem, sendo uma relação "tem-vários", na qual uma Order tem uma Lista de OrderItems (atributo Items).</p>
  
  
![image](https://user-images.githubusercontent.com/80121288/170878007-8710cd46-8e9b-4a04-b10e-2cc63fefde5d.png)
