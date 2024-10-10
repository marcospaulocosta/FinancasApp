using FinancasApp.Domain.Entities;
using FinancasApp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FinancasApp.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Add(Usuario usuario)
        {
            throw new NotImplementedException();
        }
        public bool VerifyExists(string email)
        {
            throw new NotImplementedException();
        }
        public Usuario? Get(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}