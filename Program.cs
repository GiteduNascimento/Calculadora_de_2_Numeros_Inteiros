// See https://aka.ms/new-console-template for more information
int num1;
int num2;
string operacao;

Console.WriteLine("Bem vindo, escolha o tipo de operação que deseja realizar:");
Console.WriteLine("Soma-+\nSubtração--\nMultiplicação-*\nDivisão-/");
operacao= Console.ReadLine();

Console.WriteLine("Agora digite o primeiro número para a operacão:");
num1= int.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o segundo número para a operacão:");
num2= int.Parse(Console.ReadLine());

if(operacao=="+" || operacao=="Soma"){
    Console.WriteLine("Resultado da sua soma é:");
    Console.WriteLine(num1+num2);
}
else if(operacao=="-" || operacao=="Subtração"){
    Console.WriteLine("Resultado da sua subtração é:");
    Console.WriteLine(num1-num2);
}
else if(operacao=="*" || operacao=="Mutiplicação"){
    Console.WriteLine("Resultado da sua multiplicação é:");
    Console.WriteLine(num1*num2);
}
else if(operacao=="/" || operacao=="Divisão"){
    Console.WriteLine("Resultado da sua divisão é:");
    Console.WriteLine(num1/num2);
}else{
    Console.WriteLine("Digite conforme foi pedido...");
}