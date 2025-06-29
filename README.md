# Criando o primeiro programa
## Preparando o ambiente: Windows

Vá para o diretório raiz e crie a solução com o seguinte comando:

```bash
dotnet new solution -n PrimeiroProjeto
```
Vamos:
1.  criar uma pasta, 
2. criar dentro dela um projeto de console; e 
3. em seguida acrescentá-la à solução. 

```bash
mkdir PrimeiroProjeto
cd PrimeiroProjeto
dotnet new console
cd ..
dotnet solution add PrimeiroProjeto
```
Para rodar o projeto, execute o seguinte comando na raiz da solução:

```bash
dotnet run --project PrimeiroProjeto
```
Esse comando vai executar o programa `Program.cs`, cujo conteúdo segue:
```CSharp
// PrimeiroProjeto\Program.cs
Console.WriteLine("Hello, World!");
```
