﻿using AlcidesMontadora.Models;
using AlcidesMontadora.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Services
{
    public class CidadeServices
    {
        private readonly CidadeRepository cidadeRepository;

        public CidadeServices(CidadeRepository cidadeRepository)
        {
            this.cidadeRepository = cidadeRepository;
        }

        public void Insert(Cidade cidade)
        {
            cidadeRepository.Add(cidade);
        }
        public void Delete(Cidade cidade)
        {
            cidadeRepository.Delete(cidade);                
        }
        public void Update(Cidade cidade)
        {
            cidadeRepository.Update(cidade);
        }
        public IList<Cidade> FindAll()
        {
            return cidadeRepository.GetAll();
        }
        public Cidade FindById(int id)
        {
            return cidadeRepository.GetById(id);
        }
        public IList<Cidade> FindByName(string name)
        {
            return cidadeRepository.GetByNome(name);
        }
    }
}
