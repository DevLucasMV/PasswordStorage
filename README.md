<!-- Titulo -->
<h1 align="center">Password Storage </h1>
<p align="center">Feito para armazenamento de logins via DataBase(SQL)</p> 
<h2 align="center">  <img src="https://img.shields.io/badge/Project%20Status-Working-Green"></h2>


<!-- Sobre -->
<h2> Sobre o projeto: </h2>

A finalidade deste projeto é desenvolver meus conhecimentos em C# criando um CRUD com o MVC e adicionando features.

## Preparação

1º) Restaure o banco de dados, há um arquivo na pasta  'Data - arquivo .bak' utilizando o SQL Server MS.<br/>
2º) Altere a Connection string no `appsetting.json`, utilizando os dados do SQL Server, desta forma:
```json
"ConnectionStrings": {
    "DataBase": "Server=<Nome_do_servidor>;Database=DB_SistemaCadastros;User Id=<Logon>;Password=<Senha>"
  }
  
Exemplo:

"ConnectionStrings": {
    "DataBase": "Server=L01110011;Database=DB_SistemaCadastros;User Id=sa;Password=123"
  },
```
3º) Após clonar o projeto na máquina local, abra o projeto com o Visual Studio e execute.

<!-- Tecnologias -->
<h2> Tecnologias: <h2>
<img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=WHITE"> <img src="https://img.shields.io/badge/Microsoft_SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white"> <img src="https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white">
<img src="https://img.shields.io/badge/HTML-239120?style=for-the-badge&logo=html5&logoColor=white">
<br>


