﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aprimori.ApplicationCore.Entity
{
    public class Endereco
    {
        public Endereco()
        {

        }

        public int Id { get; set; }
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Referencia { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
