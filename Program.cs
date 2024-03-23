/*  Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 *  C.S.T. em Análise e Desenvolvimento de Sistemas
 *  Disciplina de Algoritmo e Lógica de Programação II
 *  Professor Clayton Ferraz de Andrade
 *  
 *  Acadêmico Vinicius de Oliveira Pinheiro
 *  Aula do dia 09-10-2023
 *  - Introdução do conceito de classe
 *  - Breve apresentação do conceito de programação orientada a objetos
 */
using SimpleList;

Product myProduct  = new Product();
Console.WriteLine("Digite o nome do produto: ");
myProduct.name = Console.ReadLine();
Console.WriteLine("Digite o valor do produto: ");
myProduct.value = Convert.ToDecimal(Console.ReadLine());