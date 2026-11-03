# Portal de Solicitações

Aplicação web desenvolvida em ASP.NET Core MVC para apoiar o gerenciamento de solicitações. O projeto contém estrutura para autenticação de usuários e acesso a dados de usuários, chamados e solicitantes, com interface em Razor/HTML e persistência em MySQL.

## Tecnologias

- .NET 10 / ASP.NET Core MVC
- C# e Razor/HTML
- MySQL, usando o pacote `MySql.Data`
- Autenticação por cookies

## Pré-requisitos

- .NET 10 SDK
- Servidor MySQL acessível pela aplicação

## Configuração

A aplicação espera uma string de conexão chamada `ConexaoMySQL`. Configure-a no ambiente antes de iniciar. Por exemplo, no PowerShell:

```powershell
$env:ConnectionStrings__ConexaoMySQL="Server=localhost;Database=PortalSolicitacoes;User ID=SEU_USUARIO;Password=SUA_SENHA;"
```

No Bash:

```bash
export ConnectionStrings__ConexaoMySQL="Server=localhost;Database=PortalSolicitacoes;User ID=SEU_USUARIO;Password=SUA_SENHA;"
```

Substitua os valores de exemplo pelos dados do seu banco. Não versionize credenciais reais. O banco e suas tabelas devem estar preparados antes de executar a aplicação; o repositório não inclui, atualmente, instruções ou scripts de migração do esquema.

## Executar localmente

Na raiz do repositório, restaure as dependências e inicie o projeto:

```bash
dotnet restore PortalSolicitacoes.slnx
dotnet run --project PortalSolicitacoes/PortalSolicitacoes.csproj
```

A URL local será exibida no terminal. Em ambiente de desenvolvimento, abra essa URL no navegador.

## Estrutura do projeto

```text
PortalSolicitacoes/
├── Models/        # Modelos da aplicação
├── Repositories/  # Contratos e acesso a dados
├── Views/         # Páginas Razor
├── wwwroot/       # Arquivos estáticos
├── Program.cs     # Configuração e inicialização da aplicação
└── PortalSolicitacoes.csproj
```

A autenticação está configurada com cookies, com caminho de login em `/Login/Index` e duração de oito horas.
