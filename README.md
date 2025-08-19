# SeguroVeiculoSolution

Projeto de exemplo para Exame Prático Stack .NET, implementando uma API REST para cálculo e gestão de seguros de veículos, seguindo Clean Architecture.

## Stacks Utilizadas

- **.NET 8**
- **C#**
- **ASP.NET Core Web API**
- **xUnit** (Testes automatizados)
- **Swagger** (Documentação de API)
- **VS Code REST Client** (Testes de endpoints)
- **Clean Architecture** (Separação em Domain, Application, Infrastructure, Api)

## Estrutura do Projeto

- `SeguroVeiculo.Api` — Camada de apresentação (API REST)
- `SeguroVeiculo.Domain` — Entidades do domínio
- `SeguroVeiculo.Application` — Serviços e regras de negócio
- `SeguroVeiculo.Infrastructure` — Repositórios e persistência

## Como rodar

1. Instale o .NET SDK 8.0
2. Execute os comandos:
   ```powershell
   dotnet build SeguroVeiculo.Api/SeguroVeiculo.Api.csproj
   dotnet run --project SeguroVeiculo.Api/SeguroVeiculo.Api.csproj
   ```
3. Acesse o Swagger em [http://localhost:5142/swagger](http://localhost:5142/swagger)
4. Teste os endpoints usando o arquivo `SeguroVeiculo.Api.http` ou o Swagger UI

## Testes

Execute os testes automatizados com:
```powershell
dotnet test SeguroVeiculo.Application/SeguroVeiculo.Application.csproj
```

## Observações
- Projeto simplificado para fins didáticos.
- Persistência em memória.
- Front-end básico em HTML.

---

Se quiser customizar ou expandir, basta editar as camadas conforme sua necessidade.
