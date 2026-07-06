using Microsoft.AspNetCore.Mvc;
using Projeto___Gestão_de_Ginásio.Models.Requests;
using Projeto___Gestão_de_Ginásio.Models.Responses;

namespace Projeto___Gestão_de_Ginásio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private static List<ClienteResponse> clientes = new()
        {
            new ClienteResponse
            {
                ID = 1,
                Nome = "Pedro Gouveia",
                Idade = 18,
                Sexo = "M",
                GinasioId = 2,
            },
            new ClienteResponse
            {
                ID = 2,
                Nome = "André Lourenço",
                Idade = 22,
                Sexo = "M",
                GinasioId = 1,
            },
            new ClienteResponse
            {
                ID = 3,
                Nome = "Marcela Matos",
                Idade = 28,
                Sexo = "F",
                GinasioId = 5,
            },
            new ClienteResponse
            {
                ID = 4,
                Nome = "Pedro Santos",
                Idade = 42,
                Sexo = "M",
                GinasioId = 6,
            },
            new ClienteResponse
            {
                ID = 5,
                Nome = "Sara Silva",
                Idade = 25,
                Sexo = "F",
                GinasioId = 3,
            },
            new ClienteResponse
            {
                ID = 6,
                Nome = "Vera Cordeiro",
                Idade = 40,
                Sexo = "F",
                GinasioId = 4,
            },
            new ClienteResponse
            {
                ID = 7,
                Nome = "João Ferreira",
                Idade = 31,
                Sexo = "M",
                GinasioId = 1,
            },
            new ClienteResponse
            {
                ID = 8,
                Nome = "Ana Rodrigues",
                Idade = 24,
                Sexo = "F",
                GinasioId = 2,
            },
            new ClienteResponse
            {
                ID = 9,
                Nome = "Ricardo Costa",
                Idade = 37,
                Sexo = "M",
                GinasioId = 3,
            },
            new ClienteResponse
            {
                ID = 10,
                Nome = "Beatriz Martins",
                Idade = 29,
                Sexo = "F",
                GinasioId = 4,
            },
            new ClienteResponse
            {
                ID = 11,
                Nome = "Miguel Almeida",
                Idade = 21,
                Sexo = "M",
                GinasioId = 5,
            },
            new ClienteResponse
            {
                ID = 12,
                Nome = "Carolina Sousa",
                Idade = 34,
                Sexo = "F",
                GinasioId = 6,
            },
            new ClienteResponse
            {
                ID = 13,
                Nome = "Tiago Lopes",
                Idade = 27,
                Sexo = "M",
                GinasioId = 2,
            },
            new ClienteResponse
            {
                ID = 14,
                Nome = "Inês Correia",
                Idade = 30,
                Sexo = "F",
                GinasioId = 1,
            },
            new ClienteResponse
            {
                ID = 15,
                Nome = "Bruno Pinto",
                Idade = 45,
                Sexo = "M",
                GinasioId = 4,
            },
            new ClienteResponse
            {
                ID = 16,
                Nome = "Mariana Gomes",
                Idade = 19,
                Sexo = "F",
                GinasioId = 3,
            },
            new ClienteResponse
            {
                ID = 17,
                Nome = "Daniel Rocha",
                Idade = 26,
                Sexo = "M",
                GinasioId = 6,
            },
            new ClienteResponse
            {
                ID = 18,
                Nome = "Patrícia Neves",
                Idade = 39,
                Sexo = "F",
                GinasioId = 5,
            },
            new ClienteResponse
            {
                ID = 19,
                Nome = "Fábio Mendes",
                Idade = 33,
                Sexo = "M",
                GinasioId = 2,
            },
            new ClienteResponse
            {
                ID = 20,
                Nome = "Catarina Oliveira",
                Idade = 23,
                Sexo = "F",
                GinasioId = 4,
            },
            new ClienteResponse
            {
                ID = 21,
                Nome = "Luís Carvalho",
                Idade = 41,
                Sexo = "M",
                GinasioId = 1,
            },
            new ClienteResponse
            {
                ID = 22,
                Nome = "Marta Ribeiro",
                Idade = 36,
                Sexo = "F",
                GinasioId = 6,
            },
            new ClienteResponse
            {
                ID = 23,
                Nome = "Gonçalo Dias",
                Idade = 28,
                Sexo = "M",
                GinasioId = 3,
            },
            new ClienteResponse
            {
                ID = 24,
                Nome = "Sofia Fernandes",
                Idade = 32,
                Sexo = "F",
                GinasioId = 5,
            },
            new ClienteResponse
            {
                ID = 25,
                Nome = "Hugo Cardoso",
                Idade = 38,
                Sexo = "M",
                GinasioId = 1,
            },
            new ClienteResponse
            {
                ID = 26,
                Nome = "Rita Teixeira",
                Idade = 27,
                Sexo = "F",
                GinasioId = 2,
            }
        };

        private static List<ClienteResponse> clientes_desativados = new()
{
            new ClienteResponse
            {
                ID = 27,
                Nome = "Carlos Ferreira",
                Idade = 35,
                Sexo = "M",
                GinasioId = 2,
            },
            new ClienteResponse
            {
                ID = 28,
                Nome = "Helena Costa",
                Idade = 29,
                Sexo = "F",
                GinasioId = 5,
            }
        };

        [HttpGet("Listar_clientes")]
        public IActionResult GetClientes()
        {
            return Ok(clientes);
        }

        [HttpPost("Criar_cliente")]
        public IActionResult Criar(CreateClienteRequest request)
        {
            ClienteResponse cliente = new ClienteResponse
            {
                ID = clientes.Max(c => c.ID) + 1,
                Nome = request.Nome,
                Idade = request.Idade,
                Sexo = request.Sexo,
                GinasioId = request.GinasioId
            };

            clientes.Add(cliente);

            return Ok(new
            {
                Mensagem = "Cliente criado com sucesso.",
                Cliente = cliente
            });
        }

        [HttpPut("Editar_cliente")]
        public IActionResult Editar(int id, UpdateClienteRequest request)
        {
            ClienteResponse? cliente = clientes.FirstOrDefault(c => c.ID == id);

            if (cliente == null)
            {
                return NotFound(new
                {
                    Mensagem = "Cliente não encontrado."
                });
            }

            cliente.Nome = request.Nome;
            cliente.Idade = request.Idade;
            cliente.Sexo = request.Sexo;
            cliente.GinasioId = request.GinasioId;

            return Ok(new
            {
                Mensagem = "Cliente atualizado com sucesso.",
                Cliente = cliente
            });
        }

        [HttpDelete("Desativar_cliente")]
        public IActionResult Desativar(int id)
        {
            ClienteResponse? cliente = clientes.FirstOrDefault(c => c.ID == id);

            if (cliente == null)
            {
                return NotFound(new
                {
                    Mensagem = "Cliente não encontrado."
                });
            }

            clientes.Remove(cliente);
            clientes_desativados.Add(cliente);

            return Ok(new
            {
                Mensagem = "Cliente desativado com sucesso.",
                Cliente = cliente
            });
        }
    }
}
