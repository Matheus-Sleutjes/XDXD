//using Stefanini.Data.Contract;
//using Stefanini.Domain.Dto;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Stefanini.Data.Context;
//using Stefanini.Domain.Model;

//namespace Stefanini.Data.Repository
//{
//    public class ProdutoRepository(StefaniniContext _context) : IProdutoRepository
//    {
//        public Pedido Get(int id)
//        {
//            return _context.Produtos.AsNoTracking().Where(t => t.Id == id).FirstOrDefault();
//        }

//        public List<Pedido> GetByName(string name)
//        {
//            return _context.Produtos.AsNoTracking().Autocomplete(t => t.Nome.Contains(name), o => o.Nome).Take(100).ToList();
//        }

//        public List<Pedido> GetBySort(List<Sort> sorts)
//        {
//            return _context.Produtos.AsNoTracking().ToSort(sorts);
//        }

//        public void Add(Pedido entity)
//        {
//            _context.Produtos.Add(entity);
//        }

//        public void Update(Pedido entity)
//        {
//            _context.Produtos.Update(entity);
//        }

//        public void Delete(Pedido entity)
//        {
//            _context.Produtos.Remove(entity);
//        }

//        public void Savechanges()
//        {
//            _context.SaveChanges();
//        }
//    }
//}
