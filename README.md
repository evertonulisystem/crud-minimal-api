### Esta API foi desenvolvida visando apenas o uso do postman
### Representa uma minimal API, em dotNet
### Para executa-la de forma prática:
### 1- Baixe o ZIP do repositorio
### 2- Descompacte-o numa pasta de preferencia
### 3- Defina a IDE a ser utilizada:
### 3.1 Sendo Visual Studio:
### i.Apenas abra o arquivo da Solução (crud-minimal-api.sln) e execute a aplicação
### 3.2 Sendo o VSCODE:
### i. Abra o projeto na IDE
### ii. Deixe seu arquivo appsettings.json como se mostra abaixo:
![image](https://github.com/evertonulisystem/crud-minimal-api/assets/79390590/17d17f50-3660-4e01-af9d-ef81baac4a4c)

#### Copie o texto abaixo e cole no teu original: 

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Urls": {
    "Http": "http://localhost:5180", //veja se é esta porta que é exibida após o comando dotnet run
    "Https": "https://localhost:5181"
  }
}

# 4- Execute os comandos no terminal, na sequencia:
![image](https://github.com/evertonulisystem/crud-minimal-api/assets/79390590/a9c89fa0-f0df-4edf-b75c-6f36f9e465ef)
#### Copie o texto abaixo e cole no teu original: 
:\ dotnet restore (( Será exibido: Determinando os projetos a serem restaurados... Todos os projetos estão atualizados para restauração.
:\ dotnet build ((tem de exibir Compilação com êxito. 0 Aviso(s) e 0 Erro(s)0 erros))
:\ dotnet run 

# 5- Acesse pelo navegador o endereço: http://localhost:5180/swagger
![image](https://github.com/evertonulisystem/crud-minimal-api/assets/79390590/b25b640e-6cea-4a72-8feb-25293ced2f63)
